<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatiGen
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
        Me.cmdSalva = New System.Windows.Forms.Button()
        Me.cmdAnnulla = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageGen = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodCda = New System.Windows.Forms.TextBox()
        Me.updLungProgArt = New System.Windows.Forms.NumericUpDown()
        Me.updLungProgComp = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodCicloLavTemplate = New System.Windows.Forms.TextBox()
        Me.cmdSfogliafileOr = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPathFileOr = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdSfogliaAcc = New System.Windows.Forms.Button()
        Me.txtDbAcc = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmdSfogliaPathes = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtpahtconfEs = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtDbNameSql = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtUtente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtWSP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOperatore = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWS = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDbGruppo = New System.Windows.Forms.TextBox()
        Me.TabPageCosti = New System.Windows.Forms.TabPage()
        Me.dgvDatiEsport = New System.Windows.Forms.DataGridView()
        Me.cmdSfogliaPathExp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPathExport = New System.Windows.Forms.TextBox()
        Me.cmdSfogliaBat = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFileBat = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNomeFoglio = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPageGen.SuspendLayout()
        CType(Me.updLungProgArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updLungProgComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPageCosti.SuspendLayout()
        CType(Me.dgvDatiEsport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalva
        '
        Me.cmdSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalva.Location = New System.Drawing.Point(498, 429)
        Me.cmdSalva.Name = "cmdSalva"
        Me.cmdSalva.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalva.TabIndex = 10
        Me.cmdSalva.Text = "Salva"
        Me.cmdSalva.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnnulla.Location = New System.Drawing.Point(588, 429)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnnulla.TabIndex = 11
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageGen)
        Me.TabControl1.Controls.Add(Me.TabPageCosti)
        Me.TabControl1.Location = New System.Drawing.Point(3, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(664, 417)
        Me.TabControl1.TabIndex = 43
        '
        'TabPageGen
        '
        Me.TabPageGen.Controls.Add(Me.Label14)
        Me.TabPageGen.Controls.Add(Me.txtNomeFoglio)
        Me.TabPageGen.Controls.Add(Me.Label13)
        Me.TabPageGen.Controls.Add(Me.txtCodCda)
        Me.TabPageGen.Controls.Add(Me.updLungProgArt)
        Me.TabPageGen.Controls.Add(Me.updLungProgComp)
        Me.TabPageGen.Controls.Add(Me.Label11)
        Me.TabPageGen.Controls.Add(Me.Label12)
        Me.TabPageGen.Controls.Add(Me.Label5)
        Me.TabPageGen.Controls.Add(Me.txtCodCicloLavTemplate)
        Me.TabPageGen.Controls.Add(Me.cmdSfogliafileOr)
        Me.TabPageGen.Controls.Add(Me.Label4)
        Me.TabPageGen.Controls.Add(Me.txtPathFileOr)
        Me.TabPageGen.Controls.Add(Me.GroupBox5)
        Me.TabPageGen.Controls.Add(Me.cmdSfogliaPathes)
        Me.TabPageGen.Controls.Add(Me.Label18)
        Me.TabPageGen.Controls.Add(Me.txtpahtconfEs)
        Me.TabPageGen.Controls.Add(Me.GroupBox3)
        Me.TabPageGen.Controls.Add(Me.txtWSP)
        Me.TabPageGen.Controls.Add(Me.Label7)
        Me.TabPageGen.Controls.Add(Me.txtOperatore)
        Me.TabPageGen.Controls.Add(Me.Label8)
        Me.TabPageGen.Controls.Add(Me.txtWS)
        Me.TabPageGen.Controls.Add(Me.Label10)
        Me.TabPageGen.Controls.Add(Me.Label6)
        Me.TabPageGen.Controls.Add(Me.txtDbGruppo)
        Me.TabPageGen.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGen.Name = "TabPageGen"
        Me.TabPageGen.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGen.Size = New System.Drawing.Size(656, 391)
        Me.TabPageGen.TabIndex = 2
        Me.TabPageGen.Text = "Generali"
        Me.TabPageGen.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Cod.Cda"
        '
        'txtCodCda
        '
        Me.txtCodCda.Location = New System.Drawing.Point(109, 268)
        Me.txtCodCda.Name = "txtCodCda"
        Me.txtCodCda.Size = New System.Drawing.Size(121, 20)
        Me.txtCodCda.TabIndex = 76
        '
        'updLungProgArt
        '
        Me.updLungProgArt.Location = New System.Drawing.Point(129, 297)
        Me.updLungProgArt.Name = "updLungProgArt"
        Me.updLungProgArt.Size = New System.Drawing.Size(87, 20)
        Me.updLungProgArt.TabIndex = 75
        '
        'updLungProgComp
        '
        Me.updLungProgComp.Location = New System.Drawing.Point(377, 297)
        Me.updLungProgComp.Name = "updLungProgComp"
        Me.updLungProgComp.Size = New System.Drawing.Size(87, 20)
        Me.updLungProgComp.TabIndex = 74
        Me.updLungProgComp.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(257, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Lunghezza Prog.Comp"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Lunghezza Progressivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Ciclo Lav.Template"
        Me.Label5.Visible = False
        '
        'txtCodCicloLavTemplate
        '
        Me.txtCodCicloLavTemplate.Location = New System.Drawing.Point(343, 216)
        Me.txtCodCicloLavTemplate.Name = "txtCodCicloLavTemplate"
        Me.txtCodCicloLavTemplate.Size = New System.Drawing.Size(121, 20)
        Me.txtCodCicloLavTemplate.TabIndex = 68
        Me.txtCodCicloLavTemplate.Visible = False
        '
        'cmdSfogliafileOr
        '
        Me.cmdSfogliafileOr.Location = New System.Drawing.Point(440, 241)
        Me.cmdSfogliafileOr.Name = "cmdSfogliafileOr"
        Me.cmdSfogliafileOr.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliafileOr.TabIndex = 13
        Me.cmdSfogliafileOr.Text = "..."
        Me.cmdSfogliafileOr.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Path file da leggere"
        '
        'txtPathFileOr
        '
        Me.txtPathFileOr.Location = New System.Drawing.Point(109, 242)
        Me.txtPathFileOr.Name = "txtPathFileOr"
        Me.txtPathFileOr.Size = New System.Drawing.Size(326, 20)
        Me.txtPathFileOr.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdSfogliaAcc)
        Me.GroupBox5.Controls.Add(Me.txtDbAcc)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 91)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(463, 57)
        Me.GroupBox5.TabIndex = 56
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Connessione Db Access"
        '
        'cmdSfogliaAcc
        '
        Me.cmdSfogliaAcc.Location = New System.Drawing.Point(433, 22)
        Me.cmdSfogliaAcc.Name = "cmdSfogliaAcc"
        Me.cmdSfogliaAcc.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaAcc.TabIndex = 5
        Me.cmdSfogliaAcc.Text = "..."
        Me.cmdSfogliaAcc.UseVisualStyleBackColor = True
        '
        'txtDbAcc
        '
        Me.txtDbAcc.Location = New System.Drawing.Point(100, 22)
        Me.txtDbAcc.Name = "txtDbAcc"
        Me.txtDbAcc.Size = New System.Drawing.Size(330, 20)
        Me.txtDbAcc.TabIndex = 4
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(9, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(52, 13)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "Nome Db"
        '
        'cmdSfogliaPathes
        '
        Me.cmdSfogliaPathes.Location = New System.Drawing.Point(440, 189)
        Me.cmdSfogliaPathes.Name = "cmdSfogliaPathes"
        Me.cmdSfogliaPathes.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaPathes.TabIndex = 10
        Me.cmdSfogliaPathes.Text = "..."
        Me.cmdSfogliaPathes.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 193)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "PathConf Es"
        '
        'txtpahtconfEs
        '
        Me.txtpahtconfEs.Location = New System.Drawing.Point(109, 190)
        Me.txtpahtconfEs.Name = "txtpahtconfEs"
        Me.txtpahtconfEs.Size = New System.Drawing.Size(326, 20)
        Me.txtpahtconfEs.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPwd)
        Me.GroupBox3.Controls.Add(Me.txtDbNameSql)
        Me.GroupBox3.Controls.Add(Me.txtServer)
        Me.GroupBox3.Controls.Add(Me.txtUtente)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 79)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Connessione Esolver"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(339, 45)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(121, 20)
        Me.txtPwd.TabIndex = 3
        '
        'txtDbNameSql
        '
        Me.txtDbNameSql.Location = New System.Drawing.Point(339, 19)
        Me.txtDbNameSql.Name = "txtDbNameSql"
        Me.txtDbNameSql.Size = New System.Drawing.Size(121, 20)
        Me.txtDbNameSql.TabIndex = 1
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(100, 19)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(121, 20)
        Me.txtServer.TabIndex = 0
        '
        'txtUtente
        '
        Me.txtUtente.Location = New System.Drawing.Point(100, 45)
        Me.txtUtente.Name = "txtUtente"
        Me.txtUtente.Size = New System.Drawing.Size(121, 20)
        Me.txtUtente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nome Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Pwd"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(248, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Nome Db"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Utente"
        '
        'txtWSP
        '
        Me.txtWSP.Location = New System.Drawing.Point(372, 164)
        Me.txtWSP.Name = "txtWSP"
        Me.txtWSP.Size = New System.Drawing.Size(41, 20)
        Me.txtWSP.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "WSP"
        '
        'txtOperatore
        '
        Me.txtOperatore.Location = New System.Drawing.Point(109, 164)
        Me.txtOperatore.Name = "txtOperatore"
        Me.txtOperatore.Size = New System.Drawing.Size(121, 20)
        Me.txtOperatore.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Operatore"
        '
        'txtWS
        '
        Me.txtWS.Location = New System.Drawing.Point(277, 164)
        Me.txtWS.Name = "txtWS"
        Me.txtWS.Size = New System.Drawing.Size(41, 20)
        Me.txtWS.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(246, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "WS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "DBGruppo"
        '
        'txtDbGruppo
        '
        Me.txtDbGruppo.Location = New System.Drawing.Point(109, 216)
        Me.txtDbGruppo.Name = "txtDbGruppo"
        Me.txtDbGruppo.Size = New System.Drawing.Size(121, 20)
        Me.txtDbGruppo.TabIndex = 11
        '
        'TabPageCosti
        '
        Me.TabPageCosti.Controls.Add(Me.dgvDatiEsport)
        Me.TabPageCosti.Controls.Add(Me.cmdSfogliaPathExp)
        Me.TabPageCosti.Controls.Add(Me.Label1)
        Me.TabPageCosti.Controls.Add(Me.txtPathExport)
        Me.TabPageCosti.Controls.Add(Me.cmdSfogliaBat)
        Me.TabPageCosti.Controls.Add(Me.Label9)
        Me.TabPageCosti.Controls.Add(Me.txtFileBat)
        Me.TabPageCosti.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCosti.Name = "TabPageCosti"
        Me.TabPageCosti.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCosti.Size = New System.Drawing.Size(656, 391)
        Me.TabPageCosti.TabIndex = 1
        Me.TabPageCosti.Text = "Importazione"
        Me.TabPageCosti.UseVisualStyleBackColor = True
        '
        'dgvDatiEsport
        '
        Me.dgvDatiEsport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatiEsport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatiEsport.Location = New System.Drawing.Point(20, 107)
        Me.dgvDatiEsport.Name = "dgvDatiEsport"
        Me.dgvDatiEsport.Size = New System.Drawing.Size(600, 248)
        Me.dgvDatiEsport.TabIndex = 8
        '
        'cmdSfogliaPathExp
        '
        Me.cmdSfogliaPathExp.Location = New System.Drawing.Point(600, 59)
        Me.cmdSfogliaPathExp.Name = "cmdSfogliaPathExp"
        Me.cmdSfogliaPathExp.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaPathExp.TabIndex = 7
        Me.cmdSfogliaPathExp.Text = "..."
        Me.cmdSfogliaPathExp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Path File Export"
        '
        'txtPathExport
        '
        Me.txtPathExport.Location = New System.Drawing.Point(105, 57)
        Me.txtPathExport.Name = "txtPathExport"
        Me.txtPathExport.Size = New System.Drawing.Size(488, 20)
        Me.txtPathExport.TabIndex = 6
        '
        'cmdSfogliaBat
        '
        Me.cmdSfogliaBat.Location = New System.Drawing.Point(600, 9)
        Me.cmdSfogliaBat.Name = "cmdSfogliaBat"
        Me.cmdSfogliaBat.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaBat.TabIndex = 5
        Me.cmdSfogliaBat.Text = "..."
        Me.cmdSfogliaBat.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Batch"
        '
        'txtFileBat
        '
        Me.txtFileBat.Location = New System.Drawing.Point(105, 7)
        Me.txtFileBat.Name = "txtFileBat"
        Me.txtFileBat.Size = New System.Drawing.Size(488, 20)
        Me.txtFileBat.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(240, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Nome Foglio xls"
        '
        'txtNomeFoglio
        '
        Me.txtNomeFoglio.Location = New System.Drawing.Point(344, 268)
        Me.txtNomeFoglio.Name = "txtNomeFoglio"
        Me.txtNomeFoglio.Size = New System.Drawing.Size(121, 20)
        Me.txtNomeFoglio.TabIndex = 78
        '
        'frmDatiGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 471)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdSalva)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimumSize = New System.Drawing.Size(683, 503)
        Me.Name = "frmDatiGen"
        Me.Text = "Dati Generali"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageGen.ResumeLayout(False)
        Me.TabPageGen.PerformLayout()
        CType(Me.updLungProgArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updLungProgComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPageCosti.ResumeLayout(False)
        Me.TabPageCosti.PerformLayout()
        CType(Me.dgvDatiEsport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSalva As System.Windows.Forms.Button
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageCosti As System.Windows.Forms.TabPage
    Friend WithEvents cmdSfogliaBat As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFileBat As System.Windows.Forms.TextBox
    Friend WithEvents TabPageGen As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSfogliaAcc As System.Windows.Forms.Button
    Friend WithEvents txtDbAcc As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmdSfogliaPathes As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtpahtconfEs As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtDbNameSql As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtUtente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtWSP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOperatore As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtWS As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDbGruppo As System.Windows.Forms.TextBox
    Friend WithEvents cmdSfogliafileOr As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPathFileOr As System.Windows.Forms.TextBox
    Friend WithEvents cmdSfogliaPathExp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPathExport As System.Windows.Forms.TextBox
    Friend WithEvents dgvDatiEsport As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodCicloLavTemplate As System.Windows.Forms.TextBox
    Friend WithEvents updLungProgArt As NumericUpDown
    Friend WithEvents updLungProgComp As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodCda As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNomeFoglio As TextBox
End Class
