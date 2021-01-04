Public Class frmMain
    Private intResult As Integer
    Private sngWinnings As Single
    Private rndVal As New Random

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblForfeit.Visible = False
        timSpin.Start()
    End Sub

    Private Sub timSpin_Tick(sender As Object, e As EventArgs) Handles timSpin.Tick
        lblResult.Text = rndVal.Next(500)
        lblResult.Refresh()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timSpin.Stop()
        If lblResult.Text <> "" Then
            CalculateWinnings()
        End If
    End Sub

    Private Sub CalculateWinnings()
        Dim intSpinVal As Integer
        Dim intPrizeNum As Integer
        Dim sngPrizeVal As Single
        Dim strImage As String

        intSpinVal = CInt(lblResult.Text) 'convert the label's contents to an integer

        Select Case intSpinVal
            Case Is < 100
                intPrizeNum = 1
                sngPrizeVal = 50
                strImage = "prize-1.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize
            Case Is < 200
                intPrizeNum = 2
                sngPrizeVal = 75
                strImage = "prize-2.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize

            Case Is < 300
                intPrizeNum = 3
                sngPrizeVal = 60
                strImage = "prize-3.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize
            Case Else 'for any other value not handled in a case statement
                intPrizeNum = 4
                sngPrizeVal = 0
                strImage = "consolation prize.png"
                picPrize.SizeMode = PictureBoxSizeMode.Zoom
                lblForfeit.Visible = True
        End Select

        lblPrizeVal.Text = FormatCurrency(sngPrizeVal)
        If intSpinVal < 300 Then 'a winner
            sngWinnings += sngPrizeVal
        Else
            sngWinnings = 0 'wipe out the accumulated winnings!
        End If

        lblWinnings.Text = FormatCurrency(sngWinnings)
        picPrize.Load("Resources\" & strImage)

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("You will forfeit your winnings if you quit now. Do you want yo quit?",
                                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intResult = DialogResult.No Then 'user does not want to quit
            Exit Sub 'early jump out to the end of the procedure
        End If

        'end the program
        Application.Exit()
    End Sub
End Class
