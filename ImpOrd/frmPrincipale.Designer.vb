<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipale
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipale))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.cmdEsci = New System.Windows.Forms.Button()
        Me.cmdEsporta = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cmdSfogliaXls = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblEspo = New System.Windows.Forms.Label()
        Me.lblgruppoEs = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk2007 = New System.Windows.Forms.CheckBox()
        Me.txtFileOr = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpzioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VediFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VediLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtDataRegDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DarkRed
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 273)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(549, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 3
        '
        'cmdEsci
        '
        Me.cmdEsci.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdEsci.Location = New System.Drawing.Point(496, 305)
        Me.cmdEsci.Name = "cmdEsci"
        Me.cmdEsci.Size = New System.Drawing.Size(75, 23)
        Me.cmdEsci.TabIndex = 8
        Me.cmdEsci.Text = "Esci"
        Me.cmdEsci.UseVisualStyleBackColor = True
        '
        'cmdEsporta
        '
        Me.cmdEsporta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdEsporta.Location = New System.Drawing.Point(415, 306)
        Me.cmdEsporta.Name = "cmdEsporta"
        Me.cmdEsporta.Size = New System.Drawing.Size(75, 23)
        Me.cmdEsporta.TabIndex = 7
        Me.cmdEsporta.Text = "Elabora"
        Me.cmdEsporta.UseVisualStyleBackColor = True
        '
        'cmdSfogliaXls
        '
        Me.cmdSfogliaXls.Location = New System.Drawing.Point(523, 37)
        Me.cmdSfogliaXls.Name = "cmdSfogliaXls"
        Me.cmdSfogliaXls.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaXls.TabIndex = 11
        Me.cmdSfogliaXls.Text = "..."
        Me.cmdSfogliaXls.UseVisualStyleBackColor = True
        '
        'lblEspo
        '
        Me.lblEspo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEspo.AutoSize = True
        Me.lblEspo.Location = New System.Drawing.Point(18, 241)
        Me.lblEspo.Name = "lblEspo"
        Me.lblEspo.Size = New System.Drawing.Size(39, 13)
        Me.lblEspo.TabIndex = 22
        Me.lblEspo.Text = "Label8"
        '
        'lblgruppoEs
        '
        Me.lblgruppoEs.AutoSize = True
        Me.lblgruppoEs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgruppoEs.ForeColor = System.Drawing.Color.Red
        Me.lblgruppoEs.Location = New System.Drawing.Point(9, 35)
        Me.lblgruppoEs.Name = "lblgruppoEs"
        Me.lblgruppoEs.Size = New System.Drawing.Size(257, 24)
        Me.lblgruppoEs.TabIndex = 23
        Me.lblgruppoEs.Text = "GRUPPO SELEZIONATO :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk2007)
        Me.GroupBox1.Controls.Add(Me.txtFileOr)
        Me.GroupBox1.Controls.Add(Me.cmdSfogliaXls)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 74)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File da importare"
        '
        'chk2007
        '
        Me.chk2007.AutoSize = True
        Me.chk2007.Location = New System.Drawing.Point(468, 14)
        Me.chk2007.Name = "chk2007"
        Me.chk2007.Size = New System.Drawing.Size(79, 17)
        Me.chk2007.TabIndex = 12
        Me.chk2007.Text = "Excel 2007"
        Me.chk2007.UseVisualStyleBackColor = True
        Me.chk2007.Visible = False
        '
        'txtFileOr
        '
        Me.txtFileOr.Location = New System.Drawing.Point(9, 37)
        Me.txtFileOr.Name = "txtFileOr"
        Me.txtFileOr.Size = New System.Drawing.Size(508, 20)
        Me.txtFileOr.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Location = New System.Drawing.Point(176, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 20)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Export"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(28, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 20)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "test"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpzioniToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(590, 24)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpzioniToolStripMenuItem
        '
        Me.OpzioniToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpostazioniToolStripMenuItem, Me.VediFilesToolStripMenuItem, Me.VediLogToolStripMenuItem})
        Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
        Me.OpzioniToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.OpzioniToolStripMenuItem.Text = "Opzioni"
        '
        'ImpostazioniToolStripMenuItem
        '
        Me.ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        Me.ImpostazioniToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ImpostazioniToolStripMenuItem.Text = "Impostazioni"
        '
        'VediFilesToolStripMenuItem
        '
        Me.VediFilesToolStripMenuItem.Name = "VediFilesToolStripMenuItem"
        Me.VediFilesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.VediFilesToolStripMenuItem.Text = "Vedi Files"
        '
        'VediLogToolStripMenuItem
        '
        Me.VediLogToolStripMenuItem.Name = "VediLogToolStripMenuItem"
        Me.VediLogToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.VediLogToolStripMenuItem.Text = "Vedi Log"
        '
        'dtDataRegDoc
        '
        Me.dtDataRegDoc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtDataRegDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataRegDoc.Location = New System.Drawing.Point(195, 190)
        Me.dtDataRegDoc.Name = "dtDataRegDoc"
        Me.dtDataRegDoc.Size = New System.Drawing.Size(121, 20)
        Me.dtDataRegDoc.TabIndex = 56
        Me.dtDataRegDoc.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Data Regristrazione Documenti"
        Me.Label2.Visible = False
        '
        'frmPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 352)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtDataRegDoc)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblgruppoEs)
        Me.Controls.Add(Me.lblEspo)
        Me.Controls.Add(Me.cmdEsporta)
        Me.Controls.Add(Me.cmdEsci)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPrincipale"
        Me.Text = "Importazione Ordini"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdEsci As System.Windows.Forms.Button
    Friend WithEvents cmdEsporta As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdSfogliaXls As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblEspo As System.Windows.Forms.Label
    Friend WithEvents lblgruppoEs As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFileOr As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpzioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpostazioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VediFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VediLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chk2007 As System.Windows.Forms.CheckBox
    Friend WithEvents dtDataRegDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
