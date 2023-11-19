Imports DevExpress.XtraTab

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FE100
    Inherits Base9.Form

    'UserControl1은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame9.ePanel()
        Me.btn_wic = New Frame9.eButton()
        Me.btn_pur = New Frame9.eButton()
        Me.EButton1 = New Frame9.eButton()
        Me.btn_project = New Frame9.eButton()
        Me.acc_grp = New Frame9.eText()
        Me.memo = New Frame9.eText()
        Me.f_project = New Frame9.eText()
        Me.f_dept = New Frame9.eText()
        Me.f_cust = New Frame9.eText()
        Me.f_to_dt = New Frame9.eDate()
        Me.f_fr_dt = New Frame9.eDate()
        Me.f_vc_no = New Frame9.eText()
        Me.acc_cd = New Frame9.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame9.ePanel()
        Me.g10 = New Frame9.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame9.ePanel()
        Me.asset_amount = New Frame9.eText()
        Me.btn_close = New Frame9.eButton()
        Me.btn_select = New Frame9.eButton()
        Me.dp_rate = New Frame9.eText()
        Me.btn_apply = New Frame9.eButton()
        Me.pur_date = New Frame9.eDate()
        Me.lifetime = New Frame9.eText()
        Me.dp_method = New Frame9.eOptionBox()
        Me.dp_end_date = New Frame9.eDate()
        Me.vendor = New Frame9.eText()
        Me.dp_start_date = New Frame9.eDate()
        Me.diff = New Frame9.eText()
        Me.pid = New Frame9.eText()
        Me.note = New Frame9.eMemo()
        Me.vc_date = New Frame9.eDate()
        Me.vc_no = New Frame9.eText()
        Me.dept = New Frame9.eText()
        Me.project = New Frame9.eText()
        Me.asset_category = New Frame9.eCombo()
        Me.g20 = New Frame9.eGrid()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(2149, 900)
        Me.SplitContainer1.SplitterDistance = 77
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_wic)
        Me.EPanel1.Controls.Add(Me.btn_pur)
        Me.EPanel1.Controls.Add(Me.EButton1)
        Me.EPanel1.Controls.Add(Me.btn_project)
        Me.EPanel1.Controls.Add(Me.acc_grp)
        Me.EPanel1.Controls.Add(Me.memo)
        Me.EPanel1.Controls.Add(Me.f_project)
        Me.EPanel1.Controls.Add(Me.f_dept)
        Me.EPanel1.Controls.Add(Me.f_cust)
        Me.EPanel1.Controls.Add(Me.f_to_dt)
        Me.EPanel1.Controls.Add(Me.f_fr_dt)
        Me.EPanel1.Controls.Add(Me.f_vc_no)
        Me.EPanel1.Controls.Add(Me.acc_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(2149, 77)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     Search"
        '
        'btn_wic
        '
        Me.btn_wic.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_wic.Appearance.Options.UseBackColor = True
        Me.btn_wic.Location = New System.Drawing.Point(1671, 24)
        Me.btn_wic.Name = "btn_wic"
        Me.btn_wic.Size = New System.Drawing.Size(113, 42)
        Me.btn_wic.TabIndex = 57
        Me.btn_wic.Text = "WIC List"
        '
        'btn_pur
        '
        Me.btn_pur.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_pur.Appearance.Options.UseBackColor = True
        Me.btn_pur.Location = New System.Drawing.Point(1552, 24)
        Me.btn_pur.Name = "btn_pur"
        Me.btn_pur.Size = New System.Drawing.Size(113, 42)
        Me.btn_pur.TabIndex = 54
        Me.btn_pur.Text = "Purchase List"
        '
        'EButton1
        '
        Me.EButton1.Location = New System.Drawing.Point(721, 24)
        Me.EButton1.Name = "EButton1"
        Me.EButton1.Size = New System.Drawing.Size(26, 20)
        Me.EButton1.TabIndex = 53
        Me.EButton1.Text = "..."
        '
        'btn_project
        '
        Me.btn_project.Location = New System.Drawing.Point(721, 47)
        Me.btn_project.Name = "btn_project"
        Me.btn_project.Size = New System.Drawing.Size(26, 20)
        Me.btn_project.TabIndex = 52
        Me.btn_project.Text = "..."
        '
        'acc_grp
        '
        Me.acc_grp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acc_grp.Location = New System.Drawing.Point(755, 47)
        Me.acc_grp.Name = "acc_grp"
        Me.acc_grp.Size = New System.Drawing.Size(240, 20)
        Me.acc_grp.TabIndex = 51
        Me.acc_grp.Title = "COA Group"
        Me.acc_grp.TitleWidth = 90
        '
        'memo
        '
        Me.memo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memo.Location = New System.Drawing.Point(755, 25)
        Me.memo.Name = "memo"
        Me.memo.Size = New System.Drawing.Size(407, 20)
        Me.memo.TabIndex = 50
        Me.memo.Title = "Description"
        Me.memo.TitleWidth = 90
        '
        'f_project
        '
        Me.f_project.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_project.Location = New System.Drawing.Point(477, 47)
        Me.f_project.Name = "f_project"
        Me.f_project.Size = New System.Drawing.Size(240, 20)
        Me.f_project.TabIndex = 49
        Me.f_project.Title = "Project"
        Me.f_project.TitleWidth = 90
        '
        'f_dept
        '
        Me.f_dept.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_dept.Location = New System.Drawing.Point(477, 24)
        Me.f_dept.Name = "f_dept"
        Me.f_dept.Size = New System.Drawing.Size(240, 20)
        Me.f_dept.TabIndex = 48
        Me.f_dept.Title = "Dept"
        Me.f_dept.TitleWidth = 90
        '
        'f_cust
        '
        Me.f_cust.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_cust.Location = New System.Drawing.Point(231, 47)
        Me.f_cust.Name = "f_cust"
        Me.f_cust.Size = New System.Drawing.Size(240, 20)
        Me.f_cust.TabIndex = 47
        Me.f_cust.Title = "Vendor"
        Me.f_cust.TitleWidth = 90
        '
        'f_to_dt
        '
        Me.f_to_dt.Location = New System.Drawing.Point(65, 47)
        Me.f_to_dt.Name = "f_to_dt"
        Me.f_to_dt.Size = New System.Drawing.Size(160, 20)
        Me.f_to_dt.TabIndex = 46
        Me.f_to_dt.Title = "~"
        Me.f_to_dt.TitleAlign = Frame9.Alignment.Center
        Me.f_to_dt.TitleWidth = 30
        '
        'f_fr_dt
        '
        Me.f_fr_dt.Location = New System.Drawing.Point(5, 24)
        Me.f_fr_dt.Name = "f_fr_dt"
        Me.f_fr_dt.Size = New System.Drawing.Size(220, 20)
        Me.f_fr_dt.TabIndex = 45
        Me.f_fr_dt.Title = "Voucher Date"
        Me.f_fr_dt.TitleWidth = 90
        '
        'f_vc_no
        '
        Me.f_vc_no.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_vc_no.Location = New System.Drawing.Point(231, 24)
        Me.f_vc_no.Name = "f_vc_no"
        Me.f_vc_no.Size = New System.Drawing.Size(240, 20)
        Me.f_vc_no.TabIndex = 44
        Me.f_vc_no.Title = "Voucher No"
        Me.f_vc_no.TitleWidth = 90
        '
        'acc_cd
        '
        Me.acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acc_cd.Location = New System.Drawing.Point(1001, 47)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(161, 20)
        Me.acc_cd.TabIndex = 43
        Me.acc_cd.Title = "COA"
        Me.acc_cd.TitleWidth = 50
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(2149, 819)
        Me.SplitContainer2.SplitterDistance = 392
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(2149, 392)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     Voucher List"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 21)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(2145, 369)
        Me.g10.TabIndex = 3
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer3.Size = New System.Drawing.Size(2149, 423)
        Me.SplitContainer3.SplitterDistance = 115
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.asset_amount)
        Me.EPanel2.Controls.Add(Me.btn_close)
        Me.EPanel2.Controls.Add(Me.btn_select)
        Me.EPanel2.Controls.Add(Me.dp_rate)
        Me.EPanel2.Controls.Add(Me.btn_apply)
        Me.EPanel2.Controls.Add(Me.pur_date)
        Me.EPanel2.Controls.Add(Me.lifetime)
        Me.EPanel2.Controls.Add(Me.dp_method)
        Me.EPanel2.Controls.Add(Me.dp_end_date)
        Me.EPanel2.Controls.Add(Me.vendor)
        Me.EPanel2.Controls.Add(Me.dp_start_date)
        Me.EPanel2.Controls.Add(Me.diff)
        Me.EPanel2.Controls.Add(Me.pid)
        Me.EPanel2.Controls.Add(Me.note)
        Me.EPanel2.Controls.Add(Me.vc_date)
        Me.EPanel2.Controls.Add(Me.vc_no)
        Me.EPanel2.Controls.Add(Me.dept)
        Me.EPanel2.Controls.Add(Me.project)
        Me.EPanel2.Controls.Add(Me.asset_category)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(2149, 115)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Asset Info"
        '
        'asset_amount
        '
        Me.asset_amount.Location = New System.Drawing.Point(367, 87)
        Me.asset_amount.Name = "asset_amount"
        Me.asset_amount.Size = New System.Drawing.Size(240, 20)
        Me.asset_amount.TabIndex = 121
        Me.asset_amount.Title = "Amount"
        Me.asset_amount.TitleWidth = 70
        '
        'btn_close
        '
        Me.btn_close.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_close.Appearance.Options.UseBackColor = True
        Me.btn_close.Location = New System.Drawing.Point(2041, 68)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(90, 42)
        Me.btn_close.TabIndex = 56
        Me.btn_close.Text = "Close"
        '
        'btn_select
        '
        Me.btn_select.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_select.Appearance.Options.UseBackColor = True
        Me.btn_select.Location = New System.Drawing.Point(1945, 68)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(90, 42)
        Me.btn_select.TabIndex = 55
        Me.btn_select.Text = "Select"
        '
        'dp_rate
        '
        Me.dp_rate.Location = New System.Drawing.Point(912, 87)
        Me.dp_rate.Name = "dp_rate"
        Me.dp_rate.Size = New System.Drawing.Size(68, 20)
        Me.dp_rate.TabIndex = 120
        Me.dp_rate.Title = "Lifetime"
        Me.dp_rate.TitleWidth = 0
        '
        'btn_apply
        '
        Me.btn_apply.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_apply.Appearance.Options.UseBackColor = True
        Me.btn_apply.Location = New System.Drawing.Point(1665, 24)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(119, 83)
        Me.btn_apply.TabIndex = 58
        Me.btn_apply.Text = "Apply"
        '
        'pur_date
        '
        Me.pur_date.Location = New System.Drawing.Point(5, 45)
        Me.pur_date.Name = "pur_date"
        Me.pur_date.Size = New System.Drawing.Size(356, 20)
        Me.pur_date.TabIndex = 97
        Me.pur_date.Title = "Purchase Date"
        Me.pur_date.TitleWidth = 100
        '
        'lifetime
        '
        Me.lifetime.Location = New System.Drawing.Point(613, 87)
        Me.lifetime.Name = "lifetime"
        Me.lifetime.Size = New System.Drawing.Size(293, 20)
        Me.lifetime.TabIndex = 102
        Me.lifetime.Title = "Lifetime"
        Me.lifetime.TitleWidth = 120
        '
        'dp_method
        '
        Me.dp_method.Location = New System.Drawing.Point(613, 66)
        Me.dp_method.Name = "dp_method"
        Me.dp_method.Size = New System.Drawing.Size(367, 21)
        Me.dp_method.TabIndex = 101
        Me.dp_method.Title = "Depreciation Method"
        Me.dp_method.TitleWidth = 120
        '
        'dp_end_date
        '
        Me.dp_end_date.Location = New System.Drawing.Point(613, 45)
        Me.dp_end_date.Name = "dp_end_date"
        Me.dp_end_date.Size = New System.Drawing.Size(367, 20)
        Me.dp_end_date.TabIndex = 100
        Me.dp_end_date.Title = "Depreciation End"
        Me.dp_end_date.TitleWidth = 120
        '
        'vendor
        '
        Me.vendor.Location = New System.Drawing.Point(367, 66)
        Me.vendor.Name = "vendor"
        Me.vendor.Size = New System.Drawing.Size(240, 20)
        Me.vendor.TabIndex = 119
        Me.vendor.Title = "Vendor"
        Me.vendor.TitleWidth = 70
        '
        'dp_start_date
        '
        Me.dp_start_date.Location = New System.Drawing.Point(613, 24)
        Me.dp_start_date.Name = "dp_start_date"
        Me.dp_start_date.Size = New System.Drawing.Size(367, 20)
        Me.dp_start_date.TabIndex = 99
        Me.dp_start_date.Title = "Depreciation Start"
        Me.dp_start_date.TitleWidth = 120
        '
        'diff
        '
        Me.diff.Location = New System.Drawing.Point(1367, 225)
        Me.diff.Name = "diff"
        Me.diff.Size = New System.Drawing.Size(113, 20)
        Me.diff.TabIndex = 114
        Me.diff.Title = "diff"
        Me.diff.TitleWidth = 50
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(1367, 199)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(113, 20)
        Me.pid.TabIndex = 113
        Me.pid.Title = "ID"
        Me.pid.TitleWidth = 50
        '
        'note
        '
        Me.note.Location = New System.Drawing.Point(986, 24)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(673, 83)
        Me.note.TabIndex = 105
        Me.note.Title = "Note"
        Me.note.TitleWidth = 50
        '
        'vc_date
        '
        Me.vc_date.Location = New System.Drawing.Point(5, 66)
        Me.vc_date.Name = "vc_date"
        Me.vc_date.Size = New System.Drawing.Size(356, 20)
        Me.vc_date.TabIndex = 92
        Me.vc_date.Title = "Voucher Date"
        Me.vc_date.TitleWidth = 100
        '
        'vc_no
        '
        Me.vc_no.Location = New System.Drawing.Point(5, 87)
        Me.vc_no.Name = "vc_no"
        Me.vc_no.Size = New System.Drawing.Size(356, 20)
        Me.vc_no.TabIndex = 91
        Me.vc_no.Title = "Voucher No"
        Me.vc_no.TitleWidth = 100
        '
        'dept
        '
        Me.dept.Location = New System.Drawing.Point(367, 45)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(240, 20)
        Me.dept.TabIndex = 82
        Me.dept.Title = "Dept"
        Me.dept.TitleWidth = 70
        '
        'project
        '
        Me.project.Location = New System.Drawing.Point(367, 24)
        Me.project.Name = "project"
        Me.project.Size = New System.Drawing.Size(240, 20)
        Me.project.TabIndex = 80
        Me.project.Title = "Project"
        Me.project.TitleWidth = 70
        '
        'asset_category
        '
        Me.asset_category.Location = New System.Drawing.Point(5, 24)
        Me.asset_category.Name = "asset_category"
        Me.asset_category.Size = New System.Drawing.Size(356, 20)
        Me.asset_category.TabIndex = 75
        Me.asset_category.Title = "Asset Category"
        Me.asset_category.TitleWidth = 100
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.Size = New System.Drawing.Size(2149, 304)
        Me.g20.TabIndex = 3
        '
        'FE100
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FE100"
        Me.Size = New System.Drawing.Size(2149, 900)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents EPanel1 As Frame9.ePanel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents EPanel2 As Frame9.ePanel
    Friend WithEvents asset_category As Frame9.eCombo
    Friend WithEvents note As Frame9.eMemo
    Friend WithEvents lifetime As Frame9.eText
    Friend WithEvents dp_method As Frame9.eOptionBox
    Friend WithEvents dp_end_date As Frame9.eDate
    Friend WithEvents dp_start_date As Frame9.eDate
    Friend WithEvents pur_date As Frame9.eDate
    Friend WithEvents vc_date As Frame9.eDate
    Friend WithEvents vc_no As Frame9.eText
    Friend WithEvents project As Frame9.eText
    Friend WithEvents pid As Frame9.eText
    Friend WithEvents diff As Frame9.eText
    Friend WithEvents EPanel3 As Frame9.ePanel
    Friend WithEvents g10 As Frame9.eGrid
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents vendor As Frame9.eText
    Friend WithEvents dept As Frame9.eText
    Friend WithEvents EButton1 As Frame9.eButton
    Friend WithEvents btn_project As Frame9.eButton
    Friend WithEvents acc_grp As Frame9.eText
    Friend WithEvents memo As Frame9.eText
    Friend WithEvents f_project As Frame9.eText
    Friend WithEvents f_dept As Frame9.eText
    Friend WithEvents f_cust As Frame9.eText
    Friend WithEvents f_to_dt As Frame9.eDate
    Friend WithEvents f_fr_dt As Frame9.eDate
    Friend WithEvents f_vc_no As Frame9.eText
    Friend WithEvents acc_cd As Frame9.eText
    Friend WithEvents btn_pur As Frame9.eButton
    Friend WithEvents btn_close As Frame9.eButton
    Friend WithEvents btn_select As Frame9.eButton
    Friend WithEvents btn_wic As Frame9.eButton
    Friend WithEvents btn_apply As Frame9.eButton
    Friend WithEvents g20 As Frame9.eGrid
    Friend WithEvents dp_rate As Frame9.eText
    Friend WithEvents asset_amount As Frame9.eText
End Class
