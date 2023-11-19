Imports Base9

Public Class FE900
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
        Open("FE900_TimeStamp")
    End Sub

    Private Sub EButton2_Click(sender As Object, e As EventArgs)
        Open("FE900_Trans")
    End Sub

    Private Sub EButton3_Click(sender As Object, e As EventArgs)
        Open("FE900_Result")
    End Sub
End Class
