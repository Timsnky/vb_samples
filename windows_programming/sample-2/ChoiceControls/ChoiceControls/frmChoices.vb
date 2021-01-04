Public Class frmChoices

    Private arrRadColor(2) As RadioButton 'array of 3 RadioButton objects
    Private arrRadTrim(2) As RadioButton
    Private arrChk(2) As CheckBox
    Private strColor As String ' to hold the color choice 
    Private strTrim As String 'to hold the trim color
    Private strStartDate As String
    Private strEndDate As String
    Private Summary As frmSummary

    Private Sub LoadComboBoxChoices()
        cboSaleItems.Items.Add("Long Sleeve Shirt")
        cboSaleItems.Items.Add("Short Sleeve Shirt")
        cboSaleItems.Items.Add("Lightwight Jacket")
    End Sub

    Private Sub LoadListBoxChoices()
        lstSizes.Items.Add("Small")
        lstSizes.Items.Add("Medium")
        lstSizes.Items.Add("Large")
        lstSizes.Items.Add("XL")
        lstSizes.Items.Add("XXL")
    End Sub

    Private Sub LoadCheckedListBoxChoices()
        clbHats.Items.Add("Baseball Cap")
        clbHats.Items.Add("Cowboy Hat")
        clbHats.Items.Add("Tennis Hat")
        clbHats.Items.Add("Golf Hat")
    End Sub

    Private Sub frmChoices_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBoxChoices()
        LoadListBoxChoices()
        LoadCheckedListBoxChoices()

        'load the control arrays
        arrRadColor(0) = radRed
        arrRadColor(1) = radBlue
        arrRadColor(2) = radGreen

        arrRadTrim(0) = radGold
        arrRadTrim(1) = radSilver
        arrRadTrim(2) = radBlack

        arrChk(0) = chkExpress
        arrChk(1) = chkSaturday
        arrChk(2) = chkResidence
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'end the program
    End Sub

    Private Sub radColors_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged, radBlue.CheckedChanged, radGreen.CheckedChanged
        ' we have wired all of the 3 color radio buttons to this single event procedure
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)

        If rad.Checked Then 'only do this when the radio button is being turned on
            strColor = rad.Text
        End If
    End Sub

    Private Sub radTrims_CheckedChanged(sender As Object, e As EventArgs) Handles radGold.CheckedChanged, radSilver.CheckedChanged, radBlack.CheckedChanged

        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)

        If rad.Checked Then
            strTrim = rad.Text
        End If
    End Sub

    Private Sub mclSaleRange_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mclSaleRange.DateSelected
        'capture the start and end date of the selected data range
        strStartDate = FormatDateTime(e.Start.ToString, DateFormat.ShortDate)
        strEndDate = FormatDateTime(e.End.ToString, DateFormat.ShortDate)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim strResult As String
        Dim i As Integer
        Dim blnErrors As Boolean
        errP.Clear() 'clear any previous error messages

        'validate that the user made selections in the combo, listbox and radiobuttons
        If cboSaleItems.SelectedIndex = -1 Then 'no selection was made
            errP.SetError(cboSaleItems, "You must select a sale item")
            blnErrors = True
        End If

        If lstSizes.SelectedIndex = -1 Then 'no selection was made
            errP.SetError(lstSizes, "You must select a size")
            blnErrors = True
        End If

        If strColor = "" Then 'no color was selected
            errP.SetError(grpColors, "You must select a color")
            blnErrors = True
        End If

        If strTrim = "" Then 'no trim was selected
            errP.SetError(grpTrim, "You must select a trim")
            blnErrors = True
        End If

        If strStartDate = "" Then 'no date range selected
            errP.SetError(mclSaleRange, "You must select a date range")
            blnErrors = True
        End If

        If Not IsNumeric(txtID.Text) Then 'ID value is non-numeric
            errP.SetError(txtID, "Your ID must be numeric")
            blnErrors = True
        End If

        If mskZip.Text = "" Then 'Missing zip code
            errP.SetError(mskZip, "You must enter the Zip code")
            blnErrors = True
        End If

        If blnErrors Then 'can't go forward, some of the data is missing or bad
            Exit Sub 'early jump out of this procedure
        End If

        'if we get this far all of the data is good
        strResult = "You selected the folowing:" & vbCrLf
        strResult &= "Sale Item: " & cboSaleItems.SelectedItem.ToString & vbCrLf
        strResult &= "Size: " & lstSizes.SelectedItem.ToString & vbCrLf
        strResult &= "Color: " & strColor & vbCrLf
        strResult &= "Trim: " & strTrim & vbCrLf
        strResult &= "Hats:" & vbCrLf

        For i = 0 To clbHats.Items.Count - 1
            If clbHats.GetItemCheckState(i) = CheckState.Checked Then 'this item was selected
                strResult &= "   " & clbHats.Items(i).ToString & vbCrLf
            End If
        Next

        strResult &= "Delivery Options: " & vbCrLf

        For i = 0 To arrChk.Length - 1
            If arrChk(i).Checked Then
                strResult &= "   " & arrChk(i).Text & vbCrLf
            End If
        Next

        strResult &= "Approval Date: " & FormatDateTime(dtmApproval.Value, DateFormat.ShortDate) & vbCrLf
        strResult &= "Sale Start Date: " & strStartDate & vbCrLf
        strResult &= "Sale End Date: " & strEndDate & vbCrLf

        ' MessageBox.Show(strResult, "Your Choices", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Summary = New frmSummary
        Summary.lblSummary.Text = strResult
        Summary.ShowDialog()
        btnClear.PerformClick()   'simulate the clicking of a button
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer

        For i = 0 To arrRadColor.Length - 1
            arrRadColor(i).Checked = False
        Next

        For i = 0 To arrRadTrim.Length - 1
            arrRadTrim(i).Checked = False
        Next

        For i = 0 To arrChk.Length - 1
            arrChk(i).Checked = False
        Next

        clbHats.ClearSelected() 'clears the highlighting of selections
        For i = 0 To clbHats.Items.Count - 1
            clbHats.SetItemCheckState(i, CheckState.Unchecked)
        Next

        lstSizes.SelectedIndex = -1
        cboSaleItems.SelectedIndex = -1
        strColor = ""
        strTrim = ""
        dtmApproval.Value = Today.Date
        mclSaleRange.SelectionStart = Today
        mclSaleRange.SelectionEnd = Today
        errP.Clear()
        txtID.Clear()
        mskZip.Clear()
    End Sub
End Class

