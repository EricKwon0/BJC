Imports System.Data
Imports System.Net
Imports Base9
Imports Base9.Shared

Public Class FE150

    Private Sub FE150_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'asset_no.CodeNo = "FE300"
        'asset_no.CodeDateField = install_date\
        startCustomFtp(Me.Name) 'FTP Inint
        Me.Open()
        g30.RowAutoHeight = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
                If pid.Text = "" Then
                    btn_voucher.Enabled = True
                Else
                    btn_voucher.Enabled = False
                End If

            'Case MenuType.Print
            '    Me.Print()

            Case MenuType.New
                g10.AllowAddRows = True
                g10.AddNewRow()
                _ReadOnly(False)
                g10.AllowAddRows = False

                'asset_no.Text = ""
                'OpenTrigger("fe150_g10")
                'btn_voucher.Enabled = True
                '_ReadOnly(False)

            Case MenuType.Save
                If Me.Save() Then
                    Dim finder As String = asset_no.Text
                    Me.Open()
                    g10.Find("asset_no = " + finder)
                End If

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

#Region "Voucher List PopUp"
    Private Sub btn_voucher_Click(sender As Object, e As EventArgs) Handles btn_voucher.Click
        Dim popup As New VoucherList
        popup = New VoucherList
        popup.InitPopUP(Me)
        If popup.ShowDialog() = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Public Sub setValue(vcNo As String, vcDate As String, vcAmount As Decimal)
        If vcNo <> "" Then
            vc_no.Text = vcNo
            vc_date.Text = vcDate
            pur_date.Text = vcDate
            bg_date.Text = vcDate
            pur_amount.Text = vcAmount
            bg_amount.Text = vcAmount
            dp_amount.Text = vcAmount
        Else
            pur_amount.Text = vcAmount
            bg_amount.Text = vcAmount
            dp_amount.Text = vcAmount
        End If
    End Sub
#End Region

