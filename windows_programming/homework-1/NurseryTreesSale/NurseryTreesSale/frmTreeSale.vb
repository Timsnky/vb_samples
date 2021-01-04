'Name: Sultan Abuhaqab
'Date: 20/09/2020
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.

Public Class frmTreeSale
    'Define the constants needed in the program
    Private Const KEY_LIME_PRICE As Single = 15.95
    Private Const PERSIAN_LIME_PRICE As Single = 12.95
    Private Const MEYER_LEMON_PRICE As Single = 13.95
    Private Const DELIVERY_FEE As Single = 10
    Private Const PLANTING_FEE As Single = 8
    Private Const TAX_RATE As Single = 7

    Private arrRadTreeType(2) As RadioButton
    Private arrChkAdditionalServices(1) As CheckBox

    Private strTreeType As String
    Private sngTreeCost As Double

    Private Summary As frmSummary

    Private Sub LoadControlArrays()
        arrRadTreeType(0) = radKeyLime
        arrRadTreeType(1) = radPersianLime
        arrRadTreeType(2) = radMeyerLemon

        arrChkAdditionalServices(0) = chkDelivery
        arrChkAdditionalServices(1) = chkPlanting
    End Sub

    Private Sub frmTreeSale_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadControlArrays()
    End Sub

    Private Sub radTreeTypes_CheckedChanged(sender As Object, e As EventArgs) Handles radKeyLime.CheckedChanged,
            radPersianLime.CheckedChanged, radMeyerLemon.CheckedChanged
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)

        If rad.Checked Then
            Dim strTreePreviewImage As String

            strTreeType = rad.Text

            If strTreeType = arrRadTreeType(0).Text Then
                sngTreeCost = KEY_LIME_PRICE
                strTreePreviewImage = "key_lime.jpg"
            ElseIf strTreeType = arrRadTreeType(1).Text Then
                sngTreeCost = PERSIAN_LIME_PRICE
                strTreePreviewImage = "persian_lime.jpg"
            Else
                sngTreeCost = MEYER_LEMON_PRICE
                strTreePreviewImage = "meyer_lemon.jpg"
            End If
            picTreePreview.Load("Resources\" & strTreePreviewImage)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer

        'Clear the radio buttons
        For i = 0 To arrRadTreeType.Length - 1
            arrRadTreeType(i).Checked = False
        Next

        'Clear the picture box
        picTreePreview.Image = Nothing

        'Clear the check boxes
        For i = 0 To arrChkAdditionalServices.Length - 1
            arrChkAdditionalServices(i).Checked = False
        Next

        'Clear the text boxes
        txtNumberOfTrees.Clear()
        txtName.Clear()
        mskPhone.Clear()
        txtAddress.Clear()

        'Clear the variables
        strTreeType = ""
        sngTreeCost = 0.0

        'Clear the error provider
        errP.Clear()

    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim sngTreeCost As Single
        Dim sngTotalNetCost As Single
        Dim sngTreePurchaseCost As Single
        Dim sngDeliveryFee As Single
        Dim sngPlantingFee As Single

        errP.Clear()

        'Check if we have validation errors and exit subroutine
        If ValidateData() Then
            Exit Sub
        End If

        'Calculate the tree purchase cost
        sngTreePurchaseCost = sngTreeCost * txtNumberOfTrees.Text

        'Calculate the delivery fee cost
        If chkDelivery.Checked Then
            sngDeliveryFee = DELIVERY_FEE
        End If

        'Calculate the planting fee cost
        If chkPlanting.Checked Then
            sngPlantingFee = txtNumberOfTrees.Text * PLANTING_FEE
        End If

        sngTreeCost = sngTreePurchaseCost + sngDeliveryFee + sngPlantingFee

        sngTotalNetCost = sngTreeCost * (100 + TAX_RATE) / 100

        'Populate the summary form with the data
        Summary = New frmSummary

        Summary.lblName.Text = txtName.Text
        Summary.lblPhone.Text = mskPhone.Text
        Summary.lblAddress.Text = txtAddress.Text

        Summary.lblTreeType.Text = strTreeType & " Tree Type"
        Summary.lblTreeTypePrice.Text = sngTreeCost
        Summary.lblTreeQuantity.Text = txtNumberOfTrees.Text
        Summary.lblTreeCost.Text = sngTreePurchaseCost

        Summary.lblDelivery.Text = chkDelivery.Text
        If sngDeliveryFee <> 0 Then
            Summary.lblDeliveryPrice.Text = DELIVERY_FEE
        End If
        Summary.lblDeliveryCost.Text = sngDeliveryFee

        Summary.lblPlanting.Text = chkPlanting.Text
        If sngPlantingFee <> 0 Then
            Summary.lblPlantingPrice.Text = PLANTING_FEE
            Summary.lblPlantingQuantity.Text = txtNumberOfTrees.Text
        End If
        Summary.lblPlantingCost.Text = sngPlantingFee

        Summary.lblGrossTotal.Text = Math.Round(sngTreeCost, 2)
        Summary.lblTaxRate.Text = TAX_RATE & "%"
        Summary.lblNetTotal.Text = Math.Round(sngTotalNetCost, 2)

        Summary.ShowDialog()

        btnClear.PerformClick()
    End Sub

    Private Function ValidateData()
        Dim binErrors As Boolean

        'Validate that the tree type radio buttons was selected
        If strTreeType = "" Then
            errP.SetError(grpTreeTypes, "You must select a tree type")
            binErrors = True
        End If

        'Validate the number of tree text box
        If Not IsNumeric(txtNumberOfTrees.Text) Then
            errP.SetError(txtNumberOfTrees, "The number of trees must be numeric")
            binErrors = True
        ElseIf txtNumberOfTrees.Text > 5 Or txtNumberOfTrees.Text < 1 Then
            errP.SetError(txtNumberOfTrees, "The number of trees ordered must be not more than 5 and greater than 0")
            binErrors = True
        End If

        'Validate the name text box
        If txtName.Text = "" Then
            errP.SetError(txtName, "You must provide your name")
            binErrors = True
        End If

        'Validate the phone text box
        If mskPhone.Text = "" Then
            errP.SetError(mskPhone, "You must provide your phone number")
            binErrors = True
        End If

        'Validate the address text box
        If txtAddress.Text = "" Then
            errP.SetError(txtAddress, "You must provide your address")
            binErrors = True
        End If

        Return binErrors

    End Function
End Class
