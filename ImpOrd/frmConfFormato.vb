
Imports System.Data.OleDb

Public Class frmConfFormato
    Public filetoread As String
    Private _IsSelectAllChecked As Boolean
     

    Private Sub frmConfFormato_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        DisconnettiEs()
    End Sub
    Private Sub frmConfFormato_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ConnettiEs()
        If filetoread <> "" Then CaricaDs(filetoread)
    End Sub
    Private Sub CaricaDs(ByVal NomeFile As String)


        With DataGridView1
            '.AutoGenerateColumns = False
            '    .AllowUserToAddRows = True
            '    .ReadOnly = False
        End With

        Dim lines = IO.File.ReadAllLines(NomeFile)
        Dim tbl = New DataTable("Conti")
        Dim colCount = lines.First.Split(";"c).Length
        tbl.Columns.Add(New DataColumn("Id", GetType(Int32)))
        tbl.Columns.Add(New DataColumn("Conto", GetType(String)))
        tbl.Columns.Add(New DataColumn("DareAvere", GetType(String)))
        tbl.Columns.Add(New DataColumn("CodConto", GetType(String)))
        tbl.Columns.Add(New DataColumn("NrCampo", GetType(Int32)))
        tbl.Columns.Add(New DataColumn("DaImportare", GetType(Boolean)))
        tbl.Columns.Add(New DataColumn("CampoDest", GetType(String)))

        For i As Int32 = 0 To colCount - 1
            Dim newRow As Data.DataRow = tbl.NewRow
            With newRow
                .Item("Id") = i + 1
                'Dim appoLine As String = lines.First
                '   Dim mrec() As String = appoLine.Split(";")
                Dim Conto As String = Trim(lines.First.Split(";")(i))
                .Item("Conto") = Conto
                .Item("DareAvere") = GetDatConf(Conto, "DareAvere", i)
                .Item("CodConto") = GetDatConf(Conto, "CodConto", i)
                .Item("NrCampo") = i
                .Item("DaImportare") = Val(GetDatConf(Conto, "DaImportare", i))
                .Item("CampoDest") = GetDatConf(Conto, "CampoDest", i)
            End With
            tbl.Rows.Add(newRow)
        Next

        Dim cell As DataGridViewCell = New DataGridViewCheckBoxCell()



        Dim bs As New BindingSource
        bs.DataSource = tbl
        DataGridView1.DataSource = bs


        AddSelectAllCheckBox(DataGridView1)
        Dim isAllChecked As Boolean = True
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(5).Value = False Then
                isAllChecked = False
                Exit For
            End If
        Next
        DirectCast(DataGridView1.Controls.Item("SelectAll"), CheckBox).Checked = isAllChecked
    End Sub

    Private Sub AddSelectAllCheckBox(ByVal theDataGridView As DataGridView)
        Dim cbx As New CheckBox
        cbx.Name = "SelectAll"
        'The box size
        cbx.Size = New Size(14, 14)

        Dim rect As Rectangle
        rect = theDataGridView.GetCellDisplayRectangle(5, -1, True)
        'Put CheckBox in the middle-center of the column header.
        cbx.Location = New System.Drawing.Point(rect.Location.X + ((rect.Width - cbx.Width)) - 10, rect.Location.Y + ((rect.Height - cbx.Height) / 2))
        cbx.BackColor = Color.White
        theDataGridView.Controls.Add(cbx)

        'Handle header CheckBox check/uncheck function
        AddHandler cbx.Click, AddressOf HeaderCheckBox_Click
        'When any CheckBox value in the DataGridViewRows changed,
        'check/uncheck the header CheckBox accordingly.
        AddHandler theDataGridView.CellValueChanged, AddressOf DataGridView_CellChecked
        'This event handler is necessary to commit new CheckBox cell value right after
        'user clicks the CheckBox.
        'Without it, CellValueChanged event occurs until the CheckBox cell lose focus
        'which means the header CheckBox won't display corresponding checked state instantly when user
        'clicks any one of the CheckBoxes.
        AddHandler theDataGridView.CurrentCellDirtyStateChanged, AddressOf DataGridView_CurrentCellDirtyStateChanged
    End Sub
    Private Sub HeaderCheckBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllChecked = True

        Dim cbx As CheckBox
        cbx = DirectCast(sender, CheckBox)
        Dim theDataGridView As DataGridView = cbx.Parent

        For Each row As DataGridViewRow In theDataGridView.Rows
            row.Cells(5).Value = cbx.Checked
        Next

        theDataGridView.EndEdit()

        Me._IsSelectAllChecked = False
    End Sub

    Private Sub DataGridView_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)
        If e.ColumnIndex = 5 Then
            If Not Me._IsSelectAllChecked Then
                If dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                    'When any single CheckBox is unchecked, uncheck the header CheckBox.
                    DirectCast(dataGridView.Controls.Item("SelectAll"), CheckBox).Checked = False
                Else
                    'When any single CheckBox is checked, loop through all CheckBoxes to determine
                    'if the header CheckBox needs to be unchecked.
                    Dim isAllChecked As Boolean = True
                    For Each row As DataGridViewRow In dataGridView.Rows
                        If row.Cells(5).Value = False Then
                            isAllChecked = False
                            Exit For
                        End If
                    Next
                    DirectCast(dataGridView.Controls.Item("SelectAll"), CheckBox).Checked = isAllChecked
                End If
            End If
        End If
    End Sub

    'The CurrentCellDirtyStateChanged event happens after user change the cell value,
    'before the cell lose focus and CellValueChanged event.
    Private Sub DataGridView_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf dataGridView.CurrentCell Is DataGridViewCheckBoxCell Then
            'When the value changed cell is DataGridViewCheckBoxCell, commit the change
            'to invoke the CellValueChanged event.
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub cmdSalva_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalva.Click

        Dim bs As New BindingSource
        bs = DataGridView1.DataSource
        Dim tbl As DataTable = bs.DataSource

        Dim mrow() As DataRow = tbl.Select()
        Dim rs As New ADODB.Recordset
        m_ConnEs.Execute("delete from xs1r_ImpP_Conf where dbgruppo='" & DatiGen.DbGruppo & "' ")
        rs.Open("Select * from xs1r_ImpP_Conf where dbgruppo='" & DatiGen.DbGruppo & "' ", m_ConnEs, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        For i As Integer = 0 To mrow.Length - 1
            rs.AddNew()
            rs("Dbgruppo").Value = DatiGen.DbGruppo
            rs("Conto").Value = mrow(i).Item("Conto")
            rs("DareAvere").Value = NoNull(mrow(i).Item("DareAvere"))
            rs("CodConto").Value = NoNull(mrow(i).Item("CodConto"))
            rs("NrCampo").Value = NoNull(mrow(i).Item("NrCampo"))
            rs("DaImportare").Value = IIf(NoNull(mrow(i).Item("DaImportare")) = True, 1, 0)
            rs("CampoDest").Value = NoNull(mrow(i).Item("CampoDest"))
            rs.Update()
        Next
        rs.Close()
        rs = Nothing
    End Sub

    
End Class