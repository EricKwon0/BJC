Imports Frame9
Imports Base9
Imports Base9.Shared
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Text

Public Class FE100

    Private Sub FE100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
        Me.Init_Popup()
        asset_amount.Visible = False
        g10.SelectRow = True
        g20.SelectRow = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

            'Case MenuType.Print
            '    Me.Print()

            'Case MenuType.New

            Case MenuType.Save
                If Me.Save() Then
                    'Dim finder As String = vc_no.Text
                    'Me.Open()
                    'g10.Find("vc_no = " + finder)
                    OpenTrigger("fe100_g01")
                End If

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public m_stop_event As Boolean
    Private Sub lifetime_TextChanged(sender As Object, oldValue As String) Handles lifetime.TextChanged
        If Not CheckRequired(pur_date) Then Exit Sub
        '
        If m_stop_event Then Exit Sub
        '
        m_stop_event = True
        '
        Dim dset As DataSet = OpenDataSet("fe100_getMon")

        If Not IsEmpty(dset) Then
            'dp_rate.Text = DataValue(dset, "straight_line")
            dp_start_date.Text = DataValue(dset, "sMon")
            dp_end_date.Text = DataValue(dset, "eMon")
            dp_rate.Text = DataValue(dset, "straight_line")
            m_stop_event = False
            Exit Sub
        End If
        m_stop_event = False
    End Sub

    Private Sub asset_category_TextChanged(sender As Object, e As EventArgs) Handles asset_category.TextChanged
        If m_stop_event Then Exit Sub
        '
        m_stop_event = True
        '
        Dim dset As DataSet = OpenDataSet("fe100_lifetime")

        If Not IsEmpty(dset) Then
            dp_rate.Text = DataValue(dset, "straight_line")
            lifetime.Text = DataValue(dset, "lifetime")
            If DataValue(dset, "lifetime") <> "" Then
                Dim dset1 As DataSet = OpenDataSet("fe100_getMon")
                '
                If Not IsEmpty(dset) Then
                    dp_start_date.Text = DataValue(dset1, "sMon")
                    dp_end_date.Text = DataValue(dset1, "eMon")
                End If
                '
            End If
            m_stop_event = False
            Exit Sub
        End If
        m_stop_event = False
    End Sub

    Private Sub dp_start_mm_TextChanged(sender As Object, e As EventArgs) Handles dp_start_date.TextChanged
        If m_stop_event Then Exit Sub
        m_stop_event = True
        '
        If lifetime.Text <> "" And dp_start_date.Text <> "" Then
            Dim dset As DataSet = OpenDataSet("fe100_eMon")
            '
            If Not IsEmpty(dset) Then
                m_stop_event = False
                dp_end_date.Text = DataValue(dset, "eMon")
                Exit Sub
            End If
        End If
        m_stop_event = False
    End Sub

    Private Sub btn_pur_Click(sender As Object, e As EventArgs) Handles btn_pur.Click
        acc_grp.Text = "AF120"
        Me.Open("FE100_g01")
    End Sub

    Private Sub btn_wic_Click(sender As Object, e As EventArgs) Handles btn_wic.Click
        acc_grp.Text = "AF130"
        Me.Open("FE100_g01")
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        If m_stop_event Then Exit Sub
        m_stop_event = True
        '
        vc_no.Focus()
        If Not CheckRequired(asset_category, lifetime, dp_method) Then
            m_stop_event = False
            Exit Sub
        End If
        '
        If pur_date.Text <> "" Then
            Dim dset As DataSet = OpenDataSet("fe100_dpCheck")
            If DataValue(dset, "rtn") = "ERROR" Then
                m_stop_event = False
                PutMessage("BJC100_43", "Unable to register")
                Exit Sub
            End If
        End If
        '
        g20.AllowAddRows = True

        For idx As Int16 = 1 To g10.ToDec("qty")
            g20.AddNewRow()
            g20.Text("asset_name") = g10.Text("memo")
            g20.Text("asset_ename") = g10.Text("memo")
            g20.Text("pur_date") = IIf(acc_grp.Text = "AF120", g10.Text("vc_date"), pur_date.Text)
            g20.Text("pur_amount") = IIf(acc_grp.Text = "AF120", g10.Text("price"), asset_amount.Text)
            g20.Text("vc_date") = vc_date.Text
            g20.Text("vc_no") = vc_no.Text
            g20.Text("project") = project.Text
            g20.Text("dept") = dept.Text
            g20.Text("supp") = vendor.Text
            g20.Text("supp_date") = vc_date.Text
            g20.Text("dp_start_date") = dp_start_date.Text
            g20.Text("dp_end_date") = dp_end_date.Text
            g20.Text("dp_method") = "FI009100"
            g20.Text("pur_status") = "BC830100"
            g20.Text("asset_status") = "FM111600"
            g20.Text("note") = note.Text
            g20.Text("lifetime") = lifetime.Text
            g20.Text("dp_rate") = dp_rate.Text
            g20.Text("residual_rate") = 10.0
            g20.Text("residual_value") = IIf(acc_grp.Text = "AF120", g10.ToDec("price"), asset_amount.ToDec) * 10.0 / 100
        Next

        g20.AllowAddRows = False
        m_stop_event = False
    End Sub

    Private Sub g10_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        If ColumnName = "chk" And Value = "1" And acc_grp.Text = "AF120" Then
            'g10.UpdateCurrentRow()
            Dim i As Integer = 0
            For i = 0 To g10.RowCount - 1
                If g10.Text("chk", i) = "1" And i <> RowIndex Then
                    'g10.UpdateCurrentRow()
                    g10.Text("chk", i) = "0"
                    g10.UpdateCurrentRow()
                    g10.Text("chk", RowIndex) = "1"
                End If
            Next
        End If
        '
        If ColumnName = "chk" And Value = "1" And acc_grp.Text = "AF130" Then
            'g10.UpdateCurrentRow()
            Dim i As Integer = 0
            For i = 0 To g10.RowCount - 1
                If g10.Text("chk", i) = "1" And
                   i <> RowIndex And
                   g10.Text("project", i) <> g10.Text("project", RowIndex) Then
                    'g10.UpdateCurrentRow()
                    g10.Text("chk", RowIndex) = "0"
                    g10.UpdateCurrentRow()
                End If
            Next
        End If
    End Sub

    Private p As Popup
    Private Sub Init_Popup()
        p = New Popup() ' COA Popup
        p.BaseField = f_dept
        p.PopupID = "3544"
        p.SubCode = "HR200P1"
        p.Title = "Dept Search"
        p.FormWidth = 1000
        'Input 값 (Popup SQL의 Where조건에 쓰인다) 
        p.AddInput("@dept", dept)
        'Output 값 (Popup에서 선택된 후 화면에 뿌려질 필드에 대한 설정) 
        p.AddOutput("dept", dept)
        '
        p1 = New Popup() 'Project PopUp
        p1.BaseField = f_project
        p1.PopupID = "3479"
        p1.SubCode = "BJ210P"
        p1.Title = "Project Search"
        p1.FormWidth = 1000
        'Input 값 (Popup SQL의 Where조건에 쓰인다) 
        p1.AddInput("@project", project)
        'Output 값 (Popup에서 선택된 후 화면에 뿌려질 필드에 대한 설정) 
        p1.AddOutput("project_no", project)
    End Sub

    Private p1 As Popup
    Private Sub btn_project_Click(sender As Object, e As EventArgs) Handles btn_project.Click
        p1.Run(True)
    End Sub

    Private Sub EButton1_Click(sender As Object, e As EventArgs) Handles EButton1.Click
        p.Run(True)
    End Sub

    Private Sub acc_grp_TextChanged(sender As Object, oldValue As String) Handles acc_grp.TextChanged
        If acc_grp.Text = "AF130" Then
            asset_amount.Visible = True
            asset_amount.ReadOnly = True
            _ReadOnly(False)
        Else
            asset_amount.Visible = False
            _ReadOnly(True)
        End If
    End Sub

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        Dim assetAmount As Decimal = 0.0,
            i As Integer = 0
        If ColumnName = "chk" Then
            vc_no.Focus()
            asset_amount.Text = ""
            For i = 0 To g10.RowCount - 1
                If g10.Text("chk", i) = "1" Then
                    assetAmount = assetAmount + g10.ToDec("price", i)
                End If
            Next
            asset_amount.Text = assetAmount
        End If

    End Sub

    Private Sub _ReadOnly(ByVal ref As Boolean)
        pur_date.ReadOnly = ref
    End Sub

    Private Sub pur_date_TextChanged(sender As Object, e As EventArgs) Handles pur_date.TextChanged
        dp_start_date.Text = pur_date.Text
    End Sub
End Class
