<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRicercaCli
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents _lvwCli_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvwCli_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
    Public WithEvents lvwCli As System.Windows.Forms.ListView
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRicercaCli))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lvwCli = New System.Windows.Forms.ListView()
        Me._lvwCli_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvwCli_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvwCli
        '
        Me.lvwCli.AllowColumnReorder = True
        Me.lvwCli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCli.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvwCli_ColumnHeader_1, Me._lvwCli_ColumnHeader_2})
        Me.lvwCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCli.ForeColor = System.Drawing.Color.Black
        Me.lvwCli.FullRowSelect = True
        Me.lvwCli.GridLines = True
        Me.lvwCli.LabelWrap = False
        Me.lvwCli.Location = New System.Drawing.Point(1, 3)
        Me.lvwCli.Name = "lvwCli"
        Me.lvwCli.Size = New System.Drawing.Size(607, 417)
        Me.lvwCli.TabIndex = 0
        Me.lvwCli.UseCompatibleStateImageBehavior = False
        Me.lvwCli.View = System.Windows.Forms.View.Details
        '
        '_lvwCli_ColumnHeader_1
        '
        Me._lvwCli_ColumnHeader_1.Text = "Codice"
        Me._lvwCli_ColumnHeader_1.Width = 177
        '
        '_lvwCli_ColumnHeader_2
        '
        Me._lvwCli_ColumnHeader_2.Text = "Ragione Sociale"
        Me._lvwCli_ColumnHeader_2.Width = 588
        '
        'frmRicercaCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(611, 424)
        Me.Controls.Add(Me.lvwCli)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmRicercaCli"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Ricerca Clienti"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class