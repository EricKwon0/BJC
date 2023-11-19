<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FE730
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
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame9.ePanel()
        Me.q_chk2 = New Frame9.eCheck()
        Me.q_asset_status = New Frame9.eCheckCombo()
        Me.q_chk = New Frame9.eCheck()
        Me.q_category = New Frame9.eCheckCombo()
        Me.q_month = New Frame9.eDate()
        Me.q_asset = New Frame9.eText()
        Me.EPanel7 = New Frame9.ePanel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g10 = New Frame9.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame9.ePanel()
        Me.g20 = New Frame9.eGrid()
        Me.EPanel5 = New Frame9.ePanel()
        Me.g21 = New Frame9.eGrid()
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
        Me.btn_exc = New Frame9.eButton()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel7.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1750, 750)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel7)
        Me.SplitContainer3.Size = New System.Drawing.Size(1750, 78)
        Me.SplitContainer3.SplitterDistance = 804
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.q_chk2)
        Me.EPanel3.Controls.Add(Me.q_asset_status)
        Me.EPanel3.Controls.Add(Me.q_chk)
        Me.EPanel3.Controls.Add(Me.q_category)
        Me.EPanel3.Controls.Add(Me.q_month)
        Me.EPanel3.Controls.Add(Me.q_asset)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(804, 78)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Apply Leave"
        '
        'q_chk2
        '
        Me.q_chk2.Location = New System.Drawing.Point(530, 47)
        Me.q_chk2.Name = "q_chk2"
        Me.q_chk2.Size = New System.Drawing.Size(221, 21)
        Me.q_chk2.TabIndex = 73
        Me.q_chk2.Title = "Exclude Depreciation Completed"
        Me.q_chk2.TitleLocation = Frame9.TitleLocation.Right
        Me.q_chk2.TitleWidth = 70
        '
        'q_asset_status
        '
        Me.q_asset_status.Location = New System.Drawing.Point(530, 24)
        Me.q_asset_status.Name = "q_asset_status"
        Me.q_asset_status.Size = New System.Drawing.Size(220, 20)
        Me.q_asset_status.TabIndex = 72
        Me.q_asset_status.Title = "Asset Status"
        Me.q_asset_status.TitleWidth = 80
        '
        'q_chk
        '
        Me.q_chk.Location = New System.Drawing.Point(6, 47)
        Me.q_chk.Name = "q_chk"
        Me.q_chk.Size = New System.Drawing.Size(90, 21)
        Me.q_chk.TabIndex = 71
        Me.q_chk.Title = "All Period"
        Me.q_chk.TitleWidth = 70
        '
        'q_category
        '
        Me.q_category.Location = New System.Drawing.Point(213, 24)
        Me.q_category.Name = "q_category"
        Me.q_category.Size = New System.Drawing.Size(311, 20)
        Me.q_category.TabIndex = 66
        Me.q_category.Title = "Category"
        Me.q_category.TitleWidth = 60
        '
        'q_month
        '
        Me.q_month.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q_month.Location = New System.Drawing.Point(6, 24)
        Me.q_month.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.q_month.Name = "q_month"
        Me.q_month.Size = New System.Drawing.Size(200, 20)
        Me.q_month.TabIndex = 65
        Me.q_month.Title = "Month"
        Me.q_month.TitleWidth = 70
        '
        'q_asset
        '
        Me.q_asset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q_asset.Location = New System.Drawing.Point(213, 47)
        Me.q_asset.Name = "q_asset"
        Me.q_asset.Size = New System.Drawing.Size(311, 20)
        Me.q_asset.TabIndex = 64
        Me.q_asset.Title = "Asset No"
        Me.q_asset.TitleWidth = 60
        '
        'EPanel7
        '
        Me.EPanel7.Controls.Add(Me.btn_exc)
        Me.EPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel7.Location = New System.Drawing.Point(0, 0)
        Me.EPanel7.Name = "EPanel7"
        Me.EPanel7.Size = New System.Drawing.Size(942, 78)
        Me.EPanel7.TabIndex = 3
        Me.EPanel7.Text = "     Search"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1750, 668)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AlwaysScrollActiveControlIntoView = False
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.g10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(1744, 639)
        Me.g10.TabIndex = 1
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.SplitContainer2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1744, 639)
        Me.Panel4.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel5)
        Me.SplitContainer2.Size = New System.Drawing.Size(1744, 639)
        Me.SplitContainer2.SplitterDistance = 1226
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(1226, 639)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     Apply Leave"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 21)
        Me.g20.Name = "g20"
        Me.g20.Size = New System.Drawing.Size(1222, 616)
        Me.g20.TabIndex = 2
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g21)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(514, 639)
        Me.EPanel5.TabIndex = 2
        Me.EPanel5.Text = "     Apply Leave"
        '
        'g21
        '
        Me.g21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g21.Location = New System.Drawing.Point(2, 21)
        Me.g21.Name = "g21"
        Me.g21.Size = New System.Drawing.Size(510, 616)
        Me.g21.TabIndex = 2
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.AutoScroll = True
        Me.XtraTabPage3.Controls.Add(Me.g30)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g30.Name = "g30"
        Me.g30.Size = New System.Drawing.Size(1744, 639)
        Me.g30.TabIndex = 1
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.AutoScroll = True
        Me.XtraTabPage4.Controls.Add(Me.g40)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage4.Text = "XtraTabPage4"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g40.Name = "g40"
        Me.g40.Size = New System.Drawing.Size(1744, 639)
        Me.g40.TabIndex = 1
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.AutoScroll = True
        Me.XtraTabPage5.Controls.Add(Me.g50)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage5.Text = "XtraTabPage5"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g50.Name = "g50"
        Me.g50.Size = New System.Drawing.Size(1744, 639)
        Me.g50.TabIndex = 1
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.AutoScroll = True
        Me.XtraTabPage6.Controls.Add(Me.g60)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage6.Text = "XtraTabPage6"
        '
        'g60
        '
        Me.g60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g60.Location = New System.Drawing.Point(0, 0)
        Me.g60.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g60.Name = "g60"
        Me.g60.Size = New System.Drawing.Size(1744, 639)
        Me.g60.TabIndex = 0
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.AutoScroll = True
        Me.XtraTabPage7.Controls.Add(Me.g70)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage7.Text = "XtraTabPage7"
        '
        'g70
        '
        Me.g70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g70.Location = New System.Drawing.Point(0, 0)
        Me.g70.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g70.Name = "g70"
        Me.g70.Size = New System.Drawing.Size(1744, 639)
        Me.g70.TabIndex = 0
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.AutoScroll = True
        Me.XtraTabPage8.Controls.Add(Me.g80)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage8.Text = "XtraTabPage8"
        '
        'g80
        '
        Me.g80.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g80.Location = New System.Drawing.Point(0, 0)
        Me.g80.Name = "g80"
        Me.g80.Size = New System.Drawing.Size(1744, 639)
        Me.g80.TabIndex = 2
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.AutoScroll = True
        Me.XtraTabPage9.Controls.Add(Me.g90)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(1744, 639)
        Me.XtraTabPage9.Text = "XtraTabPage9"
        '
        'g90
        '
        Me.g90.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g90.Location = New System.Drawing.Point(0, 0)
        Me.g90.Name = "g90"
        Me.g90.Size = New System.Drawing.Size(1744, 639)
        Me.g90.TabIndex = 1
        '
        'btn_exc
        '
        Me.btn_exc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exc.Appearance.Options.UseFont = True
        Me.btn_exc.Appearance.Options.UseTextOptions = True
        Me.btn_exc.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btn_exc.Location = New System.Drawing.Point(18, 24)
        Me.btn_exc.Name = "btn_exc"
        Me.btn_exc.Size = New System.Drawing.Size(153, 44)
        Me.btn_exc.TabIndex = 5
        Me.btn_exc.Text = "Calculate"
        '
        'FE730
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FE730"
        Me.Size = New System.Drawing.Size(1750, 750)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel7.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
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
    Friend WithEvents q_asset As Frame9.eText
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
    Friend WithEvents g30 As Frame9.eGrid
    Friend WithEvents g40 As Frame9.eGrid
    Friend WithEvents g50 As Frame9.eGrid
    Friend WithEvents q_month As Frame9.eDate
    Friend WithEvents q_category As Frame9.eCheckCombo
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents EPanel4 As Frame9.ePanel
    Friend WithEvents g20 As Frame9.eGrid
    Friend WithEvents EPanel5 As Frame9.ePanel
    Friend WithEvents g21 As Frame9.eGrid
    Friend WithEvents q_chk As Frame9.eCheck
    Friend WithEvents q_asset_status As Frame9.eCheckCombo
    Friend WithEvents q_chk2 As Frame9.eCheck
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents EPanel7 As Frame9.ePanel
    Friend WithEvents btn_exc As Frame9.eButton
End Class
