Imports DevExpress.XtraTab

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FE150
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame9.ePanel()
        Me.f_asset_status = New Frame9.eCheckCombo()
        Me.f_facility_no = New Frame9.eText()
        Me.f_manager = New Frame9.eText()
        Me.f_car_no = New Frame9.eText()
        Me.f_store = New Frame9.eText()
        Me.f_project = New Frame9.eText()
        Me.f_serial = New Frame9.eText()
        Me.f_model = New Frame9.eText()
        Me.f_location = New Frame9.eText()
        Me.f_asset_category = New Frame9.eCheckCombo()
        Me.f_to_dt = New Frame9.eDate()
        Me.f_fr_dt = New Frame9.eDate()
        Me.f_asset_name = New Frame9.eText()
        Me.f_asset_no = New Frame9.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame9.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame9.ePanel()
        Me.btn_addition = New Frame9.eButton()
        Me.btn_apply = New Frame9.eButton()
        Me.car_model = New Frame9.eText()
        Me.bg_date = New Frame9.eDate()
        Me.dp_amount = New Frame9.eText()
        Me.btn_voucher = New Frame9.eButton()
        Me.bg_amount = New Frame9.eText()
        Me.pid = New Frame9.eText()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.parent_asset_no = New Frame9.eText()
        Me.dp_rate = New Frame9.eText()
        Me.book_value = New Frame9.eText()
        Me.cumulative = New Frame9.eText()
        Me.lifetime = New Frame9.eText()
        Me.pm_name = New Frame9.eText()
        Me.vc_no = New Frame9.eText()
        Me.note = New Frame9.eMemo()
        Me.asset_status = New Frame9.eCombo()
        Me.pur_status = New Frame9.eCombo()
        Me.vc_date = New Frame9.eDate()
        Me.facility_no = New Frame9.eText()
        Me.diff = New Frame9.eText()
        Me.manager = New Frame9.eText()
        Me.dept = New Frame9.eText()
        Me.store = New Frame9.eText()
        Me.project = New Frame9.eText()
        Me.car_no = New Frame9.eText()
        Me.calc_formula = New Frame9.eText()
        Me.serial = New Frame9.eText()
        Me.asset_location = New Frame9.eText()
        Me.asset_ename = New Frame9.eText()
        Me.asset_name = New Frame9.eText()
        Me.model = New Frame9.eText()
        Me.asset_category = New Frame9.eCombo()
        Me.asset_no = New Frame9.eText()
        Me.picture2 = New Frame9.eImage()
        Me.picture = New Frame9.eImage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dp_end_date = New Frame9.eDate()
        Me.dp_method = New Frame9.eOptionBox()
        Me.dp_start_date = New Frame9.eDate()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.pur_amount = New Frame9.eText()
        Me.residual_rate = New Frame9.eText()
        Me.pur_date = New Frame9.eDate()
        Me.residual_value = New Frame9.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.EPanel3 = New Frame9.ePanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cust_vat = New Frame9.eText()
        Me.disposal_type = New Frame9.eCombo()
        Me.cust_date = New Frame9.eDate()
        Me.cust = New Frame9.eText()
        Me.cust_vc_no = New Frame9.eText()
        Me.cust_price = New Frame9.eText()
        Me.cust_doc_no = New Frame9.eText()
        Me.cust_doc_date = New Frame9.eDate()
        Me.cust_name = New Frame9.eText()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ins_premium = New Frame9.eText()
        Me.ins_amount = New Frame9.eText()
        Me.ins_no = New Frame9.eText()
        Me.ins_date = New Frame9.eDate()
        Me.ins_co = New Frame9.eText()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.war_phone = New Frame9.eText()
        Me.war_no = New Frame9.eText()
        Me.war_date = New Frame9.eDate()
        Me.war_co = New Frame9.eText()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.supp_name = New Frame9.eText()
        Me.supp_phone = New Frame9.eText()
        Me.supp_doc_no = New Frame9.eText()
        Me.supp_date = New Frame9.eDate()
        Me.supp = New Frame9.eText()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame9.eGrid()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame9.eGrid()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.cuFtp = New Frame9.eGrid()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
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
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(2100, 900)
        Me.SplitContainer1.SplitterDistance = 77
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.f_asset_status)
        Me.EPanel1.Controls.Add(Me.f_facility_no)
        Me.EPanel1.Controls.Add(Me.f_manager)
        Me.EPanel1.Controls.Add(Me.f_car_no)
        Me.EPanel1.Controls.Add(Me.f_store)
        Me.EPanel1.Controls.Add(Me.f_project)
        Me.EPanel1.Controls.Add(Me.f_serial)
        Me.EPanel1.Controls.Add(Me.f_model)
        Me.EPanel1.Controls.Add(Me.f_location)
        Me.EPanel1.Controls.Add(Me.f_asset_category)
        Me.EPanel1.Controls.Add(Me.f_to_dt)
        Me.EPanel1.Controls.Add(Me.f_fr_dt)
        Me.EPanel1.Controls.Add(Me.f_asset_name)
        Me.EPanel1.Controls.Add(Me.f_asset_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(2100, 77)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     Search"
        '
        'f_asset_status
        '
        Me.f_asset_status.Location = New System.Drawing.Point(1481, 50)
        Me.f_asset_status.Name = "f_asset_status"
        Me.f_asset_status.Size = New System.Drawing.Size(240, 20)
        Me.f_asset_status.TabIndex = 60
        Me.f_asset_status.Title = "Status"
        Me.f_asset_status.TitleWidth = 90
        '
        'f_facility_no
        '
        Me.f_facility_no.Location = New System.Drawing.Point(1481, 27)
        Me.f_facility_no.Name = "f_facility_no"
        Me.f_facility_no.Size = New System.Drawing.Size(240, 20)
        Me.f_facility_no.TabIndex = 59
        Me.f_facility_no.Title = "Facility No"
        Me.f_facility_no.TitleWidth = 90
        '
        'f_manager
        '
        Me.f_manager.Location = New System.Drawing.Point(1235, 50)
        Me.f_manager.Name = "f_manager"
        Me.f_manager.Size = New System.Drawing.Size(240, 20)
        Me.f_manager.TabIndex = 58
        Me.f_manager.Title = "Manager"
        Me.f_manager.TitleWidth = 90
        '
        'f_car_no
        '
        Me.f_car_no.Location = New System.Drawing.Point(1235, 27)
        Me.f_car_no.Name = "f_car_no"
        Me.f_car_no.Size = New System.Drawing.Size(240, 20)
        Me.f_car_no.TabIndex = 57
        Me.f_car_no.Title = "Car No"
        Me.f_car_no.TitleWidth = 90
        '
        'f_store
        '
        Me.f_store.Location = New System.Drawing.Point(989, 50)
        Me.f_store.Name = "f_store"
        Me.f_store.Size = New System.Drawing.Size(240, 20)
        Me.f_store.TabIndex = 56
        Me.f_store.Title = "Store"
        Me.f_store.TitleWidth = 90
        '
        'f_project
        '
        Me.f_project.Location = New System.Drawing.Point(989, 27)
        Me.f_project.Name = "f_project"
        Me.f_project.Size = New System.Drawing.Size(240, 20)
        Me.f_project.TabIndex = 55
        Me.f_project.Title = "Project"
        Me.f_project.TitleWidth = 90
        '
        'f_serial
        '
        Me.f_serial.Location = New System.Drawing.Point(743, 50)
        Me.f_serial.Name = "f_serial"
        Me.f_serial.Size = New System.Drawing.Size(240, 20)
        Me.f_serial.TabIndex = 54
        Me.f_serial.Title = "Serial"
        Me.f_serial.TitleWidth = 90
        '
        'f_model
        '
        Me.f_model.Location = New System.Drawing.Point(743, 27)
        Me.f_model.Name = "f_model"
        Me.f_model.Size = New System.Drawing.Size(240, 20)
        Me.f_model.TabIndex = 53
        Me.f_model.Title = "Model"
        Me.f_model.TitleWidth = 90
        '
        'f_location
        '
        Me.f_location.Location = New System.Drawing.Point(497, 50)
        Me.f_location.Name = "f_location"
        Me.f_location.Size = New System.Drawing.Size(240, 20)
        Me.f_location.TabIndex = 52
        Me.f_location.Title = "Location"
        Me.f_location.TitleWidth = 90
        '
        'f_asset_category
        '
        Me.f_asset_category.Location = New System.Drawing.Point(497, 27)
        Me.f_asset_category.Name = "f_asset_category"
        Me.f_asset_category.Size = New System.Drawing.Size(240, 20)
        Me.f_asset_category.TabIndex = 51
        Me.f_asset_category.Title = "Asset Category"
        Me.f_asset_category.TitleWidth = 90
        '
        'f_to_dt
        '
        Me.f_to_dt.Location = New System.Drawing.Point(5, 50)
        Me.f_to_dt.Name = "f_to_dt"
        Me.f_to_dt.Size = New System.Drawing.Size(240, 20)
        Me.f_to_dt.TabIndex = 50
        Me.f_to_dt.Title = "~"
        Me.f_to_dt.TitleAlign = Frame9.Alignment.Left
        Me.f_to_dt.TitleWidth = 90
        '
        'f_fr_dt
        '
        Me.f_fr_dt.Location = New System.Drawing.Point(5, 27)
        Me.f_fr_dt.Name = "f_fr_dt"
        Me.f_fr_dt.Size = New System.Drawing.Size(240, 20)
        Me.f_fr_dt.TabIndex = 49
        Me.f_fr_dt.Title = "Install Date"
        Me.f_fr_dt.TitleWidth = 90
        '
        'f_asset_name
        '
        Me.f_asset_name.Location = New System.Drawing.Point(251, 50)
        Me.f_asset_name.Name = "f_asset_name"
        Me.f_asset_name.Size = New System.Drawing.Size(240, 20)
        Me.f_asset_name.TabIndex = 44
        Me.f_asset_name.Title = "Asset Category"
        Me.f_asset_name.TitleWidth = 90
        '
        'f_asset_no
        '
        Me.f_asset_no.Location = New System.Drawing.Point(251, 27)
        Me.f_asset_no.Name = "f_asset_no"
        Me.f_asset_no.Size = New System.Drawing.Size(240, 20)
        Me.f_asset_no.TabIndex = 43
        Me.f_asset_no.Title = "Asset No"
        Me.f_asset_no.TitleWidth = 90
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.g10)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(2100, 819)
        Me.SplitContainer2.SplitterDistance = 524
        Me.SplitContainer2.TabIndex = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(524, 819)
        Me.g10.TabIndex = 0
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1572, 819)
        Me.SplitContainer3.SplitterDistance = 381
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.btn_addition)
        Me.EPanel2.Controls.Add(Me.btn_apply)
        Me.EPanel2.Controls.Add(Me.car_model)
        Me.EPanel2.Controls.Add(Me.bg_date)
        Me.EPanel2.Controls.Add(Me.dp_amount)
        Me.EPanel2.Controls.Add(Me.btn_voucher)
        Me.EPanel2.Controls.Add(Me.bg_amount)
        Me.EPanel2.Controls.Add(Me.pid)
        Me.EPanel2.Controls.Add(Me.GroupBox6)
        Me.EPanel2.Controls.Add(Me.pm_name)
        Me.EPanel2.Controls.Add(Me.vc_no)
        Me.EPanel2.Controls.Add(Me.note)
        Me.EPanel2.Controls.Add(Me.asset_status)
        Me.EPanel2.Controls.Add(Me.pur_status)
        Me.EPanel2.Controls.Add(Me.vc_date)
        Me.EPanel2.Controls.Add(Me.facility_no)
        Me.EPanel2.Controls.Add(Me.diff)
        Me.EPanel2.Controls.Add(Me.manager)
        Me.EPanel2.Controls.Add(Me.dept)
        Me.EPanel2.Controls.Add(Me.store)
        Me.EPanel2.Controls.Add(Me.project)
        Me.EPanel2.Controls.Add(Me.car_no)
        Me.EPanel2.Controls.Add(Me.calc_formula)
        Me.EPanel2.Controls.Add(Me.serial)
        Me.EPanel2.Controls.Add(Me.asset_location)
        Me.EPanel2.Controls.Add(Me.asset_ename)
        Me.EPanel2.Controls.Add(Me.asset_name)
        Me.EPanel2.Controls.Add(Me.model)
        Me.EPanel2.Controls.Add(Me.asset_category)
        Me.EPanel2.Controls.Add(Me.asset_no)
        Me.EPanel2.Controls.Add(Me.picture2)
        Me.EPanel2.Controls.Add(Me.picture)
        Me.EPanel2.Controls.Add(Me.GroupBox7)
        Me.EPanel2.Controls.Add(Me.GroupBox5)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1572, 381)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Asset Info"
        '
        'btn_addition
        '
        Me.btn_addition.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_addition.Appearance.Options.UseBackColor = True
        Me.btn_addition.Location = New System.Drawing.Point(1251, 273)
        Me.btn_addition.Name = "btn_addition"
        Me.btn_addition.Size = New System.Drawing.Size(83, 43)
        Me.btn_addition.TabIndex = 123
        Me.btn_addition.Text = "Addition"
        '
        'btn_apply
        '
        Me.btn_apply.Appearance.BackColor = System.Drawing.Color.Olive
        Me.btn_apply.Appearance.Options.UseBackColor = True
        Me.btn_apply.Location = New System.Drawing.Point(1251, 310)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(83, 43)
        Me.btn_apply.TabIndex = 124
        Me.btn_apply.Text = "Apply"
        '
        'car_model
        '
        Me.car_model.Location = New System.Drawing.Point(807, 134)
        Me.car_model.Name = "car_model"
        Me.car_model.Size = New System.Drawing.Size(295, 20)
        Me.car_model.TabIndex = 122
        Me.car_model.Title = "Facility Name"
        Me.car_model.TitleWidth = 0
        '
        'bg_date
        '
        Me.bg_date.Location = New System.Drawing.Point(1359, 296)
        Me.bg_date.Name = "bg_date"
        Me.bg_date.Size = New System.Drawing.Size(153, 20)
        Me.bg_date.TabIndex = 98
        Me.bg_date.Title = "Carrying Date"
        Me.bg_date.TitleWidth = 100
        '
        'dp_amount
        '
        Me.dp_amount.Location = New System.Drawing.Point(1359, 321)
        Me.dp_amount.Name = "dp_amount"
        Me.dp_amount.Size = New System.Drawing.Size(153, 20)
        Me.dp_amount.TabIndex = 86
        Me.dp_amount.Title = "Target"
        Me.dp_amount.TitleWidth = 100
        '
        'btn_voucher
        '
        Me.btn_voucher.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_voucher.Appearance.Options.UseBackColor = True
        Me.btn_voucher.Location = New System.Drawing.Point(1251, 112)
        Me.btn_voucher.Name = "btn_voucher"
        Me.btn_voucher.Size = New System.Drawing.Size(261, 42)
        Me.btn_voucher.TabIndex = 61
        Me.btn_voucher.Text = "Popup Voucher"
        '
        'bg_amount
        '
        Me.bg_amount.Location = New System.Drawing.Point(1359, 273)
        Me.bg_amount.Name = "bg_amount"
        Me.bg_amount.Size = New System.Drawing.Size(153, 20)
        Me.bg_amount.TabIndex = 85
        Me.bg_amount.Title = "Carrying Amount"
        Me.bg_amount.TitleWidth = 100
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(1359, 254)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(153, 20)
        Me.pid.TabIndex = 121
        Me.pid.Title = "pid"
        Me.pid.TitleWidth = 50
        Me.pid.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.parent_asset_no)
        Me.GroupBox6.Controls.Add(Me.dp_rate)
        Me.GroupBox6.Controls.Add(Me.book_value)
        Me.GroupBox6.Controls.Add(Me.cumulative)
        Me.GroupBox6.Controls.Add(Me.lifetime)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(777, 252)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(331, 116)
        Me.GroupBox6.TabIndex = 119
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "[ Book Value ]"
        '
        'parent_asset_no
        '
        Me.parent_asset_no.Location = New System.Drawing.Point(11, 89)
        Me.parent_asset_no.Name = "parent_asset_no"
        Me.parent_asset_no.Size = New System.Drawing.Size(314, 20)
        Me.parent_asset_no.TabIndex = 123
        Me.parent_asset_no.Title = "Parent Asset"
        Me.parent_asset_no.TitleWidth = 100
        '
        'dp_rate
        '
        Me.dp_rate.Location = New System.Drawing.Point(207, 19)
        Me.dp_rate.Name = "dp_rate"
        Me.dp_rate.Size = New System.Drawing.Size(118, 20)
        Me.dp_rate.TabIndex = 103
        Me.dp_rate.Title = "Rate"
        Me.dp_rate.TitleWidth = 50
        '
        'book_value
        '
        Me.book_value.Location = New System.Drawing.Point(11, 66)
        Me.book_value.Name = "book_value"
        Me.book_value.Size = New System.Drawing.Size(314, 20)
        Me.book_value.TabIndex = 88
        Me.book_value.Title = "Book Value"
        Me.book_value.TitleWidth = 100
        '
        'cumulative
        '
        Me.cumulative.Location = New System.Drawing.Point(11, 42)
        Me.cumulative.Name = "cumulative"
        Me.cumulative.Size = New System.Drawing.Size(314, 20)
        Me.cumulative.TabIndex = 87
        Me.cumulative.Title = "Cumulative"
        Me.cumulative.TitleWidth = 100
        '
        'lifetime
        '
        Me.lifetime.Location = New System.Drawing.Point(11, 19)
        Me.lifetime.Name = "lifetime"
        Me.lifetime.Size = New System.Drawing.Size(190, 20)
        Me.lifetime.TabIndex = 102
        Me.lifetime.Title = "Lifetime"
        Me.lifetime.TitleWidth = 100
        '
        'pm_name
        '
        Me.pm_name.Location = New System.Drawing.Point(807, 156)
        Me.pm_name.Name = "pm_name"
        Me.pm_name.Size = New System.Drawing.Size(295, 20)
        Me.pm_name.TabIndex = 115
        Me.pm_name.Title = "Facility Name"
        Me.pm_name.TitleWidth = 0
        '
        'vc_no
        '
        Me.vc_no.Location = New System.Drawing.Point(537, 179)
        Me.vc_no.Name = "vc_no"
        Me.vc_no.Size = New System.Drawing.Size(261, 20)
        Me.vc_no.TabIndex = 91
        Me.vc_no.Title = "Voucher No / Date"
        Me.vc_no.TitleWidth = 120
        '
        'note
        '
        Me.note.Location = New System.Drawing.Point(144, 202)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(958, 45)
        Me.note.TabIndex = 105
        Me.note.Title = "Note"
        Me.note.TitleWidth = 100
        '
        'asset_status
        '
        Me.asset_status.Location = New System.Drawing.Point(144, 179)
        Me.asset_status.Name = "asset_status"
        Me.asset_status.Size = New System.Drawing.Size(387, 20)
        Me.asset_status.TabIndex = 94
        Me.asset_status.Title = "Asset Status"
        Me.asset_status.TitleWidth = 100
        '
        'pur_status
        '
        Me.pur_status.Location = New System.Drawing.Point(144, 156)
        Me.pur_status.Name = "pur_status"
        Me.pur_status.Size = New System.Drawing.Size(387, 20)
        Me.pur_status.TabIndex = 93
        Me.pur_status.Title = "Purchase Status"
        Me.pur_status.TitleWidth = 100
        '
        'vc_date
        '
        Me.vc_date.Location = New System.Drawing.Point(807, 179)
        Me.vc_date.Name = "vc_date"
        Me.vc_date.Size = New System.Drawing.Size(294, 20)
        Me.vc_date.TabIndex = 92
        Me.vc_date.Title = "Voucher Date"
        Me.vc_date.TitleWidth = 0
        '
        'facility_no
        '
        Me.facility_no.Location = New System.Drawing.Point(537, 156)
        Me.facility_no.Name = "facility_no"
        Me.facility_no.Size = New System.Drawing.Size(261, 20)
        Me.facility_no.TabIndex = 90
        Me.facility_no.Title = "Facility No"
        Me.facility_no.TitleWidth = 120
        '
        'diff
        '
        Me.diff.Location = New System.Drawing.Point(1359, 228)
        Me.diff.Name = "diff"
        Me.diff.Size = New System.Drawing.Size(153, 20)
        Me.diff.TabIndex = 114
        Me.diff.Title = "diff"
        Me.diff.TitleWidth = 50
        Me.diff.Visible = False
        '
        'manager
        '
        Me.manager.Location = New System.Drawing.Point(144, 134)
        Me.manager.Name = "manager"
        Me.manager.Size = New System.Drawing.Size(387, 20)
        Me.manager.TabIndex = 83
        Me.manager.Title = "Manager"
        Me.manager.TitleWidth = 100
        '
        'dept
        '
        Me.dept.Location = New System.Drawing.Point(144, 112)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(387, 20)
        Me.dept.TabIndex = 82
        Me.dept.Title = "Dept"
        Me.dept.TitleWidth = 100
        '
        'store
        '
        Me.store.Location = New System.Drawing.Point(144, 90)
        Me.store.Name = "store"
        Me.store.Size = New System.Drawing.Size(387, 20)
        Me.store.TabIndex = 81
        Me.store.Title = "Store"
        Me.store.TitleWidth = 100
        '
        'project
        '
        Me.project.Location = New System.Drawing.Point(144, 68)
        Me.project.Name = "project"
        Me.project.Size = New System.Drawing.Size(387, 20)
        Me.project.TabIndex = 80
        Me.project.Title = "Project"
        Me.project.TitleWidth = 100
        '
        'car_no
        '
        Me.car_no.Location = New System.Drawing.Point(537, 134)
        Me.car_no.Name = "car_no"
        Me.car_no.Size = New System.Drawing.Size(261, 20)
        Me.car_no.TabIndex = 79
        Me.car_no.Title = "Vehicle No"
        Me.car_no.TitleWidth = 120
        '
        'calc_formula
        '
        Me.calc_formula.Location = New System.Drawing.Point(1359, 202)
        Me.calc_formula.Name = "calc_formula"
        Me.calc_formula.Size = New System.Drawing.Size(132, 20)
        Me.calc_formula.TabIndex = 76
        Me.calc_formula.Title = "Calc. Formula"
        Me.calc_formula.TitleWidth = 100
        Me.calc_formula.Visible = False
        '
        'serial
        '
        Me.serial.Location = New System.Drawing.Point(537, 112)
        Me.serial.Name = "serial"
        Me.serial.Size = New System.Drawing.Size(565, 20)
        Me.serial.TabIndex = 78
        Me.serial.Title = "Serial"
        Me.serial.TitleWidth = 120
        '
        'asset_location
        '
        Me.asset_location.Location = New System.Drawing.Point(537, 68)
        Me.asset_location.Name = "asset_location"
        Me.asset_location.Size = New System.Drawing.Size(565, 20)
        Me.asset_location.TabIndex = 77
        Me.asset_location.Title = "Location"
        Me.asset_location.TitleWidth = 120
        '
        'asset_ename
        '
        Me.asset_ename.Location = New System.Drawing.Point(537, 46)
        Me.asset_ename.Name = "asset_ename"
        Me.asset_ename.Size = New System.Drawing.Size(565, 20)
        Me.asset_ename.TabIndex = 77
        Me.asset_ename.Title = "Asset Name (Eng)"
        Me.asset_ename.TitleWidth = 120
        '
        'asset_name
        '
        Me.asset_name.Location = New System.Drawing.Point(537, 24)
        Me.asset_name.Name = "asset_name"
        Me.asset_name.Size = New System.Drawing.Size(565, 20)
        Me.asset_name.TabIndex = 77
        Me.asset_name.Title = "Asset Name"
        Me.asset_name.TitleWidth = 120
        '
        'model
        '
        Me.model.Location = New System.Drawing.Point(537, 90)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(565, 20)
        Me.model.TabIndex = 77
        Me.model.Title = "Model"
        Me.model.TitleWidth = 120
        '
        'asset_category
        '
        Me.asset_category.Location = New System.Drawing.Point(144, 46)
        Me.asset_category.Name = "asset_category"
        Me.asset_category.Size = New System.Drawing.Size(387, 20)
        Me.asset_category.TabIndex = 75
        Me.asset_category.Title = "Asset Category"
        Me.asset_category.TitleWidth = 100
        '
        'asset_no
        '
        Me.asset_no.Location = New System.Drawing.Point(144, 24)
        Me.asset_no.Name = "asset_no"
        Me.asset_no.Size = New System.Drawing.Size(387, 20)
        Me.asset_no.TabIndex = 74
        Me.asset_no.Title = "Asset"
        Me.asset_no.TitleWidth = 100
        '
        'picture2
        '
        Me.picture2.Location = New System.Drawing.Point(5, 198)
        Me.picture2.Name = "picture2"
        Me.picture2.Size = New System.Drawing.Size(133, 170)
        Me.picture2.TabIndex = 3
        '
        'picture
        '
        Me.picture.Location = New System.Drawing.Point(5, 24)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(133, 170)
        Me.picture.TabIndex = 2
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dp_end_date)
        Me.GroupBox7.Controls.Add(Me.dp_method)
        Me.GroupBox7.Controls.Add(Me.dp_start_date)
        Me.GroupBox7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(477, 254)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(294, 116)
        Me.GroupBox7.TabIndex = 118
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "[ Depreciation ]"
        '
        'dp_end_date
        '
        Me.dp_end_date.Location = New System.Drawing.Point(10, 42)
        Me.dp_end_date.Name = "dp_end_date"
        Me.dp_end_date.Size = New System.Drawing.Size(270, 20)
        Me.dp_end_date.TabIndex = 100
        Me.dp_end_date.Title = "End Date"
        Me.dp_end_date.TitleWidth = 100
        '
        'dp_method
        '
        Me.dp_method.Location = New System.Drawing.Point(10, 66)
        Me.dp_method.Name = "dp_method"
        Me.dp_method.Size = New System.Drawing.Size(270, 41)
        Me.dp_method.TabIndex = 101
        Me.dp_method.Title = "Method"
        Me.dp_method.TitleWidth = 100
        '
        'dp_start_date
        '
        Me.dp_start_date.Location = New System.Drawing.Point(10, 19)
        Me.dp_start_date.Name = "dp_start_date"
        Me.dp_start_date.Size = New System.Drawing.Size(270, 20)
        Me.dp_start_date.TabIndex = 99
        Me.dp_start_date.Title = "Start Date"
        Me.dp_start_date.TitleWidth = 100
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.pur_amount)
        Me.GroupBox5.Controls.Add(Me.residual_rate)
        Me.GroupBox5.Controls.Add(Me.pur_date)
        Me.GroupBox5.Controls.Add(Me.residual_value)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(145, 253)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(326, 116)
        Me.GroupBox5.TabIndex = 116
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "[ Purchase ]"
        '
        'pur_amount
        '
        Me.pur_amount.Location = New System.Drawing.Point(8, 19)
        Me.pur_amount.Name = "pur_amount"
        Me.pur_amount.Size = New System.Drawing.Size(278, 20)
        Me.pur_amount.TabIndex = 84
        Me.pur_amount.Title = "Purchase Amount"
        Me.pur_amount.TitleWidth = 100
        '
        'residual_rate
        '
        Me.residual_rate.Location = New System.Drawing.Point(8, 66)
        Me.residual_rate.Name = "residual_rate"
        Me.residual_rate.Size = New System.Drawing.Size(278, 20)
        Me.residual_rate.TabIndex = 105
        Me.residual_rate.Title = "Residual %"
        Me.residual_rate.TitleWidth = 100
        '
        'pur_date
        '
        Me.pur_date.Location = New System.Drawing.Point(8, 42)
        Me.pur_date.Name = "pur_date"
        Me.pur_date.Size = New System.Drawing.Size(278, 20)
        Me.pur_date.TabIndex = 97
        Me.pur_date.Title = "Purchase Date"
        Me.pur_date.TitleWidth = 100
        '
        'residual_value
        '
        Me.residual_value.Location = New System.Drawing.Point(8, 89)
        Me.residual_value.Name = "residual_value"
        Me.residual_value.Size = New System.Drawing.Size(278, 20)
        Me.residual_value.TabIndex = 104
        Me.residual_value.Title = "Residual Value"
        Me.residual_value.TitleWidth = 100
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1572, 434)
        Me.XtraTabControl1.TabIndex = 3
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage6, Me.XtraTabPage1})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.EPanel3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1566, 405)
        Me.XtraTabPage2.Text = "Disposal"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.GroupBox4)
        Me.EPanel3.Controls.Add(Me.GroupBox3)
        Me.EPanel3.Controls.Add(Me.GroupBox2)
        Me.EPanel3.Controls.Add(Me.GroupBox1)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.IconVisible = False
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.ShowCaption = False
        Me.EPanel3.Size = New System.Drawing.Size(1566, 405)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "EPanel3"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cust_vat)
        Me.GroupBox4.Controls.Add(Me.disposal_type)
        Me.GroupBox4.Controls.Add(Me.cust_date)
        Me.GroupBox4.Controls.Add(Me.cust)
        Me.GroupBox4.Controls.Add(Me.cust_vc_no)
        Me.GroupBox4.Controls.Add(Me.cust_price)
        Me.GroupBox4.Controls.Add(Me.cust_doc_no)
        Me.GroupBox4.Controls.Add(Me.cust_doc_date)
        Me.GroupBox4.Controls.Add(Me.cust_name)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox4.Location = New System.Drawing.Point(5, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(548, 163)
        Me.GroupBox4.TabIndex = 121
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Disposal"
        '
        'cust_vat
        '
        Me.cust_vat.ForeColor = System.Drawing.Color.Black
        Me.cust_vat.Location = New System.Drawing.Point(235, 110)
        Me.cust_vat.Name = "cust_vat"
        Me.cust_vat.Size = New System.Drawing.Size(223, 20)
        Me.cust_vat.TabIndex = 121
        Me.cust_vat.Title = "VAT"
        Me.cust_vat.TitleWidth = 100
        '
        'disposal_type
        '
        Me.disposal_type.ForeColor = System.Drawing.Color.Black
        Me.disposal_type.Location = New System.Drawing.Point(6, 18)
        Me.disposal_type.Name = "disposal_type"
        Me.disposal_type.Size = New System.Drawing.Size(223, 20)
        Me.disposal_type.TabIndex = 113
        Me.disposal_type.Title = "Disposal Type"
        Me.disposal_type.TitleWidth = 100
        '
        'cust_date
        '
        Me.cust_date.ForeColor = System.Drawing.Color.Black
        Me.cust_date.Location = New System.Drawing.Point(6, 41)
        Me.cust_date.Name = "cust_date"
        Me.cust_date.Size = New System.Drawing.Size(223, 20)
        Me.cust_date.TabIndex = 107
        Me.cust_date.Title = "Date"
        Me.cust_date.TitleWidth = 100
        '
        'cust
        '
        Me.cust.ForeColor = System.Drawing.Color.Black
        Me.cust.Location = New System.Drawing.Point(6, 64)
        Me.cust.Name = "cust"
        Me.cust.Size = New System.Drawing.Size(536, 20)
        Me.cust.TabIndex = 108
        Me.cust.Title = "Customer"
        Me.cust.TitleWidth = 100
        '
        'cust_vc_no
        '
        Me.cust_vc_no.ForeColor = System.Drawing.Color.Black
        Me.cust_vc_no.Location = New System.Drawing.Point(235, 18)
        Me.cust_vc_no.Name = "cust_vc_no"
        Me.cust_vc_no.Size = New System.Drawing.Size(223, 20)
        Me.cust_vc_no.TabIndex = 120
        Me.cust_vc_no.Title = "Voucher No"
        Me.cust_vc_no.TitleWidth = 100
        '
        'cust_price
        '
        Me.cust_price.ForeColor = System.Drawing.Color.Black
        Me.cust_price.Location = New System.Drawing.Point(6, 110)
        Me.cust_price.Name = "cust_price"
        Me.cust_price.Size = New System.Drawing.Size(223, 20)
        Me.cust_price.TabIndex = 109
        Me.cust_price.Title = "Amount"
        Me.cust_price.TitleWidth = 100
        '
        'cust_doc_no
        '
        Me.cust_doc_no.ForeColor = System.Drawing.Color.Black
        Me.cust_doc_no.Location = New System.Drawing.Point(235, 135)
        Me.cust_doc_no.Name = "cust_doc_no"
        Me.cust_doc_no.Size = New System.Drawing.Size(223, 20)
        Me.cust_doc_no.TabIndex = 110
        Me.cust_doc_no.Title = "Document No"
        Me.cust_doc_no.TitleWidth = 100
        '
        'cust_doc_date
        '
        Me.cust_doc_date.ForeColor = System.Drawing.Color.Black
        Me.cust_doc_date.Location = New System.Drawing.Point(6, 135)
        Me.cust_doc_date.Name = "cust_doc_date"
        Me.cust_doc_date.Size = New System.Drawing.Size(223, 20)
        Me.cust_doc_date.TabIndex = 111
        Me.cust_doc_date.Title = "Document Date"
        Me.cust_doc_date.TitleWidth = 100
        '
        'cust_name
        '
        Me.cust_name.ForeColor = System.Drawing.Color.Black
        Me.cust_name.Location = New System.Drawing.Point(6, 87)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.Size = New System.Drawing.Size(536, 20)
        Me.cust_name.TabIndex = 114
        Me.cust_name.Title = "Customer Name"
        Me.cust_name.TitleWidth = 100
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ins_premium)
        Me.GroupBox3.Controls.Add(Me.ins_amount)
        Me.GroupBox3.Controls.Add(Me.ins_no)
        Me.GroupBox3.Controls.Add(Me.ins_date)
        Me.GroupBox3.Controls.Add(Me.ins_co)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox3.Location = New System.Drawing.Point(560, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(548, 140)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Insurance"
        '
        'ins_premium
        '
        Me.ins_premium.ForeColor = System.Drawing.Color.Black
        Me.ins_premium.Location = New System.Drawing.Point(8, 106)
        Me.ins_premium.Name = "ins_premium"
        Me.ins_premium.Size = New System.Drawing.Size(533, 20)
        Me.ins_premium.TabIndex = 110
        Me.ins_premium.Title = "Premium"
        Me.ins_premium.TitleWidth = 100
        '
        'ins_amount
        '
        Me.ins_amount.ForeColor = System.Drawing.Color.Black
        Me.ins_amount.Location = New System.Drawing.Point(8, 83)
        Me.ins_amount.Name = "ins_amount"
        Me.ins_amount.Size = New System.Drawing.Size(533, 20)
        Me.ins_amount.TabIndex = 109
        Me.ins_amount.Title = "Amount"
        Me.ins_amount.TitleWidth = 100
        '
        'ins_no
        '
        Me.ins_no.ForeColor = System.Drawing.Color.Black
        Me.ins_no.Location = New System.Drawing.Point(8, 37)
        Me.ins_no.Name = "ins_no"
        Me.ins_no.Size = New System.Drawing.Size(223, 20)
        Me.ins_no.TabIndex = 108
        Me.ins_no.Title = "Document No"
        Me.ins_no.TitleWidth = 100
        '
        'ins_date
        '
        Me.ins_date.ForeColor = System.Drawing.Color.Black
        Me.ins_date.Location = New System.Drawing.Point(8, 60)
        Me.ins_date.Name = "ins_date"
        Me.ins_date.Size = New System.Drawing.Size(223, 20)
        Me.ins_date.TabIndex = 107
        Me.ins_date.Title = "Date Until"
        Me.ins_date.TitleWidth = 100
        '
        'ins_co
        '
        Me.ins_co.ForeColor = System.Drawing.Color.Black
        Me.ins_co.Location = New System.Drawing.Point(8, 14)
        Me.ins_co.Name = "ins_co"
        Me.ins_co.Size = New System.Drawing.Size(533, 20)
        Me.ins_co.TabIndex = 107
        Me.ins_co.Title = "Company"
        Me.ins_co.TitleWidth = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.war_phone)
        Me.GroupBox2.Controls.Add(Me.war_no)
        Me.GroupBox2.Controls.Add(Me.war_date)
        Me.GroupBox2.Controls.Add(Me.war_co)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox2.Location = New System.Drawing.Point(5, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 140)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warranty"
        '
        'war_phone
        '
        Me.war_phone.ForeColor = System.Drawing.Color.Black
        Me.war_phone.Location = New System.Drawing.Point(6, 83)
        Me.war_phone.Name = "war_phone"
        Me.war_phone.Size = New System.Drawing.Size(537, 20)
        Me.war_phone.TabIndex = 109
        Me.war_phone.Title = "Phone"
        Me.war_phone.TitleWidth = 100
        '
        'war_no
        '
        Me.war_no.ForeColor = System.Drawing.Color.Black
        Me.war_no.Location = New System.Drawing.Point(6, 37)
        Me.war_no.Name = "war_no"
        Me.war_no.Size = New System.Drawing.Size(223, 20)
        Me.war_no.TabIndex = 108
        Me.war_no.Title = "Document No"
        Me.war_no.TitleWidth = 100
        '
        'war_date
        '
        Me.war_date.ForeColor = System.Drawing.Color.Black
        Me.war_date.Location = New System.Drawing.Point(6, 60)
        Me.war_date.Name = "war_date"
        Me.war_date.Size = New System.Drawing.Size(223, 20)
        Me.war_date.TabIndex = 107
        Me.war_date.Title = "Date Until"
        Me.war_date.TitleWidth = 100
        '
        'war_co
        '
        Me.war_co.ForeColor = System.Drawing.Color.Black
        Me.war_co.Location = New System.Drawing.Point(6, 15)
        Me.war_co.Name = "war_co"
        Me.war_co.Size = New System.Drawing.Size(537, 20)
        Me.war_co.TabIndex = 107
        Me.war_co.Title = "Company"
        Me.war_co.TitleWidth = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.supp_name)
        Me.GroupBox1.Controls.Add(Me.supp_phone)
        Me.GroupBox1.Controls.Add(Me.supp_doc_no)
        Me.GroupBox1.Controls.Add(Me.supp_date)
        Me.GroupBox1.Controls.Add(Me.supp)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(559, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 163)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier"
        '
        'supp_name
        '
        Me.supp_name.ForeColor = System.Drawing.Color.Black
        Me.supp_name.Location = New System.Drawing.Point(6, 41)
        Me.supp_name.Name = "supp_name"
        Me.supp_name.Size = New System.Drawing.Size(536, 20)
        Me.supp_name.TabIndex = 110
        Me.supp_name.Title = "Company Name"
        Me.supp_name.TitleWidth = 100
        '
        'supp_phone
        '
        Me.supp_phone.ForeColor = System.Drawing.Color.Black
        Me.supp_phone.Location = New System.Drawing.Point(6, 110)
        Me.supp_phone.Name = "supp_phone"
        Me.supp_phone.Size = New System.Drawing.Size(536, 20)
        Me.supp_phone.TabIndex = 109
        Me.supp_phone.Title = "Phone"
        Me.supp_phone.TitleWidth = 100
        '
        'supp_doc_no
        '
        Me.supp_doc_no.ForeColor = System.Drawing.Color.Black
        Me.supp_doc_no.Location = New System.Drawing.Point(6, 87)
        Me.supp_doc_no.Name = "supp_doc_no"
        Me.supp_doc_no.Size = New System.Drawing.Size(223, 20)
        Me.supp_doc_no.TabIndex = 108
        Me.supp_doc_no.Title = "Document No"
        Me.supp_doc_no.TitleWidth = 100
        '
        'supp_date
        '
        Me.supp_date.ForeColor = System.Drawing.Color.Black
        Me.supp_date.Location = New System.Drawing.Point(6, 64)
        Me.supp_date.Name = "supp_date"
        Me.supp_date.Size = New System.Drawing.Size(223, 20)
        Me.supp_date.TabIndex = 107
        Me.supp_date.Title = "Date"
        Me.supp_date.TitleWidth = 100
        '
        'supp
        '
        Me.supp.ForeColor = System.Drawing.Color.Black
        Me.supp.Location = New System.Drawing.Point(6, 16)
        Me.supp.Name = "supp"
        Me.supp.Size = New System.Drawing.Size(536, 20)
        Me.supp.TabIndex = 107
        Me.supp.Title = "Company"
        Me.supp.TitleWidth = 100
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g30)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1566, 405)
        Me.XtraTabPage3.Text = "Additional"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.Size = New System.Drawing.Size(1566, 405)
        Me.g30.TabIndex = 4
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.g20)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1566, 405)
        Me.XtraTabPage6.Text = "Depreciation"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.Size = New System.Drawing.Size(1566, 405)
        Me.g20.TabIndex = 2
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.cuFtp)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1566, 405)
        Me.XtraTabPage1.Text = "Document"
        '
        'cuFtp
        '
        Me.cuFtp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cuFtp.Location = New System.Drawing.Point(0, 0)
        Me.cuFtp.Name = "cuFtp"
        Me.cuFtp.Size = New System.Drawing.Size(1566, 405)
        Me.cuFtp.TabIndex = 3
        '
        'FE150
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FE150"
        Me.Size = New System.Drawing.Size(2100, 900)
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
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents EPanel1 As Frame9.ePanel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents g10 As Frame9.eGrid
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents EPanel2 As Frame9.ePanel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g20 As Frame9.eGrid
    Friend WithEvents f_asset_name As Frame9.eText
    Friend WithEvents f_asset_no As Frame9.eText
    Friend WithEvents f_to_dt As Frame9.eDate
    Friend WithEvents f_fr_dt As Frame9.eDate
    Friend WithEvents f_store As Frame9.eText
    Friend WithEvents f_project As Frame9.eText
    Friend WithEvents f_serial As Frame9.eText
    Friend WithEvents f_model As Frame9.eText
    Friend WithEvents f_location As Frame9.eText
    Friend WithEvents f_asset_category As Frame9.eCheckCombo
    Friend WithEvents f_asset_status As Frame9.eCheckCombo
    Friend WithEvents f_facility_no As Frame9.eText
    Friend WithEvents f_manager As Frame9.eText
    Friend WithEvents f_car_no As Frame9.eText
    Friend WithEvents XtraTabPage1 As XtraTabPage
    Friend WithEvents cuFtp As Frame9.eGrid
    Friend WithEvents picture2 As Frame9.eImage
    Friend WithEvents picture As Frame9.eImage
    Friend WithEvents calc_formula As Frame9.eText
    Friend WithEvents asset_category As Frame9.eCombo
    Friend WithEvents asset_no As Frame9.eText
    Friend WithEvents cust_doc_date As Frame9.eDate
    Friend WithEvents cust_doc_no As Frame9.eText
    Friend WithEvents cust_price As Frame9.eText
    Friend WithEvents cust As Frame9.eText
    Friend WithEvents cust_date As Frame9.eDate
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ins_premium As Frame9.eText
    Friend WithEvents ins_amount As Frame9.eText
    Friend WithEvents ins_no As Frame9.eText
    Friend WithEvents ins_date As Frame9.eDate
    Friend WithEvents ins_co As Frame9.eText
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents war_phone As Frame9.eText
    Friend WithEvents war_no As Frame9.eText
    Friend WithEvents war_date As Frame9.eDate
    Friend WithEvents war_co As Frame9.eText
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents supp_phone As Frame9.eText
    Friend WithEvents supp_doc_no As Frame9.eText
    Friend WithEvents supp_date As Frame9.eDate
    Friend WithEvents supp As Frame9.eText
    Friend WithEvents note As Frame9.eMemo
    Friend WithEvents residual_value As Frame9.eText
    Friend WithEvents dp_rate As Frame9.eText
    Friend WithEvents lifetime As Frame9.eText
    Friend WithEvents dp_method As Frame9.eOptionBox
    Friend WithEvents dp_end_date As Frame9.eDate
    Friend WithEvents dp_start_date As Frame9.eDate
    Friend WithEvents bg_date As Frame9.eDate
    Friend WithEvents pur_date As Frame9.eDate
    Friend WithEvents asset_status As Frame9.eCombo
    Friend WithEvents pur_status As Frame9.eCombo
    Friend WithEvents vc_date As Frame9.eDate
    Friend WithEvents vc_no As Frame9.eText
    Friend WithEvents facility_no As Frame9.eText
    Friend WithEvents book_value As Frame9.eText
    Friend WithEvents cumulative As Frame9.eText
    Friend WithEvents dp_amount As Frame9.eText
    Friend WithEvents bg_amount As Frame9.eText
    Friend WithEvents pur_amount As Frame9.eText
    Friend WithEvents manager As Frame9.eText
    Friend WithEvents dept As Frame9.eText
    Friend WithEvents store As Frame9.eText
    Friend WithEvents project As Frame9.eText
    Friend WithEvents car_no As Frame9.eText
    Friend WithEvents serial As Frame9.eText
    Friend WithEvents model As Frame9.eText
    Friend WithEvents disposal_type As Frame9.eCombo
    Friend WithEvents diff As Frame9.eText
    Friend WithEvents cust_name As Frame9.eText
    Friend WithEvents pm_name As Frame9.eText
    Friend WithEvents asset_location As Frame9.eText
    Friend WithEvents asset_ename As Frame9.eText
    Friend WithEvents asset_name As Frame9.eText
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents residual_rate As Frame9.eText
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents XtraTabPage2 As XtraTabPage
    Friend WithEvents EPanel3 As Frame9.ePanel
    Friend WithEvents cust_vc_no As Frame9.eText
    Friend WithEvents btn_voucher As Frame9.eButton
    Friend WithEvents pid As Frame9.eText
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cust_vat As Frame9.eText
    Friend WithEvents car_model As Frame9.eText
    Friend WithEvents parent_asset_no As Frame9.eText
    Friend WithEvents XtraTabPage3 As XtraTabPage
    Friend WithEvents g30 As Frame9.eGrid
    Friend WithEvents btn_addition As Frame9.eButton
    Friend WithEvents btn_apply As Frame9.eButton
    Friend WithEvents supp_name As Frame9.eText
End Class
