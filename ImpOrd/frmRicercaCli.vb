Option Strict Off
Option Explicit On
Friend Class frmRicercaCli
	Inherits System.Windows.Forms.Form
	Public CodCli As String
	Public RagSoc As String 
	Public condizione As String 
	 
	
	Private Sub frmRicercaCli_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
		CaricaLista()
	End Sub
	
    Private Sub CaricaLista()
        Try

            If ConnettiEs() Then

                Dim rs As New ADODB.Recordset
                lvwCli.Items.Clear()
                rs.Open("Select distinct codclifor,concat( AnagrGenIndirizzi.ragsoc1 ,AnagrGenIndirizzi.ragsoc2) as RagSoc  " & _
                        "FROM ClientiFornitori INNER JOIN  " & _
                        "AnagrGenIndirizzi  ON ClientiFornitori.IdAnagGen  = AnagrGenIndirizzi.IdAnagGen " & _
                        IIf(condizione = "", " where tipoanagrafica=1", condizione & " and tipoanagrafica=1") & _
                        " and dbgruppo='" & DatiGen.DbGruppo & "' and AnagrGenIndirizzi.NumProgr=0   order by codclifor", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rs.EOF Then
                    Do While Not rs.EOF
                        lvwCli.Items.Add("a" & rs.Fields("codclifor").Value, rs.Fields("codclifor").Value, "")
                        lvwCli.Items.Item("a" & rs.Fields("codclifor").Value).SubItems.add(rs.Fields("RagSoc").Value)

                        rs.MoveNext()
                    Loop
                End If
                rs.Close()
                lvwCli.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                rs = Nothing
            End If


        Catch ex As Exception
            MsgBox("Errore Ricerca clienti " & ex.Message)
        End Try
        DisconnettiEs()
    End Sub
	
    Private Sub lvwCli_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvwCli.DoubleClick
        If lvwCli.SelectedItems.Count > 0 Then
            CodCli = Mid(lvwCli.SelectedItems(0).Name, 2)
            RagSoc = lvwCli.SelectedItems(0).SubItems(1).Text
            Me.Close()
        End If
    End Sub
	
	  
End Class