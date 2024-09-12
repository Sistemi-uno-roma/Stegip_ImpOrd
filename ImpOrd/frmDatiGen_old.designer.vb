<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatiGen_old
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDbGruppo = New System.Windows.Forms.TextBox()
        Me.TabPageCosti = New System.Windows.Forms.TabPage()
        Me.cmdSfogliaBat = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFileBat = New System.Windows.Forms.TextBox()
        Me.txtGrCod_PF = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCodCda = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGrCod_Comp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtModelloORA = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFilOutORA = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdSfogliaFileOutORA = New System.Windows.Forms.Button()
        Me.chkDocProvORA = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtModelloORV = New System.Windows.Forms.TextBox()
        Me.chkDocProvORV = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFilOutORV = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdSfogliaFileOutORV = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtModelloDb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFilOutDB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSfogliaFileOutDB = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtModelloArt = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtFilOutArt = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdSfogliaFileOutANA = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPageGen.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCosti.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSalva
        '
        Me.cmdSalva.Location = New System.Drawing.Point(502, 411)
        Me.cmdSalva.Name = "cmdSalva"
        Me.cmdSalva.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalva.TabIndex = 10
        Me.cmdSalva.Text = "Salva"
        Me.cmdSalva.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(592, 411)
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
        Me.TabControl1.Controls.Add(Me.TabPageGen)
        Me.TabControl1.Controls.Add(Me.TabPageCosti)
        Me.TabControl1.Location = New System.Drawing.Point(3, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(668, 399)
        Me.TabControl1.TabIndex = 43
        '
        'TabPageGen
        '
        Me.TabPageGen.Controls.Add(Me.txtGrCod_Comp)
        Me.TabPageGen.Controls.Add(Me.Label13)
        Me.TabPageGen.Controls.Add(Me.txtGrCod_PF)
        Me.TabPageGen.Controls.Add(Me.Label11)
        Me.TabPageGen.Controls.Add(Me.txtCodCda)
        Me.TabPageGen.Controls.Add(Me.Label12)
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
        Me.TabPageGen.Controls.Add(Me.DataGridView1)
        Me.TabPageGen.Controls.Add(Me.Label6)
        Me.TabPageGen.Controls.Add(Me.txtDbGruppo)
        Me.TabPageGen.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGen.Name = "TabPageGen"
        Me.TabPageGen.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGen.Size = New System.Drawing.Size(660, 373)
        Me.TabPageGen.TabIndex = 2
        Me.TabPageGen.Text = "Generali"
        Me.TabPageGen.UseVisualStyleBackColor = True
        '
        'cmdSfogliafileOr
        '
        Me.cmdSfogliafileOr.Location = New System.Drawing.Point(440, 241)
        Me.cmdSfogliafileOr.Name = "cmdSfogliafileOr"
        Me.cmdSfogliafileOr.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliafileOr.TabIndex = 58
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
        Me.txtPathFileOr.TabIndex = 57
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 316)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(456, 33)
        Me.DataGridView1.TabIndex = 9
        Me.DataGridView1.Visible = False
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
        Me.TabPageCosti.Controls.Add(Me.GroupBox6)
        Me.TabPageCosti.Controls.Add(Me.GroupBox4)
        Me.TabPageCosti.Controls.Add(Me.GroupBox1)
        Me.TabPageCosti.Controls.Add(Me.cmdSfogliaBat)
        Me.TabPageCosti.Controls.Add(Me.Label9)
        Me.TabPageCosti.Controls.Add(Me.GroupBox2)
        Me.TabPageCosti.Controls.Add(Me.txtFileBat)
        Me.TabPageCosti.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCosti.Name = "TabPageCosti"
        Me.TabPageCosti.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCosti.Size = New System.Drawing.Size(660, 373)
        Me.TabPageCosti.TabIndex = 1
        Me.TabPageCosti.Text = "Importazione"
        Me.TabPageCosti.UseVisualStyleBackColor = True
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
        'txtGrCod_PF
        '
        Me.txtGrCod_PF.Location = New System.Drawing.Point(108, 290)
        Me.txtGrCod_PF.Name = "txtGrCod_PF"
        Me.txtGrCod_PF.Size = New System.Drawing.Size(121, 20)
        Me.txtGrCod_PF.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(105, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Gr.Codifica Prodotto Finito"
        '
        'txtCodCda
        '
        Me.txtCodCda.Location = New System.Drawing.Point(394, 290)
        Me.txtCodCda.Name = "txtCodCda"
        Me.txtCodCda.Size = New System.Drawing.Size(71, 20)
        Me.txtCodCda.TabIndex = 61
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(391, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Codice CDA"
        '
        'txtGrCod_Comp
        '
        Me.txtGrCod_Comp.Location = New System.Drawing.Point(249, 290)
        Me.txtGrCod_Comp.Name = "txtGrCod_Comp"
        Me.txtGrCod_Comp.Size = New System.Drawing.Size(121, 20)
        Me.txtGrCod_Comp.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(246, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Gr.Codifica Componenti"
        '
        'txtModelloORA
        '
        Me.txtModelloORA.Location = New System.Drawing.Point(96, 22)
        Me.txtModelloORA.Name = "txtModelloORA"
        Me.txtModelloORA.Size = New System.Drawing.Size(65, 20)
        Me.txtModelloORA.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Modello"
        '
        'txtFilOutORA
        '
        Me.txtFilOutORA.Location = New System.Drawing.Point(259, 22)
        Me.txtFilOutORA.Name = "txtFilOutORA"
        Me.txtFilOutORA.Size = New System.Drawing.Size(325, 20)
        Me.txtFilOutORA.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(171, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "FIle da creare"
        '
        'cmdSfogliaFileOutORA
        '
        Me.cmdSfogliaFileOutORA.Location = New System.Drawing.Point(591, 22)
        Me.cmdSfogliaFileOutORA.Name = "cmdSfogliaFileOutORA"
        Me.cmdSfogliaFileOutORA.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaFileOutORA.TabIndex = 3
        Me.cmdSfogliaFileOutORA.Text = "..."
        Me.cmdSfogliaFileOutORA.UseVisualStyleBackColor = True
        '
        'chkDocProvORA
        '
        Me.chkDocProvORA.AutoSize = True
        Me.chkDocProvORA.Location = New System.Drawing.Point(259, 53)
        Me.chkDocProvORA.Name = "chkDocProvORA"
        Me.chkDocProvORA.Size = New System.Drawing.Size(145, 17)
        Me.chkDocProvORA.TabIndex = 49
        Me.chkDocProvORA.Text = "Importa come Provvisorio"
        Me.chkDocProvORA.UseVisualStyleBackColor = True
        Me.chkDocProvORA.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkDocProvORA)
        Me.GroupBox6.Controls.Add(Me.cmdSfogliaFileOutORA)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.txtFilOutORA)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txtModelloORA)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 223)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(629, 76)
        Me.GroupBox6.TabIndex = 48
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Importazione Documento ORA"
        '
        'txtModelloORV
        '
        Me.txtModelloORV.Location = New System.Drawing.Point(96, 22)
        Me.txtModelloORV.Name = "txtModelloORV"
        Me.txtModelloORV.Size = New System.Drawing.Size(65, 20)
        Me.txtModelloORV.TabIndex = 1
        '
        'chkDocProvORV
        '
        Me.chkDocProvORV.AutoSize = True
        Me.chkDocProvORV.Location = New System.Drawing.Point(259, 48)
        Me.chkDocProvORV.Name = "chkDocProvORV"
        Me.chkDocProvORV.Size = New System.Drawing.Size(145, 17)
        Me.chkDocProvORV.TabIndex = 48
        Me.chkDocProvORV.Text = "Importa come Provvisorio"
        Me.chkDocProvORV.UseVisualStyleBackColor = True
        Me.chkDocProvORV.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Modello"
        '
        'txtFilOutORV
        '
        Me.txtFilOutORV.Location = New System.Drawing.Point(259, 22)
        Me.txtFilOutORV.Name = "txtFilOutORV"
        Me.txtFilOutORV.Size = New System.Drawing.Size(325, 20)
        Me.txtFilOutORV.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(171, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "FIle da creare"
        '
        'cmdSfogliaFileOutORV
        '
        Me.cmdSfogliaFileOutORV.Location = New System.Drawing.Point(591, 22)
        Me.cmdSfogliaFileOutORV.Name = "cmdSfogliaFileOutORV"
        Me.cmdSfogliaFileOutORV.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaFileOutORV.TabIndex = 3
        Me.cmdSfogliaFileOutORV.Text = "..."
        Me.cmdSfogliaFileOutORV.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdSfogliaFileOutORV)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtFilOutORV)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.chkDocProvORV)
        Me.GroupBox4.Controls.Add(Me.txtModelloORV)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 150)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(629, 67)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Importazione Documento ORV"
        '
        'txtModelloDb
        '
        Me.txtModelloDb.Location = New System.Drawing.Point(96, 22)
        Me.txtModelloDb.Name = "txtModelloDb"
        Me.txtModelloDb.Size = New System.Drawing.Size(65, 20)
        Me.txtModelloDb.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Modello"
        '
        'txtFilOutDB
        '
        Me.txtFilOutDB.Location = New System.Drawing.Point(259, 22)
        Me.txtFilOutDB.Name = "txtFilOutDB"
        Me.txtFilOutDB.Size = New System.Drawing.Size(325, 20)
        Me.txtFilOutDB.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "FIle da creare"
        '
        'cmdSfogliaFileOutDB
        '
        Me.cmdSfogliaFileOutDB.Location = New System.Drawing.Point(591, 22)
        Me.cmdSfogliaFileOutDB.Name = "cmdSfogliaFileOutDB"
        Me.cmdSfogliaFileOutDB.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaFileOutDB.TabIndex = 3
        Me.cmdSfogliaFileOutDB.Text = "..."
        Me.cmdSfogliaFileOutDB.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSfogliaFileOutDB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFilOutDB)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtModelloDb)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 53)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Importazione Distinta Base"
        '
        'txtModelloArt
        '
        Me.txtModelloArt.Location = New System.Drawing.Point(96, 22)
        Me.txtModelloArt.Name = "txtModelloArt"
        Me.txtModelloArt.Size = New System.Drawing.Size(65, 20)
        Me.txtModelloArt.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 13)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "Modello"
        '
        'txtFilOutArt
        '
        Me.txtFilOutArt.Location = New System.Drawing.Point(259, 22)
        Me.txtFilOutArt.Name = "txtFilOutArt"
        Me.txtFilOutArt.Size = New System.Drawing.Size(325, 20)
        Me.txtFilOutArt.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(171, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 13)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "FIle da creare"
        '
        'cmdSfogliaFileOutANA
        '
        Me.cmdSfogliaFileOutANA.Location = New System.Drawing.Point(591, 22)
        Me.cmdSfogliaFileOutANA.Name = "cmdSfogliaFileOutANA"
        Me.cmdSfogliaFileOutANA.Size = New System.Drawing.Size(24, 20)
        Me.cmdSfogliaFileOutANA.TabIndex = 3
        Me.cmdSfogliaFileOutANA.Text = "..."
        Me.cmdSfogliaFileOutANA.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdSfogliaFileOutANA)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtFilOutArt)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtModelloArt)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(629, 53)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Importazione Anagrafica"
        '
        'frmDatiGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 453)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdSalva)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmDatiGen"
        Me.Text = "Dati Generali"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageGen.ResumeLayout(False)
        Me.TabPageGen.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCosti.ResumeLayout(False)
        Me.TabPageCosti.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDbGruppo As System.Windows.Forms.TextBox
    Friend WithEvents cmdSfogliafileOr As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPathFileOr As System.Windows.Forms.TextBox
    Friend WithEvents txtGrCod_Comp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtGrCod_PF As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCodCda As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDocProvORA As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSfogliaFileOutORA As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFilOutORA As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtModelloORA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSfogliaFileOutORV As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFilOutORV As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkDocProvORV As System.Windows.Forms.CheckBox
    Friend WithEvents txtModelloORV As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSfogliaFileOutDB As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFilOutDB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtModelloDb As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSfogliaFileOutANA As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtFilOutArt As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtModelloArt As System.Windows.Forms.TextBox

End Class
