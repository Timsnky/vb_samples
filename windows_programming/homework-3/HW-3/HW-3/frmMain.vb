Imports System.IO
Public Class frmMain
    Private intNumberOfRenters As Integer
    Private sngTotalCharges As Single
    Private strStats As String
    Private arrRadStats(3) As RadioButton
    Private arrInstruments As ArrayList

#Region "Instrument Monthly Costs"
    Private Const CLARINET_COST As Single = 15
    Private Const DRUMS_COST As Single = 22
    Private Const SAXOPHONE_COST As Single = 18
    Private Const TROMBONE_COST As Single = 17
    Private Const TRUMPET_COST As Single = 18
#End Region

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load the radio  buttons
        arrRadStats(0) = radTotal
        arrRadStats(1) = radAvg
        arrRadStats(2) = radCount
        arrRadStats(3) = radChrgByType

        'Initialise the arraylist
        arrInstruments = New ArrayList
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer

        'Clear the Radio Buttons
        For i = 0 To arrRadStats.Length - 1
            arrRadStats(i).Checked = False
        Next

        'Clear the list box
        lstCustomers.Items.Clear()

        'Clear the global variables
        intNumberOfRenters = 0
        sngTotalCharges = 0
        strStats = ""

        'Clear the instrument arraylist
        arrInstruments = New ArrayList

        'Clear the error provider
        errP.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub ReadInputFile(strFileIn As String)
        Dim fileIn As StreamReader
        Dim strLineIn As String
        Dim strFields() As String

        lstCustomers.Items.Clear()

        fileIn = New StreamReader(strFileIn)
        fileIn.ReadLine()

        While Not fileIn.EndOfStream
            strLineIn = fileIn.ReadLine()
            strFields = strLineIn.Split(Chr(9))

            lstCustomers.Items.Add(strFields(0))

            UpdateStatistics(strFields(1), strFields(2))
        End While

        fileIn.Close()
        fileIn.Dispose()

    End Sub

    Private Sub UpdateStatistics(strType As String, intMonths As Integer)
        Dim blnFountIt As Boolean
        Dim sngTypeCost As Single

        'Get the cost of the instrument type
        Select Case strType
            Case "Clarinet"
                sngTypeCost = CLARINET_COST
            Case "Drums"
                sngTypeCost = DRUMS_COST
            Case "Saxophone"
                sngTypeCost = SAXOPHONE_COST
            Case "Trombone"
                sngTypeCost = TROMBONE_COST
            Case "Trumpet"
                sngTypeCost = TRUMPET_COST
            Case Else
                MessageBox.Show("Invalid instrument type", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        'Check if Category already exists, If exists update else create new
        For Each aInstrument As CInstrument In arrInstruments
            If aInstrument.Type = strType Then
                aInstrument.TotalCount += 1
                aInstrument.TotalCost += sngTypeCost * intMonths
                blnFountIt = True
                Exit For
            End If
        Next

        'Create new instrrument and add it to arraylist
        If Not blnFountIt Then
            arrInstruments.Add(New CInstrument(strType, sngTypeCost * intMonths))
        End If

        'Update the global variables
        intNumberOfRenters += 1
        sngTotalCharges += sngTypeCost * intMonths
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim intResult As Integer
        '****** You will NOT need to write this code for open file dialogs  ******
        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*"
        ofdOpen.FilterIndex = 1
        '*******************
        'Show the open dialog and check if user cancelled. If not, call ReadInputFile
        intResult = ofdOpen.ShowDialog

        If intResult = DialogResult.Cancel Then 'User cancelled the dialog
            Exit Sub
        End If

        Try
            ReadInputFile(ofdOpen.FileName)
        Catch ex As Exception
            MessageBox.Show("Error occurred while reading the input file", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        '****** display the selected type of statistics
        Dim blnErrors As Boolean
        Dim strStatResult As String

        errP.Clear()

        'Validate that the listbox has data
        If lstCustomers.Items.Count = 0 Then
            blnErrors = True
            errP.SetError(lstCustomers, "Please load data first from file")
        End If

        'Validate the radio buttons
        If strStats = "" Then
            blnErrors = True
            errP.SetError(grpStats, "Please select a statistic type first")
        End If

        If blnErrors Then
            Exit Sub
        End If

        strStatResult = ""
        Select Case strStats
            Case "Overall Total Charges"
                strStatResult = "Overall Total Charges : " & FormatCurrency(sngTotalCharges)
            Case "Overall Average Charge"
                strStatResult = "Overall Average Charge : " & FormatCurrency(sngTotalCharges / intNumberOfRenters)
            Case "Overall Client Count"
                strStatResult = "Overall Client Count : " & intNumberOfRenters
            Case "Total Charge by Type"
                For Each aInstrument As CInstrument In arrInstruments
                    strStatResult &= aInstrument.Type & ": " & FormatCurrency(aInstrument.TotalCost) & vbCrLf
                Next
            Case Else
                MessageBox.Show("Invalid statistics option selected", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        MessageBox.Show(strStatResult, "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub radStats_CheckedChanged(sender As Object, e As EventArgs) Handles radAvg.CheckedChanged, radCount.CheckedChanged, radChrgByType.CheckedChanged, radTotal.CheckedChanged
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)

        If rad.Checked Then
            strStats = rad.Text
        End If
    End Sub
End Class