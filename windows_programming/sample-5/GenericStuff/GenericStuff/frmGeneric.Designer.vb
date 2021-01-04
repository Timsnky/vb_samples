<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneric
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.chkSenior = New System.Windows.Forms.CheckBox()
        Me.cboLetterGrade = New System.Windows.Forms.ComboBox()
        Me.mskBirthday = New System.Windows.Forms.MaskedTextBox()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpInput.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input here:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Senior"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Grade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Birthday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Grade"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(71, 15)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(266, 20)
        Me.txtName.TabIndex = 1
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(71, 165)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(266, 20)
        Me.txtGrade.TabIndex = 4
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(71, 65)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(266, 20)
        Me.txtAge.TabIndex = 2
        '
        'chkSenior
        '
        Me.chkSenior.AutoSize = True
        Me.chkSenior.Location = New System.Drawing.Point(71, 215)
        Me.chkSenior.Name = "chkSenior"
        Me.chkSenior.Size = New System.Drawing.Size(15, 14)
        Me.chkSenior.TabIndex = 5
        Me.chkSenior.UseVisualStyleBackColor = True
        '
        'cboLetterGrade
        '
        Me.cboLetterGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLetterGrade.FormattingEnabled = True
        Me.cboLetterGrade.Location = New System.Drawing.Point(71, 259)
        Me.cboLetterGrade.Name = "cboLetterGrade"
        Me.cboLetterGrade.Size = New System.Drawing.Size(266, 21)
        Me.cboLetterGrade.TabIndex = 6
        '
        'mskBirthday
        '
        Me.mskBirthday.Location = New System.Drawing.Point(71, 115)
        Me.mskBirthday.Mask = "00/00/0000"
        Me.mskBirthday.Name = "mskBirthday"
        Me.mskBirthday.Size = New System.Drawing.Size(266, 20)
        Me.mskBirthday.TabIndex = 3
        Me.mskBirthday.ValidatingType = GetType(Date)
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(80, 397)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(75, 23)
        Me.btnAction.TabIndex = 7
        Me.btnAction.Text = "Action"
        Me.btnAction.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(274, 397)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(180, 397)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.mskBirthday)
        Me.grpInput.Controls.Add(Me.cboLetterGrade)
        Me.grpInput.Controls.Add(Me.chkSenior)
        Me.grpInput.Controls.Add(Me.txtAge)
        Me.grpInput.Controls.Add(Me.txtGrade)
        Me.grpInput.Controls.Add(Me.txtName)
        Me.grpInput.Controls.Add(Me.Label7)
        Me.grpInput.Controls.Add(Me.Label6)
        Me.grpInput.Controls.Add(Me.Label5)
        Me.grpInput.Controls.Add(Me.Label4)
        Me.grpInput.Controls.Add(Me.Label3)
        Me.grpInput.Controls.Add(Me.Label2)
        Me.grpInput.Location = New System.Drawing.Point(59, 67)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(349, 301)
        Me.grpInput.TabIndex = 10
        Me.grpInput.TabStop = False
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmGeneric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGeneric"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generic Stuff"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents chkSenior As CheckBox
    Friend WithEvents cboLetterGrade As ComboBox
    Friend WithEvents mskBirthday As MaskedTextBox
    Friend WithEvents btnAction As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents errP As ErrorProvider
End Class
