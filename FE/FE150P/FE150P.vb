Imports Frame9
Imports Base9
Imports Base9.Shared
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Text

Public Class FE150P
    Private Sub FE150P_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Init_Popup()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
                If acc_grp.Text = "AF130" Then
                    extra_amount.ReadOnly = False
                Else
                    extra_amount.ReadOnly = True
                End If

            Case MenuType.Print

            Case MenuType.New

            Case MenuType.Save

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select
    End Sub

#Region "Customer Popup"
    Private m_ParentForm As Object
    Public Sub initPopup()
    End Sub

    Public Sub setParam(parentsFrm As Object)
        m_ParentForm = parentsFrm
    End Sub

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If g10.Text("chk", RowIndex) = "1" Then
            If acc_grp.Text = "AF120" Then
                'vcNo.Text = g10.Text("vc_no", RowIndex)
                'vcDate.Text = g10.Text("vc_date", RowIndex)
                'vcAmount.Text = g10.ToDec("dr", RowIndex)
                Dim i As Integer = 0
                For i = 0 To g10.RowCount - 1
                    If g10.Text("chk", i) = "1" Then
                        g10.Text("chk", i) = "0"
                    End If
                Next
            End If
            '
        End If
    End Sub

    Private Sub returnResult()
        If acc_grp.Text = "AF130" Then
            Dim amt As Decimal = 0.0,
                i As Integer = 0
            '
            For i = 0 To g10.RowCount - 1
                If g10.Text("chk", i) = "1" Then
                    amt = amt + g10.ToDec("dr", i)
                End If
            Next
            '
            vcAmount.Text = amt + extra_amount.ToDec
            m_ParentForm.setValue("", "", vcAmount.ToDec)
        Else
            m_ParentForm.setValue(vcNo.Text, vcDate.Text, vcAmount.ToDec)
        End If
        'acc_cd.Focus()
        'For ii = 0 To g10.RowCount - 1
        '    If g10.Text("chk", ii) = "1" Then
        '        m_ParentForm.setValue(g10.Text("vc_no", ii))
        '    End If
        'Next

        ParentForm.Close()
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        returnResult()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        acc_cd.Focus()
        For ii = 0 To g10.RowCount - 1
            If g10.Text("chk", ii) = "1" Then
                g10.Text("chk", ii) = "0"
            End If
        Next
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ParentForm.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        g10.Open()
    End Sub

    Private Sub btn_pur_Click(sender As Object, e As EventArgs) Handles btn_pur.Click
        acc_grp.Text = "AF120"
        extra_amount.ReadOnly = True
        extra_amount.Visible = False
        Me.Open()
    End Sub

    Private Sub btn_wic_Click(sender As Object, e As EventArgs) Handles btn_wic.Click
        acc_grp.Text = "AF130"
        extra_amount.ReadOnly = False
        extra_amount.Visible = True
        Me.Open()
    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        vcNo.Text = g10.Text("vc_no", RowIndex)
        vcDate.Text = g10.Text("vc_date", RowIndex)
        vcAmount.Text = g10.Text("dr", RowIndex)
    End Sub

    Private p As Popup
    Private Sub Init_Popup()
        p = New Popup() ' COA Popup
        p.BaseField = acc_cd
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
        p1.BaseField = project
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


#End Region
End Class
