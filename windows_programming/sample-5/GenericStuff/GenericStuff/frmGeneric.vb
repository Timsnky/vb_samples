Public Class frmGeneric
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearScreenControls(Me)
    End Sub

    Private Sub frmGeneric_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboLetterGrade.Items.Add("A")
        cboLetterGrade.Items.Add("B")
        cboLetterGrade.Items.Add("C")
        cboLetterGrade.Items.Add("D")
        cboLetterGrade.Items.Add("F")
    End Sub

    Private Sub txtBoxes_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus, txtGrade.GotFocus, txtAge.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll() 'Highlight the contents for replacement typing
    End Sub

    Private Sub txtBoxes_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus, txtGrade.LostFocus, txtAge.LostFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.DeselectAll() 'Highlight the contents for replacement typing
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Dim blnErrors As Boolean
        Dim cntrl As Control    'Generic class representing any type of control
        Dim intPosition As Integer
        'Validate input
        If Not ValidateTextBoxLength(txtName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxNumeric(txtAge, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtGrade, errP) Then
            blnErrors = True
        End If
        'If Not ValidateCombo(cboLetterGrade, errP) Then
        '    blnErrors = True
        'End If

        If blnErrors Then
            Exit Sub
        End If

        'If we get this far all of the input data is good
        'If we want to do the same thing in all textboxes
        For Each cntrl In Me.Controls
            If TypeOf cntrl Is GroupBox Then
                UpCaseText(cntrl)
            End If
        Next

        'Try to match the textbox grade with an entry in the combo
        intPosition = cboLetterGrade.FindStringExact(txtGrade.Text)
        If intPosition <> -1 Then
            cboLetterGrade.SelectedIndex = intPosition
        Else
            MessageBox.Show("Could not find this grade in the combo")
        End If
    End Sub

    Private Sub UpCaseText(grpBox As GroupBox)
        For Each cntrl In grpBox.Controls
            If TypeOf cntrl Is TextBox Then
                Dim tBox As TextBox = DirectCast(cntrl, TextBox)
                tBox.Text = tBox.Text.ToUpper   'Uppercase the textbox content
            End If
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
