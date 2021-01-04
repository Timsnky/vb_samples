Imports System.IO
Public Class frmListView

    Private strFileName As String
    Private dblTotalInvValue As Double
    Private intTotalCount As Integer
    Private arrCategories As ArrayList
    Private Stats As frmStats
#Region "Column constants"
    'constants to manage the list view columns
    Private Const ARTID As Integer = 0
    Private Const ARTIST As Integer = 1
    Private Const ITEM_TITLE As Integer = 2
    Private Const DATE_ACQUIRED As Integer = 3
    Private Const CATEGORY As Integer = 4
    Private Const CONDITION As Integer = 5
    Private Const ITEM_LOCATION As Integer = 6
    Private Const ITEM_VALUE As Integer = 7
#End Region


    Private Sub OpenFile()
        Dim intResult As Integer

        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "All Files (*.*)|*.*|Text files (*.txt)|*.txt"
        ofdOpen.FilterIndex = 2

        intResult = ofdOpen.ShowDialog

        If intResult = DialogResult.Cancel Then 'user cancelled the open
            Exit Sub
        End If

        strFileName = ofdOpen.FileName

        Try
            ReadInputFile(strFileName)
        Catch exNotFound As FileNotFoundException
            'put error handling code here
        Catch exIOError As IOException
            'put error handling code here
        Catch exOther As Exception  'anything else that might go wrong
            'put error handling code here
        End Try
    End Sub

    Private Sub SaveFile()
        Dim intResult As Integer
        sfdSave.InitialDirectory = Application.StartupPath
        sfdSave.Filter = "All Files (*.*)|*.*|Text files (*.txt)|*.txt"
        sfdSave.FilterIndex = 2
        intResult = sfdSave.ShowDialog
        If intResult = DialogResult.Cancel Then
            Exit Sub
        End If
        strFileName = sfdSave.FileName
        Try
            WriteOutputFile(strFileName)
        Catch exNotFound As FileNotFoundException
            'put error handling code here
        Catch exIOError As IOException
            'put error handling code here
        Catch exOther As Exception  'anything else that might go wrong
            'put error handling code here
        End Try
    End Sub

    Private Sub ReadInputFile(strIn As String)
        Dim fileIn As StreamReader
        Dim strLineIn As String
        Dim strFields() As String   'string array to hold the fields from a record in the file
        Dim i As Integer

        lvwInventory.Items.Clear()

        Try
            fileIn = New StreamReader(strIn)
            If Not fileIn.EndOfStream Then ' get the first line and use it to build column headings
                strLineIn = fileIn.ReadLine
                strFields = strLineIn.Split(",")
                For i = 0 To strFields.Length - 1 'build column headings
                    lvwInventory.Columns.Add(strFields(i))
                Next

                'Do some formatting for the columns
                With lvwInventory
                    .Columns(ARTIST).Width = 80
                    .Columns(ITEM_TITLE).Width = 150
                    .Columns(DATE_ACQUIRED).Width = 80
                    .Columns(CATEGORY).Width = 80
                    .Columns(CONDITION).Width = 80
                    .Columns(ITEM_LOCATION).Width = 100
                    .Columns(ITEM_VALUE).Width = 100
                    .Columns(ITEM_VALUE).TextAlign = HorizontalAlignment.Right
                End With
            End If

            'Get the data for each row
            While Not fileIn.EndOfStream
                strLineIn = fileIn.ReadLine
                strFields = strLineIn.Split(",")

                'Set up the first column value in a new listview item (the row)
                Dim lviRow As New ListViewItem(strFields(0))
                'Now add the rest of the column values as subitems to that listviewitem

                For i = 1 To strFields.Length - 1
                    Dim lsiCol As New ListViewItem.ListViewSubItem
                    If i <> ITEM_VALUE Then
                        lsiCol.Text = strFields(i)
                    Else 'it is the money value, so format it
                        lsiCol.Text = FormatCurrency(strFields(i), 0)
                    End If

                    lviRow.SubItems.Add(lsiCol) ' Add the column to the row
                Next
                'Now add the completed row to the listview
                lvwInventory.Items.Add(lviRow)
                UpdateStatistics(lviRow)
            End While
            fileIn.Close()
            fileIn.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub WriteOutputFile(strName As String)
        Dim fileOut As StreamWriter
        Dim strLineOut As String = ""
        Dim i As Integer
        Dim j As Integer

        Try
            fileOut = New StreamWriter(strName)

            'Build the field names as the first line in the ourput file by readin the column names
            For i = 0 To lvwInventory.Columns.Count - 1
                If i <> lvwInventory.Columns.Count - 1 Then 'not the last column
                    strLineOut &= lvwInventory.Columns(i).Text & ","
                Else    'this is the last column
                    strLineOut &= lvwInventory.Columns(i).Text
                End If
            Next
            'Write our the column headings to the output file
            fileOut.WriteLine(strLineOut)
            'build each data line with commas separating the fields by looping through the rows 
            'and columns of the listview
            For i = 0 To lvwInventory.Items.Count - 1
                strLineOut = lvwInventory.Items(i).Text 'write the first column item
                For j = 1 To lvwInventory.Items(j).SubItems.Count - 1
                    If j = ITEM_VALUE Then
                        strLineOut &= "," & CSng(lvwInventory.Items(i).SubItems(j).Text)
                    Else
                        strLineOut &= "," & lvwInventory.Items(i).SubItems(j).Text
                    End If

                Next
                fileOut.WriteLine(strLineOut)
            Next
            fileOut.Close()
            fileOut.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub UpdateStatistics(aRow As ListViewItem)
        Dim blnFoundIt As Boolean
        'Find check if the new row's category already exists in our arraylist
        For Each aCat As CCategory In arrCategories
            If aCat.CatName = aRow.SubItems(CATEGORY).Text Then 'we already have is so update it
                aCat.TotalValue += CDbl(aRow.SubItems(ITEM_VALUE).Text)
                aCat.TotalCount += 1
                blnFoundIt = True
                Exit For 'early jump out of the for loop
            End If
        Next

        If Not blnFoundIt Then ' need to create a new ccategory object
            Dim newCat As New CCategory(aRow.SubItems(CATEGORY).Text, aRow.SubItems(ITEM_VALUE).Text)
            arrCategories.Add(newCat)
        End If

        'Now update the global overall stats also
        dblTotalInvValue += CDbl(aRow.SubItems(ITEM_VALUE).Text)
        intTotalCount += 1
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        OpenFile()
    End Sub

    Private Sub frmListView_Load(sender As Object, e As EventArgs) Handles Me.Load
        arrCategories = New ArrayList()
        Stats = New frmStats
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        OpenFile()
    End Sub

    Private Sub mnuStats_Click(sender As Object, e As EventArgs) Handles mnuStats.Click
        Stats.lstStats.Items.Clear()
        With Stats.lstStats
            .Items.Add("Total Inventory Value = " & FormatCurrency(dblTotalInvValue))
            .Items.Add("Total Inventory Count = " & CStr(intTotalCount))
            For Each aCat As CCategory In arrCategories
                .Items.Add(aCat.CatName & ":")
                .Items.Add("   Value = " & FormatCurrency(aCat.TotalValue))
                .Items.Add("   Count = " & CStr(aCat.TotalCount))
            Next
        End With
        Stats.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lvwInventory.Items.Clear()
        dblTotalInvValue = 0
        intTotalCount = 0
        arrCategories = New ArrayList
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFile()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        SaveFile()
    End Sub
End Class
