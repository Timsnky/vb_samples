<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenus
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
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.cmuImage = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRotate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFlip = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstText = New System.Windows.Forms.ListBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sspProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.fntFont = New System.Windows.Forms.FontDialog()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.prtPrint = New System.Windows.Forms.PrintDialog()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmuImage.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picDog
        '
        Me.picDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDog.ContextMenuStrip = Me.cmuImage
        Me.picDog.Image = Global.MenuSample.My.Resources.Resources.dog088
        Me.picDog.Location = New System.Drawing.Point(29, 55)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(210, 239)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDog.TabIndex = 0
        Me.picDog.TabStop = False
        '
        'cmuImage
        '
        Me.cmuImage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRotate, Me.mnuFlip})
        Me.cmuImage.Name = "cmuImage"
        Me.cmuImage.Size = New System.Drawing.Size(109, 48)
        '
        'mnuRotate
        '
        Me.mnuRotate.Name = "mnuRotate"
        Me.mnuRotate.Size = New System.Drawing.Size(108, 22)
        Me.mnuRotate.Text = "Rotate"
        '
        'mnuFlip
        '
        Me.mnuFlip.Name = "mnuFlip"
        Me.mnuFlip.Size = New System.Drawing.Size(108, 22)
        Me.mnuFlip.Text = "Flip"
        '
        'lstText
        '
        Me.lstText.FormattingEnabled = True
        Me.lstText.Location = New System.Drawing.Point(261, 57)
        Me.lstText.Name = "lstText"
        Me.lstText.Size = New System.Drawing.Size(211, 238)
        Me.lstText.TabIndex = 1
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(495, 57)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(196, 238)
        Me.txtInput.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(718, 57)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(718, 98)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuOptions, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(943, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.ToolStripMenuItem1, Me.mnuSave, Me.mnuSaveAs, Me.ToolStripMenuItem2, Me.mnuPrint, Me.ToolStripMenuItem3, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(149, 22)
        Me.mnuNew.Text = "&New"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(149, 22)
        Me.mnuOpen.Text = "&Open"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(146, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(149, 22)
        Me.mnuSave.Text = "&Save..."
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(149, 22)
        Me.mnuSaveAs.Text = "Save As..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(146, 6)
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuPrint.Size = New System.Drawing.Size(149, 22)
        Me.mnuPrint.Text = "&Print..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(146, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(149, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCut, Me.mnuCopy, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(144, 22)
        Me.mnuCut.Text = "Cut"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuPaste.Text = "Paste"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFont})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(61, 20)
        Me.mnuOptions.Text = "Options"
        '
        'mnuFont
        '
        Me.mnuFont.Name = "mnuFont"
        Me.mnuFont.Size = New System.Drawing.Size(149, 22)
        Me.mnuFont.Text = "Change font..."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(116, 22)
        Me.mnuAbout.Text = "About..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus, Me.sspProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 342)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(943, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.AutoSize = False
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(450, 17)
        Me.sslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sspProgress
        '
        Me.sspProgress.AutoSize = False
        Me.sspProgress.Name = "sspProgress"
        Me.sspProgress.Size = New System.Drawing.Size(450, 16)
        '
        'prtPrint
        '
        Me.prtPrint.UseEXDialog = True
        '
        'frmMenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lstText)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Sample"
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmuImage.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picDog As PictureBox
    Friend WithEvents lstText As ListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuPrint As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuOptions As ToolStripMenuItem
    Friend WithEvents mnuFont As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents sslStatus As ToolStripStatusLabel
    Friend WithEvents sspProgress As ToolStripProgressBar
    Friend WithEvents fntFont As FontDialog
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents sfdSave As SaveFileDialog
    Friend WithEvents prtPrint As PrintDialog
    Friend WithEvents cmuImage As ContextMenuStrip
    Friend WithEvents mnuRotate As ToolStripMenuItem
    Friend WithEvents mnuFlip As ToolStripMenuItem
End Class
