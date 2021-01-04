﻿Public Class frmMain
    Private RoleInfo As frmRole
    Private SecurityInfo As frmSecurity
    Private LoginInfo As frmLogin
    Private EventInfo As frmEventManagement
    Private RSVPInfo As frmEventRSVP
    Private MemberInfo As frmMembers

#Region "Toolbar Stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter,
        tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter,
        tsbSemester.MouseEnter, tsbTutor.MouseEnter, tsbSecurity.MouseEnter
        'We need to do this only because we are not putting our images in the Image property of the toolbar buttons
        ToolStripMouseEnter(sender)
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave,
        tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave,
        tsbSemester.MouseLeave, tsbTutor.MouseLeave, tsbSecurity.MouseLeave
        'We need to do this only because we are not putting our images in the Image property of the toolbar buttons
        ToolStripMouseLeave(sender)
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        If Not AuthUser.IsAdmin() And Not AuthUser.IsOfficer() Then
            MessageBox.Show("Access Denied : You dont have the required credentials to access this page", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.Hide()
        RoleInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        Me.Cursor = Cursors.WaitCursor

        'Close any open forms except main
        CloseForms()

        'Reset the Auth User object
        AuthUser = New CAuthUser()

        Me.Cursor = Cursors.Default

        PerformLogin()
    End Sub

    Private Sub tsbSecurity_Click(sender As Object, e As EventArgs) Handles tsbSecurity.Click
        If Not AuthUser.IsAdmin() Then
            MessageBox.Show("Access Denied : You dont have the required credentials to access this page", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.Hide()
        SecurityInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbEvents_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        If Not AuthUser.IsAdmin() And Not AuthUser.IsOfficer() Then
            MessageBox.Show("Access Denied : You dont have the required credentials to access this page", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Hide()
        EventInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbEventRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        Me.Hide()
        RSVPInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        'Do nothing since we are already at HOME form
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        If Not AuthUser.IsAdmin() And Not AuthUser.IsOfficer() Then
            MessageBox.Show("Access Denied : You dont have the required credentials to access this page", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Hide()
        MemberInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub
#End Region

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoleInfo = New frmRole
        SecurityInfo = New frmSecurity
        LoginInfo = New frmLogin
        EventInfo = New frmEventManagement
        RSVPInfo = New frmEventRSVP
        MemberInfo = New frmMembers

        Try
            myDB.OpenDB()
        Catch ex As Exception
            MessageBox.Show("Unable to open database. Connection string = " & gstrConn, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EndProgram()
        End Try

    End Sub

    Private Sub EndProgram()
        Me.Cursor = Cursors.WaitCursor

        'Close any open forms except main
        CloseForms()

        'Close the database connection
        If Not objSQLConn Is Nothing Then
            objSQLConn.Close()
            objSQLConn.Dispose()
        End If

        Me.Cursor = Cursors.Default

        Application.Exit()
    End Sub

    Private Sub CloseForms()
        'Close each form except main
        Dim f As Form
        For Each f In Application.OpenForms
            If f.Name <> Me.Name Then
                If Not f Is Nothing Then
                    f.Close()
                End If
            End If
        Next
    End Sub

    Private Sub PerformNextAction()
        'Get the next action specified on the child form, and then simulate the click of the button here
        Select Case intNextAction
            Case ACTION_COURSE
                tsbCourse.PerformClick()
            Case ACTION_EVENT
                tsbEvent.PerformClick()
            Case ACTION_HELP
                tsbHelp.PerformClick()
            Case ACTION_HOME
                tsbHome.PerformClick()
            Case ACTION_LOGOUT
                tsbLogOut.PerformClick()
            Case ACTION_MEMBER
                tsbMember.PerformClick()
            Case ACTION_NONE
                'Nothing to do here
            Case ACTION_ROLE
                tsbRole.PerformClick()
            Case ACTION_RSVP
                tsbRSVP.PerformClick()
            Case ACTION_SECURITY
                tsbSecurity.PerformClick()
            Case ACTION_SEMESTER
                tsbSemester.PerformClick()
            Case ACTION_TUTOR
                tsbTutor.PerformClick()
            Case ACTION_LOGIN
                PerformLogin()
            Case ACTION_EXIT
                EndProgram()
            Case Else
                MessageBox.Show("Unexpected case value in Form Main PerformNextAction", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        intNextAction = ACTION_LOGIN
        PerformNextAction()
    End Sub

    Private Sub PerformLogin()
        LoginInfo.ShowDialog()
        PerformNextAction()
    End Sub

End Class
