'Name: Sultan Abuhaqab
'Date: 04/10/2020
'I affirm that this program was created by me. It Is solely my work and does not include any work done by anyone else.

Imports System.IO
Public Class frmPayrollCalculator
    Private strFileName As String
    Private intTotalEmployees As Integer
    Private intEmployeesWithBonus As Integer
    Private dblTotalBonusPaid As Double
    Private sngTotalScore As Single
    Private Const BONUS_PERCENTAGE_RATE As Single = 0.05
    Private arrJobCodes As ArrayList
    Private Stats As frmStats
#Region "Column Constants"
    'Constants to manage the list view columns
    Private Const EMPLOYEE_ID As Integer = 0
    Private Const LASTNAME As Integer = 1
    Private Const FIRSTNAME As Integer = 2
    Private Const JOB_CODE As Integer = 3
    Private Const DEPARTMENT As Integer = 4
    Private Const SCORE As Integer = 5
    Private Const RATING As Integer = 6
    Private Const BASE_SALARY As Integer = 7
    Private Const BONUS_PERCENTAGE As Integer = 8
    Private Const BONUS_AMOUNT As Integer = 9
    Private Const TOTAL_PAID As Integer = 10
#End Region
#Region "Job Code Base Salaries"
    'Constants to hold the base salary values for each job code
    Private Const E428_SALARY As Double = 42000
    Private Const E538_SALARY As Double = 39500
    Private Const E425_SALARY As Double = 38000
    Private Const E513_SALARY As Double = 56000
    Private Const E535_SALARY As Double = 57500
    Private Const E601_SALARY As Double = 67500
#End Region
#Region "Evaluation Score Rating Cutoff"
    Private Const POOR_CUTOFF As Single = 60
    Private Const FAIR_CUTOFF As Single = 70
    Private Const GOOD_CUTOFF As Single = 80
    Private Const EXCELLENT_CUTOFF As Single = 90
