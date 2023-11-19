Imports Base9

Public Class FE710
    Private Sub FE710_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    g10.Open()
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
                End If
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


    Private Sub _ReadOnly(ByVal ref As Boolean)
        g10.ReadOnly = ref
    End Sub

    Private Sub EButton1_Click(sender As Object, e As EventArgs)
        Open("FE710_TimeStamp")
    End Sub

    Private Sub EButton2_Click(sender As Object, e As EventArgs)
        Open("FE710_Trans")
    End Sub

    Private Sub EButton3_Click(sender As Object, e As EventArgs)
        Open("FE710_Result")
    End Sub

    Private Sub btn_show1_Click(sender As Object, e As EventArgs) Handles btn_show1.Click
        Dim chkview As Boolean = False
        If btn_show1.Text = "Show Warranty" Then
            btn_show1.Text = "Hide Warranty"
            chkview = True
        Else
            btn_show1.Text = "Show Warranty"
            chkview = False
        End If

        g10.ColumnVisible("war_co") = chkview
        g10.ColumnVisible("war_no") = chkview
        g10.ColumnVisible("war_date") = chkview
        g10.ColumnVisible("war_phone") = chkview
    End Sub

    Private Sub btn_show2_Click(sender As Object, e As EventArgs) Handles btn_show2.Click
        Dim chkview As Boolean = False
        If btn_show2.Text = "Show Insurance" Then
            btn_show2.Text = "Hide Insurance"
            chkview = True
        Else
            btn_show2.Text = "Show Insurance"
            chkview = False
        End If

        g10.ColumnVisible("ins_co") = chkview
        g10.ColumnVisible("ins_no") = chkview
        g10.ColumnVisible("ins_date") = chkview
        g10.ColumnVisible("ins_premium") = chkview
        g10.ColumnVisible("ins_amount") = chkview
    End Sub

    Private Sub btn_show3_Click(sender As Object, e As EventArgs) Handles btn_show3.Click
        Dim chkview As Boolean = False
        If btn_show3.Text = "Show Supplier" Then
            btn_show3.Text = "Hide Supplier"
            chkview = True
        Else
            btn_show3.Text = "Show Supplier"
            chkview = False
        End If

        g10.ColumnVisible("supp") = chkview
        g10.ColumnVisible("supp_doc_no") = chkview
        g10.ColumnVisible("supp_date") = chkview
        g10.ColumnVisible("supp_phone") = chkview
    End Sub

    Private Sub btn_show4_Click(sender As Object, e As EventArgs) Handles btn_show4.Click
        Dim chkview As Boolean = False
        If btn_show4.Text = "Show Disposal" Then
            btn_show4.Text = "Hide Disposal"
            chkview = True
        Else
            btn_show4.Text = "Show Disposal"
            chkview = False
        End If

        g10.ColumnVisible("disposal_type") = chkview
        g10.ColumnVisible("cust") = chkview
        g10.ColumnVisible("cust_date") = chkview
        g10.ColumnVisible("cust_price") = chkview
        g10.ColumnVisible("cust_doc_no") = chkview
        g10.ColumnVisible("cust_doc_date") = chkview
    End Sub
End Class