#Region "Custom FTP"
    Private cuFtpid As String, cuFtpip As String, cuFtppwd As String, cuFtproot As String, cuFtppath As String, cuFtpfullpath As String, cuLocalpath As String, cuFrmcd As String
    Private Sub startCustomFtp(frmCd As String)
        '0. FB100À» Âü°íÇÏ¿© ¸¸µé¾úÀ½
        '1. Grid ÀÌ¸§Àº cuFtp
        '2. FormLoad½Ã startCustomFtp(Me.Name) È£Ãâ
        '3. GLBFTP¿¡¼­ WorkSet Copy ([formName]_cuFtp, [formName]_ftpInfo)
        '* FTP path information¿¡´Â ¼ÂÆÃÇÏÁö ¾Ê´Â´Ù. 

        cuFtp.AllowDrop = True
        cuFtp.AllowAddRows = True
        cuFtp.AllowDeleteRows = True

        Dim strinfo As String = frmCd + "_ftpInfo"
        Dim dset As DataSet = OpenDataSet(strinfo)

        If IsEmpty(dset) Then
            Exit Sub
        End If

        cuFtpip = DataValue(dset, "cuFtpip").ToString()
        cuFtpid = DataValue(dset, "cuFtpid").ToString()
        cuFtppwd = DataValue(dset, "cuFtppwd").ToString()
        cuFtproot = DataValue(dset, "cuFtproot").ToString()
        cuFtppath = DataValue(dset, "cuFtproot").ToString() + Year(Today).ToString + Format(Today, "MM")
        cuLocalpath = DataValue(dset, "cuLocalpath").ToString()
        cuFtpfullpath = cuFtpip + cuFtproot + Year(Today).ToString + Format(Today, "MM")
        cuFrmcd = frmCd

        CreateFTPDirectory(cuFtpip + cuFtproot, cuFtpid, cuFtppwd)
        CreateFTPDirectory(cuFtpip + cuFtproot + Year(Today).ToString + Format(Today, "MM"), cuFtpid, cuFtppwd)
    End Sub

    Private Sub CreateFTPDirectory(cuFtpfullpath As String, cuFtpid As String, cuFtppwd As String)
        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(cuFtpfullpath)
            request.Method = WebRequestMethods.Ftp.MakeDirectory
            request.Credentials = New NetworkCredential(cuFtpid, cuFtppwd)
            Using response = DirectCast(request.GetResponse(), FtpWebResponse)
            End Using
        Catch ex As WebException
            If TypeOf ex.Response Is FtpWebResponse Then
                Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
                If response.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                Else
                    Throw
                End If
            Else
                Throw
            End If
        End Try
    End Sub

    Private Sub cuFtp_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles cuFtp.ButtonPressed
        Dim fileId As String = cuFtp.Text("fid")
        Dim filePath As String = cuFtp.Text("fPath")
        Dim fileNm As String = cuFtp.Text("fNm")      'LOG »ý¼º¿¡ »ç¿ëµÈ´Ù.
        Dim filefrmNm As String = cuFtp.Text("frmNm") 'LOG »ý¼º¿¡ »ç¿ëµÈ´Ù.

        If columnName = "upload" AndAlso fileId = "" Then
            If Not MyBase.Save() Then
                Exit Sub
            End If

            Dim fullPath As String = ""

            Try
                Dim OpenDialog As New OpenFileDialog
                OpenDialog.Filter = "All files (*.*)|*.*"
                OpenDialog.Multiselect = False

                If OpenDialog.ShowDialog = DialogResult.OK Then
                    fullPath = OpenDialog.FileName
                End If

            Catch ex As Exception

            End Try

            If fullPath = "" Then Exit Sub

            'Grid³» °°Àº File¸í Ã¼Å© 
            'fileNm = System.IO.Path.GetFileName(fullPath)
            'If Me._IsExists(g30, fileNm) Then
            '    If PutYesNo("GAM100_01", "ÀÌ¹Ì °°Àº ÆÄÀÏ¸íÀ» °¡Áø ÆÄÀÏÀÌ Á¸ÀçÇÕ´Ï´Ù.<br><br>±×·¡µµ Upload ÇÏ½Ã°Ú½À´Ï±î ?<br><br>[@1]", fileNm) = MsgBoxResult.No Then
            '        Exit Sub
            '    End If
            'End If

            'Grid¿¡ ¼±ÅÃÆÄÀÏ Ãß°¡
            fileId = [FTPShared].FileUpload("", fullPath)

            ' ¿À·ù¼öÁ¤: fileID °¡ ¾ø¾î¸é ÀúÀå ¾ÈµÇ°Ô ÇØ¾ßÇÑ´Ù
            If fileId <> "" Then

                fileId = System9.FTPShared.FileUpload(cuFtppath, fullPath, cuFrmcd, False, False)

                Dim f As New System.IO.FileInfo(fullPath)

                cuFtp.Text("fid") = fileId
                cuFtp.Text("fPath") = cuFtppath
                cuFtp.Text("fNm") = System.IO.Path.GetFileName(fullPath)
                cuFtp.Text("fSize") = f.Length.ToString()
                cuFtp.Text("fExt") = System.IO.Path.GetExtension(fullPath)
                cuFtp.Text("frmNm") = cuFrmcd

                cuFtp.Save()
                cuFtp.Open()
            End If


            Exit Sub
        End If

        If fileNm = "" Then
            Exit Sub
        End If


        If columnName = "del" Then
            Try
                If System9.FTPShared.FileDelete(fileId, fileNm, filePath, cuFrmcd, False) = True Then
                    cuFtp.AllowDeleteRows = True
                    cuFtp.DeleteRow(cuFtp.RowIndex)
                    cuFtp.AllowDeleteRows = False
                    Me.Save(cuFtp.WorkSet)
                End If
            Catch ex As Exception
                MessageInfo(ex)
            End Try

        End If

        If columnName = "show" Then
            System9.FTPShared.FileDownLoad(fileId, fileNm, filePath, True, cuFrmcd, cuLocalpath)
        End If

        If columnName = "down" Then
            System9.FTPShared.FileDownLoad(fileId, fileNm, filePath, False, cuFrmcd, cuLocalpath)
        End If
    End Sub

    Private Sub cuFtp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles cuFtp.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            If Not MyBase.Save() Then
                Exit Sub
            End If

            ''Grid³» °°Àº File¸í Ã¼Å©
            'For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
            '    fileNm = System.IO.Path.GetFileName(fileNm)
            '    If Me._IsExists(ftp10, fileNm) Then
            '        If MessageYesNo("ÀÌ¹Ì °°Àº ÆÄÀÏ¸íÀ» °¡Áø ÆÄÀÏÀÌ Á¸ÀçÇÕ´Ï´Ù." + vbLf + vbLf +
            '                        "±×·¡µµ Upload ÇÏ½Ã°Ú½À´Ï±î ?" + vbLf + vbLf + "[" + fileNm + "]") = MsgBoxResult.No Then
            '            Exit Sub
            '        End If
            '    End If
            'Next

            'Grid¿¡ ¼±ÅÃÆÄÀÏ Ãß°¡
            Dim fullPath As String
            cuFtp.AllowAddRows = True
            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)
                Dim FileID As String = System9.FTPShared.FileUpload(cuFtppath, fullPath, cuFrmcd, False, False)
                If FileID <> "" And fullPath <> "" Then
                    Dim f As New System.IO.FileInfo(fullPath)
                    cuFtp.AddNewRow()
                    cuFtp.Text("fid") = FileID
                    cuFtp.Text("fPath") = cuFtppath
                    cuFtp.Text("fNm") = System.IO.Path.GetFileName(fullPath)
                    cuFtp.Text("fSize") = f.Length.ToString()
                    cuFtp.Text("fExt") = System.IO.Path.GetExtension(fullPath)
                    cuFtp.Text("frmNm") = cuFrmcd
                End If
            Next
            cuFtp.AllowAddRows = False
            Me.Save(cuFtp.WorkSet)
            cuFtp.Open()
        End If
    End Sub

    Private Sub cuFtp_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles cuFtp.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    'Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
    '    With g
    '        For i As Integer = 0 To .RowCount - 1
    '            If .Text("file_nm", i) = fileNm Then
    '                Return True
    '            End If
    '        Next
    '    End With
    '    Return False
    'End Function
