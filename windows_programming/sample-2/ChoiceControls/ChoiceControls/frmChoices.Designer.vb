<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoices
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
        Me.cboSaleItems = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSizes = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbHats = New System.Windows.Forms.CheckedListBox()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.grpColors = New System.Windows.Forms.GroupBox()
        Me.grpTrim = New System.Windows.Forms.GroupBox()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radBlack = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkResidence = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkExpress = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtmApproval = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mclSaleRange = New System.Windows.Forms.MonthCalendar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskZip = New System.Windows.Forms.MaskedTextBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpColors.SuspendLayout()
        Me.grpTrim.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ComboBox - Sale Items"
        '
        'cboSaleItems
        '
        Me.cboSaleItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSaleItems.FormattingEnabled = True
        Me.cboSaleItems.Location = New System.Drawing.Point(33, 46)
        Me.cboSaleItems.Name = "cboSaleItems"
        Me.cboSaleItems.Size = New System.Drawing.Size(144, 21)
        Me.cboSaleItems.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ListBox - Sizes"
        '
        'lstSizes
        '
        Me.lstSizes.FormattingEnabled = True
        Me.lstSizes.Location = New System.Drawing.Point(33, 114)
        Me.lstSizes.Name = "lstSizes"
        Me.lstSizes.Size = New System.Drawing.Size(141, 82)
        Me.lstSizes.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CheckedListBox - Hats"
        '
        'clbHats
        '
        Me.clbHats.CheckOnClick = True
        Me.clbHats.FormattingEnabled = True
        Me.clbHats.Location = New System.Drawing.Point(36, 243)
        Me.clbHats.Name = "clbHats"
        Me.clbHats.Size = New System.Drawing.Size(138, 79)
        Me.clbHats.TabIndex = 5
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(6, 19)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(45, 17)
        Me.radRed.TabIndex = 7
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Location = New System.Drawing.Point(6, 65)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(54, 17)
        Me.radGreen.TabIndex = 8
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(6, 42)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(46, 17)
        Me.radBlue.TabIndex = 9
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'grpColors
        '
        Me.grpColors.Controls.Add(Me.radBlue)
        Me.grpColors.Controls.Add(Me.radGreen)
        Me.grpColors.Controls.Add(Me.radRed)
        Me.grpColors.Location = New System.Drawing.Point(218, 21)
        Me.grpColors.Name = "grpColors"
        Me.grpColors.Size = New System.Drawing.Size(145, 99)
        Me.grpColors.TabIndex = 10
        Me.grpColors.TabStop = False
        Me.grpColors.Text = "RadioButtons - Color"
        '
        'grpTrim
        '
        Me.grpTrim.Controls.Add(Me.radSilver)
        Me.grpTrim.Controls.Add(Me.radBlack)
        Me.grpTrim.Controls.Add(Me.radGold)
        Me.grpTrim.Location = New System.Drawing.Point(218, 130)
        Me.grpTrim.Name = "grpTrim"
        Me.grpTrim.Size = New System.Drawing.Size(145, 99)
        Me.grpTrim.TabIndex = 11
        Me.grpTrim.TabStop = False
        Me.grpTrim.Text = "More RadioButtons - Trim"
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(6, 42)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(51, 17)
        Me.radSilver.TabIndex = 9
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Location = New System.Drawing.Point(6, 65)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(52, 17)
        Me.radBlack.TabIndex = 8
        Me.radBlack.TabStop = True
        Me.radBlack.Text = "Black"
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(6, 19)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(47, 17)
        Me.radGold.TabIndex = 7
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkResidence)
        Me.GroupBox3.Controls.Add(Me.chkSaturday)
        Me.GroupBox3.Controls.Add(Me.chkExpress)
        Me.GroupBox3.Location = New System.Drawing.Point(218, 243)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(145, 100)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CheckBoxes - Delivery"
        '
        'chkResidence
        '
        Me.chkResidence.AutoSize = True
        Me.chkResidence.Location = New System.Drawing.Point(7, 66)
        Me.chkResidence.Name = "chkResidence"
        Me.chkResidence.Size = New System.Drawing.Size(119, 17)
        Me.chkResidence.TabIndex = 2
        Me.chkResidence.Text = "Residential Address"
        Me.chkResidence.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Location = New System.Drawing.Point(7, 43)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(109, 17)
        Me.chkSaturday.TabIndex = 1
        Me.chkSaturday.Text = "Saturday Delivery"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkExpress
        '
        Me.chkExpress.AutoSize = True
        Me.chkExpress.Location = New System.Drawing.Point(7, 20)
        Me.chkExpress.Name = "chkExpress"
        Me.chkExpress.Size = New System.Drawing.Size(107, 17)
        Me.chkExpress.TabIndex = 0
        Me.chkExpress.Text = "Express Shipping"
        Me.chkExpress.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DateTimePicker - Approval Date"
        '
        'dtmApproval
        '
        Me.dtmApproval.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmApproval.Location = New System.Drawing.Point(392, 40)
        Me.dtmApproval.Name = "dtmApproval"
        Me.dtmApproval.Size = New System.Drawing.Size(227, 20)
        Me.dtmApproval.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(392, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "MonthCalendar - Sale Date Range"
        '
        'mclSaleRange
        '
        Me.mclSaleRange.Location = New System.Drawing.Point(392, 104)
        Me.mclSaleRange.Name = "mclSaleRange"
        Me.mclSaleRange.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(392, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "TextBox - Manager ID #"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(392, 309)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(227, 20)
        Me.txtID.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(395, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Masked TextBox - Store Zip Code"
        '
        'mskZip
        '
        Me.mskZip.Location = New System.Drawing.Point(392, 374)
        Me.mskZip.Mask = "00000-9999"
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(227, 20)
        Me.mskZip.TabIndex = 20
        Me.mskZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(651, 21)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(137, 28)
        Me.btnReport.TabIndex = 21
        Me.btnReport.Text = "Report Choices"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(651, 114)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 28)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(651, 68)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 28)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmChoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.mskZip)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mclSaleRange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtmApproval)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpTrim)
        Me.Controls.Add(Me.grpColors)
        Me.Controls.Add(Me.clbHats)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstSizes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSaleItems)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChoices"
        Me.Text = "Controls that provide choices"
        Me.grpColors.ResumeLayout(False)
        Me.grpColors.PerformLayout()
        Me.grpTrim.ResumeLayout(False)
        Me.grpTrim.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboSaleItems As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSizes As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clbHats As CheckedListBox
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents grpColors As GroupBox
    Friend WithEvents grpTrim As GroupBox
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents radGold As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkResidence As CheckBox
    Friend WithEvents chkSaturday As CheckBox
    Friend WithEvents chkExpress As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtmApproval As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents mclSaleRange As MonthCalendar
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mskZip As MaskedTextBox
    Friend WithEvents btnReport As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents errP As ErrorProvider
End Class
