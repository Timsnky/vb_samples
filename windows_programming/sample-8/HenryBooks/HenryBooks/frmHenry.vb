Imports System.Data.SqlClient

Public Class frmHenry
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private myDB As CDB
    Private sqlDR As SqlDataReader

    Private Sub frmHenry_Load(sender As Object, e As EventArgs) Handles Me.Load
        myDB = New CDB

        If Not myDB.OpenDB() Then
            Application.Exit()
        End If

        LoadTableNames(cboTable)
        LoadSearchChoices(cboSearch)
    End Sub

    Private Sub LoadTableNames(cbo As ComboBox)
        cbo.Items.Clear()

        sqlDR = myDB.GetDataReaderBySP("dbo.sp_getTableList", Nothing)

        While sqlDR.Read
            cbo.Items.Add(sqlDR.Item("name"))
        End While

        sqlDR.Close()

    End Sub

    Private Sub LoadSearchChoices(cbo As ComboBox)
        cbo.Items.Add("Book Title")
        cbo.Items.Add("Author Last Name")
        cbo.Items.Add("Branch Name")
        cbo.Items.Add("Publisher Name")
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strSP As String = ""
        objSQLCommand.Parameters.Clear()
        objSQLCommand.CommandType = CommandType.StoredProcedure

        errP.Clear()

        If cboTable.SelectedIndex = -1 Then
            errP.SetError(cboTable, "You must make a table selection here")
            Exit Sub
        End If

        Select Case cboTable.SelectedItem.ToString
            Case "AUTHOR"
                strSP = "dbo.sp_getTableAuthor"
            Case "BOOK"
                strSP = "dbo.sp_getTableBook"
            Case "BRANCH"
                strSP = "dbo.sp_getTableBranch"
            Case "INVENTORY"
                strSP = "dbo.sp_getTableInventory"
            Case "PUBLISHER"
                strSP = "dbo.sp_getTablePublisher"
            Case "WROTE"
                strSP = "dbo.sp_getTableWrote"
            Case Else
                MessageBox.Show("Invalid table name in btnShow_Click event", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        sqlDA = myDB.GetDataAdapterBySP(strSP, Nothing)
        dt = New DataTable
        sqlDA.Fill(dt)

        dgrInventory.DataSource = dt
        dgrInventory.AutoGenerateColumns = True

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim blnErrors As Boolean
        Dim params As New ArrayList

        errP.Clear()

        If txtVal.Text.Length = 0 Then 'Missing search value
            errP.SetError(txtVal, "You must enter a search value here")
            blnErrors = True
        End If

        If cboSearch.SelectedIndex = -1 Then
            errP.SetError(cboSearch, "You must make a selection here")
            blnErrors = True
        End If

        If blnErrors Then
            Exit Sub
        End If

        Select Case cboSearch.SelectedItem.ToString
            Case "Book Title"
                params.Add(New SqlParameter("@title", txtVal.Text))
                sqlDA = myDB.GetDataAdapterBySP("dbo.sp_getTitleList", params)
            Case "Author Last Name"
                params.Add(New SqlParameter("@lastname", txtVal.Text))
                sqlDA = myDB.GetDataAdapterBySP("dbo.sp_getAuthorList", params)
            Case "Branch Name"
                params.Add(New SqlParameter("@branch", txtVal.Text))
                sqlDA = myDB.GetDataAdapterBySP("dbo.sp_getBranchList", params)
            Case "Publisher Name"
                params.Add(New SqlParameter("@Publisher", txtVal.Text))
                sqlDA = myDB.GetDataAdapterBySP("dbo.sp_GetInventoryInfo", params)
            Case Else
                MessageBox.Show("Invalid search name in btnSearch_Click event", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        dt = New DataTable
        sqlDA.Fill(dt)

        dgrInventory.DataSource = dt
        dgrInventory.AutoGenerateColumns = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If objSQLConn.State = ConnectionState.Open Then
            myDB.CloseDB()
        End If

        Application.Exit()
    End Sub
End Class
