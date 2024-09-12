
Imports System.Data.OleDb
Public Class frmRicPRV
    Public IdDocPRV_RIF As Long
    Public RiferimentoPrev As String
    Private Sub cmdCerca_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerca.Click
        If Val(txtCodCli.Text) <> 0 Then
            CaricaPRV(Val(txtCodCli.Text))
        Else
            MsgBox("Indicare un codice cliente", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub CaricaPRV(ByVal CodCli As Long)
        If DatiGen.NomeDbSql <> "" And DatiGen.Server <> "" And DatiGen.Utente <> "" Then

            Dim connectionString As String = ""
            Dim cnn As OleDbConnection
            'connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatiGen.DbAccess & ";"
            connectionString = "Provider=sqloledb; Data Source=" & DatiGen.Server & _
                                "; Initial Catalog=" & DatiGen.NomeDbSql & "; User Id=" & DatiGen.Utente & _
                                "; Password=" & DatiGen.Pwd & ";"
            Try
                cnn = New OleDbConnection(connectionString)
                cnn.Open()

            Catch ex As Exception
                MsgBox("Error connessione Esolver", MsgBoxStyle.Critical)
                Exit Sub
            End Try
            Dim Sql As String = "select   DocElencoGen.IdDocumento , " & _
                " DocElencoGen.DataRegistrazione ,DocElencoGen.PeriodoRifNumeraz ,DocElencoGen.CodSerie, DocElencoGen.NumRegistraz , DocElencoGen.CodCliFor     " & _
                "from DocElencoGen inner join Docunitestata  " & _
                "on DocElencoGen.dbgruppo=Docunitestata.DBGruppo and  " & _
                "DocElencoGen.iddocumento=Docunitestata.iddocumento " & _
                " left join  " & _
                "(select distinct dbgruppo, DocOrigGruppoDoc, docorigiddoc from DocLegami " & _
                "where dbgruppo='" & DatiGen.DbGruppo & "'  " & _
                "and DocOrigGruppoDoc ='OPV'  " & _
                "and docdergruppodoc='ORV') as Legami  " & _
                "on DocElencoGen.dbgruppo=Legami.DBGruppo and  " & _
                "DocElencoGen.GruppoDoc=Legami.DocOrigGruppoDoc and  " & _
                "DocElencoGen.iddocumento=Legami.docorigiddoc " & _
                "where DocElencoGen.dbgruppo='" & DatiGen.DbGruppo & "'  " & _
                "and DocElencoGen.GruppoDoc ='OPV'  " & _
                "and DocElencoGen.OrdDDTSaldato=0  " & _
                "and docorigiddoc is null " & _
                "and DocElencoGen.CodCliFor =" & CodCli

            'da vedere se rimettere filtro su preventivo accettato
            '"and Docunitestata.AccettazionePrev=1  " & _

            Dim dsPrv As DataSet
            Dim dscmdPrv As OleDbDataAdapter

            Dim command As OleDbCommand = cnn.CreateCommand()
            command.CommandText = Sql
            dscmdPrv = New OleDbDataAdapter(Sql, cnn)

            dsPrv = New DataSet()

            Dim Cmd As OleDbCommandBuilder
            Cmd = New OleDbCommandBuilder(dscmdPrv)
            dscmdPrv.Fill(dsPrv, "PRV")

            dgvPRV.DataSource = dsPrv
            dgvPRV.DataMember = "PRV"
            dgvPRV.Refresh()
        End If





    End Sub
 

    Private Sub dgvPRV_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPRV.CellDoubleClick
        Dim mrow As Integer = e.RowIndex 
        Dim IddocPrv As Integer = dgvPRV.Item(0, mrow).Value


        Dim annoprv As Integer = dgvPRV.Item(2, mrow).Value
        Dim serieprv As Integer = dgvPRV.Item(3, mrow).Value
        Dim nrprv As Integer = dgvPRV.Item(4, mrow).Value

        IdDocPRV_RIF = IddocPrv
        RiferimentoPrev = annoprv & "." & serieprv & "." & nrprv
        Me.Close()
    End Sub

    Private Sub cmdAnnulla_Click(sender As System.Object, e As System.EventArgs) Handles cmdAnnulla.Click

        IdDocPRV_RIF = 0
        RiferimentoPrev = ""
        Me.Close()
    End Sub

    Private Sub frmRicPRV_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        IdDocPRV_RIF = 0
        RiferimentoPrev = ""
        Me.CenterToScreen()
    End Sub

    Private Sub cmdRicCodCli_Click(sender As System.Object, e As System.EventArgs) Handles cmdRicCodCli.Click
        RicercaCli(IIf(Val(txtCodCli.Text) <> 0, " Where CodCliFor =" & Val(txtCodCli.Text), ""))
    End Sub

    Private Sub cmdRicRagSoc_Click(sender As System.Object, e As System.EventArgs) Handles cmdRicRagSoc.Click
        RicercaCli(IIf((txtRagSoc.Text) <> "", " Where concat( AnagrGenIndirizzi.ragsoc1 ,AnagrGenIndirizzi.ragsoc2) like '" & Replace(txtRagSoc.Text, "*", "%") & "'", ""))

    End Sub

    Private Sub RicercaCli(ByVal Condi As String)
        Dim mfrmric As New frmRicercaCli
        With mfrmric
            .condizione = Condi
            .ShowDialog()
            If Not .CodCli Is Nothing Then
                txtCodCli.Text = .CodCli
                txtRagSoc.Text = .RagSoc
            End If
        End With
    End Sub

    Private Sub txtCodCli_LostFocus(sender As Object, e As System.EventArgs) Handles txtCodCli.LostFocus
        If Val(txtCodCli.Text) <> 0 Then
            Dim RagSoc As String = ""
            RagSoc = Getdaticli(DatiGen.DbGruppo, Val(txtCodCli.Text))
            ' If RagSoc <> "" Then
            txtRagSoc.Text = RagSoc
            'End If
        End If
    End Sub
    Private Function Getdaticli(ByVal DbGruppo As String, ByVal CodCliFor As Long) As String
        Getdaticli = ""
        Try

            If ConnettiEs() Then
                Dim rs As New ADODB.Recordset
                rs.Open("Select distinct codclifor,concat( AnagrGenIndirizzi.ragsoc1 ,AnagrGenIndirizzi.ragsoc2) as RagSoc  " & _
                       "FROM ClientiFornitori INNER JOIN  " & _
                       "AnagrGenIndirizzi  ON ClientiFornitori.IdAnagGen  = AnagrGenIndirizzi.IdAnagGen " & _
                        "  Where CodCliFor =" & CodCliFor & " and tipoanagrafica=1" & _
                       " and dbgruppo='" & DatiGen.DbGruppo & "' and AnagrGenIndirizzi.NumProgr=0 ", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rs.EOF Then
                    Getdaticli = rs("RagSoc").Value
                End If
                rs.Close()
                rs = Nothing
            End If

        Catch ex As Exception
            MsgBox("Errore Ricerca Cliente " & ex.Message)
        End Try
        DisconnettiEs()
    End Function
     
End Class