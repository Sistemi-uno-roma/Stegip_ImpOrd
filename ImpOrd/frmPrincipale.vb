Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Public Class frmPrincipale
    Private Structure TP_Listini
        ' Dim Prior_DataRif As String
        ' Dim Prior_Tipo As String
        ' Dim Prior_Codice As String
        ' Dim Ord_Tipo As String
        'Dim Ord_Codice As String
        'Dim Rig_DataRif As String
        Dim Rig_Tipo As String
        Dim Rig_Codice As String
        ' Dim List_UM As String
    End Structure

    Private Enum TP_LAVORO_EN
        TP_ANAGR = 1
        TP_OFFERTE = 2
        TP_ACCETTORV = 3
    End Enum

    Private TP_LAVORO As TP_LAVORO_EN

    Public idImportazione As Long = 0

    

    Private Sub cmdEsci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEsci.Click

        '        m_Conn.Close()
        '        m_Conn = Nothing
        End
    End Sub
    Public Function GetDataFromExcel(ByVal FileName As String, _
         ByVal RangeName As String) As System.Data.DataSet
        '        On Error GoTo errore
        '        Dim strConn As String = _
        '            "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        '            "Data Source=" & FileName & ";Extended Properties='Excel 8.0;HDR=No;IMEX=1'"
        '        Dim objConn As New System.Data.OleDb.OleDbConnection(strConn)
        '        objConn.Open()
        '        If Mid(RangeName, Len(RangeName), 1) <> "$" Then RangeName = RangeName & "$"
        '        Dim objCmd As New System.Data.OleDb.OleDbCommand( _
        '            "SELECT * FROM  [" & RangeName & "]", objConn)

        '        Dim objDA As New System.Data.OleDb.OleDbDataAdapter()
        '        objDA.SelectCommand = objCmd
        '        Dim objDS As New System.Data.DataSet()
        '        objDA.FillLoadOption = LoadOption.Upsert
        '        objDA.FillSchema(objDS, SchemaType.Source)
        '        objDA.Fill(objDS)
        '        objConn.Close()
        '        Return objDS
        'errore:
        '        If Err.Number <> 0 Then
        '            MsgBox(Err.Description)
        '            On Error GoTo 0
        '            Return Nothing
        '        End If
    End Function
  

    Private Function EsportaAna(ByRef IndR As Integer) As Boolean
        'Dim msep As String = "#"

        '' Dim FileDes As System.IO.StreamWriter = Nothing
        'EsportaAna = False
        'Try
        '    Dim rs As New ADODB.Recordset
        '    Dim RecOut As String = ""
        '    Dim NrRec As Long = 0
        '    ProgressBar1.Minimum = 0
        '    ProgressBar1.Maximum = 100
        '    Dim mPerc As Double
        '    Cursor = Cursors.WaitCursor
        '    'Dim RigaIn As String
        '    Dim LanciaImpo As Boolean = True
        '    ProgressBar1.Value = 0


        '    'FileDes = New StreamWriter(txtFileEspoAna.Text)


        '    Dim NrRigaAna As Integer = 0
        '    Dim TotAnagEspo As Integer = 0
        '    Dim TotAnagImpo As Integer = 0
        '    Dim TotRec As Integer = 0
        '    Dim NumRec As Integer = 0
        '    AggiornaLbl("Inizio Esportazione Anagrafiche")


        '    FileOpen(1, txtFileEspoAna.Text, OpenMode.Output)

        '    AggiornaLbl("Inizio Esportazione Anagrafiche")
        '    rs.Open("Select * from xs1r_ImpP_Ana where dbgruppo='" & DatiGen.DbGruppo & "' ", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic)
        '    If Not rs.EOF Then
        '        TotRec = GetNrRec("xs1r_ImpP_Ana")
        '        NrRec = TotRec + IndR
        '        rs.MoveFirst()
        '        Do While Not rs.EOF
        '            IndR += 1
        '            NumRec += 1
        '            AggiornaLbl("Esportazione record nr " & NumRec & " di " & TotRec)
        '            'IndP = IndR / 2
        '            RecOut = rs.Fields(0).Value
        '            For i As Integer = 1 To rs.Fields.Count - 2
        '                RecOut = RecOut & msep & rs.Fields(i).Value
        '            Next i
        '            RecOut = RecOut & vbCrLf
        '            Print(1, RecOut)
        '            mPerc = Val((IndR * 100) / NrRec)
        '            If mPerc > ProgressBar1.Maximum Then
        '                mPerc = ProgressBar1.Maximum
        '            End If
        '            ProgressBar1.Value = mPerc
        '            rs.MoveNext()
        '        Loop
        '    End If
        '    rs.Close()

        '    ProgressBar1.Value = 100
        '    FileClose(1)
        '    '  FileDes.Close()
        '    If LanciaImpo Then
        '        If System.IO.File.Exists(txtFileEspoAna.Text) Then

        '            Dim lastimp As Long = GetIdImpCli(DatiGen.DbGruppo)
        '            'Shell(Application.StartupPath & "\Importa_Anagrafiche.bat " & DatiGen.GruppoDocAna & _
        '            '            " " & DatiGen.ModelloAna & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & DatiGen.WSP & " " & DatiGen.Operatore, AppWinStyle.NormalFocus, True)
        '            ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 1)
        '            'Shell(DatiGen.FileBatAna & " " & DatiGen.GruppoDocAna & _
        '            '           " " & DatiGen.ModelloAna & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & DatiGen.WSP & " " & DatiGen.Operatore, AppWinStyle.NormalFocus, True)
        '            Shell(DatiGen.FileBatAna & " " & DatiGen.GruppoDocAna & _
        '                        " " & DatiGen.ModelloAna & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & _
        '                        DatiGen.WSP & " " & DatiGen.Operatore & " " & DatiGen.PathConfES, AppWinStyle.NormalFocus, True)
        '            ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 1)
        '            Dim Newimp As Long = GetIdImpCli(DatiGen.DbGruppo)
        '            If Newimp > lastimp Then
        '                TotAnagImpo = GetTotAnagImpo(Newimp, DatiGen.DbGruppo)
        '                If TotAnagEspo = TotAnagImpo Then
        '                    AggiornaLbl("Esportazione Anagrafiche Terminata!")
        '                    EsportaAna = True
        '                Else
        '                    MsgBox("Non sono state importate tutte le anagrafiche." & vbCrLf & "Controllare log di importazione su Esolver", MsgBoxStyle.Critical, "Importazione Anagrafiche")
        '                    ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 1, "Imp Anagrafiche- Non sono state importate tutte le anagrafiche")
        '                End If
        '            Else
        '                MsgBox("Importazione Anagrafiche non eseguita." & vbCrLf & "Controllare log di importazione su Esolver", MsgBoxStyle.Critical, "Importazione Anagrafiche")
        '                ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 1, "Imp Anagrafiche- Importazione Anagrafiche non creata")
        '            End If
        '        Else
        '            MsgBox("File di esportazione Anagrafiche non trovato!", MsgBoxStyle.Information)
        '            ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0, "Imp Anagrafiche- File di esportazione Anagrafiche non trovato")
        '        End If
        '    Else
        '        ProgressBar1.Value = 0
        '    End If
        'Catch ex As Exception
        '    MsgBox("Errore  " & ex.Message, MsgBoxStyle.Critical, "Esporta")
        '    ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0, "Imp Anagrafiche- Errore  " & ex.Message)
        '    ProgressBar1.Value = 0
        'Finally
        '    FileClose(1)
        '    'If Not FileDes Is Nothing Then FileDes.Close()
        '    Cursor = Cursors.Default
        'End Try

    End Function
    Private Function GetTotAnagImpo(ByVal IdImpo As Long, ByVal Gruppo As String) As Long
        'Dim rs As New ADODB.Recordset
        'rs.Open("Select  count(*) as TotAnag  from  ImpLegamiAnagrCliFor  where idimportazione=" & IdImpo & " and DBGruppo='" & Gruppo & _
        '            "' and tipoanagrafica=3", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        'Application.DoEvents()
        'If Not rs.EOF Then
        '    rs.MoveFirst()
        '    GetTotAnagImpo = NoNull(rs.Fields("TotAnag"))
        'End If
        'rs.Close()
        'rs = Nothing
    End Function
    Private Function GetIdImp(ByVal Gruppo As String, ByVal NomeTab As String) As Long
        Dim rs As New ADODB.Recordset
        rs.Open("Select max(IdImportazione) as IdImp from  " & NomeTab & "  where dbgruppo='" & _
                Gruppo & "'  and firmacreazoperatore='" & DatiGen.Operatore & _
                "' and StatoImportazione=1", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
        Application.DoEvents()
        If Not rs.EOF Then
            rs.MoveFirst()
            GetIdImp = NoNull(rs.Fields("IdImp"))
        End If
        rs.Close()
        rs = Nothing
    End Function

    Private Function GetIdImpCli(ByVal Gruppo As String) As Long
        'Dim rs As New ADODB.Recordset
        'rs.Open("Select max(IdImportazione) as IdImp from  ImportazioniAnagr  where dbgruppo='" & _
        '        Gruppo & "'  and firmacreazoperatore='" & DatiGen.Operatore & _
        '        "' and StatoImportazione=1", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
        'Application.DoEvents()
        'If Not rs.EOF Then
        '    rs.MoveFirst()
        '    GetIdImpCli = NoNull(rs.Fields("IdImp"))
        'End If
        'rs.Close()
        'rs = Nothing
    End Function

    Private Sub AggiornaDatiGenAcc()
        Try
            If m_ConnAcc.State = 0 Then
                ConnettiAcc()

            End If
            If m_ConnAcc.State = 1 Then
                Dim rs As New ADODB.Recordset
                rs.Open("select * from DatiGen where dbgruppo='" & DatiGen.DbGruppo & "'", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rs.EOF Then
                    rs.Update()
                Else
                    rs.AddNew()
                    rs("Dbgruppo").Value = DatiGen.DbGruppo
                End If
                rs("DataRegDoc").Value = dtDataRegDoc.Text
                rs.Update()
                rs.Close()
                rs = Nothing
            End If
        Catch ex As Exception
            LogWrite("errore aggiorna dati gen " & ex.Message & " in " & ex.StackTrace)

        End Try
    End Sub
    Private Sub cmdEsporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEsporta.Click
        Try

            If txtFileOr.Text <> "" And _
                DatiGen.PathExport <> "" And _
                DatiGen.DbGruppo <> "" Then 
                If DatiGen.DbAccess <> "" Then
                    'If DatiGen.Server <> "" And DatiGen.NomeDbSql <> "" And DatiGen.Utente <> "" Then
                    If ConnettiAcc() Then
                        ' DatiGen.DbGruppo = txtGruppo.Text
                        Dim ModelloManca As String = ""
                        ' If ModelliOk(ModelloManca) Then
                        AttivaFrm(False)
                        lblEspo.Visible = True
                        AggiornaLbl("Esportazione")
                        idImportazione = 0
                        ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0)
                        Dim Importa As Boolean = True
                        Dim Tipo As String = ""
                        ' For Each mitem As ListViewItem In lvwFile.Items
                        AggiornaLbl("Esportazione file " & txtFileOr.Text)

                        '  AggiornaDatiGenAcc()

                        Importa = Importa And CaricaFile(txtFileOr.Text)
                        ' Next
                        'If Importa Then
                        '    Esporta()
                        'End If
                        MsgBox("Elaborazioni Terminate", MsgBoxStyle.Information)
                        ' DisconnettiAcc()
                        AttivaFrm(True)
                        ' End
                        'Else
                        ' MsgBox("Attenzione. Non è stato trovato il modello di importazione:" & vbCrLf & ModelloManca & vbCrLf & "Impossibile proseguire!", MsgBoxStyle.Critical)
                        ' ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0, "Importazioni - Non è stato trovato il modello di importazione:" & ModelloManca)
                        '  End If
                    End If
                Else
                    MsgBox("Inserire i dati per le connessioni", MsgBoxStyle.Critical)
                    ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0, "Importazioni - Dati di Connessione Mancanti")
                End If
            Else
                MsgBox("Inserire Tutti i dati Necessari", MsgBoxStyle.Critical)
                ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0, "Importazioni - dati mancanti")
            End If

        Catch ex As Exception
            MsgBox("Errore Elaborazione " & ex.Message & " in " & ex.StackTrace, MsgBoxStyle.Critical, "Elaborazione")
        End Try
    End Sub
    Private Function ModelliOk(ByRef ModelloManca As String) As Boolean
        Dim rs As New ADODB.Recordset
        ModelliOk = True
        'rs.Open("Select * from [ImportazioniAnagr] where dbgruppo='" & DatiGen.DbGruppo & "' and IdImportazione=" & DatiGen.ModelloAna, m_ConnEs)
        'If rs.EOF Then
        '    ModelliOk = False
        '    ModelloManca = "ANAGRAFICHE NR. " & DatiGen.ModelloAna
        'End If
        'rs.Close()
        'If ModelliOk Then
        '    rs.Open("Select * from  ImportazioniDoc  where dbgruppo='" & DatiGen.DbGruppo & "' " & _
        '            " and IdImportazione=" & DatiGen.ModelloContabGen & " and GruppoDoc='" & DatiGen.GruppoDocContabGen & "'", m_ConnEs)
        '    If rs.EOF Then
        '        ModelliOk = False
        '        ModelloManca = "CONTABILITA' NR. " & DatiGen.ModelloContabGen
        '    End If
        '    rs.Close()
        'End If
        'If ModelliOk Then
        '    rs.Open("Select * from  ImportazioniDoc  where dbgruppo='" & DatiGen.DbGruppo & "' " & _
        '            " and IdImportazione=" & DatiGen.ModelloMovInd & " and GruppoDoc='" & DatiGen.GruppoDocMovInd & "'", m_ConnEs)
        '    If rs.EOF Then
        '        ModelliOk = False
        '        ModelloManca = "INDUSTRIALE NR. " & DatiGen.ModelloMovInd
        '    End If
        '    rs.Close()
        'End If
        rs = Nothing
    End Function
    Private Sub frmPrincipale_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        DisconnettiAcc()
        DisconnettiEs()
    End Sub

    Private Sub frmPrincipale_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CenterToScreen()
        Me.Text = Me.Text & " Ver." & Application.ProductVersion
        lblgruppoEs.Text = "GRUPPO SELEZIONATO: " & DatiGen.DbGruppo 
        'txtFilOutArt.Text = DatiGen.FilOutArt
        'txtFilOutDB.Text = DatiGen.FilOutDB
        'txtFilOutORV.Text = DatiGen.FilOutORV
        'txtFilOutORA.Text = DatiGen.FilOutORA

        'txtFilOutArt.Enabled = False
        'txtFilOutDB.Enabled = False
        'txtFilOutORV.Enabled = False
        'txtFilOutORA.Enabled = False

        cmdEsporta.Enabled = False
        lblEspo.Visible = False
         
        'grpAnag.Visible = False
        'If DatiGen.GestPartite = 1 Then
        '    grpAnag.Visible = True
        'Else
        '    grpAnag.Visible = False
        'End If
    End Sub
     
    Private Sub cmdSfogliaXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSfogliaXls.Click
        With OpenFileDialog1
            .Title = "File da importare"
            Dim Inidir As String = Application.StartupPath
            If DatiGen.PathFileOr <> "" Then
                Inidir = DatiGen.PathFileOr
            End If
            .InitialDirectory = Inidir
            '.Filter = "xls files (*.xls)|*.xls" '"csv files (*.csv)|*.csv" '"
            .Filter = "xls files (*.xls*)|*.xls*" '"csv files (*.csv)|*.csv" '"
            .ShowDialog()
            txtFileOr.Text = .FileName
            AbilitaEsportazione()
        End With
    End Sub
    Private Sub AbilitaEsportazione()
        cmdEsporta.Enabled = False
        If txtFileOr.Text <> "" And _
                 DatiGen.PathExport <> "" And _
                 DatiGen.DbGruppo <> "" Then 

             
                cmdEsporta.Enabled = True 
        End If
    End Sub
    Private Sub AttivaFrm(ByVal Attiva As Boolean)
        ImpostazioniToolStripMenuItem.Enabled = Attiva
        cmdEsporta.Enabled = Attiva
        cmdEsci.Enabled = Attiva
        cmdSfogliaXls.Enabled = Attiva
        txtFileOr.Enabled = Attiva
    End Sub
    
    Private Sub AggiornaLbl(ByVal Testo As String)
        lblEspo.Text = Testo
        Me.Refresh()
    End Sub
     
     
    Private Function CaricaFile(ByVal NomeFile As String) As Boolean
        CaricaFile = False
        Cursor = Cursors.WaitCursor
        Dim NrRec As Long = 0
        Dim TotRec As Long = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100

        'If ImportaFiletxt(NomeFile, NrRec, TotRec) Then
        If LeggiExcel(NomeFile) Then
            'If PulisciRecord(NrRec, TotRec) Then
            'If LeggiExcel(NomeFile) Then
            'If chkAllegaFile.Checked Then
            '    AllegaFileEs(CodPart, Tipo, NomeFile, DatiGen.DbGruppo)
            'End If
            CaricaFile = True
            ' Dim Continua As Boolean = False
            'If DatiGen.GestPartite = 1 Then
            '    If EsportaAna(IndR) Then
            '        Continua = True
            '    End If
            'Else
            '    Continua = True
            'End If
            'If Continua Then
            ' EsportaCosti()
            'End If
            'End If
        End If

        'Dim IndR As Integer = 0

        'Dim FileOr As StreamReader = Nothing
        'FileOr = New StreamReader(txtFileOr.Text)
        'Dim temp As String = FileOr.ReadToEnd()
        'Dim Righe() As String = Split(temp, Chr(10))
        'NrRec = UBound(Righe) + 1
        'FileOr.Close()
        'FileOr = New StreamReader(txtFileOr.Text)
        'If ImportaFiletxt(txtFileOr.Text, IndR) Then
        '    Dim Continua As Boolean = False
        '    If DatiGen.GestPartite = 1 Then
        '        If EsportaAna(IndR) Then
        '            Continua = True
        '        End If
        '    Else
        '        Continua = True
        '    End If
        '    If Continua Then
        '        EsportaCosti()
        '    End If
        'End If
        'FileOr.Close()
        'Else
        'MsgBox("Attenzione!Il partitario inserito non esiste in Esolver", MsgBoxStyle.Critical)
        'CaricaFile = False
        'End If
        Cursor = Cursors.Default
    End Function




    Private Function GetCodPart(ByVal PathFile As String, ByRef Tipo As String) As Long

        'Dim xlApp As Excel.Application
        'Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value

        'xlApp = New Excel.ApplicationClass
        'xlWorkBook = xlApp.Workbooks.Open(DatiGen.FileXlsPart)
        'xlWorkSheet = xlWorkBook.Worksheets(1)

        'Dim Nomefile As String = System.IO.Path.GetFileNameWithoutExtension(PathFile)
        'Dim CodPart As Long = 0
        'Dim TotRow As Integer = xlWorkSheet.UsedRange.Rows.Count 'xlWorkSheet.Rows.Count
        'For nrR As Integer = 1 To TotRow
        '    Dim appofile As String = xlWorkSheet.Cells(nrR, 1).value
        '    If UCase(appofile) = UCase(Nomefile) Then
        '        CodPart = xlWorkSheet.Cells(nrR, 2).value
        '        Tipo = xlWorkSheet.Cells(nrR, 3).value
        '        Exit For
        '    End If
        'Next
        'xlWorkBook.Close(False)
        'xlApp.Quit()

        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)
        'GetCodPart = CodPart


    End Function

    Private Function EsisteCodPart(ByVal CodPart As Long, ByVal Tipo As String) As Boolean
        Dim rs As New ADODB.Recordset

        EsisteCodPart = False
        If ConnettiEs() Then
            rs.Open("Select * from clientifornitori where codclifor=" & CodPart & " and Dbgruppo='" & DatiGen.DbGruppo & "' " & _
                    " and TipoAnagrafica=" & IIf(UCase(Tipo) = "C", 1, 2), m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                EsisteCodPart = True
            End If
            rs.Close()
        End If
        DisconnettiEs()
        rs = Nothing

    End Function
    Private Sub Esporta()
        Try
            Dim msep As String = "#@#"
            Dim rs As New ADODB.Recordset
            Dim RecOut As String = ""
            Dim NrRec As Long = 0
            Dim TotRec As Long = 0
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 100
            ProgressBar1.Value = 0
            Dim mPerc As Double
            Dim IndR As Integer = 0
            Dim NumRec As Integer = 0
            Cursor = Cursors.WaitCursor
            AggiornaLbl("Inizio Esportazione")
            LogWrite("Inizio Esportazione")


            Dim ReportImport As String = ""

            Dim Continua As Boolean = True
            If ConnettiAcc() Then
                Continua = True
            End If

            If Continua Then
                Dim nomefile As String = ""
                Dim Tabella As String = ""
                Dim TipoImp As Long = 0
                Dim NrModello As Long = 0
                Dim LanciaBat As Boolean = False
                Dim CreaLegami As Boolean = False
                Dim GruppoDocOr As String = ""
                Dim GruppoDocDer As String = ""
                Dim GestVarianti As Boolean = False
                Dim GestRifDocDaEvadere As Boolean = False

                Dim GestProvvisorio As Boolean = False
                Dim AllegaFile As Boolean = False
                Dim GestCicliLav As Boolean = False
                Dim StrSql As String = ""
                Dim rsOr As New ADODB.Recordset

                Dim nomeField As String = "TipoLavoro_" & TP_LAVORO

                rsOr.Open("Select * from DaEseguire where dbgruppo='" & DatiGen.DbGruppo & "' and attiva=true and " & nomeField & " =true order by priorita", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rsOr.EOF Then
                    Do While Not rsOr.EOF
                        TipoImp = 0
                        NrModello = 0
                        LanciaBat = False
                        Tabella = ""
                        Tabella = rsOr("NomeTabella").Value

                        TipoImp = Val(NoNull(rsOr("TipoImp")))
                        NrModello = Val(NoNull(rsOr("NrModello")))
                        LanciaBat = (NoNull(rsOr("LanciaBat")))
                        CreaLegami = (NoNull(rsOr("CreaLegami")))
                        GruppoDocOr = NoNull(rsOr("GruppoDocOR"))
                        GruppoDocDer = NoNull(rsOr("GruppoDocDer"))
                        GestVarianti = NoNull(rsOr("GestVarianti"))

                        GestRifDocDaEvadere = NoNull(rsOr("GestRifDocDaEvadere")) '= 1

                        GestProvvisorio = NoNull(rsOr("GestProvvisorio"))

                        AllegaFile = NoNull(rsOr("AllegaFile"))

                        GestCicliLav = NoNull(rsOr("GestCicliLav"))

                        nomefile = ""
                        nomefile = rsOr("NomeFileExpo").Value
                        If nomefile = "" Then nomefile = Tabella & ".txt"
                        Dim PatExport As String = DatiGen.PathExport
                        nomefile = PatExport & "\" & nomefile
                        FileOpen(1, nomefile, OpenMode.Output)

                        AggiornaLbl("Inizio Esportazione " & Tabella)

                        StrSql = "SELECT * " & _
                            "FROM " & Tabella & " where dbgruppo='" & DatiGen.DbGruppo & "'"
                        rs.Open(StrSql, m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic)
                        If Not rs.EOF Then
                            TotRec = GetNrRec(Tabella)
                            NrRec = TotRec + IndR
                            rs.MoveFirst()
                            Do While Not rs.EOF
                                IndR += 1
                                NumRec += 1
                                AggiornaLbl("Esportazione " & Tabella & " record nr " & NumRec & " di " & TotRec)
                                'IndP = IndR / 2
                                RecOut = rs.Fields(0).Value
                                Dim nrfield As Integer = rs.Fields.Count - 1

                                For i As Integer = 1 To nrfield
                                    RecOut = RecOut & msep & rs.Fields(i).Value
                                Next i

                                Dim RifPrev As String = ""
                                 

                                RecOut = RecOut & vbCrLf
                                Print(1, RecOut)
                                mPerc = Val((IndR * 100) / NrRec)
                                If mPerc > ProgressBar1.Maximum Then
                                    mPerc = ProgressBar1.Maximum
                                End If
                                ProgressBar1.Value = mPerc
                                rs.MoveNext()
                            Loop
                        End If
                        rs.Close()
                        ProgressBar1.Value = 100
                        FileClose(1)

                        If LanciaBat Then
                            AggiornaLbl("Lancio file batch")
                            LogWrite("Lancio file batch")
                            ''Shell(Application.StartupPath & "\Importa_MovInd.bat " & DatiGen.GruppoDocMovInd & _
                            ''    " " & DatiGen.ModelloMovInd & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & DatiGen.WSP & " " & DatiGen.Operatore, AppWinStyle.NormalFocus, True)
                            '' ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 2)
                            'Shell(DatiGen.FileBat & " " & TipoImp & _
                            '   " " & NrModello & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & DatiGen.WSP & " " & DatiGen.Operatore, AppWinStyle.NormalFocus, True)

                            If ConnettiEs() Then
                                Dim NomeTab As String = ""
                                If TipoImp = 0 Then
                                    NomeTab = "ImportazioniDoc"
                                Else
                                    NomeTab = "ImportazioniAnagr"
                                End If

                                Dim lastimp As Long = GetIdImp(DatiGen.DbGruppo, NomeTab)
                                Dim FileName As String = nomefile
                                If System.IO.File.Exists(FileName) Then
                                    Shell(DatiGen.FileBat & " " & TipoImp & _
                                                      " " & NrModello & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & _
                                                      DatiGen.WSP & " " & DatiGen.Operatore & " " & DatiGen.PathConfES, AppWinStyle.NormalFocus, True)
                                End If
                                Dim Newimp As Long = GetIdImp(DatiGen.DbGruppo, NomeTab)
                                If Newimp > lastimp Then
                                    LogWrite("Importazione :" & Newimp)
                                    If System.IO.File.Exists(Replace(FileName, ".txt", "._xt")) Then
                                        My.Computer.FileSystem.MoveFile(Replace(FileName, ".txt", "._xt"), Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".txt"), True)
                                    ElseIf System.IO.File.Exists(Replace(FileName, ".txt", ".err")) Then
                                        My.Computer.FileSystem.MoveFile(Replace(FileName, ".txt", ".err"), Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".ERR"), True)

                                    ElseIf System.IO.File.Exists(FileName) Then
                                        My.Computer.FileSystem.MoveFile(FileName, Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".txt"), True)
                                    End If


                                    If GestVarianti Then

                                        'LogWrite("Salva Varianti")
                                        'SalvaVariantiEs(DatiGen.DbGruppo)
                                    End If

                                    If CreaLegami Then
                                        LogWrite("Crea Legami")
                                        GestisciLegami(Newimp, DatiGen.DbGruppo, GruppoDocOr, GruppoDocDer)
                                    End If

                                    'gestione provvisori
                                    If GestProvvisorio Then
                                        LogWrite("Gestisci Provvisori")
                                        GestisciProvvisori(Newimp, DatiGen.DbGruppo)
                                    End If

                                    'gestione Allegati
                                    If AllegaFile Then
                                        LogWrite("Gestisci Allegati")
                                        GestisciAllegati(Newimp, DatiGen.DbGruppo)
                                    End If

                                    If GestCicliLav Then
                                        LogWrite("Gestisci Cicli Lavorazione")
                                        GestisciCicliLav(Newimp, DatiGen.DbGruppo)
                                    End If

                                    Dim reptab As String = ""
                                    ControllaEsitoImport(DatiGen.DbGruppo, Newimp, TipoImp, reptab)
                                    ReportImport = ReportImport & " " & Tabella & ":" & vbCrLf & reptab & vbCrLf

                                Else
                                    ReportImport = ReportImport & " " & Tabella & ":" & vbCrLf & "Importazione non effettuata" & vbCrLf & vbCrLf
                                End If
                                'ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 2)
                            Else
                                MsgBox("Errore connessione Esolver")
                                LogWrite("Errore connessione Esolver")
                            End If
                            DisconnettiEs()
                        End If
                        rsOr.MoveNext()
                    Loop
                End If
                rsOr.Close()
                If ReportImport <> "" Then
                    MsgBox(ReportImport, MsgBoxStyle.Information)
                End If
                LogWrite("Riepilogo :" & ReportImport)

                'MsgBox("Fine")
                'FileOpen(1, "expo_art.txt", OpenMode.Output)


                'AggiornaLbl("Lancio file batch")
                'LogWrite("Lancio file batch")
                ''Shell(Application.StartupPath & "\Importa_MovInd.bat " & DatiGen.GruppoDocMovInd & _
                ''    " " & DatiGen.ModelloMovInd & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & DatiGen.WSP & " " & DatiGen.Operatore, AppWinStyle.NormalFocus, True)
                '' ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 2)
                ''Shell(DatiGen.FileBatCosti & " " & DatiGen.GruppoDocContabGen & _
                ''    " " & DatiGen.ModelloContabGen & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & DatiGen.WSP & " " & DatiGen.Operatore, AppWinStyle.NormalFocus, True)
                'If ConnettiEs() Then
                '    Dim lastimp As Long = GetIdImp(DatiGen.DbGruppo)
                '    Dim FileName As String = txtFileORV.Text
                '    If System.IO.File.Exists(FileName) Then
                '        Shell(DatiGen.FileBatCosti & " " & DatiGen.GruppoDocContabGen & _
                '                          " " & DatiGen.ModelloContabGen & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & _
                '                          DatiGen.WSP & " " & DatiGen.Operatore & " " & DatiGen.PathConfES, AppWinStyle.NormalFocus, True)
                '    End If
                '    Dim Newimp As Long = GetIdImp(DatiGen.DbGruppo)
                '    If Newimp > lastimp Then
                '        LogWrite("Importazione :" & Newimp)
                '        If System.IO.File.Exists(Replace(FileName, ".txt", "._xt")) Then
                '            My.Computer.FileSystem.MoveFile(Replace(FileName, ".txt", "._xt"), Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".txt"), True)
                '        ElseIf System.IO.File.Exists(Replace(FileName, ".txt", ".err")) Then
                '            My.Computer.FileSystem.MoveFile(Replace(FileName, ".txt", ".err"), Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".ERR"), True)

                '        ElseIf System.IO.File.Exists(FileName) Then
                '            My.Computer.FileSystem.MoveFile(FileName, Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".txt"), True)
                '        End If
                '        UpdDocEsolver(Newimp, DatiGen.DbGruppo)
                '    End If
                '    'ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 2)
                'Else
                '    LogWrite("Errore connessione Esolver")
                'End If
                'DisconnettiEs()
            End If

            AggiornaLbl("Esportazione Terminata")
            Cursor = Cursors.Default
            rs = Nothing

        Catch ex As Exception
            MsgBox("Errore  " & ex.Message, MsgBoxStyle.Critical, "Esporta  ")
            LogWrite("Esporta   - Errore  " & ex.Message & " in " & ex.StackTrace)
            ' ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0, "Imp Fatture- Errore  " & ex.Message)
            ProgressBar1.Value = 0
        Finally
            FileClose(1)
            'FileClose(2)
            Cursor = Cursors.Default
        End Try
        DisconnettiAcc()
    End Sub



    Private Sub GestisciCicliLav(ByVal IdImpo As Long, ByVal DbGruppo As String)
        Dim rs As New ADODB.Recordset
        Dim rs2 As New ADODB.Recordset
        Try

            Dim i As Long

            Dim NumFaseSMT As Long = 0
            Dim NumFaseTHT As Long = 0
            Dim NumFaseAltra As Long = 0
            Dim NumFaseMax As Long = 0

            'If DatiGen.CodCicloTemplate = "" Then
            '    DatiGen.CodCicloTemplate = "Z_TEMPLATE_CICLO"
            'End If

            'rs.Open("Select dbgruppo, CodCiclo, max(case when CodLavorazione ='SMT' then numfase else 0 end) as numfaseSMT, " & _
            '    "max(case when CodLavorazione ='THT' then numfase else 0 end) as numfaseTHT, " & _
            '    "max(case when  CodLavorazione<>'SMT' or  CodLavorazione<>'THT' then  numfase  else 0 end) as NumFaseAltra " & _
            '    "From CicloLavRigheFasi where CodCiclo ='" & DatiGen.CodCicloTemplate & "'  and DBGruppo='" & DbGruppo & "' " & _
            '    "group by dbgruppo,CodCiclo    ", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
            'If Not rs.EOF Then
            '    NumFaseSMT = rs("numfaseSMT").Value
            '    NumFaseTHT = rs("numfaseTHT").Value
            '    NumFaseAltra = rs("NumFaseAltra").Value
            'Else
            '    MsgBox("ATTENZIONE!" & vbCrLf & "CICLO TEMPLATE NON TROVATO" & vbCrLf & "IL SALVATAGGIO DEI CICLI DI LAVORAZIONE NON VERRA ESEGUITO", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If
            'rs.Close()
            'rs = Nothing

            rs = New ADODB.Recordset
            rs.Open("Select dbgruppo,CodDb ,VarianteArt,DataDecorrenza,TipoConfDb ,AltConfDb  from ImpLegamiDbase  where IdImportazione = " & IdImpo & " and DBGruppo='" & DbGruppo & _
                        "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
            If Not rs.EOF Then 

                Do While Not rs.EOF
                    i = i + 1

                    Dim Coddb As String = ""
                    Dim VarDb As String = ""
                    Dim DataDec As String = ""
                    Dim TipoConfDb As Long = 0
                    Dim AltConfDb As String = ""

                    Coddb = rs.Fields("CodDb").Value
                    VarDb = rs.Fields("VarianteArt").Value
                    DataDec = rs.Fields("DataDecorrenza").Value
                    TipoConfDb = rs.Fields("TipoConfDb").Value
                    AltConfDb = rs.Fields("AltConfDb").Value
                    LogWrite("DISTINTA IMPORTATA CODICE " & Coddb)


                    NumFaseSMT = 0
                    NumFaseTHT = 0
                    NumFaseAltra = 0
                    NumFaseMax = 0

                    LogWrite("Leggo Ciclo " & Coddb)

                    Dim rs1 As New ADODB.Recordset

                    '07/06/2023 - parametrizzato i codici per SMT e THT so deve prendere la fase generica (la max) basta mettere codici inesisteniti

                    ' rs1.Open("Select dbgruppo, CodCiclo,max(numfase) as MaxFase, max(case when CodLavorazione ='SMT' then numfase else 0 end) as numfaseSMT, " & _
                    '"max(case when CodLavorazione ='THT' then numfase else 0 end) as numfaseTHT, " & _
                    '"max(case when  CodLavorazione<>'SMT' and  CodLavorazione<>'THT' then  numfase  else 0 end) as NumFaseAltra " & _
                    '"From CicloLavRigheFasi where CodCiclo ='" & Coddb & "'  and DBGruppo='" & DbGruppo & "' " & _
                    '"group by dbgruppo,CodCiclo    ", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)

                    rs1.Open("Select dbgruppo, CodCiclo,max(numfase) as MaxFase, max(case when CodLavorazione ='" & DatiGen.CodSMT & "' then numfase else 0 end) as numfaseSMT, " & _
                     "max(case when CodLavorazione ='" & DatiGen.CodTHT & "' then numfase else 0 end) as numfaseTHT, " & _
                     "max(case when  CodLavorazione<>'" & DatiGen.CodSMT & "' and  CodLavorazione<>'" & DatiGen.CodTHT & "' then  numfase  else 0 end) as NumFaseAltra " & _
                     "From CicloLavRigheFasi where CodCiclo ='" & Coddb & "'  and DBGruppo='" & DbGruppo & "' " & _
                     "group by dbgruppo,CodCiclo    ", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
                    If Not rs1.EOF Then
                        NumFaseSMT = rs1("numfaseSMT").Value
                        NumFaseTHT = rs1("numfaseTHT").Value
                        NumFaseAltra = rs1("NumFaseAltra").Value
                        NumFaseMax = rs1("MaxFase").Value
                    Else

                        LogWrite("CICLO CODICE " & Coddb & " NON TROVATO")
                        MsgBox("ATTENZIONE!" & vbCrLf & "CICLO CODICE " & Coddb & " NON TROVATO" & vbCrLf & "IL SALVATAGGIO DEI CICLI DI LAVORAZIONE NON VERRA ESEGUITO", MsgBoxStyle.Critical)

                        rs1.Close()
                        rs1 = Nothing

                        rs.Close()
                        rs = Nothing

                        Exit Sub
                    End If
                    rs1.Close()
                    rs1 = Nothing

                    LogWrite("CICLO " & Coddb & "-- FASE SMT:" & NumFaseSMT & " FASE THT:" & NumFaseTHT & " FASE ALTRO:" & NumFaseAltra)


                    rs2 = New ADODB.Recordset
                    'rs2.Open("select artanagrafica.codfamiglia,DBaseRighe.* " & _
                    '         " from DBaseRighe inner join ArtAnagrafica on  " & _
                    '         "  DBaseRighe.DBGruppo = ArtAnagrafica.DBGruppo And " & _
                    '         " DBaseRighe.CodArtComponente = ArtAnagrafica.CodArt " & _
                    '         " where DBaseRighe.dbgruppo='" & DbGruppo & "' and  " & _
                    '         " CodDb ='" & Coddb & "' and VarianteArt ='" & VarDb & "' and  " & _
                    '         " DataDecorrenza='" & DataDec & "' and " & _
                    '         " and TipoConfDb =" & tipoConfDb & " and AltConfDb ='" & altconfdb & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    rs2.Open("select DBaseRighe.* " & _
                             " from DBaseRighe " & _
                             " where DBaseRighe.dbgruppo='" & DbGruppo & "' and  " & _
                             " CodDb ='" & Coddb & "' and VarianteArt ='" & VarDb & "' and  " & _
                             " DataDecorrenza='" & DataDec & "' and " & _
                             " TipoConfDb =" & TipoConfDb & " and AltConfDb ='" & AltConfDb & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    If Not rs2.EOF Then
                        Do While Not rs2.EOF 
                            Dim CodArtCom As String = ""
                            CodArtCom = rs2("CodArtComponente").Value
                            Dim CodFam As String = ""
                            CodFam = UCase(GetCodFamiglia(DbGruppo, CodArtCom))
                            ' CodFam = UCase(rs2("codfamiglia").Value)
                            Dim NumFase As Long = 0
                            Select Case CodFam
                                Case UCase(DatiGen.CodSMT) ' "SMT"
                                    NumFase = NumFaseSMT
                                Case UCase(DatiGen.CodTHT) '"THT"
                                    NumFase = NumFaseTHT
                                Case Else
                                    NumFase = NumFaseAltra
                            End Select

                            LogWrite("Aggiorno FASE COMPONENTE: " & CodArtCom & " FAMIGLIA:" & CodFam & " FASE : " & NumFase)

                            '23/05 tolto fase max per famiglia e prendere sempre l'ultima fase (renato)
                            'NumFase = NumFaseMax

                            LogWrite("Aggiorno FASE COMPONENTE: " & CodArtCom & " ULTIMA FASE :" & NumFase)
                            rs2.Update()
                            rs2("numfase").Value = NumFase
                            rs2.Update()
                            rs2.MoveNext()
                        Loop
                    End If
                    rs2.Close()

                    Application.DoEvents()
                    rs.MoveNext()
                    Application.DoEvents()
                Loop

            End If
            rs.Close()

        Catch ex As Exception
            MsgBox("Errore  " & ex.Message, MsgBoxStyle.Critical, "GESTIONE  CICLI LAVORAZIONE  ")
            LogWrite("GESTIONE CICLI LAVORAZIONE   - Errore  " & ex.Message & " in " & ex.StackTrace)
        End Try
        rs = Nothing
        rs2 = Nothing
    End Sub

    Private Function GetCodFamiglia(ByVal DbGruppo As String, ByVal CodArtComponente As String) As String
        GetCodFamiglia = ""
        Try
            Dim rs As New ADODB.Recordset

            Dim strsql As String = "select artanagrafica.codfamiglia from ArtAnagrafica where  ArtAnagrafica.DBGruppo ='" & DbGruppo & "' and " & _
                "ArtAnagrafica.CodArt ='" & CodArtComponente & "'"

            rs.Open(strsql, m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                GetCodFamiglia = rs("codfamiglia").Value
            End If
            rs.Close()
            rs = Nothing

        Catch ex As Exception

            MsgBox("Errore Famiglia " & ex.Message, MsgBoxStyle.Critical, "GESTIONE  CICLI LAVORAZIONE  ")
            LogWrite("GET Famiglia  - Errore  " & ex.Message & " in " & ex.StackTrace)
        End Try
    End Function

    Private Sub ControllaEsitoImport(ByVal DbGruppo As String, ByVal IdImportazione As Long, ByVal Tipoimp As Long, ByRef ReportSincro As String) ', ByRef FileLogImport As String)
        Try
            Dim rs2 As New ADODB.Recordset
            Dim NumeroLetti As Long = 0
            Dim NoImport As Long = 0
            Dim Esito As Integer = 0

            'Tipoimp = 0 -> Doc  -> Categ=2 
            'Tipoimp = 1 -> ANAG -> Categ=1 


            rs2.Open("select * from ImpLogEsecuzioni where dbgruppo='" & DbGruppo & "' and idimportazione=" & IdImportazione & " " & _
                     "and CategImportazione=" & IIf(Tipoimp = 1, 1, 2), m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs2.EOF Then
                NumeroLetti = Val(NoNull(rs2("EntitaLette")))
                NoImport = Val(NoNull(rs2("EntitaNonImportate")))
                Esito = Val(NoNull(rs2("Esito")))
            End If
            If NumeroLetti > 0 Then
                ReportSincro = ReportSincro & " Documenti Letti : " & NumeroLetti & " Documenti non importati: " & NoImport & vbCrLf
                If NoImport <> 0 Then
                    ReportSincro = ReportSincro & " Controllare il log di importazione nr." & IdImportazione & " " & vbCrLf
                End If
            Else
                ReportSincro = ReportSincro & " NESSUNO DOCUMENTO DA IMPORTARE " & vbCrLf
            End If

            rs2.Close()
            rs2 = Nothing
        Catch ex As Exception
            MsgBox("Controllo esito import Errore -" & ex.Message & " - " & ex.StackTrace)
        End Try
    End Sub

    Private Sub SalvaVariantiEs(ByVal dbGruppo As String)
        Try
            If m_ConnAcc.State = 0 Then
                ConnettiAcc()
            End If
            If m_ConnEs.State = 0 Then
                ConnettiEs()
            End If
            If m_ConnAcc.State = 1 And m_ConnEs.State = 1 Then
                Dim rs As New ADODB.Recordset
                rs.Open("Select * from Expo_ArtVarianti order by codart", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rs.EOF Then
                    Do While Not rs.EOF
                        Dim CodArt As String = ""
                        Dim VarArt As String = ""
                        CodArt = rs("Codart").Value
                        VarArt = rs("VarArt").Value
                        Dim rsins As New ADODB.Recordset

                        LogWrite("Salva Varianti Codart " & CodArt & ";" & VarArt)
                        rsins.Open("Select * from ArtConfigVariante where CodArt='" & CodArt & "' and VarianteArt='" & VarArt & "' and Dbgruppo='" & dbGruppo & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        If rsins.EOF Then
                            rsins.AddNew()
                            rsins("dbGruppo").Value = dbGruppo
                            rsins("CodArt").Value = CodArt
                            rsins("VarianteArt").Value = VarArt
                            rsins("Descrizione").Value = VarArt
                            rsins("CostoStandard").Value = 0
                            rsins("DataUltAggCostoStand").Value = "1800-01-01"
                            rsins("DesCostoStandard").Value = ""
                            rsins("DataInizioValidita").Value = "1800-01-01"
                            rsins("DataFineValidita").Value = "1800-01-01"
                            rsins("DesEstesa").Value = ""
                            rsins.Update()
                        End If
                        rsins.Close()
                        rsins = Nothing

                        rs.MoveNext()
                    Loop
                End If
                rs.Close()
                rs = Nothing
            End If

        Catch ex As Exception
            LogWrite("Errore Aggiorna Varianti Esolver " & ex.Message & " in " & ex.StackTrace)
        End Try
    End Sub

    Private Sub GestisciLegami(ByVal IdImpo As Long, ByVal DbGruppo As String, ByVal GruppoDocOr As String, ByVal GruppoDocDer As String)
        Dim rs As New ADODB.Recordset
        Dim rs2 As New ADODB.Recordset
        Try

            Dim i As Long
            Dim Iddoc As Long
            Dim AggiornatoDas As Boolean
            Dim NumEsolver As String = ""
            Dim IdWeb As Long = 0
            Dim TimeOutDas As Long = 0
            Dim MaxDas As Long = 0
            Dim CodCli As Long = 0
            Dim TempoDiff As Double
            Dim TempoIni As String
            Dim TempoPre As String
            Dim DateReg As String = "01/01/18000"
            Dim TipoDoc As Long = 0
            Dim MaxTempoTrasc As Long = 10 ' 10000 'minuti trascorsi  
            TempoDiff = 0

            MaxDas = 50000
            rs.Open("Select Iddocumento from ImpDocLegami where idimportazione=" & IdImpo & " and DBGruppo='" & DbGruppo & _
                        "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
            If Not rs.EOF Then
                Do While Not rs.EOF
                    AggiornatoDas = False
                    TimeOutDas = 0
                    i = i + 1
                    Iddoc = rs.Fields("IdDocumento").Value
                    TempoIni = Date.Now ' TimeOfDay
                    Do While Not AggiornatoDas And TempoDiff <= MaxTempoTrasc 'NrTenta <= MaxTenta
                        TempoPre = Date.Now ' TimeOfDay
                        TempoDiff = DateDiff("n", (TempoIni), (TempoPre))
                        rs2 = New ADODB.Recordset
                        rs2.Open("Select StatoDocumento,IdDocumento, PeriodoRifNumeraz, CodSerie, NumRegistraz, " &
                                "Riferimento,codclifor,DataRegistrazione,StatoGestionale,CodTipoDoc, " &
                                " DocProvvResoDisp, StatoAutorizzazione " &
                                "FROM DocElencoGen where dbgruppo='" & DbGruppo & "' and " &
                                "Iddocumento=" & Iddoc & " and " &
                                "GruppoDoc='" & GruppoDocOr & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        If Not rs2.EOF Then
                            AggiornatoDas = rs2.Fields("StatoDocumento").Value = 0

                            NumEsolver = (rs2.Fields("NumRegistraz").Value)
                            CodCli = rs2.Fields("CodCliFor").Value
                            DateReg = rs2.Fields("DataRegistrazione").Value
                            TipoDoc = rs2.Fields("CodTipoDoc").Value
                        End If
                        rs2.Close()
                        rs2 = Nothing
                        Application.DoEvents()
                    Loop


                    LogWrite("IDDOC IMPORTATO " & Iddoc)
                    If AggiornatoDas Then

                        LogWrite("Salva Legami")
                        Dim rsor As New ADODB.Recordset
                        Dim NomeTabellaOr As String = "DocUniRigheOrdCli"
                        Select Case UCase(GruppoDocOr)
                            Case "ORV"
                                NomeTabellaOr = "DocUniRigheOrdCli"
                            Case "ORA"
                                NomeTabellaOr = "DocUniRigheOrdFor"

                        End Select
                        Dim NomeTabellaDer As String = "DocUniRigheOrdFor"
                        Select Case UCase(GruppoDocDer)
                            Case "ORV"
                                NomeTabellaDer = "DocUniRigheOrdCli"
                            Case "ORA"
                                NomeTabellaDer = "DocUniRigheOrdFor"

                        End Select
                        rsor = New ADODB.Recordset
                        'rsor.Open("Select dbgruppo, iddocumento, idrigadoc,riferimentocommessa,codart from " & NomeTabellaOr & " where iddocumento=" & Iddoc & " and dbgruppo='" & DbGruppo & "' order by idrigadoc", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        '21/06/2022 - Raggruppare righe doc per commessa come richiesto da Renato
                        rsor.Open("Select dbgruppo, iddocumento, min(idrigadoc) as idrigadoc ,riferimentocommessa from " & NomeTabellaOr & _
                                  " where iddocumento=" & Iddoc & " and dbgruppo='" & DbGruppo & "' " & _
                                  " Group by dbgruppo, iddocumento,  riferimentocommessa  order by idrigadoc", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        If Not rsor.EOF Then
                            Do While Not rsor.EOF

                                Dim IdRigaDocOr As Long = 0
                                IdRigaDocOr = rsor("IdRigaDoc").Value
                                Dim Commessa As String = ""
                                Commessa = rsor("riferimentocommessa").Value
                                'Dim CodArt As String = ""
                                'CodArt = rsor("CodArt").Value


                                ' LogWrite("ORIGINE : IDDOC " & Iddoc & " IDR " & IdRigaDocOr & " CODART " & CodArt & " COMMESSA " & Commessa)

                                LogWrite("ORIGINE : IDDOC " & Iddoc & " IDR " & IdRigaDocOr & " COMMESSA " & Commessa)

                                If Commessa <> "" Then
                                    Dim rsder As New ADODB.Recordset
                                    rsder.Open("Select dbgruppo, iddocumento, idrigadoc,riferimentocommessa,codart from " & NomeTabellaDer & _
                                               " where riferimentocommessa='" & Commessa & "' and dbgruppo='" & DbGruppo & "' order by idrigadoc", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                                    If Not rsder.EOF Then
                                        Do While Not rsder.EOF
                                            Dim IdDocDer As Long = 0
                                            IdDocDer = rsder("iddocumento").Value
                                            Dim IdRigaDocDer As Long = 0
                                            IdRigaDocDer = rsder("IdRigaDoc").Value



                                            LogWrite("DERIVATO : IDDOC " & IdDocDer & " IDR " & IdRigaDocDer)

                                            Dim rsIns As New ADODB.Recordset

                                            rsIns.Open("Select * from DocLegami where Dbgruppo='" & DbGruppo & "'  AND  DocDerGruppoDoc = '" & GruppoDocDer & "' " & _
                                                  " and DocOrigIdDoc=" & Iddoc & " and " & _
                                                " DocOrigIdRiga=" & IdRigaDocOr & " and " & _
                                                " DocDerIdDoc=" & IdDocDer & " and " & _
                                                " DocDerIdRiga=" & IdRigaDocDer & " and " & _
                                                " DocOrigTipoRelazione=22", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                                            If rsIns.EOF Then
                                                rsIns.AddNew()
                                                rsIns("DBGruppo").Value = DbGruppo
                                                rsIns("DocOrigIdDoc").Value = Iddoc
                                                rsIns("DocOrigIdRiga").Value = IdRigaDocOr
                                                rsIns("DocOrigNumProgr").Value = 0
                                                rsIns("DocDerIdDoc").Value = IdDocDer
                                                rsIns("DocDerIdRiga").Value = IdRigaDocDer
                                                rsIns("DocDerNumProgr").Value = 0
                                                rsIns("IdDocumento").Value = IdDocDer
                                                rsIns("IdRigaDoc").Value = IdRigaDocDer
                                                rsIns("NumProgr").Value = 0
                                                rsIns("DocOrigTipoRelazione").Value = 22
                                                rsIns("DocOrigGruppoDoc").Value = GruppoDocOr
                                                rsIns("DocDerGruppoDoc").Value = GruppoDocDer
                                                rsIns.Update()


                                                LogWrite("RIGA LEGAME SALVATA")

                                            End If
                                            rsIns.Close()

                                            rsder.MoveNext()
                                        Loop
                                    Else
                                        LogWrite("DOCUMENTO DERIVATO NON TROVATO")
                                    End If
                                    rsder.Close()
                                    rsder = Nothing
                                Else
                                    LogWrite("COMMESSA NON PRESENTE")
                                End If
                                rsor.MoveNext()
                            Loop

                        End If
                        rsor.Close()
                        rsor = Nothing
                        'rsIns.AddNew()
                        'rsIns("DBGruppo").Value = rs("DBGruppo").Value
                        'rsIns("DocOrigIdDoc").Value = rs("DocOrigIdDoc").Value
                        'rsIns("DocOrigIdRiga").Value = rs("DocOrigIdRiga").Value
                        'rsIns("DocOrigNumProgr").Value = rs("DocOrigNumProgr").Value
                        'rsIns("DocDerIdDoc").Value = rs("DocDerIdDoc").Value
                        'rsIns("DocDerIdRiga").Value = IdRigaDef ' rs("DocDerIdRiga").Value
                        'rsIns("DocDerNumProgr").Value = rs("DocDerNumProgr").Value
                        'rsIns("IdDocumento").Value = rs("IdDocumento").Value
                        'rsIns("IdRigaDoc").Value = IdRigaDef ' rs("IdRigaDoc").Value
                        'rsIns("NumProgr").Value = rs("NumProgr").Value
                        'rsIns("DocOrigTipoRelazione").Value = rs("DocOrigTipoRelazione").Value
                        'rsIns("DocOrigGruppoDoc").Value = rs("DocOrigGruppoDoc").Value
                        'rsIns("DocDerGruppoDoc").Value = rs("DocDerGruppoDoc").Value
                        'rsIns.Update()



                        Application.DoEvents()
                    Else 
                        LogWrite("DAS NON AGGIORNATO IdDoc: " & Iddoc)
                    End If
                    Application.DoEvents()
                    rs.MoveNext()
                    Application.DoEvents()
                Loop

            End If
            rs.Close()


        Catch ex As Exception
            MsgBox("Errore  " & ex.Message, MsgBoxStyle.Critical, "CREA LEGAMI  ")
            LogWrite("CREA LEGAMI   - Errore  " & ex.Message & " in " & ex.StackTrace)
        End Try
        rs = Nothing
        rs2 = Nothing
    End Sub


    Private Sub GestisciProvvisori(ByVal IdImpo As Long, ByVal DbGruppo As String)
        Dim rs As New ADODB.Recordset
        Dim rs2 As New ADODB.Recordset
        Try

            Dim i As Long
            Dim Iddoc As Long
            Dim AggiornatoDas As Boolean
            Dim NumEsolver As String = ""
            Dim IdWeb As Long = 0
            Dim TimeOutDas As Long = 0
            Dim MaxDas As Long = 0
            Dim CodCli As Long = 0
            Dim TempoDiff As Double
            Dim TempoIni As String
            Dim TempoPre As String
            Dim DateReg As String = "01/01/18000"
            Dim TipoDoc As Long = 0
            Dim MaxTempoTrasc As Long = 10 ' 10000 'minuti trascorsi  
            TempoDiff = 0

            MaxDas = 50000
            rs.Open("Select Iddocumento from ImpDocLegami where idimportazione=" & IdImpo & " and DBGruppo='" & DbGruppo & _
                        "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
            If Not rs.EOF Then
                Do While Not rs.EOF
                    AggiornatoDas = False
                    TimeOutDas = 0
                    i = i + 1
                    Iddoc = rs.Fields("IdDocumento").Value
                    LogWrite("DOCUMENTO IMPORTATO ID " & Iddoc)
                    TempoIni = Date.Now ' TimeOfDay
                    Do While Not AggiornatoDas And TempoDiff <= MaxTempoTrasc 'NrTenta <= MaxTenta
                        TempoPre = Date.Now ' TimeOfDay
                        TempoDiff = DateDiff("n", (TempoIni), (TempoPre))
                        rs2 = New ADODB.Recordset
                        rs2.Open("Select StatoDocumento,IdDocumento, PeriodoRifNumeraz, CodSerie, NumRegistraz, " &
                                "Riferimento,codclifor,DataRegistrazione,StatoGestionale,CodTipoDoc, " &
                                " DocProvvResoDisp, StatoAutorizzazione " &
                                "FROM DocElencoGen where dbgruppo='" & DbGruppo & "' and " &
                                "Iddocumento=" & Iddoc & "  ", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        If Not rs2.EOF Then
                            AggiornatoDas = rs2.Fields("StatoDocumento").Value = 0

                            NumEsolver = (rs2.Fields("NumRegistraz").Value)
                            CodCli = rs2.Fields("CodCliFor").Value
                            DateReg = rs2.Fields("DataRegistrazione").Value
                            TipoDoc = rs2.Fields("CodTipoDoc").Value

                            If AggiornatoDas Then
                                LogWrite("Salva Provvisorio")
                                rs2.Update()
                                rs2.Fields("StatoGestionale").Value = 1
                                rs2.Update()
                            End If
                        End If
                        rs2.Close()
                        rs2 = Nothing
                        Application.DoEvents()
                    Loop 
                     
                    If Not AggiornatoDas Then
                        LogWrite("DAS NON AGGIORNATO IdDoc: " & Iddoc)
                    End If
                    Application.DoEvents()
                    rs.MoveNext()
                    Application.DoEvents()
                Loop

            End If
            rs.Close()

        Catch ex As Exception
            MsgBox("Errore  " & ex.Message, MsgBoxStyle.Critical, "GESTIONE PROVVISORI")
            LogWrite("GESTIONE PROVVISORI   - Errore  " & ex.Message & " in " & ex.StackTrace)
        End Try
        rs = Nothing
        rs2 = Nothing
    End Sub


    Private Sub GestisciAllegati(ByVal IdImpo As Long, ByVal DbGruppo As String)
        Dim rs As New ADODB.Recordset
        Dim rs2 As New ADODB.Recordset
        Try

            Dim i As Long
            Dim Iddoc As Long
            Dim AggiornatoDas As Boolean
            Dim NumEsolver As String = ""
            Dim IdWeb As Long = 0
            Dim TimeOutDas As Long = 0
            Dim MaxDas As Long = 0
            Dim CodCli As Long = 0
            Dim TempoDiff As Double
            Dim TempoIni As String
            Dim TempoPre As String
            Dim DateReg As String = "01/01/18000"
            Dim TipoDoc As Long = 0
            Dim MaxTempoTrasc As Long = 10 ' 10000 'minuti trascorsi  
            TempoDiff = 0

            MaxDas = 50000
            rs.Open("Select Iddocumento from ImpDocLegami where idimportazione=" & IdImpo & " and DBGruppo='" & DbGruppo & _
                        "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
            If Not rs.EOF Then
                Do While Not rs.EOF
                    AggiornatoDas = False
                    TimeOutDas = 0
                    i = i + 1
                    Iddoc = rs.Fields("IdDocumento").Value
                    LogWrite("DOCUMENTO IMPORTATO ID " & Iddoc)
                    TempoIni = Date.Now ' TimeOfDay
                    Do While Not AggiornatoDas And TempoDiff <= MaxTempoTrasc 'NrTenta <= MaxTenta
                        TempoPre = Date.Now ' TimeOfDay
                        TempoDiff = DateDiff("n", (TempoIni), (TempoPre))
                        rs2 = New ADODB.Recordset
                        rs2.Open("Select StatoDocumento,IdDocumento, PeriodoRifNumeraz, CodSerie, NumRegistraz, " &
                                "Riferimento,codclifor,DataRegistrazione,StatoGestionale,CodTipoDoc, " &
                                " DocProvvResoDisp, StatoAutorizzazione " &
                                "FROM DocElencoGen where dbgruppo='" & DbGruppo & "' and " &
                                "Iddocumento=" & Iddoc & "  ", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        If Not rs2.EOF Then
                            AggiornatoDas = rs2.Fields("StatoDocumento").Value = 0

                            NumEsolver = (rs2.Fields("NumRegistraz").Value)
                            CodCli = rs2.Fields("CodCliFor").Value
                            DateReg = rs2.Fields("DataRegistrazione").Value
                            TipoDoc = rs2.Fields("CodTipoDoc").Value  
                        End If
                        rs2.Close()
                        rs2 = Nothing
                        Application.DoEvents()
                    Loop

                    If AggiornatoDas Then
                        Dim FileAtt As String = txtFileOr.Text
                        LogWrite("ALLEGA FILE " & FileAtt & " ")
                        If System.IO.File.Exists(FileAtt) Then
                            AllegaFileEs_Doc(Iddoc, FileAtt, DbGruppo)
                        Else
                            LogWrite("ALLEGA FILE " & FileAtt & " - FILE NON TROVATO")
                        End If


                    Else
                        LogWrite("DAS NON AGGIORNATO IdDoc: " & Iddoc)
                    End If
                    Application.DoEvents()
                    rs.MoveNext()
                    Application.DoEvents()
                Loop

            End If
            rs.Close()

        Catch ex As Exception
            MsgBox("Errore  " & ex.Message, MsgBoxStyle.Critical, "GESTIONE PROVVISORI")
            LogWrite("GESTIONE PROVVISORI   - Errore  " & ex.Message & " in " & ex.StackTrace)
        End Try
        rs = Nothing
        rs2 = Nothing
    End Sub
    Private Sub Esporta_old()
        'Try
        '    Dim msep As String = ";"
        '    Dim rs As New ADODB.Recordset
        '    Dim RecOut As String = ""
        '    Dim NrRec As Long = 0
        '    Dim TotRec As Long = 0
        '    ProgressBar1.Minimum = 0
        '    ProgressBar1.Maximum = 100
        '    ProgressBar1.Value = 0
        '    Dim mPerc As Double
        '    Dim IndR As Integer = 0
        '    Dim NumRec As Integer = 0
        '    Cursor = Cursors.WaitCursor
        '    AggiornaLbl("Inizio Esportazione")
        '    LogWrite("Inizio Esportazione")


        '    Dim Continua As Boolean = True
        '    'controllo se esistono dipendenti da importare con più iban. 
        '    'se esistono record non faccio l'importazione! 
        '    'AggiornaLbl("Controllo se esistono dipendenti da importare con più iban")
        '    'rs.Open("select * from Cntrl_IbanNonValidi", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        '    'If Not rs.EOF Then
        '    '    Continua = False
        '    'End If
        '    'rs.Close()

        '    'AggiornaLbl("Controllo se esistono dipendenti senza commesse") 
        '    'rs.Open("select * from Cntrl_IbanNonValidi", m_ConnCosti, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic) 
        '    'If Not rs.EOF Then 
        '    '    Continua = False 
        '    'End If 
        '    'rs.Close()  

        '    If Continua = False Then
        '        'MsgBox("Attenzione Esistono dipendenti aventi assegnati più Iban!" & vbCrLf & "L'importazione verrà terminata!", MsgBoxStyle.Critical)
        '        'ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0, "Imp Costi- Esistono dipendenti aventi assegnati più Iban")
        '    Else
        '        FileOpen(1, txtFileORV.Text, OpenMode.Output)

        '        AggiornaLbl("Inizio Esportazione")
        '        Dim StrSql As String = ""
        '        Dim Tabella As String = ""
        '        'If DatiGen.GestPartite = 0 Then
        '        '    Tabella = "xs1r_Imp_Cont"
        '        '    StrSql = "Select * " & _
        '        '        " from xs1r_Imp_Cont where dbgruppo='" & DatiGen.DbGruppo & "'  order by NumReg,  indiceord  "
        '        'Else
        '        '    Tabella = "xs1r_Imp_ContPAR"
        '        '    StrSql = "Select  * " & _
        '        '       " from xs1r_Imp_ContPAR  where dbgruppo='" & DatiGen.DbGruppo & "' order by NumReg, ord,indiceord "

        '        'End If

        '        Tabella = "ExportOrv"
        '        ' TipoRec, DataReg, IdReg, DataOrd, CodCli, NrOrd, CondPag, Iban, TipoRig, CodArt, Prezzo, Qta, SpeseTrasp 
        '        StrSql = "SELECT * " & _
        '            "FROM ExportOrv  where dbgruppo='" & DatiGen.DbGruppo & "'  order by  ordinamento, cint(nrr) "
        '        rs.Open(StrSql, m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic)
        '        If Not rs.EOF Then
        '            TotRec = GetNrRec(Tabella)
        '            NrRec = TotRec + IndR
        '            rs.MoveFirst()
        '            Do While Not rs.EOF
        '                IndR += 1
        '                NumRec += 1
        '                AggiornaLbl("Esportazione record nr " & NumRec & " di " & TotRec)
        '                'IndP = IndR / 2
        '                RecOut = rs.Fields(0).Value
        '                Dim nrfield As Integer = rs.Fields.Count - 4

        '                'If DatiGen.GestPartite = 0 Then
        '                '    nrfield = nrfield - 2
        '                'Else
        '                '    nrfield = nrfield - 3
        '                'End If
        '                'RecOut = RecOut & msep & NumRec
        '                'RecOut = RecOut & msep & NumRec

        '                For i As Integer = 1 To nrfield
        '                    RecOut = RecOut & msep & rs.Fields(i).Value
        '                Next i
        '                RecOut = RecOut & vbCrLf
        '                Print(1, RecOut)
        '                mPerc = Val((IndR * 100) / NrRec)
        '                If mPerc > ProgressBar1.Maximum Then
        '                    mPerc = ProgressBar1.Maximum
        '                End If
        '                ProgressBar1.Value = mPerc
        '                rs.MoveNext()
        '            Loop
        '        End If
        '        rs.Close()
        '        ProgressBar1.Value = 100
        '        FileClose(1)
        '        AggiornaLbl("Lancio file batch")
        '        LogWrite("Lancio file batch")
        '        'Shell(Application.StartupPath & "\Importa_MovInd.bat " & DatiGen.GruppoDocMovInd & _
        '        '    " " & DatiGen.ModelloMovInd & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & DatiGen.WSP & " " & DatiGen.Operatore, AppWinStyle.NormalFocus, True)
        '        ' ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 2)
        '        'Shell(DatiGen.FileBatCosti & " " & DatiGen.GruppoDocContabGen & _
        '        '    " " & DatiGen.ModelloContabGen & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & DatiGen.WSP & " " & DatiGen.Operatore, AppWinStyle.NormalFocus, True)
        '        If ConnettiEs() Then
        '            Dim lastimp As Long = GetIdImp(DatiGen.DbGruppo)
        '            Dim FileName As String = txtFileORV.Text
        '            If System.IO.File.Exists(FileName) Then
        '                Shell(DatiGen.FileBatCosti & " " & DatiGen.GruppoDocContabGen & _
        '                                  " " & DatiGen.ModelloContabGen & " " & DatiGen.DbGruppo & " " & DatiGen.WS & " " & _
        '                                  DatiGen.WSP & " " & DatiGen.Operatore & " " & DatiGen.PathConfES, AppWinStyle.NormalFocus, True)
        '            End If
        '            Dim Newimp As Long = GetIdImp(DatiGen.DbGruppo)
        '            If Newimp > lastimp Then
        '                LogWrite("Importazione :" & Newimp)
        '                If System.IO.File.Exists(Replace(FileName, ".txt", "._xt")) Then
        '                    My.Computer.FileSystem.MoveFile(Replace(FileName, ".txt", "._xt"), Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".txt"), True)
        '                ElseIf System.IO.File.Exists(Replace(FileName, ".txt", ".err")) Then
        '                    My.Computer.FileSystem.MoveFile(Replace(FileName, ".txt", ".err"), Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".ERR"), True)

        '                ElseIf System.IO.File.Exists(FileName) Then
        '                    My.Computer.FileSystem.MoveFile(FileName, Replace(FileName, ".txt", "_" & DatiGen.DbGruppo & "_" & Newimp & ".txt"), True)
        '                End If
        '                UpdDocEsolver(Newimp, DatiGen.DbGruppo)
        '            End If
        '            'ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 2)
        '        Else
        '            LogWrite("Errore connessione Esolver")
        '        End If
        '        DisconnettiEs()
        '    End If

        '    AggiornaLbl("Esportazione Ordini Terminata")
        '    Cursor = Cursors.Default
        '    rs = Nothing

        'Catch ex As Exception
        '    MsgBox("Errore  " & ex.Message, MsgBoxStyle.Critical, "Esporta Ordini")
        '    LogWrite("Esporta Ordini - Errore  " & ex.Message)
        '    ' ScriviLogImpo(DatiGen.DbGruppo, idImportazione, 0, "Imp Fatture- Errore  " & ex.Message)
        '    ProgressBar1.Value = 0
        'Finally
        '    FileClose(1)
        '    'FileClose(2)
        '    Cursor = Cursors.Default
        'End Try

    End Sub
    Private Sub UpdDocEsolver(ByVal IdImpo As Long, ByVal Gruppo As String, ByVal GruppoDoc As String)
        'Dim rs As New ADODB.Recordset
        'Dim rs2 As New ADODB.Recordset
        'Dim i As Long
        'Dim Iddoc As Long
        'Dim AggiornatoDas As Boolean
        'Dim NumEsolver As String = ""
        'Dim IdWeb As Long = 0
        'Dim TimeOutDas As Long = 0
        'Dim MaxDas As Long = 0
        'Dim CodCli As Long = 0
        'Dim TempoDiff As Double
        'Dim TempoIni As String
        'Dim TempoPre As String
        'Dim DateReg As String = "01/01/18000"
        'Dim TipoDoc As Long = 0
        'Dim MaxTempoTrasc As Long = 10 ' 10000 'minuti trascorsi  

        'Dim StatoORD As Integer = 0
        'TempoDiff = 0
        'MaxDas = 50000
        'rs.Open("Select Iddocumento from ImpDocLegami where idimportazione=" & IdImpo & " and DBGruppo='" & Gruppo & _
        '            "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
        'If Not rs.EOF Then
        '    Do While Not rs.EOF
        '        AggiornatoDas = False
        '        TimeOutDas = 0
        '        i = i + 1
        '        Iddoc = rs.Fields("IdDocumento").Value
        '        TempoIni = Date.Now ' TimeOfDay
        '        Do While Not AggiornatoDas And TempoDiff <= MaxTempoTrasc 'NrTenta <= MaxTenta
        '            TempoPre = Date.Now ' TimeOfDay
        '            TempoDiff = DateDiff("n", (TempoIni), (TempoPre))
        '            rs2.Open("Select StatoDocumento,IdDocumento, PeriodoRifNumeraz, CodSerie, NumRegistraz, " & _
        '                    "Riferimento,codclifor,DataRegistrazione,StatoGestionale,CodTipoDoc " & _
        '                    "FROM DocElencoGen where dbgruppo='" & Gruppo & "' and " & _
        '                    "Iddocumento=" & Iddoc & " and " & _
        '                    "GruppoDoc='" & GruppoDoc & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        '            If Not rs2.EOF Then
        '                AggiornatoDas = rs2.Fields("StatoDocumento").Value = 0
        '                NumEsolver = (rs2.Fields("NumRegistraz").Value)
        '                CodCli = rs2.Fields("CodCliFor").Value
        '                DateReg = rs2.Fields("DataRegistrazione").Value
        '                TipoDoc = rs2.Fields("CodTipoDoc").Value
        '                If AggiornatoDas Then
        '                    rs2.Update()
        '                    If DatiGen.DocProv Then
        '                        rs2.Fields("StatoGestionale").Value = 1
        '                    End If
        '                    rs2.Update()
        '                End If
        '            Else
        '                StatoORD = 1
        '            End If
        '            rs2.Close()
        '            Application.DoEvents()
        '        Loop
        '        If Not AggiornatoDas Then
        '            If StatoORD <> 1 Then
        '                LogWrite("Importazione Documento " & Iddoc & ";" & NumEsolver & " - Ordine non aggiornato dal Das dopo " & MaxTempoTrasc & " minuti")
        '            Else
        '                LogWrite("Importazione Documento " & Iddoc & ";" & NumEsolver & " - Ordine Annullato")
        '            End If
        '        Else
        '            LogWrite("Importazione Documento " & Iddoc & ";" & NumEsolver & " - Ordine Importato come provvisorio")
        '        End If

        '        Application.DoEvents()
        '        rs.MoveNext()
        '        Application.DoEvents()
        '    Loop
        '    'If i > 0 Then
        '    '    InviaEmail(IdTrasf, Format(Now.Date, "dd/MM/yyyy") & " - " & TimeOfDay & " - Sono stati importati " & i & " ordini dal web. Importazione Nr." & IdImpo, "Importazione Ordini dal Web")
        '    'End If
        'End If
        'rs.Close()
    End Sub
    Private Function GetNrRec(ByVal NomeTab As String) As Long
        Dim rs As New ADODB.Recordset
        rs.Open("Select count(*) as TotRec from " & NomeTab, m_ConnAcc)
        If Not rs.EOF Then
            GetNrRec = Val(rs("TotRec").Value)
        End If
        rs.Close()
        rs = Nothing
    End Function


    Private Function ImportaFiletxt(ByVal NomeFile As String, ByRef IndR As Integer, ByRef TotRec As Integer) As Boolean
        ImportaFiletxt = True
        Dim msep As String = ","
        Dim FileOr As StreamReader = Nothing
        Dim rs As New ADODB.Recordset
        Dim Indx As Integer = 0
        Dim RigaIn As String = ""
        Dim mperc As Double = 0
        FileOr = New StreamReader(NomeFile)
        Dim temp As String = FileOr.ReadToEnd()
        Dim Righe() As String = Split(temp, msep)
        Dim NrRec As Integer = UBound(Righe) + 1
        TotRec = Split(temp, vbLf).Count - 2
        TotRec = TotRec * 2
        Dim Id As Long = 0
        Dim NrRiga As Long = 0
        FileOr.Close()

        'Leggo le righe fino a quando non arrivo alla fine
        AggiornaLbl("Lettura file csv")
        LogWrite("Lettura file csv " & NomeFile)
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(NomeFile)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(msep)
            MyReader.HasFieldsEnclosedInQuotes = True

            Dim currentRow() As String
            Try

                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields
                    IndR += 1
                    'Id = IndR 
                    Id += 1
                    rs.Open("Select top 1 * from ImpFile", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    rs.AddNew()
                    rs("Id").Value = Id
                    rs("DbGruppo").Value = DatiGen.DbGruppo
                    'rs("ID").Value = Id 
                    Dim NrField As Integer
                    For i As Integer = 0 To currentRow.Length - 1
                        Try
                            Dim Valore As String = ""
                            NrField = i + 2
                            Dim NrCol As Integer = i

                            Valore = NoNull(currentRow(NrCol))
                            If Mid(Valore, 1, 1) = Chr(34) Then
                                Valore = Trim(Replace(Valore, Chr(34), "")) & Trim(Replace(NoNull(currentRow(NrCol + 1)), Chr(34), ""))
                                i = i + 1
                            End If
                            rs.Fields(NrField).Value = NoNull(Valore)
                        Catch ex As Exception
                            LogWrite("Salvataggio record " & i & "   " & rs.Fields(NrField).Name & " Errore: " & ex.Message)
                            MsgBox("Stop " & i & ": " & rs.Fields(NrField).Name & " " & ex.Message)
                        End Try
                    Next
                    rs.Update()
                    rs.Close()
                    mperc = Val((IndR * 100) / totRec)
                    If mperc > ProgressBar1.Maximum Then
                        mperc = ProgressBar1.Maximum
                    End If
                    ProgressBar1.Value = mperc
                    NrRiga += 1
                End While
            Catch ex As Exception
                LogWrite("Errore Lettura file:" & ex.Message & " in " & ex.StackTrace)
                MsgBox("Errore Lettura file:" & ex.Message & " in " & ex.StackTrace, MsgBoxStyle.Critical)

                ImportaFiletxt = False
            End Try
        End Using
    End Function

    Private Sub ScriviLogImpo(ByVal dbgruppo As String, ByRef IdImpo As Long, ByVal TipoImpo As Integer, _
                              Optional ByVal NoteImp As String = "")
        ''TipoImpo - 
        ''1->ANA
        ''2->MovInd
        ''3->Contab

        'Dim rs As New ADODB.Recordset
        'rs.Open("Select * from xs1r_LogImpDip where idimp=" & IdImpo, m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        'If rs.EOF Then
        '    rs.AddNew()
        '    IdImpo = UltimoCodiceEs("xs1r_LogImpDip", "idimp") + 1
        '    rs("idimp").Value = IdImpo
        '    rs("DataImp").Value = Format(Date.Now, "dd/MM/yyyy")
        '    rs("OraImp").Value = Format(TimeOfDay, "HH:mm:ss")
        '    rs("DataIni").Value = Date.Now
        '    rs("OperatoreEs").Value = DatiGen.OperatoreEs
        '    rs("dbgruppo").Value = dbgruppo
        '    rs("ImpAnag").Value = 0
        '    rs("ImpMovInd").Value = 0
        '    rs("ImpContab").Value = 0
        'End If
        'rs("DataFine").Value = Date.Now
        'Select Case TipoImpo
        '    '1->ANA
        '    Case 1
        '        rs("ImpAnag").Value = 1
        '    Case 2
        '        rs("ImpMovInd").Value = 1
        '    Case 3
        '        rs("ImpContab").Value = 1
        'End Select
        'rs("NoteImp").Value = NoteImp
        'rs.Update() 
    End Sub

    Private Sub txtFileOr_LostFocus(sender As Object, e As System.EventArgs) Handles txtFileOr.LostFocus
        'cboTPLav.Text = ""
        'cboTPLav.SelectedItem = Nothing
        'txtRifPrev.Text = ""
        'txtRifPrev.Tag = 0
        'txtRifPrev.Enabled = False
        'cmdRicPrev.Enabled = False
        'AbilitaEsportazione()
    End Sub
    Private Sub txtFileOr_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFileOr.TextChanged
         
        AbilitaEsportazione()
        'If System.IO.File.Exists(txtFileOr.Text) Then
        '    'If UCase(System.IO.Path.GetExtension(txtFileOr.Text)) <> ".CSV" Then
        '    '    Dim NewFile As String = convertExcelToCSV(txtFileOr.Text)
        '    '    txtFileOr.Text = NewFile

        '    'End If
        'End If
    End Sub
    Private Shared Function convertExcelToCSV(ByVal sourceFile As String) As Boolean
        'Dim worksheetName As String = "1"
        'Dim FileDest As String = System.IO.Path.GetDirectoryName(sourceFile) & "\" & System.IO.Path.GetFileNameWithoutExtension(sourceFile) & ".csv"
        'Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sourceFile & ";Extended Properties="" Excel.12.0;HDR=Yes;IMEX=1"""
        'Dim conn As System.Data.OleDb.OleDbConnection = Nothing
        'Dim wrtr As StreamWriter = Nothing
        'Dim cmd As System.Data.OleDb.OleDbCommand = Nothing
        'Dim da As System.Data.OleDb.OleDbDataAdapter = Nothing
        'Try
        '    conn = New System.Data.OleDb.OleDbConnection(strConn)
        '    conn.Open()
        '    cmd = New System.Data.OleDb.OleDbCommand("SELECT * FROM [" & worksheetName & "$]", conn)
        '    cmd.CommandType = CommandType.Text
        '    wrtr = New StreamWriter(FileDest)
        '    da = New System.Data.OleDb.OleDbDataAdapter(cmd)
        '    Dim dt As DataTable = New DataTable()
        '    da.Fill(dt)

        '    For x As Integer = 0 To dt.Rows.Count - 1
        '        Dim rowString As String = ""

        '        For y As Integer = 0 To dt.Columns.Count - 1
        '            rowString &= """" & dt.Rows(x)(y).ToString() & ""","
        '        Next y
        '        wrtr.WriteLine(rowString)
        '    Next x

        '    MessageBox.Show("Done! Your " & sourceFile & " has been converted into " & FileDest & ".")
        '    convertExcelToCSV = FileDest
        'Catch exc As Exception
        '    MessageBox.Show(exc.ToString())
        'Finally
        '    If conn.State = ConnectionState.Open Then
        '        conn.Close()
        '    End If
        '    wrtr.Close()
        'End Try
    End Function
    Private Function GetDescArt(ByVal DbGruppo As String, ByVal CodArt As String) As String
        GetDescArt = ""
        If ConnettiEs() Then
            Dim rs As New ADODB.Recordset
            rs.Open("Select DesArt from ArtAnagrafica where Dbgruppo='" & DbGruppo & "' and codart='" & CodArt & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                GetDescArt = rs("DesArt").Value
            End If
            rs.Close()
            rs = Nothing
        End If
        DisconnettiEs()
    End Function
    Private Function GetArtCollegato(ByVal DbGruppo As String, ByVal CodArt As String) As String
        GetArtCollegato = ""
        If ConnettiEs() Then
            Dim rs As New ADODB.Recordset
            rs.Open("Select CodArtCollegato from artcollegati where Dbgruppo='" & DbGruppo & "' and codart='" & CodArt & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                GetArtCollegato = rs("CodArtCollegato").Value
            End If
            rs.Close()
            rs = Nothing
        End If
        DisconnettiEs()
    End Function

    Private Function GetScortaArt(ByVal DbGruppo As String, ByVal CodArt As String) As Double
        GetScortaArt = 0
        If ConnettiEs() Then
            Dim rs As New ADODB.Recordset
            rs.Open("Select max(ScortaMinima) as Scorta from ArtScortaMinima where Dbgruppo='" & DbGruppo & "' and codart='" & CodArt & "' Group by Dbgruppo,Codart ", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                GetScortaArt = Val(NoNull(rs("Scorta")))
            End If
            rs.Close()
            rs = Nothing
        End If
        DisconnettiEs()
    End Function
    Private Function GetDispoArt(ByVal DbGruppo As String, ByVal CodArt As String) As Double
        GetDispoArt = 0
        If ConnettiEs() Then
            Dim rs As New ADODB.Recordset
            rs.Open("select GiacDisp, Disponibilita from ESV_SITART_AV   where dbgruppo='" & DbGruppo & "' and CodArt='" & CodArt & "' ", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                GetDispoArt = Val(rs("GiacDisp").Value)
            End If
            rs.Close()
            rs = Nothing
        End If
        DisconnettiEs()
    End Function
    Private Function GetSalvaComm() As Boolean
        Try
            GetSalvaComm = False
            If ConnettiAcc() Then

                Dim NomeField As String = "TipoLavoro_" & TP_LAVORO

                Dim rs As New ADODB.Recordset
                rs.Open("Select * from DaEseguire where salvacommessa=true and " & NomeField & "=true ", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rs.EOF Then
                    GetSalvaComm = True
                End If
                rs.Close()
                rs = Nothing
            End If
            DisconnettiAcc()

        Catch ex As Exception
            LogWrite("ERRORE GET SALVA COMMESSA " & ex.Message & " in " & ex.StackTrace)
        End Try
    End Function
    '.Item("CodCli") = CodCli
    'nrc += 1
    '.Item("CapoGruppo") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    'nrc += 1
    '.Item("CDA") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CanaleVendita") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("ModelloComposto") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CODART") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("Descrizione") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("Var1") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("Var2") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("Var3") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("Var4") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("Var5") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("QTATOT") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("ModelloComponente") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CodCompo") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("DesCompo") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("VarCompo") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CodForn") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("Costo") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("LAV1") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CodTerz1") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CostoLav1") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("LAV2") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CodTerz2") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CostoLav2") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("LAV3") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CodTerz3") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CostoLav3") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("LAV4") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CodTerz4") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CostoLav4") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("LAV5") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CodTerz5") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CostoLav5") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("LAV6") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CodTerz6") = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
    '.Item("CostoLav6")=
    '.Item("LAV7")=
    '.Item("CodTerz7")=
    '.Item("CostoLav7")=
    '.Item("LAV8")=
    '.Item("CodTerz8")=
    '.Item("CostoLav8")=
    '.Item("ImpiantiFronte")=
    '.Item("Trasp")=
    '.Item("ctot")=
    '.Item("Prezzo")=
    '.Item("margsing")=
    '.Item("perc")=
    '.Item("MargTot")=
    '.Item("Fatturato")=
    '.Item("NOTE")=  

    Private Function GetVarianti(ByRef dtDatiArtConfVar As DataTable, ByVal CodArt As String, ByVal VarianteIn As String, ByVal NrVar As String) As String ' , ByRef Varianti() As String, ByRef Qta() As String, ByRef Variante As String) As String

        Dim indvar As Integer = 0
        'If Not Varianti Is Nothing Then indvar = Varianti.Length
        If VarianteIn.Contains(";") Then
            Dim Appo() As String = Split(Trim(VarianteIn), ";")
            For x As Integer = 0 To Appo.Length - 1
                Dim varqta() As String
                If Appo(x).Contains("-") Then
                    varqta = Split(Trim(Appo(x)), "-")
                    For n As Integer = 0 To varqta.Length - 1
                        varqta(n) = Trim(varqta(n))
                    Next
                End If
                If varqta.Length > 0 Then
                    'ReDim Preserve Varianti(indvar)
                    'Varianti(indvar) = Variante & varqta(1)
                    'ReDim Preserve Qta(indvar)
                    'Qta(indvar) = varqta(0)

                    Dim RowDTArtConfVar As DataRow = dtDatiArtConfVar.NewRow
                    With RowDTArtConfVar
                        .Item("DbGruppo") = DatiGen.DbGruppo
                        .Item("Codart") = CodArt
                        .Item("Variante") = varqta(1)
                        .Item("Posizione") = NrVar + 1
                        .Item("CodTipoVariante") = "" 'gettipovarEs(RowDTALL.Item("Codart"), Var(nrvar)) 
                        .Item("Qta") = varqta(0) 'gettipovarEs(RowDTALL.Item("Codart"), Var(nrvar)) 
                    End With
                    dtDatiArtConfVar.Rows.Add(RowDTArtConfVar)

                    indvar += 1
                End If
            Next

        Else
            If VarianteIn <> "" Then
                ' Variante = Variante & VarianteIn & ";"
                Dim RowDTArtConfVar As DataRow = dtDatiArtConfVar.NewRow
                With RowDTArtConfVar
                    .Item("DbGruppo") = DatiGen.DbGruppo
                    .Item("Codart") = CodArt
                    .Item("Variante") = VarianteIn
                    .Item("Posizione") = NrVar + 1
                    .Item("CodTipoVariante") = "" 'gettipovarEs(RowDTALL.Item("Codart"), Var(nrvar))
                    .Item("Qta") = 1
                End With
                dtDatiArtConfVar.Rows.Add(RowDTArtConfVar)
            End If
        End If

    End Function
    Private Function LeggiExcel(ByVal NomeFile As String) As Boolean
        Try
            LeggiExcel = True
            AggiornaLbl("Lettura file excel " & NomeFile)
            Cursor = Cursors.WaitCursor

            Dim conStr As String = ""
            Dim mprovider As String = ""
            conStr = "Provider={0};Data Source={1};Extended Properties='Excel 8.0;HDR={2}'"

            Dim Extension As String = LCase(System.IO.Path.GetExtension(NomeFile))
            Dim ExtendedProp As String = "Excel 8.0"
            Select Case Extension

                Case ".xls"

                    'Excel 97-03

                    mprovider = "Microsoft.Jet.OLEDB.4.0" 

                    ExtendedProp = "Excel 8.0"
                    Exit Select

                Case ".xlsx"

                    'Excel 07
                    
                    mprovider = "Microsoft.ACE.OLEDB.12.0"
                    ExtendedProp = "Excel 12.0 Xml"

                    Exit Select

            End Select

            'mprovider = "Microsoft.Jet.OLEDB.4.0"

            ' conStr = String.Format(conStr, mprovider, NomeFile, 1)
            'conStr = "Provider=" & mprovider & ";Data Source=" & NomeFile & ";Extended Properties='Excel 8.0;HDR=" & 1 & "'"
            ' conStr = "Provider='" & mprovider & "';Data Source='" & NomeFile & "';Extended Properties='Excel 8.0;HDR=1;IMEX=1'"
            ' If chk2007.Checked Then
            'conStr = "Provider='Microsoft.ACE.OLEDB.12.0';Data Source='" & NomeFile & "';Extended Properties='Excel 12.0 Xml;HDR=1;IMEX=1'"
            'End If

            conStr = "Provider='" & mprovider & "';Data Source='" & NomeFile & "';Extended Properties='" & ExtendedProp & ";HDR=1;IMEX=1'"

            Dim connExcel As New Data.OleDb.OleDbConnection(conStr)

            Dim cmdExcel As New Data.OleDb.OleDbCommand()

            Dim oda As New Data.OleDb.OleDbDataAdapter()

            Dim dt As New DataTable()

            Dim ds As New DataSet


            cmdExcel.Connection = connExcel



            'Get the name of First Sheet

            connExcel.Open()

            Dim dtExcelSchema As DataTable

            dtExcelSchema = connExcel.GetOleDbSchemaTable(Data.OleDb.OleDbSchemaGuid.Tables, Nothing)

            For i As Integer = 0 To dtExcelSchema.Rows.Count - 1

                Dim SheetName As String = dtExcelSchema.Rows(i)("TABLE_NAME").ToString()
                If InStr(SheetName, "_FilterDatabase") = 0 And InStr(SheetName, "'_") = 0 And InStr(SheetName, "$_") = 0 Then
                    cmdExcel.CommandText = "SELECT * From [" & SheetName & "]"

                    oda.SelectCommand = cmdExcel
                    dt = New DataTable
                    oda.Fill(dt)
                    SheetName = Replace(SheetName, "'", "")
                    If Mid(SheetName, Len(SheetName), 1) = "$" Then
                        SheetName = Mid(SheetName, 1, InStr(SheetName, "$") - 1) ' Len(SheetName) - 1)
                    End If
                    AggiornaLbl("Lettura foglio excel " & SheetName)
                    dt.TableName = SheetName
                    'Dim appo As DataRow
                    'appo = dt.Rows(3)
                    ds.Tables.Add(dt)
                End If
            Next

            ProgressBar1.Value = Val((1 * 100) / 3)

            'Dim SheetName As String = dtExcelSchema.Rows(0)("TABLE_NAME").ToString()

            connExcel.Close()
             





            'svuoto le tabelle di access
            If ConnettiAcc() Then
                m_ConnAcc.Execute("delete * from DatiOrd")
                m_ConnAcc.Execute("delete * from Anagrafica")
                ' m_ConnAcc.Execute("delete * from ArtVarianti")
                m_ConnAcc.Execute("delete * from ArtConfVar")
                m_ConnAcc.Execute("delete * from DBase")
                m_ConnAcc.Execute("delete * from ORV_TOT")
                m_ConnAcc.Execute("delete * from ORA_TOT")
                m_ConnAcc.Execute("delete * from OCL_TOT") 
            End If
            DisconnettiAcc()
            Dim dsDest As New DataSet
            Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatiGen.DbAccess & ";" ' "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccess2007file.accdb;Persist Security Info=False;"
            Dim accConnection As New OleDb.OleDbConnection(connString)
            Dim accCommand As New Data.OleDb.OleDbCommand
            Dim accDataAd As New Data.OleDb.OleDbDataAdapter

            accCommand.Connection = accConnection

            'carico i dataset
            accCommand.CommandText = "Select * from Anagrafica"
            accDataAd.SelectCommand = accCommand
            Dim dtDatiArt As New DataTable("Anagrafica")
            accDataAd.Fill(dtDatiArt)
            dsDest.Tables.Add(dtDatiArt)

            'accCommand.CommandText = "Select * from ArtVarianti"
            'accDataAd.SelectCommand = accCommand
            'Dim dtDatiArtvar As New DataTable("ArtVarianti")
            'accDataAd.Fill(dtDatiArtvar)
            'dsDest.Tables.Add(dtDatiArtvar)

            accCommand.CommandText = "Select * from ArtConfVar"
            accDataAd.SelectCommand = accCommand
            Dim dtDatiArtConfVar As New DataTable("ArtConfVar")
            accDataAd.Fill(dtDatiArtConfVar)
            dsDest.Tables.Add(dtDatiArtConfVar)

            accCommand.CommandText = "Select * from DBase"
            accDataAd.SelectCommand = accCommand
            Dim dtDatiDB As New DataTable("DBase")
            accDataAd.Fill(dtDatiDB)
            dsDest.Tables.Add(dtDatiDB)


            accCommand.CommandText = "Select * from ORV_TOT"
            accDataAd.SelectCommand = accCommand
            Dim dtDatiORV As New DataTable("ORV_TOT")
            accDataAd.Fill(dtDatiORV)
            dsDest.Tables.Add(dtDatiORV)

            

            accCommand.CommandText = "Select * from ORA_TOT"
            accDataAd.SelectCommand = accCommand
            Dim dtDatiORA As New DataTable("ORA_TOT")
            accDataAd.Fill(dtDatiORA)
            dsDest.Tables.Add(dtDatiORA)

            accCommand.CommandText = "Select * from OCL_TOT"
            accDataAd.SelectCommand = accCommand
            Dim dtDatiOCL As New DataTable("OCL_TOT")
            accDataAd.Fill(dtDatiOCL)
            dsDest.Tables.Add(dtDatiOCL)


            accCommand.CommandText = "Select * from DatiOrd"
            accDataAd.SelectCommand = accCommand
            Dim dtDatiALL As New DataTable("DatiOrd")
            accDataAd.Fill(dtDatiALL)
            dsDest.Tables.Add(dtDatiALL)

            Dim IdArt As Long = 0
            Dim IdCdb As Long = 0
            Dim IdRCdb As Long = 0
            Dim idORV As Long = 0
            Dim idRORV As Long = 0

           
              
            Dim IndTab As Integer = 0

            Dim nometb As String = ds.Tables(IndTab).TableName

            AggiornaLbl("Caricamento Dati ")
            Dim CodCliTes As String = ""
            For r As Integer = 0 To ds.Tables(IndTab).Rows.Count - 1
                Try
                    Dim RowDTALL As DataRow = dtDatiALL.NewRow
                    Dim RowDTAna As DataRow = dtDatiArt.NewRow
                    'Dim RowDTArtVar As DataRow = dtDatiArtvar.NewRow
                    Dim RowDTArtConfVar As DataRow = dtDatiArtConfVar.NewRow
                    Dim RowDTDBase As DataRow = dtDatiDB.NewRow
                    Dim RowDTORV As DataRow = dtDatiORV.NewRow
                    Dim RowDTORA As DataRow = dtDatiORA.NewRow
                    Dim RowDTOCL As DataRow = dtDatiOCL.NewRow


                    Dim CodCli As String = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(0)))


                    If CodCli <> "" Then

                        AggiornaLbl("Caricamento Dati ALL")

                        With RowDTALL
                            .Item("DbGruppo") = DatiGen.DbGruppo
                            For nrc As Integer = 0 To ds.Tables(IndTab).Columns.Count - 1
                                Try
                                    Dim valore As String = ""
                                    .Item(nrc + 2) = Trim(NoNull(ds.Tables(IndTab).Rows(r).Item(nrc)))
                                Catch ex As Exception
                                    MsgBox("Errore " & ex.Message & " Colonna: " & nrc)
                                End Try
                            Next

                        End With
                        dtDatiALL.Rows.Add(RowDTALL)

                        If Trim(RowDTALL.Item("Codart")) <> "" Then
                            CodCliTes = CodCli

                            AggiornaLbl("Caricamento articoli")
                            'articoli
                            With RowDTAna

                                .Item("DbGruppo") = DatiGen.DbGruppo
                                .Item("Codart") = RowDTALL.Item("Codart")
                                .Item("Descrizione") = RowDTALL.Item("Descrizione")
                                .Item("GruppoCodifica") = ""
                                .Item("TipoArt") = "PF"
                                .Item("Um") = ""
                                .Item("CodiceModello") = RowDTALL.Item("ModelloComposto")
                                .Item("CodForn") = ""
                                .Item("CodArtForn") = ""
                                .Item("NomeDB") = RowDTALL.Item("Codart")
                            End With
                            dtDatiArt.Rows.Add(RowDTAna)

                            'varianti

                            AggiornaLbl("Caricamento Varianti")

                            Dim Var(5) As String
                            Var(0) = RowDTALL.Item("Var1")
                            Var(1) = RowDTALL.Item("Var2")
                            Var(2) = RowDTALL.Item("Var3")
                            Var(3) = RowDTALL.Item("Var4")
                            Var(4) = RowDTALL.Item("Var5")

                            'Dim Varianti() As String
                            'Dim Qta() As String
                            Dim indvar As Long = 0
                            Try
                                Dim NrRec As Integer = 0
                                'Dim Variante As String = ""
                                For nrvar As Integer = 0 To 4
                                    If Var(nrvar) <> "" Then
                                        GetVarianti(dtDatiArtConfVar, RowDTALL.Item("Codart"), Var(nrvar), nrvar) ', Varianti, Qta, Variante)
                                    End If
                                Next

                            Catch ex As Exception
                                MsgBox("Errore " & ex.Message)
                            End Try
                            'If Not Varianti Is Nothing Then
                            '    For i As Integer = 0 To Varianti.Length - 1
                            '        RowDTArtVar = dtDatiArtvar.NewRow
                            '        With RowDTArtVar
                            '            .Item("DbGruppo") = DatiGen.DbGruppo
                            '            .Item("Codart") = RowDTALL.Item("Codart")
                            '            .Item("Variante") = Varianti(i)
                            '        End With

                            '        dtDatiArtvar.Rows.Add(RowDTArtVar)
                            '    Next
                            'End If

                            'Dim VariantiComp() As String
                            'Dim QtaComp() As String
                            'Dim VarianteCom As String = ""
                            GetVarianti(dtDatiArtConfVar, RowDTALL.Item("CodCompo"), RowDTALL.Item("VarCompo1"), 0) ', VariantiComp, QtaComp, VarianteCom)

                            'If Not VariantiComp Is Nothing Then
                            '    For i As Integer = 0 To VariantiComp.Length - 1
                            '        RowDTArtVar = dtDatiArtvar.NewRow
                            '        With RowDTArtVar
                            '            .Item("DbGruppo") = DatiGen.DbGruppo
                            '            .Item("Codart") = RowDTALL.Item("CodCompo")
                            '            .Item("Variante") = VariantiComp(i)
                            '        End With
                            '        dtDatiArtvar.Rows.Add(RowDTArtVar)
                            '    Next
                            'End If

                            'componente
                            RowDTAna = dtDatiArt.NewRow
                            With RowDTAna
                                .Item("DbGruppo") = DatiGen.DbGruppo
                                .Item("Codart") = RowDTALL.Item("CodCompo")
                                .Item("Descrizione") = RowDTALL.Item("DesCompo")
                                .Item("GruppoCodifica") = ""
                                .Item("TipoArt") = "MP"
                                .Item("Um") = ""
                                .Item("CodiceModello") = RowDTALL.Item("ModelloComponente")
                                .Item("CodForn") = RowDTALL.Item("CodForn")
                                .Item("CodArtForn") = RowDTALL.Item("CodCompo")
                                .Item("NomeDB") = RowDTALL.Item("Codart")
                            End With
                            dtDatiArt.Rows.Add(RowDTAna)

                            'Distinta


                            AggiornaLbl("Caricamento Distinta")
                            RowDTDBase = dtDatiDB.NewRow
                            With RowDTDBase

                                .Item("DbGruppo") = DatiGen.DbGruppo
                                .Item("CodDb") = RowDTALL.Item("Codart")
                                .Item("CodArtCompo") = RowDTALL.Item("CodCompo")
                                .Item("Qta") = 1
                            End With
                            dtDatiDB.Rows.Add(RowDTDBase)


                            Dim IdT As Integer = 1
                            Dim IdR As Integer = 0

                            'ORV


                            AggiornaLbl("Caricamento ORV")
                            ' For i As Integer = 0 To Varianti.Length - 1
                            IdR += 1
                            RowDTORV = dtDatiORV.NewRow()
                            With RowDTORV
                                .Item("DbGruppo") = DatiGen.DbGruppo
                                .Item("ID_T") = IdT
                                .Item("IDR") = IdR
                                .Item("CodCli") = RowDTALL.Item("CodCli")
                                .Item("CapoGruppo") = RowDTALL.Item("CapoGruppo")
                                .Item("CDA") = RowDTALL.Item("CDA")
                                .Item("CanaleVendita") = RowDTALL.Item("CanaleVendita")
                                .Item("Codart") = RowDTALL.Item("Codart")
                                .Item("Descrizione") = RowDTALL.Item("Descrizione")
                                .Item("Variante") = "" 'Varianti(i) 
                                .Item("Qta") = RowDTALL.Item("QTATOT") ' Qta(i)
                                .Item("PrezzoUnit") = RowDTALL.Item("Prezzo")
                                .Item("DataConsegnaRich") = IIf(RowDTALL.Item("DataConsegna") = "", Format(Now.Date, "dd/MM/yyyy"), RowDTALL.Item("DataConsegna"))
                            End With
                            dtDatiORV.Rows.Add(RowDTORV)
                            'Next

                            'ORA
                            IdT = 1
                            IdR = 0

                            'If Not VariantiComp Is Nothing Then
                            '    For i As Integer = 0 To VariantiComp.Length - 1
                            '        IdR += 1

                            '        RowDTORA = dtDatiORA.NewRow()
                            '        With RowDTORA
                            '            .Item("DbGruppo") = DatiGen.DbGruppo
                            '            .Item("ID_T") = IdT
                            '            .Item("IDR") = IdR
                            '            .Item("CodForn") = RowDTALL.Item("CodForn")
                            '            .Item("CodCompo") = RowDTALL.Item("CodCompo")
                            '            .Item("DesCompo") = RowDTALL.Item("DesCompo")
                            '            .Item("VarCompo") = VariantiComp(i)
                            '            .Item("Qta") = QtaComp(i)
                            '            .Item("Costo") = RowDTALL.Item("Costo")
                            '        End With
                            '        dtDatiORA.Rows.Add(RowDTORA)
                            '    Next
                            'Else

                            AggiornaLbl("Caricamento ORA")
                            IdR += 1
                            RowDTORA = dtDatiORA.NewRow()
                            With RowDTORA
                                .Item("DbGruppo") = DatiGen.DbGruppo
                                .Item("ID_T") = IdT
                                .Item("IDR") = IdR
                                .Item("CodForn") = RowDTALL.Item("CodForn")
                                .Item("CodCompo") = RowDTALL.Item("CodCompo")
                                .Item("DesCompo") = RowDTALL.Item("DesCompo")
                                .Item("VarCompo") = ""
                                .Item("Qta") = 1
                                .Item("Costo") = RowDTALL.Item("Costo")
                            End With
                            dtDatiORA.Rows.Add(RowDTORA)
                            'End If

                            'OCL
                            AggiornaLbl("Caricamento OCL")
                            IdT = 0
                            For nrocl As Integer = 1 To 8

                                Dim IdTes As Integer = 0
                                Dim CodTerz As String = RowDTALL.Item("CodTerz" & nrocl)
                                Dim mrow() As DataRow = dtDatiOCL.Select("CodTerz='" & CodTerz & "'")
                                If mrow.Length > 0 Then
                                    IdTes = mrow(0).Item("ID_T")
                                Else
                                    mrow = dtDatiOCL.Select("", "ID_T desc")
                                    If mrow.Length > 0 Then
                                        IdTes = mrow(0).Item("ID_T") + 1
                                    Else
                                        IdTes = 1
                                    End If
                                End If

                                RowDTOCL = dtDatiOCL.NewRow()
                                With RowDTOCL
                                    .Item("DbGruppo") = DatiGen.DbGruppo
                                    .Item("ID_T") = IdTes
                                    .Item("CodTerz") = RowDTALL.Item("CodTerz" & nrocl)
                                    .Item("CodLavorazione") = RowDTALL.Item("LAV" & nrocl)
                                    .Item("Qta") = 1
                                    .Item("Costo") = RowDTALL.Item("CostoLav" & nrocl)
                                End With
                                dtDatiOCL.Rows.Add(RowDTOCL)
                            Next

                        Else

                            AggiornaLbl("Caricamento NOTE")
                            If UCase(CodCli) = "*NOTE*" Then
                                Dim mrow() As DataRow = dtDatiORV.Select("IDR=0 and ID_T=1")
                                Dim Inserimento As Boolean = True
                                If mrow.Length = 0 Then
                                    RowDTORV = dtDatiORV.NewRow()
                                Else
                                    Inserimento = False
                                    RowDTORV = mrow(0)
                                End If
                                With RowDTORV
                                    .Item("DbGruppo") = DatiGen.DbGruppo
                                    .Item("ID_T") = 1
                                    .Item("IDR") = 0
                                    .Item("CodCli") = CodCliTes
                                    .Item("CapoGruppo") = ""
                                    .Item("CDA") = ""
                                    .Item("CanaleVendita") = ""
                                    .Item("Codart") = ""
                                    .Item("Descrizione") = ""
                                    .Item("Variante") = ""
                                    .Item("Qta") = 0
                                    .Item("PrezzoUnit") = 0
                                    .Item("DataConsegnaRich") = ""
                                    If Inserimento Then
                                        .Item("Note") = RowDTALL.Item("CapoGruppo")
                                    Else
                                        .Item("Note") = .Item("Note") & "\n " & RowDTALL.Item("CapoGruppo")
                                    End If
                                End With
                                If Inserimento Then dtDatiORV.Rows.Add(RowDTORV)

                            End If

                        End If

                    End If
                Catch ex As Exception
                    MsgBox("errore Scrittura " & nometb & " riga " & r & " :" & ex.Message & vbCrLf & "in " & ex.StackTrace)
                End Try
            Next
            ProgressBar1.Value = Val((2 * 100) / 3)


            'dtArt.WriteXml("test.txt") 

            Try
                AggiornaLbl("Salvataggio Dati  ")

                For i As Integer = 0 To dsDest.Tables.Count - 1
                    Dim NomeTab As String = dsDest.Tables(i).TableName

                    AggiornaLbl("Salvataggio Dati in " & NomeTab)

                    Dim selectCommand As String = "SELECT * FROM " & NomeTab
                    Dim accDataAdapter As New OleDb.OleDbDataAdapter(selectCommand, accConnection)

                    Dim accCommandBuilder As New OleDb.OleDbCommandBuilder(accDataAdapter)
                    accDataAdapter.InsertCommand = accCommandBuilder.GetInsertCommand()
                    'Dim mparam As OleDb.OleDbParameterCollection = accDataAdapter.InsertCommand.Parameters
                    'For Each mpa As OleDb.OleDbParameter In mparam
                    '    Dim aaaa = mpa.SourceColumn
                    '    Dim bbb = mpa.Value
                    'Next
                    accDataAdapter.UpdateCommand = accCommandBuilder.GetUpdateCommand()
                    Try

                        accDataAdapter.Update(dsDest.Tables(i))
                    Catch ex As Exception
                        Dim mrow() As DataRow = dsDest.Tables(i).Select()
                        Dim rs As New ADODB.Recordset
                        If ConnettiAcc() Then

                            rs.Open("select * from " & NomeTab, m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                            For riga As Integer = 0 To mrow.Count - 1

                                rs.AddNew()
                                For x As Integer = 1 To dsDest.Tables(i).Columns.Count - 1
                                    Dim nomecampo As String = dsDest.Tables(i).Columns(x).ColumnName
                                    rs(nomecampo).Value = mrow(riga).Item(nomecampo)
                                Next
                                rs.Update()
                            Next
                            rs.Close()
                        End If
                        DisconnettiAcc()

                    End Try
                Next

                ' ''salvo legami forn
                ''LogWrite("SALVO LEGAMI FORN")
                ''Try

                ''    If ConnettiEs() Then
                ''        Dim rsforn As New ADODB.Recordset
                ''        rsforn.Open("SELECT Totalizzato.CodForn " & _
                ''                    "FROM Totalizzato " & _
                ''                    "GROUP BY Totalizzato.CodForn " & _
                ''                    "HAVING  Totalizzato.CodForn<>'' ", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                ''        If Not rsforn.EOF Then
                ''            Do While Not rsforn.EOF
                ''                Dim CodFornFile As String = rsforn("CodForn").Value
                ''                Dim CodFornEs As Long = 0
                ''                CodFornEs = GetCodFornEs(DatiGen.DbGruppo, CodFornFile)

                ''                Dim rsins As New ADODB.Recordset
                ''                rsins.Open("SELECT LegamiForn.DbGruppo LegamiForn.CodFornFile, LegamiForn.CodFornEs FROM LegamiForn " & _
                ''                           " where DbGruppo='" & DatiGen.DbGruppo & "' and CodFornFile='" & CodFornFile & "'", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                ''                If rsins.EOF Then
                ''                    rsins.AddNew()
                ''                    rsins("DbGruppo").Value = DatiGen.DbGruppo
                ''                    rsins("CodFornFile").Value = CodFornFile
                ''                Else
                ''                    rsins.Update()
                ''                End If

                ''                rsins("CodFornEs").Value = CodFornEs
                ''                rsins.Update()


                ''                LogWrite("LEGAMI FORN " & CodFornFile & " -->" & CodFornEs)
                ''                rsins.Close()


                ''                rsforn.MoveNext()
                ''            Loop
                ''        End If
                ''    End If
                ''    DisconnettiEs()

                ''Catch ex As Exception
                ''    MsgBox("Errore SALVATAGGIO LEGAMI FORNITORI : " & ex.Message, MsgBoxStyle.Critical, "Lettura file")
                ''    LogWrite("SALVATAGGIO LEGAMI FORNITORI file error " & ex.Message & " In " & ex.StackTrace)
                ''    LeggiExcel = False
                ''End Try
                ProgressBar1.Value = 100



            Catch ex As Exception

                MsgBox("Errore " & ex.Message, MsgBoxStyle.Critical, "Lettura file")
                LogWrite("Lettura file error " & ex.Message & " In " & ex.StackTrace)

                LeggiExcel = False
            End Try


        Catch ex As Exception
            LeggiExcel = False
            MsgBox("Errore " & ex.Message, MsgBoxStyle.Critical, "Lettura  Excel ")
            LogWrite("Lettura file error " & ex.Message & " In " & ex.StackTrace)
        End Try
        Cursor = Cursors.Default

    End Function

    Private Function GetCodFornEs(ByVal DbGruppo As String, ByVal CodFornAlternativo As String) As Long
        GetCodFornEs = 0
        Dim rs As New ADODB.Recordset
        rs.Open("Select CodCliFor,CodAlternativo  from ClientiFornitori inner join AnagrGenCliFor " & _
                " on ClientiFornitori.IdAnagGen =AnagrGenCliFor .IdAnagGen " & _
                "where DBGruppo ='" & DbGruppo & "' and TipoAnagrafica =2 and CodAlternativo='" & CodFornAlternativo & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            GetCodFornEs = rs("CodCliFor").Value
        End If
        rs.Close()
        rs = Nothing

    End Function

    Public Function SalvaCommessa(ByVal DbGruppo As String, ByVal CodCdA As String, ByVal CodCommessa As String, ByVal CodCliEsterno As String) As Boolean
        Try
            SalvaCommessa = True
            If ConnettiEs() Then


                Dim rs As New ADODB.Recordset
                Dim CodCli As Long = 0
                If Trim(CodCliEsterno) <> "" Then
                    rs.Open("select CodCliForEsolver  from CliForLegami where dbgruppo='" & DbGruppo & "' and TipoAnagrafica =1 and CodCliForEsterno ='" & CodCliEsterno & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    If Not rs.EOF Then
                        CodCli = NoNull(rs("CodCliForEsolver"))
                    End If
                    rs.Close()
                    rs = Nothing
                End If

                rs = New ADODB.Recordset

                rs.Open("Select * from CommesseSottocomAn where DbGruppo='" & DbGruppo & "' and  " & _
                        "CodCommessa ='" & CodCommessa & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If rs.EOF Then
                    rs.AddNew()
                    rs("DbGruppo").Value = DbGruppo
                    rs("CodCommessa").Value = CodCommessa
                    rs("CodSottocommessa").Value = ""
                    rs("Descrizione").Value = CodCommessa
                    rs("DataInizio").Value = "01/01/1800"
                    rs("DataFinePrevista").Value = "01/01/1800"
                    rs("GestFasi").Value = 0
                    rs("FasiAmmesse").Value = 0
                    rs("CodCliFor").Value = CodCli ' 0 'modifica richiesta da RC 24/06/22
                    rs("RicercaAlternativa").Value = ""
                    rs("UnitaMisura").Value = ""
                    rs("CodRaggrClasse1").Value = ""
                    rs("CodRaggrClasse2").Value = ""
                    rs("CodRaggrClasse3").Value = ""
                    rs("CodCentroImputazione").Value = 0
                    rs("CodDivisione").Value = 0
                    rs("CodCdAAssegnazione").Value = CodCdA
                    rs("SituazioneCentro").Value = 0
                    rs("GestSottocommesse").Value = 0
                    rs("RagSoc1").Value = ""
                    rs("RagSoc2").Value = ""
                    rs("Presso").Value = ""
                    rs("IndirDiSpedizione").Value = ""
                    rs("Indir2DiSpedizione").Value = ""
                    rs("Cap").Value = ""
                    rs("LocalitaDiSpediz").Value = ""
                    rs("Localita2DiSpediz").Value = ""
                    rs("ProvDiSpedizione").Value = ""
                    rs("CodStato").Value = ""
                    rs("NumTel").Value = ""
                    rs("NumTel2").Value = ""
                    rs("NumFax").Value = ""
                    rs("IndirEmail").Value = ""
                    rs("CodArea").Value = ""
                    rs("DataChiusura").Value = "01/01/1800"
                    rs("CodRespPrimoLiv").Value = ""
                    rs("CodRespSecondoLiv").Value = ""
                    rs("GestPianifAttivita").Value = 0
                    rs("WsInUso").Value = ""
                    rs("FirmaCreazData").Value = Format(Now.Date, "yyyy-MM-dd")
                    rs("FirmaCreazOra").Value = Format(TimeOfDay, "HHmmss")
                    rs("FirmaCreazStazione").Value = DatiGen.WSP
                    rs("FirmaCreazOperatore").Value = DatiGen.Operatore
                    rs("FirmaUltVarData").Value = Format(Now.Date, "yyyy-MM-dd")
                    rs("FirmaUltVarOra").Value = Format(TimeOfDay, "HHmmss")
                    rs("FirmaUltVarStazione").Value = DatiGen.WSP
                    rs("FirmaUltVarOperatore").Value = DatiGen.Operatore
                    rs("Annotazione").Value = ""
                    'rs("OldCommFatturabile").Value = 0
                    rs("CodCondizPagamento").Value = ""
                    rs("FattPrestazioni").Value = 0
                    rs("DataApertura").Value = "01/01/1800"
                    rs("TipoSchedaTecnComm").Value = ""
                    rs("GestDocumentazione").Value = 0
                    rs("CodIndirizzoCli").Value = 0
                    rs("LegameCentro").Value = 1
                    rs("CodTracciabFinanz").Value = 0
                    rs("IdAnagGen").Value = 0
                    rs("CodCdAErogante").Value = ""
                    rs("DesEstesa").Value = ""
                    'rs("aolescludianagrcar").Value = 0  



                    rs.Update()

                End If
                rs.Close()
                rs = Nothing
            End If
            DisconnettiEs()
        Catch ex As Exception
            SalvaCommessa = False
            'MsgBox("Salva commessa " & CodCommessa & " - " & CodSottoComm & " Errore :" & ex.Message & " in " & ex.StackTrace)
            LogWrite("Salva commessa " & CodCommessa & " - " & CodCdA & " Errore :" & ex.Message & " in " & ex.StackTrace)
        End Try
    End Function


    Private Function LeggiExcel_App(ByVal NomeFile As String) As Boolean
        'Try
        '    LeggiExcel_App = True
        '    AggiornaLbl("Lettura file excel " & NomeFile)
        '    Cursor = Cursors.WaitCursor
        '    Dim xlApp As Excel.Application
        '    Dim xlWorkBook As Excel.Workbook
        '    Dim xlWorkSheet As Excel.Worksheet
        '    Dim misValue As Object = System.Reflection.Missing.Value

        '    xlApp = New Excel.ApplicationClass
        '    xlWorkBook = xlApp.Workbooks.Open(NomeFile)
        '    xlWorkSheet = xlWorkBook.Worksheets(1)
        '    ' xlWorkBook = xlApp.Workbooks.Add(misValue)
        '    ' xlWorkSheet = xlWorkBook.Sheets.Add()

        '    Dim rs As New ADODB.Recordset

        '    Dim NrOrd As String = ""
        '    Dim codcli As Long = 0
        '    Dim DataOrd As String = ""
        '    Dim CondPag As String = ""
        '    Dim Iban As String = ""
        '    Dim CodArt As String = ""
        '    Dim DescArt As String = ""
        '    Dim Qta As Double = 0
        '    Dim Prezzo As Double = 0
        '    Dim Importo As Double = 0
        '    Dim SpeseTrasp As Double = 0

        '    Dim m_Listini As New TP_Listini

        '    Dim msgError As String = ""


        '    Dim mperc As Double = 0

        '    Dim TotRow As Integer = xlWorkSheet.UsedRange.Rows.Count 'xlWorkSheet.Rows.Count 


        '    NrOrd = CStr(xlWorkSheet.Cells(2, 3).value)
        '    NrOrd = Trim(Mid(NrOrd, InStr(NrOrd, ".") + 1, Len(NrOrd)))
        '    DataOrd = CStr(xlWorkSheet.Cells(3, 4).value)
        '    If DataOrd = "" Then DataOrd = Format(Now.Date, "dd/MM/yyyy")
        '    codcli = CInt(xlWorkSheet.Cells(4, 4).value)
        '    CondPag = CStr(xlWorkSheet.Cells(16, 1).value)
        '    Iban = CStr(xlWorkSheet.Cells(18, 3).value)

        '    If EsisteCodPart(codcli, "C") Then
        '        Dim nrR As Integer = 0
        '        For Each mrow As Excel.Range In xlWorkSheet.UsedRange.Rows
        '            nrR = mrow.Row
        '            If nrR > 20 Then
        '                CodArt = ""
        '                DescArt = ""
        '                Qta = 0
        '                Prezzo = 0
        '                Importo = 0

        '                DescArt = CStr(xlWorkSheet.Cells(nrR, 1).value)
        '                CodArt = Replace(CStr(xlWorkSheet.Cells(nrR, 2).value), ".", "")
        '                Qta = CDbl(xlWorkSheet.Cells(nrR, 3).value)
        '                Prezzo = CDbl(xlWorkSheet.Cells(nrR, 4).value)
        '                Importo = CDbl(xlWorkSheet.Cells(nrR, 5).value)

        '                If UCase(DescArt) Like "SPESE DI TRASP*" Or UCase(DescArt) Like "SHIPPING*" Then
        '                    CodArt = ""
        '                    DescArt = ""
        '                    Qta = 0
        '                    Prezzo = 0
        '                    Importo = 0
        '                    SpeseTrasp = CDbl(xlWorkSheet.Cells(nrR, 2).value)
        '                    m_ConnAcc.Execute("Update ImpFile set SpeseTrasp=" & SpeseTrasp & " where nrord='" & NrOrd & "'")
        '                    Exit For
        '                End If

        '                If Qta <> 0 And CodArt <> "" Then

        '                    If DatiGen.CodArtCntrlDispo <> "" Then
        '                        Dim appocod() As String = Split(DatiGen.CodArtCntrlDispo, ";")
        '                        Dim ControllaDispo As Boolean = False
        '                        If Not appocod Is Nothing Then
        '                            For i As Integer = 0 To appocod.Length - 1
        '                                If UCase(CodArt) = UCase(appocod(i)) Then
        '                                    ControllaDispo = True
        '                                    Exit For
        '                                End If
        '                            Next
        '                        End If
        '                        If ControllaDispo Then

        '                            LogWrite("ARTICOLO " & CodArt & " - CONTROLLO DISPO")
        '                            Dim NrArt As Integer = 0
        '                            Dim Articoli() As String
        '                            Dim Dispo() As Double
        '                            Dim Scorta() As Double
        '                            Dim QtaOrd() As Double

        '                            ReDim Preserve Articoli(NrArt)
        '                            ReDim Preserve Dispo(NrArt)
        '                            ReDim Preserve Scorta(NrArt)
        '                            ReDim Preserve QtaOrd(NrArt)

        '                            Articoli(NrArt) = CodArt
        '                            Dim giacdisp As Double = 0
        '                            Dim scortaArt As Double = 0
        '                            Dim QtaDaOrd As Double = 0
        '                            Dim QtaRimane As Double = 0
        '                            'Dispo(NrArt)
        '                            giacdisp = GetDispoArt(DatiGen.DbGruppo, CodArt)
        '                            'Scorta(NrArt) 
        '                            scortaArt = GetScortaArt(DatiGen.DbGruppo, CodArt)


        '                            LogWrite("ARTICOLO " & CodArt & " - GIACENZA DISPO: " & giacdisp & " SCORTA : " & scortaArt & " QTA ORD:" & Qta)

        '                            giacdisp = giacdisp - scortaArt ' Qta

        '                            Dispo(NrArt) = giacdisp
        '                            Scorta(NrArt) = scortaArt

        '                            If giacdisp < Qta Then
        '                                LogWrite("ARTICOLO " & CodArt & " -   DISPO: " & giacdisp & "(GIAC-SCORTA) INFERIORE ALLA SCORTA : " & scortaArt)

        '                                If giacdisp > 0 Then
        '                                    QtaDaOrd = giacdisp 'scortaArt - giacdisp
        '                                    QtaRimane = Qta - QtaDaOrd
        '                                Else
        '                                    QtaDaOrd = 0
        '                                    QtaRimane = Qta
        '                                End If

        '                                LogWrite("ARTICOLO " & CodArt & " - QTA DA ORDINARE : " & QtaDaOrd & "(SCORTA-DISPO)  QTA RIMANENTE : " & QtaRimane & "(QTA-QTA DA ORD)")
        '                                QtaOrd(NrArt) = QtaDaOrd

        '                                If QtaRimane > 0 Then
        '                                    Dim DispoOk As Boolean = False
        '                                    Dim EsisteartColl As Boolean = True
        '                                    Dim ArtPrinc As String = Articoli(NrArt)

        '                                    LogWrite("ARTICOLO " & CodArt & " - QTA RIMANENTE : " & QtaRimane & " CONTROLLO ARTICOLI COLLEGATI ")
        '                                    Do While Not DispoOk And EsisteartColl = True
        '                                        Dim ArtCollegato As String
        '                                        ArtCollegato = GetArtCollegato(DatiGen.DbGruppo, ArtPrinc)

        '                                        LogWrite("ARTICOLO " & ArtPrinc & " - ART COLLEGATO:" & ArtCollegato)
        '                                        If ArtCollegato <> "" Then
        '                                            NrArt += 1
        '                                            ReDim Preserve Articoli(NrArt)
        '                                            ReDim Preserve Dispo(NrArt)
        '                                            ReDim Preserve Scorta(NrArt)
        '                                            ReDim Preserve QtaOrd(NrArt)

        '                                            Articoli(NrArt) = ArtCollegato
        '                                            'Dispo(NrArt) = GetDispoArt(DatiGen.DbGruppo, ArtCollegato)
        '                                            'Scorta(NrArt) = GetScortaArt(DatiGen.DbGruppo, ArtCollegato)

        '                                            giacdisp = 0
        '                                            scortaArt = 0
        '                                            giacdisp = GetDispoArt(DatiGen.DbGruppo, ArtCollegato)
        '                                            scortaArt = GetScortaArt(DatiGen.DbGruppo, ArtCollegato)
        '                                            LogWrite("ARTICOLO " & ArtCollegato & " - GIACENZA DISPO: " & giacdisp & " SCORTA : " & scortaArt & " QTA ORD:" & QtaRimane)
        '                                            giacdisp = giacdisp - scortaArt ' QtaRimane

        '                                            Dispo(NrArt) = giacdisp
        '                                            Scorta(NrArt) = scortaArt

        '                                            If giacdisp < QtaRimane Then 'scortaArt Then
        '                                                LogWrite("ARTICOLO " & ArtCollegato & " -   DISPO: " & giacdisp & "(GIAC-QTA) INFERIORE ALLA SCORTA : " & scortaArt)
        '                                                If giacdisp > 0 Then
        '                                                    QtaDaOrd = giacdisp 'scortaArt - giacdisp
        '                                                    QtaRimane = QtaRimane - QtaDaOrd
        '                                                Else
        '                                                    QtaDaOrd = 0
        '                                                    QtaRimane = QtaRimane
        '                                                End If
        '                                            Else
        '                                                LogWrite("ARTICOLO " & ArtCollegato & " -   DISPO: " & giacdisp & "(GIAC-QTA) MAGGIORE ALLA SCORTA : " & scortaArt)
        '                                                QtaDaOrd = QtaRimane
        '                                                QtaRimane = 0
        '                                            End If
        '                                            LogWrite("ARTICOLO " & ArtCollegato & " - QTA DA ORDINARE : " & QtaDaOrd & "(SCORTA-DISPO) QTA RIMANENTE : " & QtaRimane & "(QTA-QTA DA ORD)")

        '                                            QtaOrd(NrArt) = QtaDaOrd

        '                                            If QtaRimane = 0 Then
        '                                                DispoOk = True
        '                                                LogWrite("ARTICOLO " & ArtCollegato & " - QTA SUFFICENTE")

        '                                            Else
        '                                                ArtPrinc = ArtCollegato
        '                                                DispoOk = False
        '                                            End If
        '                                        Else
        '                                            LogWrite("ARTICOLO " & ArtCollegato & " - NON CI SONO ARTICOLI COLLEGATI")
        '                                            EsisteartColl = False
        '                                            Exit Do
        '                                        End If
        '                                    Loop

        '                                End If
        '                                If QtaRimane > 0 Then
        '                                    LogWrite("DISPO NON SUFFICIENTI :  prendo quello con dispo maggiore")
        '                                    'non basta prendo quello con dispo maggiore
        '                                    If Articoli.Length > 1 Then
        '                                        Dim DispoMax As Double = 0
        '                                        Dim IndOk As Integer = 0
        '                                        For i As Integer = 0 To Articoli.Length - 1
        '                                            If Dispo(i) > DispoMax Then
        '                                                DispoMax = Dispo(i)
        '                                                IndOk = i
        '                                            End If
        '                                        Next
        '                                        If DispoMax > 0 Then
        '                                            CodArt = Articoli(IndOk)
        '                                            QtaOrd(IndOk) = QtaOrd(IndOk) + QtaRimane
        '                                        Else
        '                                            CodArt = Articoli(0)
        '                                            QtaOrd(0) = QtaOrd(0) + QtaRimane
        '                                            'codice articolo originale
        '                                        End If
        '                                    End If
        '                                    LogWrite("ARTICOLO : " & CodArt & " QTA : " & Qta)
        '                                    'DescArt = GetDescArt(DatiGen.DbGruppo, CodArt)
        '                                    'SalvaRiga(codcli, CodArt, nrR, NrOrd, DataOrd, CondPag, Iban, DescArt, Qta, Prezzo, Importo)
        '                                End If
        '                                LogWrite("INSERISCO RIGHE ARTICOLI")
        '                                'inserisco nrighe
        '                                If Articoli.Length > 1 Then
        '                                    Dim DispoMax As Double = 0
        '                                    Dim IndOk As Integer = 0
        '                                    For i As Integer = 0 To Articoli.Length - 1
        '                                        If QtaOrd(i) > 0 Then
        '                                            LogWrite("ARTICOLO : " & Articoli(i) & " QTA : " & QtaOrd(i))
        '                                            DescArt = GetDescArt(DatiGen.DbGruppo, Articoli(i))
        '                                            SalvaRiga(codcli, Articoli(i), nrR + (i * 0.01), NrOrd, DataOrd, CondPag, Iban, DescArt, QtaOrd(i), Prezzo, Importo)
        '                                        End If
        '                                    Next
        '                                End If
        '                                '  End If
        '                            Else

        '                                LogWrite("ARTICOLO : " & CodArt & " DISPO SUFFICIENTE ")
        '                                QtaDaOrd = Qta
        '                                QtaRimane = 0
        '                                QtaOrd(NrArt) = QtaDaOrd
        '                                LogWrite("ARTICOLO : " & CodArt & " QTA : " & Qta)
        '                                DescArt = GetDescArt(DatiGen.DbGruppo, CodArt)
        '                                SalvaRiga(codcli, CodArt, nrR, NrOrd, DataOrd, CondPag, Iban, DescArt, Qta, Prezzo, Importo)
        '                            End If
        '                            '1000:
        '                            '400:
        '                            '800:
        '                            'Se  Dispo - Qta < Scorta  1000-400<800
        '                            'QtaOrd = Scorta - (Dispo - Qta) 800 - (1000-400) = 200
        '                            'qtarimane = Qta - qtaord ( 400 - 200 )


        '                            '-----VECCHIA LOGICA ------------
        '                            'If Dispo(NrArt) <= Scorta(NrArt) Then
        '                            '    Dim DispoOk As Boolean = False
        '                            '    Dim EsisteartColl As Boolean = True
        '                            '    Dim ArtPrinc As String = Articoli(NrArt)

        '                            '    Do While Not DispoOk And EsisteartColl = True
        '                            '        Dim ArtCollegato As String
        '                            '        ArtCollegato = GetArtCollegato(DatiGen.DbGruppo, ArtPrinc)
        '                            '        If ArtCollegato <> "" Then
        '                            '            NrArt += 1
        '                            '            ReDim Preserve Articoli(NrArt)
        '                            '            ReDim Preserve Dispo(NrArt)
        '                            '            ReDim Preserve Scorta(NrArt)

        '                            '            Articoli(NrArt) = ArtCollegato
        '                            '            Dispo(NrArt) = GetDispoArt(DatiGen.DbGruppo, ArtCollegato)
        '                            '            Scorta(NrArt) = GetScortaArt(DatiGen.DbGruppo, ArtCollegato)
        '                            '            If Dispo(NrArt) <= Scorta(NrArt) Then
        '                            '                ArtPrinc = ArtCollegato
        '                            '                DispoOk = False
        '                            '            Else
        '                            '                DispoOk = True
        '                            '            End If
        '                            '        Else
        '                            '            EsisteartColl = False
        '                            '            Exit Do
        '                            '        End If
        '                            '    Loop

        '                            '    If DispoOk Then
        '                            '        CodArt = ArtPrinc
        '                            '    Else
        '                            '        If Articoli.Length > 1 Then
        '                            '            Dim DispoMax As Double = 0
        '                            '            Dim IndOk As Integer = 0
        '                            '            For i As Integer = 0 To Articoli.Length - 1
        '                            '                If Dispo(i) > DispoMax Then
        '                            '                    DispoMax = Dispo(i)
        '                            '                    IndOk = i
        '                            '                End If
        '                            '            Next
        '                            '            If DispoMax > 0 Then
        '                            '                CodArt = Articoli(IndOk)
        '                            '            Else
        '                            '                'codice articolo originale
        '                            '            End If
        '                            '        End If
        '                            '    End If
        '                            'End If
        '                            '-----FINE VECCHIA LOGICA ------------

        '                            'DescArt = GetDescArt(DatiGen.DbGruppo, CodArt) 
        '                        Else
        '                            LogWrite("ARTICOLO : " & CodArt & " QTA : " & Qta)
        '                            SalvaRiga(codcli, CodArt, nrR, NrOrd, DataOrd, CondPag, Iban, DescArt, Qta, Prezzo, Importo)
        '                        End If
        '                    Else
        '                        LogWrite("ARTICOLO : " & CodArt & " QTA : " & Qta)
        '                        SalvaRiga(codcli, CodArt, nrR, NrOrd, DataOrd, CondPag, Iban, DescArt, Qta, Prezzo, Importo)
        '                    End If



        '                    'm_Listini = GetDatiListini(codcli, DatiGen.DbGruppo, 0, CodArt, "")

        '                    ''if codart = articolo parametrizzato (A) controllo la giacenza - impegnato = DISPONIBILE GIACDISP vista ESV_SITART_AVM
        '                    ''la scorta da ESV_SCMIN_AVMA ( NO ARTSCORTAMINIMA)
        '                    ''se disponibile<=scortaminima controllo l'articolo sostituitivo (B) (ARTCOLLEGATI)
        '                    '' se artsostituitivo (B) è disponibile prendo quello
        '                    ''se no vedo se B ha artsostituitvo C e controllo quello.
        '                    ''Se nessuno è disponibile prendo quello con Dispo maggiore

        '                    'rs.Open("Select * from impfile where id=0", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        '                    'rs.AddNew()
        '                    'rs("DbGruppo").Value = DatiGen.DbGruppo
        '                    'rs("IdReg").Value = nrR
        '                    'rs("DataReg").Value = Format(Now.Date, "dd/MM/yyyy")
        '                    'rs("NrOrd").Value = NrOrd
        '                    'rs("DataOrd").Value = DataOrd
        '                    'rs("CodCli").Value = codcli
        '                    'rs("CondPag").Value = CondPag
        '                    'rs("Iban").Value = Iban
        '                    'rs("CodArt").Value = CodArt
        '                    'rs("DescArt").Value = DescArt
        '                    'rs("Qta").Value = Qta
        '                    'rs("Prezzo").Value = Prezzo
        '                    'rs("Importo").Value = Importo
        '                    'rs("TipoList").Value = m_Listini.Rig_Tipo
        '                    'rs("CodList").Value = m_Listini.Rig_Codice

        '                    'rs.Update()
        '                    'rs.Close()
        '                End If
        '                'End If 
        '                mperc = Val((nrR * 100) / TotRow)
        '                If mperc > ProgressBar1.Maximum Then
        '                    mperc = ProgressBar1.Maximum
        '                End If
        '                ProgressBar1.Value = mperc
        '                'End If  
        '            End If
        '        Next
        '    Else
        '        MsgBox("Cliente " & codcli & " non Trovato!", MsgBoxStyle.Critical, "Lettura file xls")
        '        LeggiExcel_App = False
        '    End If
        '    xlWorkBook.Close(False)
        '    xlApp.Quit()

        '    releaseObject(xlApp)
        '    releaseObject(xlWorkBook)
        '    releaseObject(xlWorkSheet)

        '    'If msgError <> "" Then
        '    '    MsgBox("ATTENZIONE RISCONTRATI ERRORI NEL FILE, L'IMPORTAZIONE NON VERRA' ESEGUITA" & vbCrLf & msgError)
        '    '    m_ConnEs.Execute("truncate TABLE xs1r_ImpFileFatt")
        '    '    LogWrite("ERRORE FILE " & NomeFile & " :" & vbCrLf & msgError)
        '    '    LeggiExcel = False
        '    'End If

        'Catch ex As Exception
        '    LeggiExcel_App = False
        '    MsgBox("Errore " & ex.Message, MsgBoxStyle.Critical, "Lettura  Excel ")
        'End Try
        'Cursor = Cursors.Default
    End Function
    Private Function SalvaRiga(ByVal CodCli As Long, ByVal CodArt As String, ByVal NrR As Integer, ByVal NrOrd As String, ByVal DataOrd As String, ByVal CondPag As String, _
                               ByVal Iban As String, ByVal DescArt As String, ByVal Qta As Double, ByVal Prezzo As Double, ByVal Importo As Double) As Boolean
        '  Try
        SalvaRiga = True
        Dim m_Listini As New TP_Listini
        m_Listini = GetDatiListini(CodCli, DatiGen.DbGruppo, 0, CodArt, "")

        Dim rs As New ADODB.Recordset
        'if codart = articolo parametrizzato (A) controllo la giacenza - impegnato = DISPONIBILE GIACDISP vista ESV_SITART_AVM
        'la scorta da ESV_SCMIN_AVMA ( NO ARTSCORTAMINIMA)
        'se disponibile<=scortaminima controllo l'articolo sostituitivo (B) (ARTCOLLEGATI)
        ' se artsostituitivo (B) è disponibile prendo quello
        'se no vedo se B ha artsostituitvo C e controllo quello.
        'Se nessuno è disponibile prendo quello con Dispo maggiore

        rs.Open("Select * from impfile where id=0", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs("DbGruppo").Value = DatiGen.DbGruppo
        rs("IdReg").Value = NrR
        rs("DataReg").Value = Format(Now.Date, "dd/MM/yyyy")
        rs("NrOrd").Value = NrOrd
        rs("DataOrd").Value = DataOrd
        rs("CodCli").Value = CodCli
        rs("CondPag").Value = CondPag
        rs("Iban").Value = Iban
        rs("CodArt").Value = CodArt
        rs("DescArt").Value = DescArt
        rs("Qta").Value = Qta
        rs("Prezzo").Value = Prezzo
        rs("Importo").Value = Importo
        rs("TipoList").Value = m_Listini.Rig_Tipo
        rs("CodList").Value = m_Listini.Rig_Codice

        rs.Update()
        rs.Close()
        rs = Nothing
        'Catch ex As Exception
        '    SalvaRiga = False = False
        '    MsgBox("Errore " & ex.Message, MsgBoxStyle.Critical, "Lettura  Excel ")
        'End Try
    End Function

    Private Function GetDatiListini(ByVal Codcli As Long, ByVal Gruppo As String, _
                                    ByVal NumProgInd As Integer, ByVal CodArt As String, _
                                    ByVal VarArt As String) As TP_Listini


        Dim m_list As New TP_Listini

        If ConnettiEs() Then
            Dim rs As New ADODB.Recordset
            With m_list
                ' .Ord_Codice = ""
                '.Ord_Tipo = 1
                '.Prior_Codice = ""
                '.Prior_Tipo = 1
                '.Prior_DataRif = Now.Date
                .Rig_Codice = ""
                '.Rig_DataRif = Now.Date
                .Rig_Tipo = ""
                '.List_UM = ""
            End With

            Dim strsql As String = ""
            Dim GestCondComm As Integer = GetGestConComm(Codcli, Gruppo)
            If (GestCondComm = 2 And NumProgInd = 0) Or GestCondComm = 0 Then
                strsql = "Select ClasseListinoPrior, CodListinoPrior, ClasseListinoOrdin, CodListinoOrdin " & _
                   " from xs1r_GestConCommCli where dbgruppo='" & Gruppo & _
                       "' and tipoanagrafica=1 and CodCliFor=" & Codcli & " and NumProgrCondizComm=0 "
            ElseIf GestCondComm = 2 Then
                strsql = "Select * from xs1r_GestConCommCli " & _
                "WHERE (xs1r_GestConCommCli.DBGruppo = '" & Gruppo & "') and " & _
                " xs1r_GestConCommCli.TipoAnagrafica=1 and " & _
                " xs1r_GestConCommCli.CodCliFor =" & Codcli & " " & _
                " and ISNULL(xs1r_GestConCommCli.NumProgrind ,0) =  " & NumProgInd
            ElseIf GestCondComm = 1 Then
                strsql = "Select * from xs1r_GestConCommCli " & _
                "WHERE (xs1r_GestConCommCli.DBGruppo = '" & Gruppo & "') and " & _
                " xs1r_GestConCommCli.TipoAnagrafica=1 and " & _
                " xs1r_GestConCommCli.CodCliFor =" & Codcli & " " & _
                " and ISNULL(xs1r_GestConCommCli.NumProgrind ,0) =  0 "
            End If
            rs.Open(strsql, m_ConnEs)
            Application.DoEvents()
            If Not rs.EOF Then
                With m_list
                    '.Ord_Codice = rs.Fields("CodListinoOrdin").Value
                    '.Ord_Tipo = rs.Fields("ClasseListinoOrdin").Value
                    '.Prior_Codice = rs.Fields("CodListinoPrior").Value
                    '.Prior_Tipo = rs.Fields("ClasseListinoPrior").Value
                    '.Prior_DataRif = Now.Date
                    '.List_UM = ""
                    Dim Um As String = ""
                    If CodArt <> "" Then
                        'Provo prima listino cliente
                        Dim CodLisCli As String = ""
                        If EsisteList(CodArt, VarArt, Codcli, 0, 3, Gruppo, CodLisCli) Then
                            If CodLisCli = "" Then CodLisCli = "0"
                            .Rig_Codice = CodLisCli
                            '.Rig_DataRif = Now.Date
                            .Rig_Tipo = 3
                            '.List_UM = GetUmListino(CodArt, VarArt, Codcli, CodLisCli, 3, Gruppo)
                            'poi provo il prioritario
                        ElseIf EsisteList(CodArt, VarArt, Codcli, rs.Fields("CodListinoPrior").Value, rs.Fields("ClasseListinoPrior").Value, Gruppo, CodLisCli) Then
                            If rs.Fields("ClasseListinoPrior").Value = 3 Then
                                If NoNull(rs.Fields("CodListinoPrior")) = "" Then
                                    If CodLisCli = "" Then CodLisCli = "0"
                                    .Rig_Codice = CodLisCli
                                Else
                                    .Rig_Codice = NoNull(rs.Fields("CodListinoPrior"))
                                End If
                            Else
                                .Rig_Codice = rs.Fields("CodListinoPrior").Value
                            End If
                            '.Rig_DataRif = Now.Date
                            .Rig_Tipo = rs.Fields("ClasseListinoPrior").Value
                            '.List_UM = GetUmListino(CodArt, VarArt, Codcli, rs.Fields("CodListinoPrior").Value, rs.Fields("ClasseListinoPrior").Value, Gruppo)
                        Else
                            .Rig_Codice = rs.Fields("CodListinoOrdin").Value
                            '  .Rig_DataRif = Now.Date
                            .Rig_Tipo = rs.Fields("ClasseListinoOrdin").Value
                            '.List_UM = GetUmListino(CodArt, VarArt, Codcli, rs.Fields("CodListinoOrdin").Value, rs.Fields("ClasseListinoOrdin").Value, Gruppo)
                        End If
                    End If
                    'If .Ord_Tipo = 0 Then .Ord_Tipo = 3
                    'If .Prior_Tipo = 0 Then .Prior_Tipo = 3

                End With
            End If
            rs.Close()
            rs = Nothing
        End If
        DisconnettiEs()
        Return m_list
    End Function

    Private Function EsisteList(ByVal Codart As String, ByVal VarArt As String, _
                               ByVal CodCli As Long, ByVal CodList As String, _
                               ByVal TipoList As Integer, ByVal Gruppo As String, ByRef CodLisCli As String) As Boolean
        EsisteList = False
        Dim rs As New ADODB.Recordset
        Dim StrSql As String
        StrSql = "Select * from xs1r_Listini where dbgruppo='" & Gruppo & _
        "' and codart='" & Codart & "' and classelistino=" & TipoList & " "
        If GestVarListini(Codart, Gruppo) Then
            StrSql = StrSql & " and VarianteArt='" & VarArt & "'"
        End If
        If TipoList = 3 Then
            StrSql = StrSql & " and CodClifor=" & CodCli
        Else
            StrSql = StrSql & "  and codlistino='" & CodList & "'"
        End If
        rs.Open(StrSql, m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
        If Not rs.EOF Then
            EsisteList = True
            CodLisCli = rs("codlistino").Value
        End If
        rs.Close()
        rs = Nothing
    End Function
    Private Function GestVarListini(ByVal Codart As String, ByVal Gruppo As String) As Boolean
        Dim rs As New ADODB.Recordset
        GestVarListini = False
        rs.Open("select TipoConfigListino  from ArtAnagrafica where DBGruppo='" & Gruppo & "' and  CodArt='" & Codart & "' ", m_ConnEs)
        If Not rs.EOF Then
            GestVarListini = rs("TipoConfigListino").Value = 1
        End If
        rs.Close()
    End Function
    Private Function GetGestConComm(ByVal CodCli As Long, ByVal Gruppo As String) As Integer
        Dim rs As New ADODB.Recordset
        GetGestConComm = 0
        rs.Open("Select GestCondCommerciali from ClientiFornitori where dbgruppo='" & Gruppo & "' and tipoanagrafica=1 and codclifor=" & CodCli, m_ConnEs)
        If Not rs.EOF Then
            GetGestConComm = Val(rs("GestCondCommerciali").Value)
        End If
        rs.Close()
    End Function
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub GetDatiCli(ByVal CodFiscale As String, ByVal DbGruppo As String, ByRef CodCli As String, ByRef CodPag As String)
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT AnagrGenCliFor.IdAnagGen, AnagrGenCliFor.PartitaIva, " & _
                " AnagrGenCliFor.CodFiscale, ClientiFornitori.CodCliFor, CliForCondizioniComm.NumProgrCondizComm, " & _
                "CliForCondizioniComm.CodCondizPagamento, ClientiFornitori.DBGruppo " & _
                "FROM         AnagrGenCliFor INNER JOIN " & _
                " ClientiFornitori ON AnagrGenCliFor.IdAnagGen = ClientiFornitori.IdAnagGen INNER JOIN " & _
                "CliForCondizioniComm ON ClientiFornitori.DBGruppo = CliForCondizioniComm.DBGruppo AND  " & _
                "ClientiFornitori.TipoAnagrafica = CliForCondizioniComm.TipoAnagrafica And  " & _
                "ClientiFornitori.CodCliFor = CliForCondizioniComm.CodCliFor " & _
                "WHERE     (CliForCondizioniComm.NumProgrCondizComm = 0) AND  " & _
                "(ClientiFornitori.DBGruppo = '" & DbGruppo & "') " & _
                " AND ((AnagrGenCliFor.CodFiscale = '" & CodFiscale & "') OR " & _
                "(AnagrGenCliFor.PartitaIva = '" & CodFiscale & "'))", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
        Application.DoEvents()
        If Not rs.EOF Then
            rs.MoveFirst()
            CodCli = NoNull(rs.Fields("CodCliFor"))
            CodPag = NoNull(rs.Fields("CodCondizPagamento"))
        End If
        rs.Close()
        rs = Nothing


    End Sub

    Private Function GetCommessa(ByVal CodSottoComm As String, ByVal DbGruppo As String) As String
        Dim rs As New ADODB.Recordset
        GetCommessa = ""
        rs.Open("SELECT  DBGruppo ,CodCommessa , CodSottocommessa " & _
                " From CommesseSottocomAn " & _
                " WHERE DBGruppo = '" & DbGruppo & "' " & _
                " AND  CodSottocommessa= '" & CodSottoComm & "' ", m_ConnEs, ADODB.CursorTypeEnum.adOpenForwardOnly)
        Application.DoEvents()
        If Not rs.EOF Then
            rs.MoveFirst()
            GetCommessa = NoNull(rs.Fields("CodCommessa"))
        End If
        rs.Close()
        rs = Nothing


    End Function

    Private Function GetGruppoAzi(ByVal CodAzi As String) As String
        Dim MGruppo As String = ""
        GetGruppoAzi = ""
        Dim mrow() As Data.DataRow = ds.Tables("Aziende").Select("codice='" & CodAzi & "'")
        If mrow.Length > 0 Then
            MGruppo = mrow(0).Item("Gruppo")
        End If
        GetGruppoAzi = MGruppo

    End Function



    Private Sub AllegaFileEs_Doc(ByVal Iddoc As Long, ByVal FileAtt As String, ByVal DbGruppo As String)
        Try 

            LogWrite("ALLEGA FILE " & FileAtt & " IDDOC  " & Iddoc)

            Dim rs As New ADODB.Recordset

            Dim NewPath As String = System.IO.Path.GetDirectoryName(FileAtt) & "\" ' DatiGen.PathConfES & "\FileContab\"
            Dim FileName As String = System.IO.Path.GetFileName(FileAtt)
            'System.IO.Directory.CreateDirectory(NewPath)
            Dim IdAllegatoEsistente As Long = 0
            'My.Computer.FileSystem.CopyFile(NomeFile, NewPath & System.IO.Path.GetFileName(NomeFile), True)
            Dim LastIdAll As Integer = UltimoCodiceEs("Allegati", "IdAllegato")
            rs.Open("Select * from Allegati where Dbgruppo='" & DbGruppo & "' and " & _
                    " DirettivaAllegato='" & NewPath & "' and NomeFileAllegato='" & fncVerificaStringaSQL(FileName) & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                IdAllegatoEsistente = 0
                rs.AddNew()
                rs("DBGruppo").Value = DbGruppo
                rs("DirettivaAllegato").Value = NewPath
                rs("NomeFileAllegato").Value = FileName
                rs("FileImmagine").Value = 0
                rs.Update()
            Else
                IdAllegatoEsistente = rs("IdAllegato").Value
            End If
            rs.Close()
            Dim NewIdAllegato As Integer = UltimoCodiceEs("Allegati", "IdAllegato")

            If NewIdAllegato > LastIdAll Or IdAllegatoEsistente <> 0 Then
                If IdAllegatoEsistente <> 0 Then
                    NewIdAllegato = IdAllegatoEsistente
                End If
                LogWrite("ALLEGATO ID " & NewIdAllegato)
                rs.Open("Select * from DocPartAllegatiAnnot Where DBGruppo='" & DbGruppo & "' and IdDocumento=" & Iddoc & " And IdAllegato=" & NewIdAllegato, m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Then
                    rs.AddNew()
                    rs("DBGruppo").Value = DbGruppo
                    rs("IdDocumento").Value = Iddoc
                    rs("IdRigaDocumento").Value = 0 
                    rs("NumProgrAllegato").Value = UltimoCodiceEs("DocPartAllegatiAnnot", "NumProgrAllegato", _
                                                                  " Where DBGruppo='" & DbGruppo & "' and IdDocumento=" & Iddoc) + 1

                    rs("IdDocumentoOrigine").Value = Iddoc
                    rs("Stampa").Value = 0
                    rs("InsAllegatoEmail").Value = 0
                    rs("RiportaInEvasione").Value = 0
                    rs("VisualizzaInEvasione").Value = 0
                    rs("AnnotazioneDiPartita").Value = 0
                    rs("FirmaUltVarData").Value = Format(Now.Date, "yyyy-MM-dd")
                    rs("FirmaUltVarOra").Value = Format(TimeOfDay, "HHmmss")
                    rs("FirmaUltVarStazione").Value = Mid(DatiGen.WSP, 1, 2)
                    rs("FirmaUltVarOperatore").Value = DatiGen.Operatore
                    rs("NotaAllegato").Value = ""
                    rs("NumProgrLotto").Value = 0
                    rs("IdAllegato").Value = NewIdAllegato
                    rs("InsComeAllegatoFTE").Value = 0
                    rs("DesAllegatoFTE").Value = ""
                    rs("TipoAnnotazione").Value = 0
                    rs.Update()
                    LogWrite("FILE " & FileAtt & " ALLEGATO IN ESOLVER")
                Else 
                    LogWrite("Allegato Già presente in esolver: IdDoc " & Iddoc & " IDAllegato " & NewIdAllegato & " File  " & FileAtt)
                End If
                rs.Close()
            Else
                LogWrite("ALLEGATO NON INSERITO IN ALLEGATI")
            End If
            rs = Nothing

        Catch ex As Exception
            LogWrite("ERRORI ALLEGATI ESOLVER " & ex.Message & " in " & ex.StackTrace)
        End Try
    End Sub
     

    Private Sub AllegaFileEs_Cli(ByVal CodPart As Long, ByVal Tipo As String, ByVal NomeFile As String, ByVal DbGruppo As String)
        Dim rs As New ADODB.Recordset

        Dim NewPath As String = DatiGen.PathConfES & "\FileContab\"
        System.IO.Directory.CreateDirectory(NewPath)

        My.Computer.FileSystem.CopyFile(NomeFile, NewPath & System.IO.Path.GetFileName(NomeFile), True)
        Dim LastIdAll As Integer = UltimoCodiceEs("Allegati", "IdAllegato")
        rs.Open("Select * from Allegati where Dbgruppo='" & DbGruppo & "' and " & _
                " DirettivaAllegato='" & NewPath & "' and NomeFileAllegato='" & fncVerificaStringaSQL(System.IO.Path.GetFileName(NomeFile)) & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.EOF Then
            rs.AddNew()
            rs("DBGruppo").Value = DbGruppo
            rs("DirettivaAllegato").Value = NewPath
            rs("NomeFileAllegato").Value = (System.IO.Path.GetFileName(NomeFile))
            rs("FileImmagine").Value = 0
            rs.Update()
        End If
        rs.Close()
        Dim NewIdAllegato As Integer = UltimoCodiceEs("Allegati", "IdAllegato")

        If NewIdAllegato > LastIdAll Then

            rs.Open("Select * from CliForAllegatiAnnot Where DBGruppo=''", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                rs.AddNew()
                rs("DBGruppo").Value = DbGruppo
                rs("TipoAnagrafica").Value = IIf(UCase(Tipo) = "C", 1, 2)
                rs("CodCliFor").Value = CodPart
                rs("NumProgrOggetto").Value = UltimoCodiceEs("CliForAllegatiAnnot", "NumProgrOggetto", " Where DBGruppo='" & DbGruppo & "' and TipoAnagrafica=" & IIf(UCase(Tipo) = "C", 1, 2) & " and CodCliFor=" & CodPart) + 1
                rs("DataInizioValidita").Value = "01/01/1800"
                rs("DataFineValidita").Value = "01/01/1800"
                'rs("OldFileAllegato").Value = 0
                'rs("OldDirettivaAllegato").Value = ""
                'rs("OldNomeFileAllegato").Value = ""
                'rs("OldFileImmagine").Value = 0
                rs("NotaInPrev").Value = 0
                rs("NotaInOrd").Value = 0
                rs("NotaInDdt").Value = 0
                rs("NotaInFattImmediate").Value = 0
                rs("NotaInPrimaNota").Value = 0
                rs("NotaInContrCli").Value = 0
                rs("NotaInMandFatt").Value = 0
                rs("NotaInRapportino").Value = 0
                rs("NotaInOrdSped").Value = 0
                rs("DerivaSuDocumento").Value = 0
                rs("StampaAnnotazione").Value = 0
                rs("InsAllegatoEmail").Value = 0
                rs("FirmaUltVarData").Value = Format(Now.Date, "dd/MM/yyyy")
                rs("FirmaUltVarOra").Value = Format(TimeOfDay, "HHmmss")
                rs("FirmaUltVarStazione").Value = Mid(DatiGen.WSP, 1, 2)
                rs("FirmaUltVarOperatore").Value = DatiGen.Operatore
                rs("Annotazione").Value = ""
                rs("TipoAnnotazione").Value = 0
                rs("NotaInDistIncPag").Value = 0
                rs("NotaInRichIntervento").Value = 0
                rs("NotaInOrdBolleInt").Value = 0
                rs("NotaInOrdLavoro").Value = 0
                rs("NotaInInterrogContab").Value = 0
                rs("RiportaInEvasione").Value = 0
                rs("Modello").Value = 0
                rs("IdAllegato").Value = NewIdAllegato
                rs("NotaInFattDifferita").Value = 0
                rs("NotaInDocVendBanco").Value = 0
                rs.Update()
            End If
            rs.Close()
        End If
        rs = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtFileOr.Text <> "" Then
            LeggiExcel(txtFileOr.Text)
            Esporta()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Esporta()

    End Sub

    Private Sub ImpostazioniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpostazioniToolStripMenuItem.Click
        frmDatiGen.ShowDialog()
        'txtFilOutArt.Text = DatiGen.FilOutArt
        'txtFilOutDB.Text = DatiGen.FilOutDB
        'txtFilOutORV.Text = DatiGen.FilOutORV
        'txtFilOutORA.Text = DatiGen.FilOutORA
    End Sub

    Private Sub VediFilesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VediFilesToolStripMenuItem.Click
        Dim PatFiles As String = DatiGen.PathExport
        ' PatFiles = System.IO.Path.GetDirectoryName(PatFiles)
        Shell("explorer.exe " & PatFiles, AppWinStyle.NormalFocus, False)

    End Sub

    Private Sub VediLogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VediLogToolStripMenuItem.Click
        Dim PatFiles As String = Application.StartupPath & "\LOG"
        If Directory.Exists(PatFiles) = False Then
            Directory.CreateDirectory(PatFiles)

        End If
        Shell("explorer.exe " & PatFiles, AppWinStyle.NormalFocus, False)
    End Sub
     
    Private Sub cmdRicPrev_Click(sender As System.Object, e As System.EventArgs)
        Dim mfrprv As New frmRicPRV
        Dim IdDocPRV_RIF As Long = 0
        Dim RiferimentoPrev As String = ""
        With mfrprv
            .ShowDialog()
            IdDocPRV_RIF = .IdDocPRV_RIF
            RiferimentoPrev = .RiferimentoPrev
        End With

        
    End Sub
     
    Private Function GetIdDoc(ByVal RifPrev As String) As Long
        Dim iddoc As Long = 0
        Dim mRif() As String 
        mRif = Split(RifPrev, ".")
        If mRif.Length = 3 Then
            Dim AnnoPrev As String = mRif(0)
            Dim Serie As String = mRif(1)
            Dim NumREg As String = mRif(2)

            If ConnettiEs() Then
                Dim rs As New ADODB.Recordset
                Dim Strsql As String = "select DocElencoGen.Iddocumento from DocElencoGen  inner join Docunitestata   " & _
                    " on DocElencoGen.dbgruppo=Docunitestata.DBGruppo and  " & _
                    " DocElencoGen.iddocumento=Docunitestata.iddocumento " & _
                    " where DocElencoGen.dbgruppo='" & DatiGen.DbGruppo & "' and PeriodoRifNumeraz=" & AnnoPrev & _
                        " and NumRegistraz='" & NumREg & "' and CodSerie=" & Serie & " and GruppoDoc='OPV' " & _
                        " and DocElencoGen.OrdDDTSaldato=0  " & _
                        " and Docunitestata.AccettazionePrev=1  "
                rs.Open(Strsql, m_ConnEs)
                If Not rs.EOF Then
                    iddoc = rs("iddocumento").Value
                Else
                    MsgBox("Riferimento offerta non trovato", MsgBoxStyle.Critical)
                End If
                rs.Close()
                rs = Nothing
            End If
            DisconnettiEs()

        Else
            MsgBox("Inserire un riferimento all'offerta nel formato corretto", MsgBoxStyle.Critical)
        End If
        Return iddoc
    End Function

    Private Sub txtRifPrev_TextChanged(sender As System.Object, e As System.EventArgs)

        'Dim iddoc As Long = GetIdDoc(txtRifPrev.Text)
        ' txtRifPrev.Tag = iddoc
        AbilitaEsportazione()
    End Sub
End Class