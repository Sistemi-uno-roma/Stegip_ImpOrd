<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRicPRV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRicPRV))
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.cmdCerca = New System.Windows.Forms.Button()
        Me.dgvPRV = New System.Windows.Forms.DataGridView()
        Me.dtDataRegDoc = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdAnnulla = New System.Windows.Forms.Button()
        Me.cmdRicCodCli = New System.Windows.Forms.Button()
        Me.cmdRicRagSoc = New System.Windows.Forms.Button()
        Me.txtRagSoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvPRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodCli
        '
        Me.txtCodCli.Location = New System.Drawing.Point(12, 28)
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(121, 20)
        Me.txtCodCli.TabIndex = 0
        '
        'cmdCerca
        '
        Me.cmdCerca.Location = New System.Drawing.Point(543, 27)
        Me.cmdCerca.Name = "cmdCerca"
        Me.cmdCerca.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerca.TabIndex = 4
        Me.cmdCerca.Text = "Cerca"
        Me.cmdCerca.UseVisualStyleBackColor = True
        '
        'dgvPRV
        '
        Me.dgvPRV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPRV.Location = New System.Drawing.Point(12, 61)
        Me.dgvPRV.MultiSelect = False
        Me.dgvPRV.Name = "dgvPRV"
        Me.dgvPRV.ReadOnly = True
        Me.dgvPRV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPRV.Size = New System.Drawing.Size(809, 459)
        Me.dgvPRV.TabIndex = 9
        '
        'dtDataRegDoc
        '
        Me.dtDataRegDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataRegDoc.Location = New System.Drawing.Point(93, 61)
        Me.dtDataRegDoc.Name = "dtDataRegDoc"
        Me.dtDataRegDoc.Size = New System.Drawing.Size(121, 20)
        Me.dtDataRegDoc.TabIndex = 57
        Me.dtDataRegDoc.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(251, 61)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 58
        Me.DateTimePicker1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Codice Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Da Data "
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "A"
        Me.Label3.Visible = False
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnnulla.Location = New System.Drawing.Point(746, 526)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnnulla.TabIndex = 62
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdRicCodCli
        '
        Me.cmdRicCodCli.BackgroundImage = CType(resources.GetObject("cmdRicCodCli.BackgroundImage"), System.Drawing.Image)
        Me.cmdRicCodCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRicCodCli.Location = New System.Drawing.Point(135, 28)
        Me.cmdRicCodCli.Name = "cmdRicCodCli"
        Me.cmdRicCodCli.Size = New System.Drawing.Size(25, 20)
        Me.cmdRicCodCli.TabIndex = 1
        Me.cmdRicCodCli.UseVisualStyleBackColor = True
        '
        'cmdRicRagSoc
        '
        Me.cmdRicRagSoc.BackgroundImage = CType(resources.GetObject("cmdRicRagSoc.BackgroundImage"), System.Drawing.Image)
        Me.cmdRicRagSoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRicRagSoc.Location = New System.Drawing.Point(498, 29)
        Me.cmdRicRagSoc.Name = "cmdRicRagSoc"
        Me.cmdRicRagSoc.Size = New System.Drawing.Size(25, 20)
        Me.cmdRicRagSoc.TabIndex = 3
        Me.cmdRicRagSoc.UseVisualStyleBackColor = True
        '
        'txtRagSoc
        '
        Me.txtRagSoc.Location = New System.Drawing.Point(182, 29)
        Me.txtRagSoc.Name = "txtRagSoc"
        Me.txtRagSoc.Size = New System.Drawing.Size(313, 20)
        Me.txtRagSoc.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Ragione Sociale"
        '
        'frmRicPRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 569)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdRicRagSoc)
        Me.Controls.Add(Me.txtRagSoc)
        Me.Controls.Add(Me.cmdRicCodCli)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dtDataRegDoc)
        Me.Controls.Add(Me.dgvPRV)
        Me.Controls.Add(Me.cmdCerca)
        Me.Controls.Add(Me.txtCodCli)
        Me.Name = "frmRicPRV"
        Me.Text = "Ricerca Preventivi"
        CType(Me.dgvPRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents cmdCerca As System.Windows.Forms.Button
    Friend WithEvents dgvPRV As System.Windows.Forms.DataGridView
    Friend WithEvents dtDataRegDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents cmdRicCodCli As System.Windows.Forms.Button
    Friend WithEvents cmdRicRagSoc As System.Windows.Forms.Button
    Friend WithEvents txtRagSoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
