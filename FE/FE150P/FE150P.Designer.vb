<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FE150P
    Inherits Base9.Form

    'UserControl1은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EPanel1 = New Frame9.ePanel()
        Me.EPanel2 = New Frame9.ePanel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame9.ePanel()
        Me.EButton1 = New Frame9.eButton()
        Me.btn_project = New Frame9.eButton()
        Me.vcAmount = New Frame9.eText()
        Me.vcDate = New Frame9.eDate()
        Me.vcNo = New Frame9.eText()
        Me.acc_grp = New Frame9.eText()
        Me.extra_amount = New Frame9.eText()
        Me.btn_wic = New Frame9.eButton()
        Me.btn_pur = New Frame9.eButton()
        Me.memo = New Frame9.eText()
        Me.project = New Frame9.eText()
        Me.dept = New Frame9.eText()
        Me.cust = New Frame9.eText()
        Me.to_dt = New Frame9.eDate()
        Me.fr_dt = New Frame9.eDate()
        Me.btnOpen = New Frame9.eButton()
        Me.btn_close = New Frame9.eButton()
        Me.btn_clear = New Frame9.eButton()
        Me.btn_select = New Frame9.eButton()
        Me.vc_no = New Frame9.eText()
        Me.acc_cd = New Frame9.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g10 = New Frame9.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame9.eGrid()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(274, 185)
        Me.EPanel1.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(274, 185)
        Me.EPanel2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1750, 800)
        Me.SplitContainer1.SplitterDistance = 84
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.EButton1)
        Me.EPanel3.Controls.Add(Me.btn_project)
        Me.EPanel3.Controls.Add(Me.vcAmount)
        Me.EPanel3.Controls.Add(Me.vcDate)
        Me.EPanel3.Controls.Add(Me.vcNo)
        Me.EPanel3.Controls.Add(Me.acc_grp)
        Me.EPanel3.Controls.Add(Me.extra_amount)
        Me.EPanel3.Controls.Add(Me.btn_wic)
        Me.EPanel3.Controls.Add(Me.btn_pur)
        Me.EPanel3.Controls.Add(Me.memo)
        Me.EPanel3.Controls.Add(Me.project)
        Me.EPanel3.Controls.Add(Me.dept)
        Me.EPanel3.Controls.Add(Me.cust)
        Me.EPanel3.Controls.Add(Me.to_dt)
        Me.EPanel3.Controls.Add(Me.fr_dt)
        Me.EPanel3.Controls.Add(Me.btnOpen)
        Me.EPanel3.Controls.Add(Me.btn_close)
        Me.EPanel3.Controls.Add(Me.btn_clear)
        Me.EPanel3.Controls.Add(Me.btn_select)
        Me.EPanel3.Controls.Add(Me.vc_no)
        Me.EPanel3.Controls.Add(Me.acc_cd)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1750, 84)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Search"
        '
        'EButton1
        '
        Me.EButton1.Location = New System.Drawing.Point(721, 27)
        Me.EButton1.Name = "EButton1"
        Me.EButton1.Size = New System.Drawing.Size(26, 20)
        Me.EButton1.TabIndex = 42
        Me.EButton1.Text = "..."
        '
        'btn_project
        '
        Me.btn_project.Location = New System.Drawing.Point(721, 50)
        Me.btn_project.Name = "btn_project"
        Me.btn_project.Size = New System.Drawing.Size(26, 20)
        Me.btn_project.TabIndex = 41
        Me.btn_project.Text = "..."
        '
        'vcAmount
        '
        Me.vcAmount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcAmount.Location = New System.Drawing.Point(889, 205)
        Me.vcAmount.Name = "vcAmount"
        Me.vcAmount.Size = New System.Drawing.Size(240, 20)
        Me.vcAmount.TabIndex = 24
        Me.vcAmount.Title = "Project"
        Me.vcAmount.TitleWidth = 90
        '
        'vcDate
        '
        Me.vcDate.Location = New System.Drawing.Point(663, 205)
        Me.vcDate.Name = "vcDate"
        Me.vcDate.Size = New System.Drawing.Size(220, 20)
        Me.vcDate.TabIndex = 23
        Me.vcDate.Title = "Voucher Date"
        Me.vcDate.TitleWidth = 90
        '
        'vcNo
        '
        Me.vcNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcNo.Location = New System.Drawing.Point(415, 205)
        Me.vcNo.Name = "vcNo"
        Me.vcNo.Size = New System.Drawing.Size(240, 20)
        Me.vcNo.TabIndex = 22
        Me.vcNo.Title = "Voucher No"
        Me.vcNo.TitleWidth = 90
        '
        'acc_grp
        '
        Me.acc_grp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acc_grp.Location = New System.Drawing.Point(755, 50)
        Me.acc_grp.Name = "acc_grp"
        Me.acc_grp.Size = New System.Drawing.Size(240, 20)
        Me.acc_grp.TabIndex = 21
        Me.acc_grp.Title = "COA Group"
        Me.acc_grp.TitleWidth = 90
        '
        'extra_amount
        '
        Me.extra_amount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extra_amount.Location = New System.Drawing.Point(1655, 38)
        Me.extra_amount.Name = "extra_amount"
        Me.extra_amount.Size = New System.Drawing.Size(232, 20)
        Me.extra_amount.TabIndex = 20
        Me.extra_amount.Title = "Extra Amount"
        Me.extra_amount.TitleWidth = 115
        Me.extra_amount.Visible = False
        '
        'btn_wic
        '
        Me.btn_wic.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_wic.Appearance.Options.UseBackColor = True
        Me.btn_wic.Location = New System.Drawing.Point(1324, 25)
        Me.btn_wic.Name = "btn_wic"
        Me.btn_wic.Size = New System.Drawing.Size(113, 45)
        Me.btn_wic.TabIndex = 19
        Me.btn_wic.Text = "WIC List"
        '
        'btn_pur
        '
        Me.btn_pur.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_pur.Appearance.Options.UseBackColor = True
        Me.btn_pur.Location = New System.Drawing.Point(1205, 25)
        Me.btn_pur.Name = "btn_pur"
        Me.btn_pur.Size = New System.Drawing.Size(113, 45)
        Me.btn_pur.TabIndex = 18
        Me.btn_pur.Text = "Purchase List"
        '
        'memo
        '
        Me.memo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memo.Location = New System.Drawing.Point(755, 28)
        Me.memo.Name = "memo"
        Me.memo.Size = New System.Drawing.Size(407, 20)
        Me.memo.TabIndex = 17
        Me.memo.Title = "Description"
        Me.memo.TitleWidth = 90
        '
        'project
        '
        Me.project.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.project.Location = New System.Drawing.Point(477, 50)
        Me.project.Name = "project"
        Me.project.Size = New System.Drawing.Size(240, 20)
        Me.project.TabIndex = 16
        Me.project.Title = "Project"
        Me.project.TitleWidth = 90
        '
        'dept
        '
        Me.dept.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dept.Location = New System.Drawing.Point(477, 27)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(240, 20)
        Me.dept.TabIndex = 15
        Me.dept.Title = "Dept"
        Me.dept.TitleWidth = 90
        '
        'cust
        '
        Me.cust.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cust.Location = New System.Drawing.Point(231, 50)
        Me.cust.Name = "cust"
        Me.cust.Size = New System.Drawing.Size(240, 20)
        Me.cust.TabIndex = 14
        Me.cust.Title = "Vendor"
        Me.cust.TitleWidth = 90
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(65, 50)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(160, 20)
        Me.to_dt.TabIndex = 13
        Me.to_dt.Title = "~"
        Me.to_dt.TitleAlign = Frame9.Alignment.Center
        Me.to_dt.TitleWidth = 30
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(5, 27)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(220, 20)
        Me.fr_dt.TabIndex = 12
        Me.fr_dt.Title = "Voucher Date"
        Me.fr_dt.TitleWidth = 90
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(1100, 163)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(90, 23)
        Me.btnOpen.TabIndex = 11
        Me.btnOpen.Text = "Query"
        '
        'btn_close
        '
        Me.btn_close.Appearance.BackColor = System.Drawing.Color.Gray
        Me.btn_close.Appearance.Options.UseBackColor = True
        Me.btn_close.Location = New System.Drawing.Point(1559, 25)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(90, 45)
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "Close"
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(1292, 163)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(90, 23)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "Clear"
        '
        'btn_select
        '
        Me.btn_select.Appearance.BackColor = System.Drawing.Color.Gray
        Me.btn_select.Appearance.Options.UseBackColor = True
        Me.btn_select.Location = New System.Drawing.Point(1463, 25)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(90, 45)
        Me.btn_select.TabIndex = 8
        Me.btn_select.Text = "Select"
        '
        'vc_no
        '
        Me.vc_no.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vc_no.Location = New System.Drawing.Point(231, 27)
        Me.vc_no.Name = "vc_no"
        Me.vc_no.Size = New System.Drawing.Size(240, 20)
        Me.vc_no.TabIndex = 7
        Me.vc_no.Title = "Voucher No"
        Me.vc_no.TitleWidth = 90
        '
        'acc_cd
        '
        Me.acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acc_cd.Location = New System.Drawing.Point(1001, 50)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(161, 20)
        Me.acc_cd.TabIndex = 5
        Me.acc_cd.Title = "COA"
        Me.acc_cd.TitleWidth = 50
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1750, 712)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1744, 683)
        Me.XtraTabPage1.Text = "Quotation List"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(1744, 683)
        Me.g10.TabIndex = 1
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g20)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1744, 683)
        Me.XtraTabPage2.Text = "Detail"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.Size = New System.Drawing.Size(1744, 683)
        Me.g20.TabIndex = 1
        '
        'FE150P
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FE150P"
        Me.Size = New System.Drawing.Size(1750, 800)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame9.ePanel
    Friend WithEvents EPanel2 As Frame9.ePanel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents EPanel3 As Frame9.ePanel
    Friend WithEvents vc_no As Frame9.eText
    Friend WithEvents acc_cd As Frame9.eText
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame9.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g20 As Frame9.eGrid
    Friend WithEvents btn_close As Frame9.eButton
    Friend WithEvents btn_clear As Frame9.eButton
    Friend WithEvents btn_select As Frame9.eButton
    Friend WithEvents btnOpen As Frame9.eButton
    Friend WithEvents to_dt As Frame9.eDate
    Friend WithEvents fr_dt As Frame9.eDate
    Friend WithEvents acc_grp As Frame9.eText
    Friend WithEvents extra_amount As Frame9.eText
    Friend WithEvents btn_wic As Frame9.eButton
    Friend WithEvents btn_pur As Frame9.eButton
    Friend WithEvents memo As Frame9.eText
    Friend WithEvents project As Frame9.eText
    Friend WithEvents dept As Frame9.eText
    Friend WithEvents cust As Frame9.eText
    Friend WithEvents vcAmount As Frame9.eText
    Friend WithEvents vcDate As Frame9.eDate
    Friend WithEvents vcNo As Frame9.eText
    Friend WithEvents btn_project As Frame9.eButton
    Friend WithEvents EButton1 As Frame9.eButton
End Class
