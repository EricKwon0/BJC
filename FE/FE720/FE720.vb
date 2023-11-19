Imports Base9
Imports Base9.Shared

Public Class FE720
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    g10.Open()
                    'vc_no.Text = ""
                    'vc_date.Text = ""
                    'status.Text = ""
                    'yymm.Text = ""
                ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
                    g20.Open()
                    g20.ShowFilterRow() = True
                ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
                    g30.Open()
                    'OpenTrigger(g30)
                ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
                    g40.Open()
                ElseIf XtraTabControl1.SelectedTabPageIndex = 4 Then
                    g50.Open()
                ElseIf XtraTabControl1.SelectedTabPageIndex = 5 Then
                    g60.Open()
                ElseIf XtraTabControl1.SelectedTabPageIndex = 6 Then
                    g70.Open()
                ElseIf XtraTabControl1.SelectedTabPageIndex = 7 Then
                    g80.Open()
                ElseIf XtraTabControl1.SelectedTabPageIndex = 8 Then
                    g90.Open()
                End If
            Case MenuType.Print

            Case MenuType.New

            Case MenuType.Save
                If Me.Save Then
                    'Me.Open()
                End If

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


    Private Sub _ReadOnly(ByVal ref As Boolean)
        g10.ReadOnly = ref
    End Sub

    Private Sub btn_exc_Click(sender As Object, e As EventArgs) Handles btn_exc.Click
        Open("FE720_Calc")
        OpenTrigger("FE720_g10")
        g20.Find("yy = " + g10.Text("yy"))
    End Sub

    Private Sub btn_voucher_Click(sender As Object, e As EventArgs) Handles btn_voucher.Click
        If yymm.Text = "" Or vc_date.Text = "" Then
            PutMessage("", "Check. Depreciation Month And Voucher Date")
            Exit Sub
        End If
        Open("FE720_Voucher")
        '
        Dim dSet As DataSet = OpenDataSet("FE720_VCStatus")
        If Not IsEmpty(dSet) Then
            vc_no.Text = DataValue(dSet, "vc_no")
            vc_date.Text = DataValue(dSet, "vc_date")
            status.Text = DataValue(dSet, "status")
            Exit Sub
        End If
    End Sub

    Private Sub yymm_TextChanged(sender As Object, e As EventArgs) Handles yymm.TextChanged
        'Open("FE720_VCStatus")
        Dim dSet As DataSet = OpenDataSet("FE720_VCStatus")
        If Not IsEmpty(dSet) Then
            vc_no.Text = DataValue(dSet, "vc_no")
            vc_date.Text = DataValue(dSet, "vc_date")
            status.Text = DataValue(dSet, "status")
            Exit Sub
        Else
            vc_no.Text = ""
            vc_date.Text = ""
            status.Text = ""
        End If
    End Sub

    Private Sub status_TextChanged(sender As Object, e As EventArgs) Handles status.TextChanged
        If status.Text > "FI020200" Then
            btn_voucher.Enabled = False
        Else
            btn_voucher.Enabled = True
        End If
    End Sub

    Private Sub g10_DoubleClick(sender As Object, e As EventArgs) Handles g10.DoubleClick
        If SplitContainer2.Panel2Collapsed = True Then
            SplitContainer2.Panel2Collapsed = False
            g20.Open()
            g20.Find("yy = " + g10.Text("yy"))
        Else
            SplitContainer2.Panel2Collapsed = True
        End If
    End Sub

    Private Sub FE720_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer2.Panel2Collapsed = True
        g10.SelectRow = True
        g20.SelectRow = True
    End Sub
End Class
