<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FE710
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame9.ePanel()
        Me.btn_show4 = New Frame9.eButton()
        Me.btn_show3 = New Frame9.eButton()
        Me.btn_show2 = New Frame9.eButton()
        Me.btn_show1 = New Frame9.eButton()
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g10 = New Frame9.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.g20 = New Frame9.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame9.eGrid()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.g40 = New Frame9.eGrid()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.g50 = New Frame9.eGrid()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.g60 = New Frame9.eGrid()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.g70 = New Frame9.eGrid()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.g80 = New Frame9.eGrid()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.g90 = New Frame9.eGrid()
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
        Me.Panel4.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        Me.XtraTabPage7.SuspendLayout()
        Me.XtraTabPage8.SuspendLayout()
        Me.XtraTabPage9.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1915, 750)
        Me.SplitContainer1.SplitterDistance = 76
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.btn_show4)
        Me.EPanel3.Controls.Add(Me.btn_show3)
        Me.EPanel3.Controls.Add(Me.btn_show2)
        Me.EPanel3.Controls.Add(Me.btn_show1)
        Me.EPanel3.Controls.Add(Me.f_asset_status)
        Me.EPanel3.Controls.Add(Me.f_facility_no)
        Me.EPanel3.Controls.Add(Me.f_manager)
        Me.EPanel3.Controls.Add(Me.f_car_no)
        Me.EPanel3.Controls.Add(Me.f_store)
        Me.EPanel3.Controls.Add(Me.f_project)
        Me.EPanel3.Controls.Add(Me.f_serial)
        Me.EPanel3.Controls.Add(Me.f_model)
        Me.EPanel3.Controls.Add(Me.f_location)
        Me.EPanel3.Controls.Add(Me.f_asset_category)
        Me.EPanel3.Controls.Add(Me.f_to_dt)
        Me.EPanel3.Controls.Add(Me.f_fr_dt)
        Me.EPanel3.Controls.Add(Me.f_asset_name)
        Me.EPanel3.Controls.Add(Me.f_asset_no)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1915, 76)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Apply Leave"
        '
        'btn_show4
        '
        Me.btn_show4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_show4.Appearance.Options.UseBackColor = True
        Me.btn_show4.Appearance.Options.UseTextOptions = True
        Me.btn_show4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btn_show4.Location = New System.Drawing.Point(1721, 48)
        Me.btn_show4.Name = "btn_show4"
        Me.btn_show4.Size = New System.Drawing.Size(117, 20)
        Me.btn_show4.TabIndex = 82
        Me.btn_show4.Text = "Show Disposal"
        '
        'btn_show3
        '
        Me.btn_show3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_show3.Appearance.Options.UseBackColor = True
        Me.btn_show3.Appearance.Options.UseTextOptions = True
        Me.btn_show3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btn_show3.Location = New System.Drawing.Point(1721, 26)
        Me.btn_show3.Name = "btn_show3"
        Me.btn_show3.Size = New System.Drawing.Size(117, 20)
        Me.btn_show3.TabIndex = 81
        Me.btn_show3.Text = "Show Supplier"
        '
        'btn_show2
        '
        Me.btn_show2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_show2.Appearance.Options.UseBackColor = True
        Me.btn_show2.Appearance.Options.UseTextOptions = True
        Me.btn_show2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btn_show2.Location = New System.Drawing.Point(1602, 48)
        Me.btn_show2.Name = "btn_show2"
        Me.btn_show2.Size = New System.Drawing.Size(117, 20)
        Me.btn_show2.TabIndex = 80
        Me.btn_show2.Text = "Show Insurance"
        '
        'btn_show1
        '
        Me.btn_show1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_show1.Appearance.Options.UseBackColor = True
        Me.btn_show1.Appearance.Options.UseTextOptions = True
        Me.btn_show1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btn_show1.Location = New System.Drawing.Point(1602, 26)
        Me.btn_show1.Name = "btn_show1"
        Me.btn_show1.Size = New System.Drawing.Size(117, 20)
        Me.btn_show1.TabIndex = 79
        Me.btn_show1.Text = "Show Warranty"
        '
        'f_asset_status
        '
        Me.f_asset_status.Location = New System.Drawing.Point(1383, 48)
        Me.f_asset_status.Name = "f_asset_status"
        Me.f_asset_status.Size = New System.Drawing.Size(213, 20)
        Me.f_asset_status.TabIndex = 74
        Me.f_asset_status.Title = "Status"
        Me.f_asset_status.TitleWidth = 90
        '
        'f_facility_no
        '
        Me.f_facility_no.Location = New System.Drawing.Point(1383, 25)
        Me.f_facility_no.Name = "f_facility_no"
        Me.f_facility_no.Size = New System.Drawing.Size(213, 20)
        Me.f_facility_no.TabIndex = 73
        Me.f_facility_no.Title = "Facility No"
        Me.f_facility_no.TitleWidth = 90
        '
        'f_manager
        '
        Me.f_manager.Location = New System.Drawing.Point(1155, 48)
        Me.f_manager.Name = "f_manager"
        Me.f_manager.Size = New System.Drawing.Size(222, 20)
        Me.f_manager.TabIndex = 72
        Me.f_manager.Title = "Manager"
        Me.f_manager.TitleWidth = 90
        '
        'f_car_no
        '
        Me.f_car_no.Location = New System.Drawing.Point(1155, 25)
        Me.f_car_no.Name = "f_car_no"
        Me.f_car_no.Size = New System.Drawing.Size(222, 20)
        Me.f_car_no.TabIndex = 71
        Me.f_car_no.Title = "Car No"
        Me.f_car_no.TitleWidth = 90
        '
        'f_store
        '
        Me.f_store.Location = New System.Drawing.Point(934, 48)
        Me.f_store.Name = "f_store"
        Me.f_store.Size = New System.Drawing.Size(217, 20)
        Me.f_store.TabIndex = 70
        Me.f_store.Title = "Store"
        Me.f_store.TitleWidth = 90
        '
        'f_project
        '
        Me.f_project.Location = New System.Drawing.Point(934, 25)
        Me.f_project.Name = "f_project"
        Me.f_project.Size = New System.Drawing.Size(217, 20)
        Me.f_project.TabIndex = 69
        Me.f_project.Title = "Project"
        Me.f_project.TitleWidth = 90
        '
        'f_serial
        '
        Me.f_serial.Location = New System.Drawing.Point(716, 48)
        Me.f_serial.Name = "f_serial"
        Me.f_serial.Size = New System.Drawing.Size(212, 20)
        Me.f_serial.TabIndex = 68
        Me.f_serial.Title = "Serial"
        Me.f_serial.TitleWidth = 90
        '
        'f_model
        '
        Me.f_model.Location = New System.Drawing.Point(716, 25)
        Me.f_model.Name = "f_model"
        Me.f_model.Size = New System.Drawing.Size(212, 20)
        Me.f_model.TabIndex = 67
        Me.f_model.Title = "Model"
        Me.f_model.TitleWidth = 90
        '
        'f_location
        '
        Me.f_location.Location = New System.Drawing.Point(470, 48)
        Me.f_location.Name = "f_location"
        Me.f_location.Size = New System.Drawing.Size(240, 20)
        Me.f_location.TabIndex = 66
        Me.f_location.Title = "Location"
        Me.f_location.TitleWidth = 90
        '
        'f_asset_category
        '
        Me.f_asset_category.Location = New System.Drawing.Point(470, 25)
        Me.f_asset_category.Name = "f_asset_category"
        Me.f_asset_category.Size = New System.Drawing.Size(240, 20)
        Me.f_asset_category.TabIndex = 65
        Me.f_asset_category.Title = "Asset Category"
        Me.f_asset_category.TitleWidth = 90
        '
        'f_to_dt
        '
        Me.f_to_dt.Location = New System.Drawing.Point(4, 48)
        Me.f_to_dt.Name = "f_to_dt"
        Me.f_to_dt.Size = New System.Drawing.Size(214, 20)
        Me.f_to_dt.TabIndex = 64
        Me.f_to_dt.Title = "~"
        Me.f_to_dt.TitleAlign = Frame9.Alignment.Left
        Me.f_to_dt.TitleWidth = 90
        '
        'f_fr_dt
        '
        Me.f_fr_dt.Location = New System.Drawing.Point(4, 25)
        Me.f_fr_dt.Name = "f_fr_dt"
        Me.f_fr_dt.Size = New System.Drawing.Size(214, 20)
        Me.f_fr_dt.TabIndex = 63
        Me.f_fr_dt.Title = "Install Date"
        Me.f_fr_dt.TitleWidth = 90
        '
        'f_asset_name
        '
        Me.f_asset_name.Location = New System.Drawing.Point(224, 48)
        Me.f_asset_name.Name = "f_asset_name"
        Me.f_asset_name.Size = New System.Drawing.Size(240, 20)
        Me.f_asset_name.TabIndex = 62
        Me.f_asset_name.Title = "Asset Name"
        Me.f_asset_name.TitleWidth = 90
        '
        'f_asset_no
        '
        Me.f_asset_no.Location = New System.Drawing.Point(224, 25)
        Me.f_asset_no.Name = "f_asset_no"
        Me.f_asset_no.Size = New System.Drawing.Size(240, 20)
        Me.f_asset_no.TabIndex = 61
        Me.f_asset_no.Title = "Asset No"
        Me.f_asset_no.TitleWidth = 90
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1915, 670)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AlwaysScrollActiveControlIntoView = False
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.g10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(1909, 641)
        Me.g10.TabIndex = 1
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.g20)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1909, 641)
        Me.Panel4.TabIndex = 1
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.Size = New System.Drawing.Size(1909, 641)
        Me.g20.TabIndex = 3
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.AutoScroll = True
        Me.XtraTabPage3.Controls.Add(Me.g30)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g30.Name = "g30"
        Me.g30.Size = New System.Drawing.Size(1909, 641)
        Me.g30.TabIndex = 1
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.AutoScroll = True
        Me.XtraTabPage4.Controls.Add(Me.g40)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage4.Text = "XtraTabPage4"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g40.Name = "g40"
        Me.g40.Size = New System.Drawing.Size(1909, 641)
        Me.g40.TabIndex = 1
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.AutoScroll = True
        Me.XtraTabPage5.Controls.Add(Me.g50)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage5.Text = "XtraTabPage5"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g50.Name = "g50"
        Me.g50.Size = New System.Drawing.Size(1909, 641)
        Me.g50.TabIndex = 1
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.AutoScroll = True
        Me.XtraTabPage6.Controls.Add(Me.g60)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage6.Text = "XtraTabPage6"
        '
        'g60
        '
        Me.g60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g60.Location = New System.Drawing.Point(0, 0)
        Me.g60.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g60.Name = "g60"
        Me.g60.Size = New System.Drawing.Size(1909, 641)
        Me.g60.TabIndex = 0
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.AutoScroll = True
        Me.XtraTabPage7.Controls.Add(Me.g70)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage7.Text = "XtraTabPage7"
        '
        'g70
        '
        Me.g70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g70.Location = New System.Drawing.Point(0, 0)
        Me.g70.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g70.Name = "g70"
        Me.g70.Size = New System.Drawing.Size(1909, 641)
        Me.g70.TabIndex = 0
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.AutoScroll = True
        Me.XtraTabPage8.Controls.Add(Me.g80)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage8.Text = "XtraTabPage8"
        '
        'g80
        '
        Me.g80.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g80.Location = New System.Drawing.Point(0, 0)
        Me.g80.Name = "g80"
        Me.g80.Size = New System.Drawing.Size(1909, 641)
        Me.g80.TabIndex = 2
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.AutoScroll = True
        Me.XtraTabPage9.Controls.Add(Me.g90)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(1909, 641)
        Me.XtraTabPage9.Text = "XtraTabPage9"
        '
        'g90
        '
        Me.g90.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g90.Location = New System.Drawing.Point(0, 0)
        Me.g90.Name = "g90"
        Me.g90.Size = New System.Drawing.Size(1909, 641)
        Me.g90.TabIndex = 1
        '
        'FE710
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FE710"
        Me.Size = New System.Drawing.Size(1915, 750)
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
        Me.XtraTabPage2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage7.ResumeLayout(False)
        Me.XtraTabPage8.ResumeLayout(False)
        Me.XtraTabPage9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame9.ePanel
    Friend WithEvents EPanel2 As Frame9.ePanel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents EPanel3 As Frame9.ePanel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame9.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g60 As Frame9.eGrid
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g70 As Frame9.eGrid
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g80 As Frame9.eGrid
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g90 As Frame9.eGrid
    Friend WithEvents g20 As Frame9.eGrid
    Friend WithEvents g30 As Frame9.eGrid
    Friend WithEvents g40 As Frame9.eGrid
    Friend WithEvents g50 As Frame9.eGrid
    Friend WithEvents f_asset_status As Frame9.eCheckCombo
    Friend WithEvents f_facility_no As Frame9.eText
    Friend WithEvents f_manager As Frame9.eText
    Friend WithEvents f_car_no As Frame9.eText
    Friend WithEvents f_store As Frame9.eText
    Friend WithEvents f_project As Frame9.eText
    Friend WithEvents f_serial As Frame9.eText
    Friend WithEvents f_model As Frame9.eText
    Friend WithEvents f_location As Frame9.eText
    Friend WithEvents f_asset_category As Frame9.eCheckCombo
    Friend WithEvents f_to_dt As Frame9.eDate
    Friend WithEvents f_fr_dt As Frame9.eDate
    Friend WithEvents f_asset_name As Frame9.eText
    Friend WithEvents f_asset_no As Frame9.eText
    Friend WithEvents btn_show1 As Frame9.eButton
    Friend WithEvents btn_show2 As Frame9.eButton
    Friend WithEvents btn_show4 As Frame9.eButton
    Friend WithEvents btn_show3 As Frame9.eButton
End Class
