Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        lblTitle.Text = ApplicationTitle
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        lblProduct.Text = My.Application.Info.ProductName
        lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        lblCopyright.Text = My.Application.Info.Copyright
        lblCompany.Text = My.Application.Info.CompanyName
        lblDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class