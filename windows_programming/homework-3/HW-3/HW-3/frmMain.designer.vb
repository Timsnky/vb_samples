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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.radChrgByType = New System.Windows.Forms.RadioButton()
        Me.radCount = New System.Windows.Forms.RadioButton()
        Me.radAvg = New System.Windows.Forms.RadioButton()
        Me.radTotal = New System.Windows.Forms.RadioButton()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpStats.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(316, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 36)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(219, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 36)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(122, 389)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(91, 36)
        Me.btnStats.TabIndex = 13
        Me.btnStats.Text = "Statistics"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(25, 389)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(91, 36)
        Me.btnLoad.TabIndex = 12
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.radChrgByType)
        Me.grpStats.Controls.Add(Me.radCount)
        Me.grpStats.Controls.Add(Me.radAvg)
        Me.grpStats.Controls.Add(Me.radTotal)
        Me.grpStats.Location = New System.Drawing.Point(213, 243)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Size = New System.Drawing.Size(193, 134)
        Me.grpStats.TabIndex = 11
        Me.grpStats.TabStop = False
        Me.grpStats.Text = "Statistics"
        '
        'radChrgByType
        '
        Me.radChrgByType.AutoSize = True
        Me.radChrgByType.Location = New System.Drawing.Point(18, 97)
        Me.radChrgByType.Name = "radChrgByType"
        Me.radChrgByType.Size = New System.Drawing.Size(127, 17)
        Me.radChrgByType.TabIndex = 3
        Me.radChrgByType.TabStop = True
        Me.radChrgByType.Text = "Total Charge by Type"
        Me.radChrgByType.UseVisualStyleBackColor = True
        '
        'radCount
        '
        Me.radCount.AutoSize = True
        Me.radCount.Location = New System.Drawing.Point(18, 72)
        Me.radCount.Name = "radCount"
        Me.radCount.Size = New System.Drawing.Size(118, 17)
        Me.radCount.TabIndex = 2
        Me.radCount.TabStop = True
        Me.radCount.Text = "Overall Client Count"
        Me.radCount.UseVisualStyleBackColor = True
        '
        'radAvg
        '
        Me.radAvg.AutoSize = True
        Me.radAvg.Location = New System.Drawing.Point(18, 47)
        Me.radAvg.Name = "radAvg"
        Me.radAvg.Size = New System.Drawing.Size(138, 17)
        Me.radAvg.TabIndex = 1
        Me.radAvg.TabStop = True
        Me.radAvg.Text = "Overall Average Charge"
        Me.radAvg.UseVisualStyleBackColor = True
        '
        'radTotal
        '
        Me.radTotal.AutoSize = True
        Me.radTotal.Location = New System.Drawing.Point(18, 22)
        Me.radTotal.Name = "radTotal"
        Me.radTotal.Size = New System.Drawing.Size(127, 17)
        Me.radTotal.TabIndex = 0
        Me.radTotal.TabStop = True
        Me.radTotal.Text = "Overall Total Charges"
        Me.radTotal.UseVisualStyleBackColor = True
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.Location = New System.Drawing.Point(22, 70)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(185, 303)
        Me.lstCustomers.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Instrument Rentals"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.HW_3.My.Resources.Resources.instruments
        Me.PictureBox1.Location = New System.Drawing.Point(213, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(426, 440)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.grpStats)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "f20"
        Me.Text = "Instrument Rentals"
        Me.grpStats.ResumeLayout(False)
        Me.grpStats.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents grpStats As GroupBox
    Friend WithEvents radCount As RadioButton
    Friend WithEvents radAvg As RadioButton
    Friend WithEvents radTotal As RadioButton
    Friend WithEvents lstCustomers As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents radChrgByType As RadioButton
    Friend WithEvents BindingSource1 As BindingSource
End Class
