Imports Frame9
Imports Base9
Imports Base9.Shared

Public Class FE730
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
                    OpenTrigger(g21)
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
        Open("FE730_Calc")
        Me.Open()
    End Sub
End Class
