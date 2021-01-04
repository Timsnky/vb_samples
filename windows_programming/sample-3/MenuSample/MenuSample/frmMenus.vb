Imports System.IO

Public Class frmMenus
    Private Sub frmMenus_Load(sender As Object, e As EventArgs) Handles Me.Load
        'setup the properties for the open and save dialogs
        ofdOpen.DefaultExt = "*.txt"
        ofdOpen.Filter = "VB Forms (*.vb)|*.vb|Text files (*.txt)|*.txt|All Files (*.*}|*.*"
        ofdOpen.FilterIndex = 1
        ofdOpen.InitialDirectory = Application.StartupPath

        sfdSave.DefaultExt = "*.txt"
        sfdSave.Filter = "VB Forms (*.vb)|*.vb|Text files (*.txt)|*.txt|All Files (*.*}|*.*"
        sfdSave.FilterIndex = 1
        sfdSave.InitialDirectory = Application.StartupPath
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        Dim srdTextFile As StreamReader
        'show the open file dialog then get the results from that dialog
        ofdOpen.ShowDialog()

        If ofdOpen.FileName = "" Then 'user did not select a file
            sslStatus.Text = "File open action cancelled"
            Exit Sub
        End If

        srdTextFile = File.OpenText(ofdOpen.FileName)
        sslStatus.Text = ofdOpen.FileName & " opened"

        While Not srdTextFile.EndOfStream
            lstText.Items.Add(srdTextFile.ReadLine)
        End While

        srdTextFile.Close()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Dim swrTextFile As StreamWriter
        Dim i As Integer
        sfdSave.ShowDialog()

        If sfdSave.FileName = "" Then 'user did not indicate a file to save
            sslStatus.Text = "File save action cancelled"
            Exit Sub
        End If
        swrTextFile = File.CreateText(sfdSave.FileName)

        For i = 0 To lstText.Items.Count - 1
            swrTextFile.WriteLine(lstText.Items(i).ToString)
        Next
        swrTextFile.Close()
        sslStatus.Text = sfdSave.FileName & " saved"
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        Dim swrTextFile As StreamWriter
        Dim i As Integer
        sfdSave.ShowDialog()

        If sfdSave.FileName = "" Then 'user did not indicate a file to save
            sslStatus.Text = "File save action cancelled"
            Exit Sub
        End If
        swrTextFile = File.CreateText(sfdSave.FileName)

        sspProgress.Minimum = 0
        sspProgress.Maximum = 100
        sspProgress.Step = CInt(lstText.Items.Count / 100)

        For i = 0 To lstText.Items.Count - 1
            swrTextFile.WriteLine(lstText.Items(i).ToString)
            sspProgress.Increment(sspProgress.Step)
        Next
        swrTextFile.Close()
        sslStatus.Text = sfdSave.FileName & " saved"
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        Clipboard.SetDataObject(txtInput.SelectedText) 'put selected test into the Clipboard
        sslStatus.Text = "Copy action"
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        'determine whether the data in the clipboard is in a format we can put in a textbox
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then 'it is text data
            txtInput.SelectedText = Clipboard.GetDataObject.GetData(DataFormats.Text)
            sslStatus.Text = "Paste action"
        Else 'clipboard data was not in a format we can put in a textbox
            sslStatus.Text = "Could not retrieve data from the clipboard"
        End If
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        Clipboard.SetDataObject(txtInput.SelectedText) 'put the data into the clipboard
        txtInput.SelectedText = ""
        sslStatus.Text = "Cut action"
    End Sub

    Private Sub mnuFont_Click(sender As Object, e As EventArgs) Handles mnuFont.Click
        Dim intResult As Integer
        intResult = fntFont.ShowDialog
        If intResult <> DialogResult.Cancel Then
            txtInput.Font = fntFont.Font
            sslStatus.Text = "Font changed"
        Else
            sslStatus.Text = "Operation cancelled"
        End If
    End Sub

    Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
        'we will fake this, because you actually have to setup a document object and load with text before printing
        prtPrint.ShowDialog()
    End Sub

    Private Sub mnuRotate_Click(sender As Object, e As EventArgs) Handles mnuRotate.Click
        picDog.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        picDog.Refresh()
        sslStatus.Text = "Image rotated"
    End Sub

    Private Sub mnuFlip_Click(sender As Object, e As EventArgs) Handles mnuFlip.Click
        picDog.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        picDog.Refresh()
        sslStatus.Text = "Image flipped"
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim About As New frmAbout
        About.ShowDialog()
    End Sub
End Class
