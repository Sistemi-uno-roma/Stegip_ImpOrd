Module Principale
    Public m_ConnEs As New ADODB.Connection
    Public m_ConnAcc As New ADODB.Connection

    Public ds As DataSet
    Public Structure TP_DatiGenerali
        'Dim TipoOp As String
        ' Dim VoceInd1 As String
        ' Dim VoceInd2 As String
        ' Dim CentroCosto2 As String
        Dim DbGruppo As String

        Dim WS As String
        Dim WSP As String
        Dim Operatore As String
        Dim OperatoreEs As String
        Dim Server As String
        Dim NomeDbSql As String
        Dim Utente As String
        Dim Pwd As String
        Dim DbAccess As String
        Dim PathConfES As String


        Dim PathFileOr As String

        Dim GrCod_PF As String
        Dim GrCod_Comp As String
        Dim CodCDA As String

        Dim CodSMT As String
        Dim CodTHT As String

        'Dim DocProv As Boolean


        'Dim ModelloArt As String
        'Dim FilOutArt As String
        'Dim ModelloDB As String
        'Dim FilOutDB As String
        'Dim ModelloORV As String
        'Dim FilOutORV As String
        'Dim ModelloORA As String
        'Dim FilOutORA As String
        Dim FileBat As String
        Dim PathExport As String
        'Dim CodCicloTemplate As String
        'Dim FileXlsPart As String
        '' Dim GruppoSelEsolver As String

        'Dim GruppoDocAna As String
        'Dim FileOutAna As String
        'Dim ModelloAna As String 

        'Dim VoceInd2 As String
        'Dim CentroCosto2 As String
        '' Dim GruppoDocMovInd As String
        ''Dim ModelloMovInd As String
        'Dim GruppoDocContabGen As String
        'Dim ModelloContabGen As String
        'Dim FilOutContaGen As String
        '' Dim FilOutMovInd As String

        'Dim FileBatAna As String
        ''Dim FileBatCosti As String
        '' Dim FileBatMovInd As String

        ''Dim GestPartite As Integer
        ''Dim ContoContrPar As String
        ''Dim TipoPar As String
        ''Dim CodPag As String
        ''Dim CodContoNetto As String


        'Dim DocProv As Boolean
        ''Dim CodVoce As String
        ''Dim TipoRiga As String 
        ''Dim NrRegIva As String


        ''Dim CodArtCntrlDispo As String

    End Structure
    Public DatiGen As TP_DatiGenerali
    Public Sub Main()
        'MsgBox(Command)
       
        'Dim e As EnvironmentVariableTarget
        'e = EnvironmentVariableTarget.User
        'Dim strvar As String = ""
        'For i As Integer = 0 To Environment.GetEnvironmentVariables(e).Count - 1
        '    strvar = strvar & vbCrLf & Environment.GetEnvironmentVariables(e).Keys(i)
        '    strvar = strvar & vbCrLf & Environment.GetEnvironmentVariables(e).Values(i)

        'Next
        'MsgBox(strvar)

        'e = EnvironmentVariableTarget.Machine

        'strvar = ""
        'For i As Integer = 0 To Environment.GetEnvironmentVariables(e).Count - 1
        '    strvar = strvar & vbCrLf & Environment.GetEnvironmentVariables(e).Keys(i)
        '    strvar = strvar & vbCrLf & Environment.GetEnvironmentVariables(e).Values(i)

        'Next

        'MsgBox(strvar)

        'e = EnvironmentVariableTarget.Process

        'strvar = ""
        'For i As Integer = 0 To Environment.GetEnvironmentVariables(e).Count - 1
        '    strvar = strvar & vbCrLf & Environment.GetEnvironmentVariables(e).Keys(i)
        '    strvar = strvar & vbCrLf & Environment.GetEnvironmentVariables(e).Values(i)

        'Next

        'MsgBox(strvar)


        'Environment.CurrentDirectory = Environment.GetEnvironmentVariable("windir")
        'Dim info As New DirectoryInfo(".")
        'Console.WriteLine(("Directory Info:   " + info.FullName))

        LeggiConfig()

        Dim b() As String = Environment.GetCommandLineArgs 
        'Dim StazioneAppo As String = b(5)  
        Dim stazione As String = ""
        For i As Integer = 0 To b.Count - 1
            Dim marg As String = b(i)
            If UCase(marg) Like "-WS=*" Then
                stazione = Split(marg, "=")(1) 
            End If
            If UCase(marg) Like "-O=*" Then
                DatiGen.OperatoreEs = Split(marg, "=")(1) 
            End If
        Next
        Dim Gruppo As String = ""

        If stazione <> "" Then
            If DatiGen.Server <> "" And DatiGen.NomeDbSql <> "" And DatiGen.Utente <> "" Then
                If ConnettiEs() Then
                    Dim rs As New ADODB.Recordset
                    rs.Open("SELECT  [Gruppo] from [SIStazioni] where codws='" & stazione & "'", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    If Not rs.EOF Then
                        Gruppo = rs("Gruppo").Value
                    End If
                    rs.Close()
                    rs = Nothing
                    DisconnettiEs()
                Else
                    MsgBox("Configurare i dati necessari per la connessione ai database", MsgBoxStyle.Critical)
                    frmDatiGen.ShowDialog()
                End If

            End If
        Else
            MsgBox("Impossibile reperire la stazione da esolver verranno utilizzati i dati di default :" & vbCrLf & _
              "DbGruppo: " & DatiGen.DbGruppo & vbCrLf & "Stazione: " & DatiGen.WSP, MsgBoxStyle.Information)
            ' stazione = DatiGen.WSP
        End If



        'Dim mfile As String = DatiGen.PathConfES
        'mfile = Mid(mfile, 1, Len(mfile) - 2) & stazione
        'If System.IO.File.Exists(mfile) Then
        '    Dim mread As New System.IO.StreamReader(mfile)
        '    If Not mread.EndOfStream Then
        '        Dim appo As String = mread.ReadLine
        '        Gruppo = Replace(Trim(Split(appo, ",")(6)), Chr(34), "")
        '    End If
        '    mread.Close()
        '    mread = Nothing
        'End If

        If Gruppo = "" Then
            'se vuoto prendo quello dell'ini
            Gruppo = DatiGen.DbGruppo
        Else
            'altrimenti prendo quello di esolver
            DatiGen.DbGruppo = Gruppo
        End If

        ' If DatiGen.DbGruppo <> "" Then
        ' DatiGen.GruppoSelEsolver = Gruppo

        If DatiGen.Server <> "" And DatiGen.NomeDbSql <> "" And DatiGen.Utente <> "" And DatiGen.DbAccess <> "" Then
            PreparaDbAcc()
            System.Windows.Forms.Application.Run(frmPrincipale)
        Else
            MsgBox("Configurare i dati necessari per la connessione ai database", MsgBoxStyle.Critical)
            frmDatiGen.ShowDialog()
        End If
        '   Else
        ' MsgBox("Problemi con la configurazione di Esolver (Gruppo). Contattare l'assistenza!", MsgBoxStyle.Information)
        '  End If


    End Sub
    Private Sub PreparaDbAcc()
        Try
            If DatiGen.DbAccess <> "" Then
                If ConnettiAcc() Then
                    Dim rsField As New ADODB.Recordset
                    rsField = m_ConnAcc.OpenSchema(ADODB.SchemaEnum.adSchemaColumns, New Object() {Nothing, Nothing, "DaEseguire", "GestProvvisorio"})
                    If rsField.EOF Then 'il campo GestProvvisorio non esiste
                        m_ConnAcc.Execute("Alter table DaEseguire add GestProvvisorio BIT   DEFAULT 0  NULL")

                        m_ConnAcc.Execute("Update DaEseguire set GestProvvisorio =0 ")
                    End If
                    rsField.Close()

                    rsField = m_ConnAcc.OpenSchema(ADODB.SchemaEnum.adSchemaColumns, New Object() {Nothing, Nothing, "DaEseguire", "AllegaFile"})
                    If rsField.EOF Then 'il campo AllegaFile non esiste
                        m_ConnAcc.Execute("Alter table DaEseguire add AllegaFile BIT   DEFAULT 0  NULL")

                        m_ConnAcc.Execute("Update DaEseguire set AllegaFile =0 ")
                    End If
                    rsField.Close()

                    rsField = Nothing
                End If

            End If
        Catch ex As Exception
            MsgBox("error add column " & ex.Message, "PreparaDb")
        End Try
        DisconnettiAcc()
    End Sub
    Public Sub SalvaConfig()
        Dim AppRelativo As String = Application.StartupPath
        'ds   New System.Data.DataSet
        'Dim mArr(10) As String
        'Se non c'è l'xml crea la tabella, i campi e inserisce una riga (senza riga non salva niente)
        'If Dir(AppRelativo & "\AnaDip_Config.xml") = "" Then
        ds.DataSetName = "ImpOrd"
        If ds.Tables("DatiGen") Is Nothing Then
            ds.Tables.Add("DatiGen") 
            ds.Tables("DatiGen").Columns.Add("DbGruppo")
            ds.Tables("DatiGen").Columns.Add("Server")
            ds.Tables("DatiGen").Columns.Add("NomeDbSql")
            ds.Tables("DatiGen").Columns.Add("Utente")
            ds.Tables("DatiGen").Columns.Add("Pwd")
            ds.Tables("DatiGen").Columns.Add("DbAccess")
            ds.Tables("DatiGen").Columns.Add("WS")
            ds.Tables("DatiGen").Columns.Add("WSP")
            ds.Tables("DatiGen").Columns.Add("Operatore")
            ds.Tables("DatiGen").Columns.Add("PathConfES")
            ds.Tables("DatiGen").Columns.Add("PathFileOr")
            ds.Tables("DatiGen").Columns.Add("DocProv")


            'ds.Tables("DatiGen").Columns.Add("GrCod_PF")
            'ds.Tables("DatiGen").Columns.Add("GrCod_Comp")
            'ds.Tables("DatiGen").Columns.Add("CodCDA")

            'ds.Tables("DatiGen").Columns.Add("CodSMT")
            'ds.Tables("DatiGen").Columns.Add("CodTHT") 


            'ds.Tables("DatiGen").Columns.Add("ModelloArt")
            'ds.Tables("DatiGen").Columns.Add("FilOutArt")
            'ds.Tables("DatiGen").Columns.Add("ModelloDB")
            'ds.Tables("DatiGen").Columns.Add("FilOutDB")
            'ds.Tables("DatiGen").Columns.Add("ModelloORV")
            'ds.Tables("DatiGen").Columns.Add("FilOutORV")
            'ds.Tables("DatiGen").Columns.Add("ModelloORA")
            'ds.Tables("DatiGen").Columns.Add("FilOutORA")
            ds.Tables("DatiGen").Columns.Add("FileBat")
            ds.Tables("DatiGen").Columns.Add("PathExport")
            ds.Tables("DatiGen").Columns.Add("CodCicloTemplate")

            'ds.Tables("DatiGen").Columns.Add("CodArtCntrlDispo")

            '  ds.Tables("DatiGen").Columns.Add("FileXlsPart")


            'ds.Tables("DatiGen").Columns.Add("FileOutAna")
            'ds.Tables("DatiGen").Columns.Add("GruppoDocAna")
            'ds.Tables("DatiGen").Columns.Add("ModelloAna")
            'ds.Tables("DatiGen").Columns.Add("DbGruppo") 
            'ds.Tables("DatiGen").Columns.Add("FileBatAna")


            'ds.Tables("DatiGen").Columns.Add("CentroCosto2")
            'ds.Tables("DatiGen").Columns.Add("VoceInd2")
            'ds.Tables("DatiGen").Columns.Add("GruppoDocContab")
            'ds.Tables("DatiGen").Columns.Add("ModelloContab")
            'ds.Tables("DatiGen").Columns.Add("FilOutContab")
            'ds.Tables("DatiGen").Columns.Add("FileBatCosti")


            'ds.Tables("DatiGen").Columns.Add("GestPartite")
            'ds.Tables("DatiGen").Columns.Add("ContoContrPar")
            'ds.Tables("DatiGen").Columns.Add("TipoPar")
            'ds.Tables("DatiGen").Columns.Add("CodPag")
            'ds.Tables("DatiGen").Columns.Add("CodContoNetto")

            'ds.Tables("DatiGen").Columns.Add("CodVoce")
            'ds.Tables("DatiGen").Columns.Add("TipoRiga") 
            'ds.Tables("DatiGen").Columns.Add("NrRegIva")

          
        
            '   ds.Tables("DatiGen").Columns.Add("GruppoDocInd")
            '  ds.Tables("DatiGen").Columns.Add("ModelloInd")
            '  ds.Tables("DatiGen").Columns.Add("FilOutInd")
            '  ds.Tables("DatiGen").Columns.Add("FileBatMovInd")
         
        Else
            ds.Tables("DatiGen").Clear()
        End If
        Dim NewRow As DataRow = ds.Tables("DatiGen").NewRow
        With DatiGen
            NewRow.Item("DbGruppo") = .DbGruppo
            'NewRow.Item("GruppoDocAna") = .GruppoDocAna
            'NewRow.Item("ModelloAna") = .ModelloAna
            NewRow.Item("WS") = .WS
            NewRow.Item("WSP") = .WSP
            NewRow.Item("Operatore") = .Operatore
            NewRow.Item("Server") = .Server
            NewRow.Item("NomeDbSql") = .NomeDbSql
            NewRow.Item("Utente") = .Utente
            NewRow.Item("Pwd") = .Pwd
            NewRow.Item("DbAccess") = .DbAccess
            'NewRow.Item("FileOutAna") = .FileOutAna
            NewRow.Item("PathConfES") = .PathConfES
            NewRow.Item("PathFileOr") = .PathFileOr

            'NewRow.Item("DocProv") = IIf(.DocProv, 1, 0) 


            'NewRow.Item("GrCod_PF") = .GrCod_PF
            'NewRow.Item("GrCod_Comp") = .GrCod_Comp
            'NewRow.Item("CodCDA") = .CodCDA

            'NewRow.Item("CodSMT") = .CodSMT
            'NewRow.Item("CodTHT") = .CodTHT 

            'NewRow.Item("ModelloArt") = .ModelloArt
            'NewRow.Item("FilOutArt") = .FilOutArt
            'NewRow.Item("ModelloDB") = .ModelloDB
            'NewRow.Item("FilOutDB") = .FilOutDB
            'NewRow.Item("ModelloORV") = .ModelloORV
            'NewRow.Item("FilOutORV") = .FilOutORV
            'NewRow.Item("ModelloORA") = .ModelloORA
            'NewRow.Item("FilOutORA") = .FilOutORA
            NewRow.Item("FileBat") = .FileBat
            NewRow.Item("PathExport") = .PathExport
            'NewRow.Item("CodCicloTemplate") = .CodCicloTemplate 
            ' NewRow.Item("FileXlsPart") = .FileXlsPart


            'NewRow.Item("FileBatAna") = .FileBatAna

            'NewRow.Item("CentroCosto2") = .CentroCosto2
            ' NewRow.Item("VoceInd2") = .VoceInd2
            'NewRow.Item("GruppoDocContab") = .GruppoDocContabGen
            'NewRow.Item("ModelloContab") = .ModelloContabGen
            'NewRow.Item("FilOutContab") = .FilOutContaGen
            'NewRow.Item("FileBatCosti") = .FileBatCosti

            'NewRow.Item("CodArtCntrlDispo") = .CodArtCntrlDispo



            'NewRow.Item("GestPartite") = .GestPartite
            ' NewRow.Item("ContoContrPar") = .ContoContrPar
            ' NewRow.Item("TipoPar") = .TipoPar
            'NewRow.Item("CodPag") = .CodPag
            ' NewRow.Item("CodContoNetto") = .CodContoNetto


            '  NewRow.Item("CodVoce") = .CodVoce
            ' NewRow.Item("TipoRiga") = .TipoRiga
            ' NewRow.Item("CodPag") = .CodPag
            ' NewRow.Item("NrRegIva") = .NrRegIva

           
          
            '  NewRow.Item("GruppoDocInd") = .GruppoDocMovInd
            '   NewRow.Item("ModelloInd") = .ModelloMovInd
            '   NewRow.Item("FilOutInd") = .FilOutMovInd
            '   NewRow.Item("FileBatMovInd") = .FileBatMovInd

        End With
        ds.Tables("DatiGen").Rows.Add(NewRow) 'mArr)
        'If ds.Tables("Aziende") Is Nothing Then
        '    ds.Tables.Add("Aziende")
        '    ds.Tables("Aziende").Columns.Add("Codice")
        '    ds.Tables("Aziende").Columns.Add("Gruppo") 
        '    NewRow =  ds.Tables("Aziende").NewRow
        '    NewRow.Item("Codice") = ""
        '    NewRow.Item("Gruppo") = ""
        '    'ReDim mArr(1)
        '    'mArr(0) = ""
        '    'mArr(1) = ""
        '    ds.Tables("Aziende").Rows.Add(NewRow) ' mArr)
        'End If
        'Else
        'altrimenti se trova l'xml lo legge riempiendo così il dataset con la tabella, i campi e i vari record
        'ds.ReadXml("E:\test2.xml")
        'End If
        'salva tutto
        ds.WriteXml(AppRelativo & "\ImpOrd_Config.xml")
        'Dim DatiSalvati As Boolean = False
        'If Not m_ConnEs Is Nothing Then
        '    If m_ConnEs.State = 1 Then
        '        SalvaDatiGen()
        '        DatiSalvati = True
        '    End If
        'End If
        'If DatiSalvati = False Then
        '    'If ConnettiEs() Then
        '    '    SalvaDatiGen()
        '    '    DisconnettiEs()
        '    'End If
        'End If
    End Sub
    Public Sub SalvaDatiGen()
        'Dim rs As New ADODB.Recordset
        'm_ConnEs.Execute("Delete from xs1r_ImpP_DatiGen where dbgruppo='" & DatiGen.DbGruppo & "'  ")
        'rs.Open("Select * from xs1r_ImpP_DatiGen where dbgruppo='" & DatiGen.DbGruppo & "'  ", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        'If rs.EOF Then
        '    rs.AddNew()
        '    With DatiGen
        '        rs("DbGruppo").Value = .DbGruppo
        '        rs("ContoControPar").Value = .ContoContrPar
        '        rs("TipoPar").Value = .TipoPar
        '        rs("CodPag").Value = .CodPag
        '        rs("ContoNetto").Value = .CodContoNetto

        '    End With
        '    rs.Update()
        'End If
        'rs.Close()
        'rs = Nothing
    End Sub

    Public Sub LeggiConfig()
        Dim AppRelativo As String = Application.StartupPath
        Dim StruttVariata As Boolean = False
        Dim ValoriNull As Boolean = False
        ds = New System.Data.DataSet
        Dim mArr(3) As String
        'Se non c'è l'xml crea la tabella, i campi e inserisce una riga (senza riga non salva niente)
        If Dir(AppRelativo & "\ImpOrd_Config.xml") = "" Then
            frmDatiGen.ShowDialog()
        End If
        If Dir(AppRelativo & "\ImpOrd_Config.xml") <> "" Then
            ds.ReadXml(AppRelativo & "\ImpOrd_Config.xml")
            With DatiGen

                If Not ds.Tables("DatiGen").Columns("WS") Is Nothing Then
                    .WS = ds.Tables("DatiGen").Rows(0).Item("WS")
                    If .WS = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("WS")
                    StruttVariata = True
                    'frmDatiGen.txtWS.BackColor = Color.Yellow
                End If
                If Not ds.Tables("DatiGen").Columns("WSP") Is Nothing Then
                    .WSP = ds.Tables("DatiGen").Rows(0).Item("WSP")
                    If .WSP = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("WSP")
                    StruttVariata = True
                    'frmDatiGen.txtWSP.BackColor = Color.Yellow
                End If
                If Not ds.Tables("DatiGen").Columns("Operatore") Is Nothing Then
                    .Operatore = ds.Tables("DatiGen").Rows(0).Item("Operatore")
                    If .Operatore = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("Operatore")
                    StruttVariata = True
                    'frmDatiGen.txtOperatore.BackColor = Color.Yellow
                End If
                If Not ds.Tables("DatiGen").Columns("Server") Is Nothing Then
                    .Server = ds.Tables("DatiGen").Rows(0).Item("Server")
                    If .Server = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("Server")
                    StruttVariata = True
                    'frmDatiGen.txtServer.BackColor = Color.Yellow
                End If
                If Not ds.Tables("DatiGen").Columns("NomeDbSql") Is Nothing Then
                    .NomeDbSql = ds.Tables("DatiGen").Rows(0).Item("NomeDbSql")
                    If .NomeDbSql = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("NomeDbSql")
                    StruttVariata = True
                    'frmDatiGen.txtDbNameSql.BackColor = Color.Yellow
                End If
                If Not ds.Tables("DatiGen").Columns("Utente") Is Nothing Then
                    .Utente = ds.Tables("DatiGen").Rows(0).Item("Utente")
                    If .Utente = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("Utente")
                    StruttVariata = True
                    'frmDatiGen.txtUtente.BackColor = Color.Yellow
                End If
                If Not ds.Tables("DatiGen").Columns("Pwd") Is Nothing Then
                    .Pwd = ds.Tables("DatiGen").Rows(0).Item("Pwd")
                Else
                    ds.Tables("DatiGen").Columns.Add("Pwd")
                    StruttVariata = True
                    'frmDatiGen.txtPwd.BackColor = Color.Yellow
                End If

                If Not ds.Tables("DatiGen").Columns("DbAccess") Is Nothing Then
                    .DbAccess = ds.Tables("DatiGen").Rows(0).Item("DbAccess")
                    If .DbAccess = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("DbAccess")
                    StruttVariata = True
                    'frmDatiGen.txtPwd.BackColor = Color.Yellow
                End If



                If Not ds.Tables("DatiGen").Columns("PathConfES") Is Nothing Then
                    .PathConfES = ds.Tables("DatiGen").Rows(0).Item("PathConfES")
                    If .PathConfES = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("PathConfES")
                    StruttVariata = True
                    'frmDatiGen.txtDBLibroSOCI.BackColor = Color.Yellow
                End If

                If Not ds.Tables("DatiGen").Columns("PathFileOr") Is Nothing Then
                    .PathFileOr = ds.Tables("DatiGen").Rows(0).Item("PathFileOr")
                    'If .PathFileOr = "" Then
                    '    ValoriNull = True
                    'End If
                Else
                    ds.Tables("DatiGen").Columns.Add("PathFileOr")
                    StruttVariata = True
                    'frmDatiGen.txtDBLibroSOCI.BackColor = Color.Yellow
                End If





                If Not ds.Tables("DatiGen").Columns("DbGruppo") Is Nothing Then
                    .DbGruppo = ds.Tables("DatiGen").Rows(0).Item("DbGruppo")
                    If .DbGruppo = "" Then
                        ValoriNull = True
                    End If
                Else
                    ds.Tables("DatiGen").Columns.Add("DbGruppo")
                    StruttVariata = True
                    'frmDatiGen.txtDbBanca.BackColor = Color.Yellow
                End If



                'If Not ds.Tables("DatiGen").Columns("DocProv") Is Nothing Then
                '    .DocProv = Val(ds.Tables("DatiGen").Rows(0).Item("DocProv")) = 1

                'Else
                '    ds.Tables("DatiGen").Columns.Add("DocProv")
                '    StruttVariata = True
                'End If



                'If Not ds.Tables("DatiGen").Columns("GrCod_PF") Is Nothing Then
                '    .GrCod_PF = (ds.Tables("DatiGen").Rows(0).Item("GrCod_PF"))

                'Else
                '    ds.Tables("DatiGen").Columns.Add("GrCod_PF")
                '    StruttVariata = True
                'End If


                'If Not ds.Tables("DatiGen").Columns("GrCod_Comp") Is Nothing Then
                '    .GrCod_Comp = (ds.Tables("DatiGen").Rows(0).Item("GrCod_Comp"))

                'Else
                '    ds.Tables("DatiGen").Columns.Add("GrCod_Comp")
                '    StruttVariata = True
                'End If


                'If Not ds.Tables("DatiGen").Columns("CodCDA") Is Nothing Then
                '    .CodCDA = (ds.Tables("DatiGen").Rows(0).Item("CodCDA"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("CodCDA")
                '    StruttVariata = True
                'End If

                'If Not ds.Tables("DatiGen").Columns("CodSMT") Is Nothing Then
                '    .CodSMT = (ds.Tables("DatiGen").Rows(0).Item("CodSMT"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("CodSMT")
                '    StruttVariata = True
                'End If

                'If Not ds.Tables("DatiGen").Columns("CodTHT") Is Nothing Then
                '    .CodTHT = (ds.Tables("DatiGen").Rows(0).Item("CodTHT"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("CodTHT")
                '    StruttVariata = True
                'End If

                'If Not ds.Tables("DatiGen").Columns("CodCicloTemplate") Is Nothing Then
                '    .CodCicloTemplate = (ds.Tables("DatiGen").Rows(0).Item("CodCicloTemplate"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("CodCicloTemplate")
                '    StruttVariata = True
                'End If



                'If Not ds.Tables("DatiGen").Columns("ModelloArt") Is Nothing Then
                '    .ModelloArt = (ds.Tables("DatiGen").Rows(0).Item("ModelloArt"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("ModelloArt")
                '    StruttVariata = True
                'End If 
                'If Not ds.Tables("DatiGen").Columns("FilOutArt") Is Nothing Then
                '    .FilOutArt = (ds.Tables("DatiGen").Rows(0).Item("FilOutArt"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("FilOutArt")
                '    StruttVariata = True
                'End If 
                'If Not ds.Tables("DatiGen").Columns("ModelloDB") Is Nothing Then
                '    .ModelloDB = (ds.Tables("DatiGen").Rows(0).Item("ModelloDB"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("ModelloDB")
                '    StruttVariata = True
                'End If 
                'If Not ds.Tables("DatiGen").Columns("FilOutDB") Is Nothing Then
                '    .FilOutDB = (ds.Tables("DatiGen").Rows(0).Item("FilOutDB"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("FilOutDB")
                '    StruttVariata = True
                'End If 
                'If Not ds.Tables("DatiGen").Columns("ModelloORV") Is Nothing Then
                '    .ModelloORV = (ds.Tables("DatiGen").Rows(0).Item("ModelloORV"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("ModelloORV")
                '    StruttVariata = True
                'End If 
                'If Not ds.Tables("DatiGen").Columns("FilOutORV") Is Nothing Then
                '    .FilOutORV = (ds.Tables("DatiGen").Rows(0).Item("FilOutORV"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("FilOutORV")
                '    StruttVariata = True
                'End If 
                'If Not ds.Tables("DatiGen").Columns("ModelloORA") Is Nothing Then
                '    .ModelloORA = (ds.Tables("DatiGen").Rows(0).Item("ModelloORA"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("ModelloORA")
                '    StruttVariata = True
                'End If 
                'If Not ds.Tables("DatiGen").Columns("FilOutORA") Is Nothing Then
                '    .FilOutORA = (ds.Tables("DatiGen").Rows(0).Item("FilOutORA"))
                'Else
                '    ds.Tables("DatiGen").Columns.Add("FilOutORA")
                '    StruttVariata = True
                'End If


                If Not ds.Tables("DatiGen").Columns("FileBat") Is Nothing Then
                    .FileBat = (ds.Tables("DatiGen").Rows(0).Item("FileBat"))
                Else
                    ds.Tables("DatiGen").Columns.Add("FileBat")
                    StruttVariata = True
                End If

                If Not ds.Tables("DatiGen").Columns("PathExport") Is Nothing Then
                    .PathExport = (ds.Tables("DatiGen").Rows(0).Item("PathExport"))
                Else
                    ds.Tables("DatiGen").Columns.Add("PathExport")
                    StruttVariata = True
                End If

                'If ds.Tables("Aziende") Is Nothing Then
                '    ds.Tables.Add("Aziende")
                '    ds.Tables("Aziende").Columns.Add("Codice")
                '    ds.Tables("Aziende").Columns.Add("Gruppo")
                '    'ReDim mArr(1)
                '    'mArr(0) = ""
                '    'mArr(1) = ""
                '    'ds.Tables("Aziende").Rows.Add(mArr)
                '    '  StruttVariata = True
                'End If

                If ValoriNull Then
                    MsgBox("Configurare tutti i dati", MsgBoxStyle.Critical)
                    StruttVariata = True
                End If

                If StruttVariata Then
                    frmDatiGen.ShowDialog()
                End If
            End With
        End If
    End Sub
    Public Function NoNull(ByRef Dato As Object) As String
        If TypeOf Dato Is ADODB.InternalField = False Then
            If Not IsDBNull(Dato) Then
                NoNull = (Dato)
            Else
                NoNull = ""
            End If
        Else
            If Not IsDBNull(Dato.value) Then
                NoNull = (Dato.value)
            Else 
                If Dato.type = ADODB.DataTypeEnum.adVarChar Or Dato.type = ADODB.DataTypeEnum.adVarWChar Or Dato.type = ADODB.DataTypeEnum.adWChar Or Dato.type = ADODB.DataTypeEnum.adChar Then
                    NoNull = ""
                ElseIf Dato.type = ADODB.DataTypeEnum.adDate Or Dato.type = ADODB.DataTypeEnum.adDBDate Or Dato.type = ADODB.DataTypeEnum.adDBTimeStamp Then
                    NoNull = "01/01/1800"
                Else
                    NoNull = 0
                End If
            End If
        End If

    End Function
    Public Function ConnettiEs() As Boolean
        Try
            ConnettiEs = True
            m_ConnEs = New ADODB.Connection
            m_ConnEs.ConnectionString = "Provider=sqloledb; Data Source=" & DatiGen.Server & _
                                    "; Initial Catalog=" & DatiGen.NomeDbSql & "; User Id=" & DatiGen.Utente & _
                                    "; Password=" & DatiGen.Pwd & ";"

            m_ConnEs.Open()
            m_ConnEs.CommandTimeout = 1000
        Catch ex As Exception
            MsgBox("Errore " & ex.Message, MsgBoxStyle.Critical, "Connessione")
            ConnettiEs = False
            m_ConnEs = Nothing
            Exit Function
        End Try
    End Function
    Public Function DisconnettiEs() As Boolean
        Try
            DisconnettiEs = True
            If Not m_ConnEs Is Nothing Then
                If m_ConnEs.State = 1 Then
                    m_ConnEs.Close()
                End If
            End If
            m_ConnEs = Nothing
        Catch ex As Exception
            MsgBox("Errore " & ex.Message, MsgBoxStyle.Critical, "Disconnessione")
            DisconnettiEs = False
            m_ConnEs = Nothing
            Exit Function
        End Try
    End Function 
    Public Function ConnettiAcc() As Boolean
        Try
            ConnettiAcc = True
            m_ConnAcc = New ADODB.Connection
            m_ConnAcc.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatiGen.DbAccess & ";"

            'm_ConnAcc.ConnectionString = "Provider=sqloledb; Data Source=" & DatiGen.Server & _
            '                        "; Initial Catalog=" & DatiGen.NomeDbSql & "; User Id=" & DatiGen.Utente & _
            '                        "; Password=" & DatiGen.Pwd & ";"

            m_ConnAcc.Open()
            m_ConnAcc.CommandTimeout = 1000
        Catch ex As Exception
            MsgBox("Errore " & ex.Message, MsgBoxStyle.Critical, "Connessione")
            ConnettiAcc = False
            m_ConnAcc = Nothing
            Exit Function
        End Try
    End Function
    Public Function DisconnettiAcc() As Boolean
        Try
            DisconnettiAcc = True
            If Not m_ConnAcc Is Nothing Then
                If m_ConnAcc.State = 1 Then
                    m_ConnAcc.Close()
                End If
            End If
            m_ConnAcc = Nothing
        Catch ex As Exception
            MsgBox("Errore " & ex.Message, MsgBoxStyle.Critical, "Disconnessione")
            DisconnettiAcc = False
            m_ConnAcc = Nothing
            Exit Function
        End Try
    End Function

    Public Function EsisteTabellaEs(ByVal TblName As String) As Boolean

        EsisteTabellaEs = False
        Dim rs As New ADODB.Recordset
        rs = m_ConnEs.OpenSchema(ADODB.SchemaEnum.adSchemaTables)
        If Not rs.EOF Then
            Do While Not rs.EOF
                'If UCase(rs("TABLE_TYPE").Value) = "TABLE" Then
                Dim appotab As String = UCase(rs("TABLE_NAME").Value)
                If UCase(rs("TABLE_NAME").Value) = UCase(TblName) Then
                    EsisteTabellaEs = True
                    Exit Do
                End If
                'End If
                rs.MoveNext()
            Loop
        End If
        rs.Close()

        If Not EsisteTabellaEs Then
            rs = m_ConnEs.OpenSchema(ADODB.SchemaEnum.adSchemaProcedures)
            If Not rs.EOF Then
                Do While Not rs.EOF
                    'If UCase(rs("TABLE_TYPE").Value) = "TABLE" Then 
                    Dim appotab As String = UCase(rs("PROCEDURE_NAME").Value)
                    If UCase(rs("PROCEDURE_NAME").Value) = UCase(TblName) Then
                        EsisteTabellaEs = True
                        Exit Do
                    End If
                    'End If
                    rs.MoveNext()
                Loop
            End If
            rs.Close()
        End If


        rs = Nothing
        'For Each TabGen In DbRif.TableDefs
        '    EsisteTabella = EsisteTabella Or (UCase(TabGen.Name) = UCase(TblName))
        'Next TabGen

    End Function
    Public Function EsisteTabellaAcc(ByVal TblName As String) As Boolean

        EsisteTabellaAcc = False
        Dim rs As New ADODB.Recordset
        rs = m_ConnAcc.OpenSchema(ADODB.SchemaEnum.adSchemaTables)
        If Not rs.EOF Then
            Do While Not rs.EOF
                'If UCase(rs("TABLE_TYPE").Value) = "TABLE" Then
                Dim appotab As String = UCase(rs("TABLE_NAME").Value)
                If UCase(rs("TABLE_NAME").Value) = UCase(TblName) Then
                    EsisteTabellaAcc = True
                    Exit Do
                End If
                'End If
                rs.MoveNext()
            Loop
        End If
        rs.Close()

        If Not EsisteTabellaAcc Then
            rs = m_ConnAcc.OpenSchema(ADODB.SchemaEnum.adSchemaProcedures)
            If Not rs.EOF Then
                Do While Not rs.EOF
                    'If UCase(rs("TABLE_TYPE").Value) = "TABLE" Then 
                    Dim appotab As String = UCase(rs("PROCEDURE_NAME").Value)
                    If UCase(rs("PROCEDURE_NAME").Value) = UCase(TblName) Then
                        EsisteTabellaAcc = True
                        Exit Do
                    End If
                    'End If
                    rs.MoveNext()
                Loop
            End If
            rs.Close()
        End If


        rs = Nothing
        'For Each TabGen In DbRif.TableDefs
        '    EsisteTabella = EsisteTabella Or (UCase(TabGen.Name) = UCase(TblName))
        'Next TabGen

    End Function
    Public Function UltimoCodiceEs(ByVal m_Table As String, ByVal m_Chiave As String, Optional ByVal Cond As String = "") As Long
        Dim rs As New ADODB.Recordset
        rs.Open("Select top 1 " & m_Chiave & " from " & m_Table & " " & Cond & " order by " & m_Chiave & " desc", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic)
        If Not rs.EOF Then 
            UltimoCodiceEs = rs.Fields(m_Chiave).Value
        Else
            UltimoCodiceEs = 0
        End If
        rs.Close()
        rs = Nothing
    End Function
    Public Function UltimoCodiceAcc(ByVal m_Table As String, ByVal m_Chiave As String, Optional ByVal Cond As String = "") As Long
        Dim rs As New ADODB.Recordset
        rs.Open("Select top 1 " & m_Chiave & " from " & m_Table & " " & Cond & " order by " & m_Chiave & " desc", m_ConnAcc, ADODB.CursorTypeEnum.adOpenDynamic)
        If Not rs.EOF Then
            UltimoCodiceAcc = rs.Fields(m_Chiave).Value
        Else
            UltimoCodiceAcc = 0
        End If
        rs.Close()
        rs = Nothing
    End Function


    Public Function GetDatConf(ByVal Conto As String, ByVal Fieltofind As String, ByVal NrCampo As Integer, Optional ByVal FieldAlias As String = "") As String
        GetDatConf = ""
        Dim rs As New ADODB.Recordset
        Dim Cond As String = ""
        If FieldAlias <> "" Then
            Cond = " And CampoDest='" & fncVerificaStringaSQL(FieldAlias) & "'"
        End If
        If NrCampo >= 0 Then
            Cond = Cond & " and NrCampo=" & NrCampo
        End If
        rs.Open("Select " & Fieltofind & " from xs1r_ImpP_Conf where dbgruppo='" & DatiGen.DbGruppo & "' and Conto='" & fncVerificaStringaSQL(Conto) & "' " & Cond, m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            GetDatConf = rs(Fieltofind).Value
        End If
        rs.Close()
        rs = Nothing


    End Function


    Public Function fncVerificaStringaSQL(ByVal sSQLString As String) As String
        fncVerificaStringaSQL = fncStrReplaceChar(sSQLString, "'", "''")
    End Function
    Public Function fncStrReplaceChar(ByVal sSource As String, ByVal sCharToReplace As String, ByVal sReplaceChar As String) As String
        Dim iLoop As Short
        Dim sChar As String
        fncStrReplaceChar = ""
        For iLoop = 1 To Len(sSource)
            sChar = Mid(sSource, iLoop, 1)
            fncStrReplaceChar = fncStrReplaceChar & IIf(sChar = sCharToReplace, sReplaceChar, sChar)
        Next iLoop
    End Function
    Public Function fncVerificaStringaSQLPunto(ByVal sSQLString As String) As String
        fncVerificaStringaSQLPunto = fncStrReplaceCharPunto(sSQLString, ",", ".")
    End Function
    Public Function fncStrReplaceCharPunto(ByVal sSource As String, ByVal sCharToReplace As String, ByVal sReplaceChar As String) As String
        Dim iLoop As Short
        Dim sChar As String
        fncStrReplaceCharPunto = ""
        For iLoop = 1 To Len(sSource)
            sChar = Mid(sSource, iLoop, 1)
            fncStrReplaceCharPunto = fncStrReplaceCharPunto & IIf(sChar = sCharToReplace, sReplaceChar, sChar)
        Next iLoop
    End Function

    Public Sub LogWrite(ByVal Testo As String)
        Dim nrfile As Long = FreeFile()
        Dim PatFiles As String = Application.StartupPath & "\LOG"
        If System.IO.Directory.Exists(PatFiles) = False Then
            System.IO.Directory.CreateDirectory(PatFiles)

        End If

        FileOpen(nrfile, PatFiles & "\LogElab_" & Format(Now.Date, "yyyyMMdd") & ".log", OpenMode.Append)
        PrintLine(nrfile, Format(Now, "dd/MM/yyyy HH:mm:ss") & " - " & Testo)
        FileClose(nrfile)
    End Sub
End Module