#End Region

    Public m_stop_event As Boolean
    Private Sub lifetime_TextChanged(sender As Object, oldValue As String) Handles lifetime.TextChanged
        If Not CheckRequired(pur_date) Then
            MessageBox.Show("Please, Check Purchase Date.")
            Return
        End If

        If Not CheckRequired(asset_category) Then
            MessageBox.Show("Please, Check Asset Category.")
            Return
        End If

        If m_stop_event Then Return

        m_stop_event = True
        Dim dset As DataSet = OpenDataSet("fe150_getMon")
        If Not IsEmpty(dset) Then
            dp_start_date.Text = DataValue(dset, "sDate")
            dp_end_date.Text = DataValue(dset, "eDate")
        End If

        Dim dset2 As DataSet = OpenDataSet("fe150_dpRate")
        If Not IsEmpty(dset) Then
            dp_rate.Text = DataValue(dset2, "straight_line")
        End If

        m_stop_event = False
    End Sub

    Private Sub asset_category_TextChanged(sender As Object, e As EventArgs) Handles asset_category.TextChanged
        If m_stop_event Then Return

        m_stop_event = True
        Dim dset As DataSet = OpenDataSet("fe150_lifetime")
        If Not IsEmpty(dset) Then
            lifetime.Text = DataValue(dset, "lifetime")
        End If

        Dim dset1 As DataSet = OpenDataSet("fe150_dpRate")
        If Not IsEmpty(dset1) Then
            dp_rate.Text = DataValue(dset1, "straight_line")
        End If

        Dim dset2 As DataSet = OpenDataSet("fe150_getMon")
        If Not IsEmpty(dset2) Then
            dp_start_date.Text = DataValue(dset2, "sDate")
            dp_end_date.Text = DataValue(dset2, "eDate")
        End If
        m_stop_event = False
    End Sub

    Private Sub pid_TextChanged(sender As Object, oldValue As String) Handles pid.TextChanged
        If pid.Text = "" Then
            btn_voucher.Enabled = True
        Else
            btn_voucher.Enabled = False
        End If
    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        Dim rcnt As Integer = g10.RowCount - 1
        If g10.Text("asset_no", rcnt) = "" And rcnt <> RowIndex Then
            g10.AllowDeleteRows = True
            g10.DeleteRow(rcnt)
            g10.AllowDeleteRows = False
        End If

        If g10.Text("asset_status", RowIndex) >= "FM111100" Then
                btn_voucher.Enabled = False
            Else
            btn_voucher.Enabled = True
        End If
        '
        If g10.Text("chk_read", RowIndex) = "0" Then
            _ReadOnly(False)
        Else
            _ReadOnly(True)
        End If
        '
        If g10.Text("cust_vc_no", RowIndex) = "" Then
            _Disposal_ReadOnly(False)
        Else
            _Disposal_ReadOnly(True)
        End If
    End Sub

    Private Sub _Disposal_ReadOnly(ByVal ref As Boolean)
        cust_date.ReadOnly = ref
        cust.ReadOnly = ref
        cust_name.ReadOnly = ref
        cust_price.ReadOnly = ref
        'cust_vc_no.ReadOnly = ref
        cust_doc_no.ReadOnly = ref
        cust_doc_date.ReadOnly = ref
        disposal_type.ReadOnly = ref
        cust_vat.ReadOnly = ref
    End Sub

    Private Sub g30_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanged
        If ColumnName = "pur_date" Then
            g30.Text("dp_start_date") = g30.Text("pur_date")

            Dim p As OpenParameters = New OpenParameters
            p.Add("@pur_date", g30.Text("pur_date"))
            p.Add("@lifetime", g30.ToDec("lifetime"))

            Dim dset2 As DataSet = OpenDataSet("fe150_getMon", p)
            If Not IsEmpty(dset2) Then
                g30.Text("dp_end_date") = DataValue(dset2, "eDate")
            End If
        End If

        If ColumnName = "lifetime" Then
            Dim p As OpenParameters = New OpenParameters
            p.Add("@pur_date", g30.Text("pur_date"))
            p.Add("@lifetime", g30.ToDec("lifetime"))
            Dim dset2 As DataSet = OpenDataSet("fe150_getMon", p)
            If Not IsEmpty(dset2) Then
                g30.Text("dp_end_date") = DataValue(dset2, "eDate")
            End If

            Dim p1 As OpenParameters = New OpenParameters
            p1.Add("@ltime", g30.ToDec("lifetime"))
            Dim dset1 As DataSet = OpenDataSet("fe150_dpRate", p1)
            If Not IsEmpty(dset1) Then
                g30.Text("dp_rate") = DataValue(dset1, "straight_line")
            End If
        End If

        If ColumnName = "pur_amount" Then
            Try
                g30.Text("residual_value") = g30.ToDec("pur_amount") * g30.ToDec("residual_rate") / 100.0
            Catch ex As Exception
            End Try
        End If

        If ColumnName = "residual_rate" Then
            If m_stop_event Then Return

            m_stop_event = True
            Try
                g30.Text("residual_value") = g30.ToDec("pur_amount") * g30.ToDec("residual_rate") / 100.0
            Catch ex As Exception
            End Try
            m_stop_event = False
        End If

        If ColumnName = "residual_value" Then
            If m_stop_event Then Return

            m_stop_event = True
            Try
                g30.Text("residual_rate") = g30.ToDec("pur_amount") / g30.ToDec("residual_value") / 100.0
            Catch ex As Exception
            End Try
            m_stop_event = False
        End If
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        If g30.Text("pur_date") = "" Then
            MessageBox.Show("Please, Check Additional Date.")
            Return
        End If

        If g30.ToDec("pur_amount") = 0 Then
            MessageBox.Show("Please, Check Additional Amount.")
            Return
        End If

        If g30.ToDec("lifetime") = 0 Then
            MessageBox.Show("Please, Check LifeTime.")
            Return
        End If

        If g30.ToDec("residual_value") = 0 Then
            MessageBox.Show("Please, Check Residual Value.")
            Return
        End If

        If g30.Text("pur_status") = "" Then
            MessageBox.Show("Please, Check Purchase Status.")
            Return
        End If

        Save("FE150_g30")
        Open("FE150_g30")
        'Dim yy As Integer = g30.Text("pur_date").Substring(0, 4)
        'Dim mm As String = g30.Text("pur_date").Substring(5, 2)
        'yy = yy + 543
        'Dim ast_no As String = g30.Text("asset_category") + "-" + yy.ToString.Substring(2, 2) + mm
        'MessageBox.Show(ast_no)
    End Sub

    Private Sub cust_price_TextChanged(sender As Object, oldValue As String) Handles cust_price.TextChanged
        If cust_price.ToDec <> 0.0 And cust_price.Text <> "" Then
            cust_vat.Text = cust_price.ToDec * 10 / 100
        End If
    End Sub

    Private Sub _ReadOnly(ByVal ref As Boolean)
        asset_category.ReadOnly = ref
        project.ReadOnly = ref
        store.ReadOnly = ref
        dept.ReadOnly = ref
        pur_amount.ReadOnly = ref
        pur_date.ReadOnly = ref
        residual_rate.ReadOnly = ref
        residual_value.ReadOnly = ref
        lifetime.ReadOnly = ref

        'asset_no.ReadOnly = ref
        'dp_start_date.ReadOnly = ref
        'dp_end_date.ReadOnly = ref
        'manager.ReadOnly = ref
        'pur_status.ReadOnly = ref
        'asset_status.ReadOnly = ref
        'asset_name.ReadOnly = ref
        'asset_ename.ReadOnly = ref
        'asset_location.ReadOnly = ref
        'model.ReadOnly = ref
        'serial.ReadOnly = ref
        'car_no.ReadOnly = ref
        'facility_no.ReadOnly = ref
        'vc_no.ReadOnly = ref
        'vc_date.ReadOnly = ref
        'note.ReadOnly = ref
        'dp_method.ReadOnly = ref
        'dp_rate.ReadOnly = ref
        'book_value.ReadOnly = ref
        'cumulative.ReadOnly = ref
        'supp.ReadOnly = ref
        'supp_date.ReadOnly = ref
        'supp_doc_no.ReadOnly = ref
        'supp_phone.ReadOnly = ref
        'war_co.ReadOnly = ref
        'war_no.ReadOnly = ref
        'war_date.ReadOnly = ref
        'war_phone.ReadOnly = ref
        'ins_co.ReadOnly = ref
        'ins_no.ReadOnly = ref
        'ins_date.ReadOnly = ref
        'ins_amount.ReadOnly = ref
        'ins_premium.ReadOnly = ref
        'disposal_type.ReadOnly = ref
        'cust_date.ReadOnly = ref
        'cust.ReadOnly = ref
        'cust_name.ReadOnly = ref
        'cust_price.ReadOnly = ref
        'cust_vc_no.ReadOnly = ref
        'cust_doc_no.ReadOnly = ref
        'cust_doc_date.ReadOnly = ref
        'picture.ReadOnly = ref
        'picture2.ReadOnly = ref
    End Sub

    Private Sub btn_addition_Click(sender As Object, e As EventArgs) Handles btn_addition.Click
        If parent_asset_no.Text = "" And asset_no.Text <> "" Then
            g30.AllowAddRows = True
            g30.AddNewRow()
            g30.Text("asset_category") = asset_category.Text
            g30.Text("asset_no") = ""
            g30.Text("parent_asset_no") = asset_no.Text
            g30.Text("asset_name") = asset_name.Text
            g30.Text("asset_ename") = asset_ename.Text
            'g30.Text("pur_date") = add_date.Text
            'g30.Text("pur_amount") = add_amount.Text
            'g30.Text("dp_start_date") = add_dp_start_date.Text
            'g30.Text("dp_end_date") = add_dp_end_date.Text
            g30.Text("dp_method") = dp_method.Text
            g30.Text("lifetime") = lifetime.Text
            g30.Text("dp_rate") = dp_rate.Text
            g30.Text("residual_rate") = residual_rate.Text
            g30.Text("residual_value") = residual_value.Text
            g30.Text("pur_status") = "BC830100"
            g30.Text("asset_status") = "FM111100"
            g30.Text("dept") = dept.Text
            g30.Text("project") = project.Text
            g30.Text("dept") = dept.Text
            g30.Text("dept") = dept.Text
            g30.Text("dept") = dept.Text
            g30.Text("dept") = dept.Text
            g30.Text("dept") = dept.Text
            g30.Text("note") = note.Text
            g30.AllowAddRows = False
        Else
            MessageBox.Show("This is not Original Asset. Can not make Additional.")
        End If
    End Sub

    Private Sub pur_amount_TextChanged(sender As Object, oldValue As String) Handles pur_amount.TextChanged
        Try
            residual_value.Text = pur_amount.ToDec * residual_rate.ToDec / 100
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pur_date_TextChanged(sender As Object, e As EventArgs) Handles pur_date.TextChanged
        'If Not CheckRequired(asset_category) Then
        '    MessageBox.Show("Please, Check Asset Category.")
        '    Return
        'End If

        If m_stop_event Then Return

        m_stop_event = True
        If lifetime.Text <> "" Then
            Dim dset As DataSet = OpenDataSet("fe150_getMon")
            If Not IsEmpty(dset) Then
                dp_start_date.Text = DataValue(dset, "sDate")
                dp_end_date.Text = DataValue(dset, "eDate")
            End If
        End If
        m_stop_event = False
    End Sub

    Private Sub dp_start_mm_TextChanged(sender As Object, e As EventArgs) Handles dp_start_date.TextChanged
        If m_stop_event Then Exit Sub
        m_stop_event = True
        '
        If lifetime.Text <> "" And dp_start_date.Text <> "" Then
            Dim dset As DataSet = OpenDataSet("fe150_eMon")
            '
            If Not IsEmpty(dset) Then
                m_stop_event = False
                dp_end_date.Text = DataValue(dset, "eDate")
                Exit Sub
            End If
        End If
        m_stop_event = False
    End Sub

    Private Sub residual_value_TextChanged(sender As Object, oldValue As String) Handles residual_value.TextChanged
        If m_stop_event Then Return

        m_stop_event = True
        Try
            residual_rate.Text = residual_value.ToDec / pur_amount.ToDec * 100.0
        Catch ex As Exception
        End Try
        m_stop_event = False
    End Sub

    Private Sub residual_rate_TextChanged(sender As Object, oldValue As String) Handles residual_rate.TextChanged
        If m_stop_event Then Return

        m_stop_event = True
        Try
            residual_value.Text = pur_amount.ToDec * residual_rate.ToDec / 100.0
        Catch ex As Exception
        End Try
        m_stop_event = False
    End Sub
End Class