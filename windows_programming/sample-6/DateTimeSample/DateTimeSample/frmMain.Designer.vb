<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClearAdd = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAlt = New System.Windows.Forms.Label()
        Me.dtmEndAdd = New System.Windows.Forms.DateTimePicker()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lstOp = New System.Windows.Forms.ListBox()
        Me.lstIntervalAdd = New System.Windows.Forms.ListBox()
        Me.dtmStartAdd = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpSpan = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtmStartSpan = New System.Windows.Forms.DateTimePicker()
        Me.dtmEndSpan = New System.Windows.Forms.DateTimePicker()
        Me.lstIntervalSpan = New System.Windows.Forms.ListBox()
        Me.lblElapsedUnits = New System.Windows.Forms.Label()
        Me.btnSpan = New System.Windows.Forms.Button()
        Me.btnUpdateSpan = New System.Windows.Forms.Button()
        Me.btnClearSpan = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSpan.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClearAdd)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.lblAlt)
        Me.GroupBox1.Controls.Add(Me.dtmEndAdd)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.lstOp)
        Me.GroupBox1.Controls.Add(Me.lstIntervalAdd)
        Me.GroupBox1.Controls.Add(Me.dtmStartAdd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 448)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adding and Subtracting Date"
        '
        'btnClearAdd
        '
        Me.btnClearAdd.Location = New System.Drawing.Point(416, 379)
        Me.btnClearAdd.Name = "btnClearAdd"
        Me.btnClearAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAdd.TabIndex = 15
        Me.btnClearAdd.Text = "Clear"
        Me.btnClearAdd.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(416, 328)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Process"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAlt
        '
        Me.lblAlt.BackColor = System.Drawing.Color.White
        Me.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlt.Location = New System.Drawing.Point(137, 379)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.Size = New System.Drawing.Size(249, 23)
        Me.lblAlt.TabIndex = 13
        '
        'dtmEndAdd
        '
        Me.dtmEndAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmEndAdd.Location = New System.Drawing.Point(137, 331)
        Me.dtmEndAdd.Name = "dtmEndAdd"
        Me.dtmEndAdd.Size = New System.Drawing.Size(249, 20)
        Me.dtmEndAdd.TabIndex = 12
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(137, 280)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(249, 23)
        Me.lblResult.TabIndex = 11
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(137, 232)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(249, 20)
        Me.txtQty.TabIndex = 10
        '
        'lstOp
        '
        Me.lstOp.FormattingEnabled = True
        Me.lstOp.Location = New System.Drawing.Point(137, 161)
        Me.lstOp.Name = "lstOp"
        Me.lstOp.Size = New System.Drawing.Size(249, 43)
        Me.lstOp.TabIndex = 9
        '
        'lstIntervalAdd
        '
        Me.lstIntervalAdd.FormattingEnabled = True
        Me.lstIntervalAdd.Location = New System.Drawing.Point(137, 77)
        Me.lstIntervalAdd.Name = "lstIntervalAdd"
        Me.lstIntervalAdd.Size = New System.Drawing.Size(249, 56)
        Me.lstIntervalAdd.TabIndex = 8
        '
        'dtmStartAdd
        '
        Me.dtmStartAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmStartAdd.Location = New System.Drawing.Point(137, 29)
        Me.dtmStartAdd.Name = "dtmStartAdd"
        Me.dtmStartAdd.Size = New System.Drawing.Size(249, 20)
        Me.dtmStartAdd.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "What Interval?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Add or Subtract?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "How much?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "String result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DTM Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alternate format"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Date"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'grpSpan
        '
        Me.grpSpan.Controls.Add(Me.btnClearSpan)
        Me.grpSpan.Controls.Add(Me.btnUpdateSpan)
        Me.grpSpan.Controls.Add(Me.btnSpan)
        Me.grpSpan.Controls.Add(Me.lblElapsedUnits)
        Me.grpSpan.Controls.Add(Me.lstIntervalSpan)
        Me.grpSpan.Controls.Add(Me.dtmEndSpan)
        Me.grpSpan.Controls.Add(Me.dtmStartSpan)
        Me.grpSpan.Controls.Add(Me.Label8)
        Me.grpSpan.Controls.Add(Me.Label9)
        Me.grpSpan.Controls.Add(Me.Label10)
        Me.grpSpan.Controls.Add(Me.Label11)
        Me.grpSpan.Location = New System.Drawing.Point(591, 25)
        Me.grpSpan.Name = "grpSpan"
        Me.grpSpan.Size = New System.Drawing.Size(398, 448)
        Me.grpSpan.TabIndex = 1
        Me.grpSpan.TabStop = False
        Me.grpSpan.Text = "Determining the Interval"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "End Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "What interval?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Elapsed units"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Start Time"
        '
        'dtmStartSpan
        '
        Me.dtmStartSpan.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtmStartSpan.Location = New System.Drawing.Point(119, 29)
        Me.dtmStartSpan.Name = "dtmStartSpan"
        Me.dtmStartSpan.Size = New System.Drawing.Size(249, 20)
        Me.dtmStartSpan.TabIndex = 11
        '
        'dtmEndSpan
        '
        Me.dtmEndSpan.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtmEndSpan.Location = New System.Drawing.Point(119, 77)
        Me.dtmEndSpan.Name = "dtmEndSpan"
        Me.dtmEndSpan.Size = New System.Drawing.Size(249, 20)
        Me.dtmEndSpan.TabIndex = 12
        '
        'lstIntervalSpan
        '
        Me.lstIntervalSpan.FormattingEnabled = True
        Me.lstIntervalSpan.Location = New System.Drawing.Point(119, 119)
        Me.lstIntervalSpan.Name = "lstIntervalSpan"
        Me.lstIntervalSpan.Size = New System.Drawing.Size(249, 69)
        Me.lstIntervalSpan.TabIndex = 13
        '
        'lblElapsedUnits
        '
        Me.lblElapsedUnits.BackColor = System.Drawing.Color.White
        Me.lblElapsedUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblElapsedUnits.Location = New System.Drawing.Point(119, 229)
        Me.lblElapsedUnits.Name = "lblElapsedUnits"
        Me.lblElapsedUnits.Size = New System.Drawing.Size(249, 23)
        Me.lblElapsedUnits.TabIndex = 14
        '
        'btnSpan
        '
        Me.btnSpan.Location = New System.Drawing.Point(36, 303)
        Me.btnSpan.Name = "btnSpan"
        Me.btnSpan.Size = New System.Drawing.Size(100, 36)
        Me.btnSpan.TabIndex = 15
        Me.btnSpan.Text = "Calculate Span"
        Me.btnSpan.UseVisualStyleBackColor = True
        '
        'btnUpdateSpan
        '
        Me.btnUpdateSpan.Location = New System.Drawing.Point(165, 303)
        Me.btnUpdateSpan.Name = "btnUpdateSpan"
        Me.btnUpdateSpan.Size = New System.Drawing.Size(100, 36)
        Me.btnUpdateSpan.TabIndex = 16
        Me.btnUpdateSpan.Text = "Update Start From End"
        Me.btnUpdateSpan.UseVisualStyleBackColor = True
        '
        'btnClearSpan
        '
        Me.btnClearSpan.Location = New System.Drawing.Point(294, 303)
        Me.btnClearSpan.Name = "btnClearSpan"
        Me.btnClearSpan.Size = New System.Drawing.Size(74, 36)
        Me.btnClearSpan.TabIndex = 17
        Me.btnClearSpan.Text = "Clear"
        Me.btnClearSpan.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(884, 497)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 549)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpSpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date and Time Handling Samples"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSpan.ResumeLayout(False)
        Me.grpSpan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearAdd As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblAlt As Label
    Friend WithEvents dtmEndAdd As DateTimePicker
    Friend WithEvents lblResult As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lstOp As ListBox
    Friend WithEvents lstIntervalAdd As ListBox
    Friend WithEvents dtmStartAdd As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents btnExit As Button
    Friend WithEvents grpSpan As GroupBox
    Friend WithEvents btnClearSpan As Button
    Friend WithEvents btnUpdateSpan As Button
    Friend WithEvents btnSpan As Button
    Friend WithEvents lblElapsedUnits As Label
    Friend WithEvents lstIntervalSpan As ListBox
    Friend WithEvents dtmEndSpan As DateTimePicker
    Friend WithEvents dtmStartSpan As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
