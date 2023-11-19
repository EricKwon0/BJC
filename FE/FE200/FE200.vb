Imports Frame9
Imports Base9
Imports Base9.Shared


Public Class FE200

    Public Overrides Sub Open()
        MyBase.Open()
    End Sub

    Public Overrides Function Save() As Boolean
        'If MyBase.Save() Then
        '    Dim finder As String = g10.Text("pid")
        '    Me.Open()
        '    g10.Find("pid= " + finder)
        'End If
    End Function

End Class