#End Region

    Private Sub OpenFile()
        Dim intResult As Integer

        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "All Files (*.*)|*.*|Text files (*.txt)|*.txt"
        ofdOpen.FilterIndex = 2

        intResult = ofdOpen.ShowDialog

        If intResult = DialogResult.Cancel Then 'User cancelled the open
            Exit Sub
        End If

        strFileName = ofdOpen.FileName

        Try
            ReadInputFile(strFileName)
        Catch exNotFound As FileNotFoundException
            MessageBox.Show("The selected file could not be located")
        Catch exIOError As IOException
            MessageBox.Show("Input Output error occurred while retrieving the selected file")
        Catch exOther As Exception  'Anything else that might go wrong
            MessageBox.Show("Error occurred while retrieving the selected file")
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
            MessageBox.Show("The selected file could not be located")
        Catch exIOError As IOException
            MessageBox.Show("Input Output error occurred while retrieving the selected file")
        Catch exOther As Exception  'Anything else that might go wrong
            MessageBox.Show("Error occurred while retrieving the selected file")
        End Try
    End Sub

    Private Sub ReadInputFile(strIn As String)
        Dim fileIn As StreamReader
        Dim strLineIn As String
        Dim strFields() As String   'String array to hold the fields from a record in the file
        Dim i As Integer
        Dim sngEvalScore As Single
        Dim dblBaseSalary As Double
        Dim sngBonusPercentageRate As Single
        Dim dblBonusAmount As Double
        Dim dblTotalPaid As Double

        lvwEmployees.Items.Clear()

        Try
            fileIn = New StreamReader(strIn)
            If Not fileIn.EndOfStream Then ' Get the first line and use it to build column headings
                strLineIn = fileIn.ReadLine
                strFields = strLineIn.Split(",")
                For i = 0 To strFields.Length - 1 'Build column headings
                    lvwEmployees.Columns.Add(strFields(i))
                Next
                'Add the additional new columns
                lvwEmployees.Columns.Add("Rating")
                lvwEmployees.Columns.Add("Base Salary")
                lvwEmployees.Columns.Add("Bonus %")
                lvwEmployees.Columns.Add("Bonus Amt")
                lvwEmployees.Columns.Add("Total Paid")

                'Do some formatting for the columns
                With lvwEmployees
                    .Columns(EMPLOYEE_ID).TextAlign = HorizontalAlignment.Center
                    .Columns(LASTNAME).Width = 100
                    .Columns(FIRSTNAME).Width = 100
                    .Columns(JOB_CODE).TextAlign = HorizontalAlignment.Center
                    .Columns(SCORE).Width = 80
                    .Columns(SCORE).TextAlign = HorizontalAlignment.Center
                    .Columns(BASE_SALARY).TextAlign = HorizontalAlignment.Right
                    .Columns(BASE_SALARY).Width = 80
                    .Columns(BONUS_PERCENTAGE).TextAlign = HorizontalAlignment.Right
                    .Columns(BONUS_PERCENTAGE).Width = 80
                    .Columns(BONUS_AMOUNT).TextAlign = HorizontalAlignment.Right
                    .Columns(BONUS_AMOUNT).Width = 80
                    .Columns(TOTAL_PAID).TextAlign = HorizontalAlignment.Right
                    .Columns(TOTAL_PAID).Width = 80
                End With
            End If

            'Get the data for each row
            While Not fileIn.EndOfStream
                strLineIn = fileIn.ReadLine
                strFields = strLineIn.Split(",")

                'Set up the first column value in a new listview item (the row)
                Dim lviRow As New ListViewItem(strFields(0))

                'Add the rest of the column values as subitems to the listviewitem
                For i = 1 To strFields.Length - 1
                    Dim lsiCol As New ListViewItem.ListViewSubItem
                    lsiCol.Text = strFields(i)
                    lviRow.SubItems.Add(lsiCol) ' Add the column to the row
                Next

                'Add the other additional columns
                'Rating Column
                sngEvalScore = CSng(strFields(SCORE))
                lviRow.SubItems.Add(GetListViewSubItem(GetRating(sngEvalScore)))

                'Base Salary Column
                dblBaseSalary = GetBaseSalary(strFields(JOB_CODE))
                lviRow.SubItems.Add(GetListViewSubItem(FormatCurrency(dblBaseSalary, 0)))

                'Bonus Percentage Column
                sngBonusPercentageRate = GetBonusPercentageRate(sngEvalScore)
                lviRow.SubItems.Add(GetListViewSubItem(FormatNumber(sngBonusPercentageRate, 2)))

                'Bonus Amount Column
                dblBonusAmount = sngBonusPercentageRate * dblBaseSalary
                lviRow.SubItems.Add(GetListViewSubItem(FormatCurrency(dblBonusAmount, 0)))

                'Total Paid Column
                dblTotalPaid = dblBaseSalary + dblBonusAmount
                lviRow.SubItems.Add(GetListViewSubItem(FormatCurrency(dblTotalPaid, 0)))

                'Now add the completed row to the listview
                lvwEmployees.Items.Add(lviRow)
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
            For i = 0 To lvwEmployees.Columns.Count - 1
                If i <> lvwEmployees.Columns.Count - 1 Then 'not the last column
                    strLineOut &= lvwEmployees.Columns(i).Text & ","
                Else    'this is the last column
                    strLineOut &= lvwEmployees.Columns(i).Text
                End If
            Next
            'Write our the column headings to the output file
            fileOut.WriteLine(strLineOut)
            'build each data line with commas separating the fields by looping through the rows 
            'and columns of the listview
            For i = 0 To lvwEmployees.Items.Count - 1
                strLineOut = lvwEmployees.Items(i).Text 'write the first column item
                For j = 1 To lvwEmployees.Items(j).SubItems.Count - 1
                    If j = BASE_SALARY Or j = BONUS_AMOUNT Or j = TOTAL_PAID Then
                        strLineOut &= "," & CDbl(lvwEmployees.Items(i).SubItems(j).Text)
                    ElseIf j = BONUS_PERCENTAGE Then
                        strLineOut &= "," & CSng(lvwEmployees.Items(i).SubItems(j).Text)
                    Else
                        strLineOut &= "," & lvwEmployees.Items(i).SubItems(j).Text
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

    Private Function GetListViewSubItem(columnValue As String) As ListViewItem.ListViewSubItem
        Dim lsiCol As New ListViewItem.ListViewSubItem
        lsiCol.Text = columnValue
        Return lsiCol
    End Function

    Private Function GetRating(score As Single) As String
        Dim strRating As String

        Select Case score
            Case POOR_CUTOFF To FAIR_CUTOFF - 1
                strRating = "Poor"
            Case FAIR_CUTOFF To GOOD_CUTOFF - 1
                strRating = "Fair"
            Case GOOD_CUTOFF To EXCELLENT_CUTOFF - 1
                strRating = "Good"
            Case EXCELLENT_CUTOFF To 100 - 1
                strRating = "Excellent"
            Case Else
                strRating = ""
                MessageBox.Show("The provided evaluation score of " & CStr(score) & " is not within specified ratings cutoffs")
        End Select

        Return strRating
    End Function

    Private Function GetBaseSalary(jobCode As String) As Double
        Dim dblSalary As Double

        Select Case jobCode
            Case "E428"
                dblSalary = E428_SALARY
            Case "E538"
                dblSalary = E535_SALARY
            Case "E425"
                dblSalary = E425_SALARY
            Case "E513"
                dblSalary = E513_SALARY
            Case "E535"
                dblSalary = E535_SALARY
            Case "E601"
                dblSalary = E601_SALARY
            Case Else
                dblSalary = 0.0
                MessageBox.Show("The provided job code of " & jobCode & " is not among the list of employee job codes")
        End Select

        Return dblSalary
    End Function

    Private Function GetBonusPercentageRate(score As Single) As Single
        Dim sngBonusPercentageRate As String

        Select Case score
            Case POOR_CUTOFF To FAIR_CUTOFF - 1
                sngBonusPercentageRate = 0.0
            Case FAIR_CUTOFF To 100 - 1
                sngBonusPercentageRate = BONUS_PERCENTAGE_RATE
            Case Else
                sngBonusPercentageRate = 0.0
                MessageBox.Show("The provided evaluation score of " & CStr(score) & " is not within specified ratings cutoffs")
        End Select

        Return sngBonusPercentageRate
    End Function

    Private Sub UpdateStatistics(aRow As ListViewItem)
        Dim dblBonusPaid As Double
        Dim sngEvalScore As Single
        Dim blnFoundIt As Boolean

        dblBonusPaid = CDbl(aRow.SubItems(BONUS_AMOUNT).Text)
        sngEvalScore = CSng(aRow.SubItems(SCORE).Text)

        'Update the overall statistics
        intTotalEmployees += 1
        If dblBonusPaid <> 0 Then
            intEmployeesWithBonus += 1
        End If
        dblTotalBonusPaid += dblBonusPaid
        sngTotalScore += sngEvalScore

        'Update the job code statistics
        For Each aJobCode As CJobCode In arrJobCodes
            If aJobCode.JobCode = aRow.SubItems(JOB_CODE).Text Then
                aJobCode.TotalEmployees += 1
                If dblBonusPaid <> 0 Then
                    aJobCode.TotalEmployeesWithBonus += 1
                End If
                aJobCode.TotalBonusPaid += dblBonusPaid
                aJobCode.TotalScore += sngEvalScore
                blnFoundIt = True
                Exit For
            End If
        Next

        If Not blnFoundIt Then
            Dim newJobCode As New CJobCode(aRow.SubItems(JOB_CODE).Text, dblBonusPaid, sngEvalScore)
            arrJobCodes.Add(newJobCode)
        End If
    End Sub

    Private Sub frmPayrollCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        arrJobCodes = New ArrayList
        Stats = New frmStats
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        OpenFile()
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        Stats.lstOverall.Items.Clear()
        Stats.lstJobCodes.Items.Clear()

        With Stats.lstOverall
            .Items.Add("Employee Count : " & intTotalEmployees)
            .Items.Add("Employees With Bonus : " & intEmployeesWithBonus)
            .Items.Add("Total Bonus Paid : " & FormatCurrency(dblTotalBonusPaid, 2))
            .Items.Add("Average Score : " & FormatNumber(sngTotalScore / CStr(intTotalEmployees), 1))
        End With

        With Stats.lstJobCodes
            For Each aJobCode As CJobCode In arrJobCodes
                .Items.Add(aJobCode.JobCode & " : ")
                .Items.Add(vbTab & "Employee Count : " & aJobCode.TotalEmployees)
                .Items.Add(vbTab & "Employees With Bonuses : " & aJobCode.TotalEmployeesWithBonus)
                .Items.Add(vbTab & "Total Bonuses : " & FormatCurrency(aJobCode.TotalBonusPaid, 0))
                .Items.Add(vbTab & "Average Score : " & FormatNumber(aJobCode.GetAverageScore(), 2))
            Next

        End With

        Stats.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFile()
    End Sub

    Private Sub btnClear_MouseClick(sender As Object, e As MouseEventArgs) Handles btnClear.MouseClick
        lvwEmployees.Items.Clear()
        arrJobCodes = New ArrayList
        strFileName = ""
        intTotalEmployees = 0
        intEmployeesWithBonus = 0
        dblTotalBonusPaid = 0
        sngTotalScore = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
