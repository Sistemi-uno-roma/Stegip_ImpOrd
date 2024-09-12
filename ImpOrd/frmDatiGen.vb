
Imports System.Data.OleDb
Public Class frmDatiGen
    'Dim dscmd As OleDbDataAdapter

    Dim dsGen As DataSet
    Dim dscmdGen As OleDbDataAdapter
    Dim dsConti As DataSet
    Dim dscmdConti As OleDbDataAdapter
    Private Sub cmdSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalva.Click
        With DatiGen
            'Generale
            .WS = txtWS.Text
            .WSP = txtWSP.Text
            .Operatore = txtOperatore.Text
            .Server = txtServer.Text
            .NomeDbSql = txtDbNameSql.Text
            .Utente = txtUtente.Text
            .Pwd = txtPwd.Text
            .DbAccess = txtDbAcc.Text
            .PathConfES = txtpahtconfEs.Text
            .DbGruppo = txtDbGruppo.Text
            .PathFileOr = txtPathFileOr.Text

            '.DocProv = True
            'If chkDocProvORV.Checked Then
            '    .DocProv = True
            'Else
            '    .docprov = False
            'End If




           

            '.ModelloArt = txtModelloArt.Text
            '.FilOutArt = txtFilOutArt.Text
            '.Modellodb = txtModelloDb.Text
            '.FilOutdb = txtFilOutDB.Text
            '.ModelloORV = txtModelloORV.Text
            '.FilOutORV = txtFilOutORV.Text
            '.ModelloORa = txtModelloORA.Text
            '.FilOutORa = txtFilOutORA.Text

            .FileBat = txtFileBat.Text
            .PathExport = txtPathExport.Text

            '.CodCiclotemplate = txtCodCicloLavTemplate.Text

            ' .FileXlsPart = txtFilexlsPart.Text


            'Anagrafiche
            '.FileOutAna = txtFilOutAna.Text
            '.GruppoDocAna = txtGruppoDoc.Text
            '.ModelloAna = txtModello.Text
            '.FileBatAna = txtFileBatAna.Text

            'Costi 
            '.VoceInd2 = txtVoceInd2.Text
            '.CentroCosto2 = txtCentroCosto2.Text
            '.GruppoDocContabGen = txtGruppoDocContabGen.Text
            '.ModelloContabGen = txtModelloArt.Text
            '.FilOutContaGen = txtFilOutAna.Text
            '.FileBatCosti = txtBat.Text


            '.GestPartite = IIf(chkPartite.Checked, 1, 0)
            '.ContoContrPar = txtContoContrPar.Text
            '.TipoPar = txtTipoPar.Text
            '.CodPag = txtCodPag.Text
            '.CodContoNetto = txtCodContoNetto.Text



            '.CodVoce = txtCodVoce.Text
            '.TipoRiga = txtTipoRiga.Text
            '.CodPag = txtCodPag.Text
            '.NrRegIva = txtNrRegIva.Text


            ' .GruppoDocMovInd = txtGruppoDocInd.Text
            ' .ModelloMovInd = txtModelloInd.Text
            ' .FilOutMovInd = txtFilOutInd.Text
            ' .FileBatMovInd = txtBatMovInd.Text

            '.CodArtCntrlDispo = txtCodArtCntrlDispo.Text

        End With
        SalvaConfig()

        'DataGridView1.EndEdit() 
        'dscmd.Update(ds, "Aziende")


        dgvDatiEsport.EndEdit()
        dscmdGen.Update(dsGen, "dtGen")
        'dgvConti.EndEdit()
        'dscmdConti.Update(dsConti, "Conti")
        Me.Close()

    End Sub

    Private Sub frmDatiGen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CenterToScreen()
        For Each mcontrl As Control In Me.Controls
            If TypeOf mcontrl Is TextBox Then
                mcontrl.BackColor = Color.Yellow
                AddHandler CType(mcontrl, TextBox).TextChanged, AddressOf TextBox_LOSTFOCUS
            End If
        Next
        With DatiGen

            'Generale
            txtDbGruppo.Text = .DbGruppo
            txtWS.Text = .WS
            txtWSP.Text = .WSP
            txtOperatore.Text = .Operatore
            txtServer.Text = .Server
            txtDbNameSql.Text = .NomeDbSql
            txtUtente.Text = .Utente
            txtPwd.Text = .Pwd
            txtDbAcc.Text = .DbAccess
            txtpahtconfEs.Text = .PathConfES

            txtPathFileOr.Text = .PathFileOr

         

            'txtModelloArt.Text = .ModelloArt
            'txtFilOutArt.Text = .FilOutArt
            'txtModelloDb.Text = .Modellodb
            'txtFilOutDB.Text = .FilOutdb
            'txtModelloORV.Text = .ModelloORV
            'txtFilOutORV.Text = .FilOutORV
            'txtModelloORA.Text = .ModelloORa
            'txtFilOutORA.Text = .FilOutORa

            txtFileBat.Text = .FileBat
            txtPathExport.Text = .PathExport

            'txtCodCicloLavTemplate.Text = .CodCiclotemplate


            ' If .DocProv = True Then
            'chkDocProvORV.Checked = True
            'Else
            'chkDocProvORV.Checked = False
            'End If
            ' txtFilexlsPart.Text = .FileXlsPart

            'Anagrafiche
            'txtFilOutAna.Text = .FileOutAna
            'txtGruppoDoc.Text = .GruppoDocAna
            'txtModello.Text = .ModelloAna
            'txtFileBatAna.Text = .FileBatAna

            'Costi 
            ' txtVoceInd2.Text = .VoceInd2
            ' txtCentroCosto2.Text = .CentroCosto2
            'txtGruppoDocContabGen.Text = .GruppoDocContabGen
            'txtModelloArt.Text = .ModelloContabGen
            'txtFilOutArt.Text = .FilOutContaGen
            'txtFileBat.Text = .FileBatCosti


            'chkPartite.Checked = Val(.GestPartite)
            'txtContoContrPar.Text = .ContoContrPar
            'txtTipoPar.Text = .TipoPar
            'txtCodPag.Text = .CodPag
            'txtCodContoNetto.Text = .CodContoNetto

            'txtCodVoce.Text = .CodVoce
            'txtTipoRiga.Text = .TipoRiga
            'txtCodPag.Text = .CodPag
            'txtNrRegIva.Text = .NrRegIva

            '   txtGruppoDocInd.Text = .GruppoDocMovInd
            '   txtModelloInd.Text = .ModelloMovInd
            '   txtFilOutInd.Text = .FilOutMovInd
            ' txtBatMovInd.Text = .FileBatMovInd


            'txtCodArtCntrlDispo.Text = .CodArtCntrlDispo


        End With
        'If txtDb.Text = "" Then
        '    txtDb.Text = Application.StartupPath & "\AnaDip.mdb"
        'End If
        'If ds.Tables("Aziende") Is Nothing Then
        '    ds.Tables.Add("Aziende")
        '    ds.Tables("Aziende").Columns.Add("Codice")
        '    ds.Tables("Aziende").Columns.Add("Gruppo")
        '    'Dim mArr(1) As String
        '    'mArr(0) = ""
        '    'mArr(1) = ""
        '    'ds.Tables("Aziende").Rows.Add(mArr)
        'End If
        'DataGridView1.DataSource = ds
        'DataGridView1.DataMember = "Aziende"
        'DataGridView1.Refresh()

        CaricaConti()
        CaricaDatiGen()

    End Sub

    Private Sub CaricaConti()

        'Dim connectionString As String = ""
        'Dim cnn As OleDbConnection
        'connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatiGen.DbAccess & ";"
        'cnn = New OleDbConnection(connectionString)
        'cnn.Open()
        'Dim Sql As String = "Select * from CostiVoci " & _
        '  " Order by CodContoFile "
        'Dim command As OleDbCommand = cnn.CreateCommand()
        'command.CommandText = Sql
        'dscmdConti = New OleDbDataAdapter(Sql, cnn)

        'dsConti = New DataSet()

        'Dim Cmd As OleDbCommandBuilder
        'Cmd = New OleDbCommandBuilder(dscmdConti)
        'dscmdConti.Fill(dsConti, "Conti")
        ''Dim DataTable As New DataTable
        ''dscmd.Fill(DataTable)

        ''Dim bindingSource As BindingSource


        'dgvConti.DataSource = dsConti
        'dgvConti.DataMember = "Conti"
        'dgvConti.Refresh()
        ''bindingSource = New BindingSource(DataTable)
        ''DataGridView1.DataSource = bindingSource 


    End Sub
    Private Sub CaricaDatiGen()

        If DatiGen.DbAccess <> "" Then

            Dim connectionString As String = ""
            Dim cnn As OleDbConnection
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatiGen.DbAccess & ";"
            Try
                cnn = New OleDbConnection(connectionString)
                cnn.Open()

            Catch ex As Exception
                MsgBox("Error connessione access", MsgBoxStyle.Critical)
                Exit Sub
            End Try
            Dim Sql As String = "Select * from  DaEseguire order by dbgruppo,priorita"
            Dim command As OleDbCommand = cnn.CreateCommand()
            command.CommandText = Sql
            dscmdGen = New OleDbDataAdapter(Sql, cnn)

            dsGen = New DataSet()

            Dim Cmd As OleDbCommandBuilder
            Cmd = New OleDbCommandBuilder(dscmdGen)
            dscmdGen.Fill(dsGen, "dtGen")
            'Dim DataTable As New DataTable
            'dscmd.Fill(DataTable)

            'Dim bindingSource As BindingSource


            dgvDatiEsport.DataSource = dsGen
            dgvDatiEsport.DataMember = "dtGen"
            dgvDatiEsport.Refresh()
            'bindingSource = New BindingSource(DataTable)
            'DataGridView1.DataSource = bindingSource 
        End If

        'Dim connectionString As String = ""
        'Dim cnn As OleDbConnection
        'connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatiGen.DbAccess & ";"
        'cnn = New OleDbConnection(connectionString)
        'cnn.Open()
        'Dim Sql As String = "Select * from  DatiGen"  
        'Dim command As OleDbCommand = cnn.CreateCommand()
        'command.CommandText = Sql
        'dscmdGen = New OleDbDataAdapter(Sql, cnn)

        'dsGen = New DataSet()

        'Dim Cmd As OleDbCommandBuilder
        'Cmd = New OleDbCommandBuilder(dscmdGen)
        'dscmdGen.Fill(dsGen, "dtGen")
        ''Dim DataTable As New DataTable
        ''dscmd.Fill(DataTable)

        ''Dim bindingSource As BindingSource


        'dgvDatiGen.DataSource = dsGen
        'dgvDatiGen.DataMember = "dtGen"
        'dgvDatiGen.Refresh()
        ''bindingSource = New BindingSource(DataTable)
        ''DataGridView1.DataSource = bindingSource 



    End Sub

    Private Sub TextBox_LOSTFOCUS(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim mtxt As TextBox = CType(sender, TextBox)
        If mtxt.Text <> "" Then
            mtxt.BackColor = Color.White
        Else
            mtxt.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.Close()
    End Sub


    Private Sub cmdFileOutAna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'With SaveFileDialog1
        '    .Title = "File Esportazione Dipendenti"
        '    .InitialDirectory = Application.StartupPath
        '    .Filter = "txt files (*.txt)|*.txt"
        '    .ShowDialog()
        '    txtFilOutAna.Text = .FileName
        'End With
    End Sub

 

    Private Sub cmdSfogliaPathes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSfogliaPathes.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        Dim CartellaSel As String
        With FolderBrowserDialog1
            .Description = "Radice Path Configurazione esolver"
            '.SelectedPath = Application.StartupPath
            .RootFolder = Environment.SpecialFolder.Desktop
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                CartellaSel = .SelectedPath
                txtpahtconfEs.Text = CartellaSel
            End If
        End With



        'With OpenFileDialog1
        '    .Title = "Radice Path Configurazione esolver"
        '    .FileName = ""
        '    .InitialDirectory = Application.StartupPath
        '    .ShowDialog()
        '    txtpahtconfEs.Text = .FileName
        'End With
    End Sub

    Private Sub cmdSfogliaBatCosti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSfogliaBat.Click
        With OpenFileDialog1
            .Title = "File Batch "
            .FileName = ""
            .InitialDirectory = Application.StartupPath
            .Filter = "File Batch (.bat)|*.bat"
            .ShowDialog()
            txtFileBat.Text = .FileName
        End With
    End Sub

    Private Sub cmdSfogliaBatAna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'With OpenFileDialog1
        '    .Title = "File Batch Anaagrafiche"
        '    .FileName = ""
        '    .InitialDirectory = Application.StartupPath
        '    .Filter = "File Batch (.bat)|*.bat"
        '    .ShowDialog()
        '    txtFileBatAna.Text = .FileName
        'End With
    End Sub

    Private Sub cmdSfogliaAcc_Click(sender As System.Object, e As System.EventArgs) Handles cmdSfogliaAcc.Click
        With OpenFileDialog1
            .Title = "File Access "
            .FileName = ""
            .InitialDirectory = Application.StartupPath
            .Filter = "File access (.mdb)|*.mdb"
            .ShowDialog()
            txtDbAcc.Text = .FileName
            If txtDbAcc.Text <> "" Then
                DatiGen.DbAccess = txtDbAcc.Text
                CaricaConti()
                CaricaDatiGen()
            End If
        End With
    End Sub

    Private Sub txtDbAcc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDbAcc.TextChanged
        If txtDbAcc.Text <> "" Then
            If System.IO.File.Exists(txtDbAcc.Text) Then
                DatiGen.DbAccess = txtDbAcc.Text
                CaricaConti()
                CaricaDatiGen()
            End If
        End If
    End Sub

    Private Sub cmdSfogliafileOr_Click(sender As System.Object, e As System.EventArgs) Handles cmdSfogliafileOr.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        Dim CartellaSel As String
        With FolderBrowserDialog1
            .Description = "Percorso dei file di origine"
            '.SelectedPath = Application.StartupPath
            .RootFolder = Environment.SpecialFolder.Desktop
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                CartellaSel = .SelectedPath
                txtPathFileOr.Text = CartellaSel
            End If
        End With
    End Sub
 


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdSfogliaPathExp.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        Dim CartellaSel As String
        With FolderBrowserDialog1
            .Description = "Radice Path File Esportazioni"
            '.SelectedPath = Application.StartupPath
            .RootFolder = Environment.SpecialFolder.Desktop
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                CartellaSel = .SelectedPath
                txtPathExport.Text = CartellaSel
            End If
        End With
    End Sub
End Class
