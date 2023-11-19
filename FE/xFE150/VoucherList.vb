Public Class VoucherList
    Public PopUp As FE150P
    Public Sub InitPopUP(frmCd As Object)
        PopUp = New FE150P
        If PopUp IsNot Nothing Then
            PopUp.Dock = Windows.Forms.DockStyle.Fill

            'popup 화면에 버턴이 있다면 popup내에서 제어해도 되고 여기서도 제어 가능하다

            'AddHandler PopUp.btn_exit.Click, AddressOf btn_exit_click
            'AddHandler PopUp.btn_ok.Click, AddressOf btn_ok_click
            'AddHandler PopUp.btn_save.Click, AddressOf btn_save_click
            'PopUp.Tag = pParam
            Me.Width = 1750
            Me.Height = 800
            Me.Text = "Popup Voucher"
            Me.Controls.Add(PopUp)
            PopUp.initPopup()
            PopUp.setParam(frmCd)
            Me.StartPosition = FormStartPosition.CenterScreen

            'PopUp.btn_ok.Show()
            'PopUp.btn_query.Show()

            'PopUp.Show()

            'If PopUp IsNot Nothing Then
            'PopUp.Dock = System.Windows.Forms.DockStyle.Fill
        End If
    End Sub
End Class