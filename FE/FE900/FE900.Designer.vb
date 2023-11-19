<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FE900
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame9.ePanel()
        Me.q_asset = New Frame9.eText()
        Me.q_asset_group = New Frame9.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g10 = New Frame9.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.g60 = New Frame9.eGrid()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.g70 = New Frame9.eGrid()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.g80 = New Frame9.eGrid()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.g90 = New Frame9.eGrid()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.chk1 = New Frame9.eCheck()
        Me.chk2 = New Frame9.eCheck()
        Me.g20 = New Frame9.eGrid()
        Me.g30 = New Frame9.eGrid()
        Me.g40 = New Frame9.eGrid()
        Me.g50 = New Frame9.eGrid()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1750, 750)
        Me.SplitContainer1.SplitterDistance = 75
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.chk2)
        Me.EPanel3.Controls.Add(Me.chk1)
        Me.EPanel3.Controls.Add(Me.q_asset)
        Me.EPanel3.Controls.Add(Me.q_asset_group)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1750, 75)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Apply Leave"
        '
        'q_asset
        '
        Me.q_asset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q_asset.Location = New System.Drawing.Point(5, 36)
        Me.q_asset.Name = "q_asset"
        Me.q_asset.Size = New System.Drawing.Size(209, 20)
        Me.q_asset.TabIndex = 64
        Me.q_asset.Title = "Asset"
        Me.q_asset.TitleWidth = 70
        '
        'q_asset_group
        '
        Me.q_asset_group.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q_asset_group.Location = New System.Drawing.Point(220, 36)
        Me.q_asset_group.Name = "q_asset_group"
        Me.q_asset_group.Size = New System.Drawing.Size(209, 20)
        Me.q_asset_group.TabIndex = 3
        Me.q_asset_group.Title = "Asset Group"
        Me.q_asset_group.TitleWidth = 70
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1750, 671)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AlwaysScrollActiveControlIntoView = False
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.g10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1744, 642)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(1744, 642)
        Me.g10.TabIndex = 1
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1744, 642)
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
        Me.Panel4.Size = New System.Drawing.Size(1744, 642)
        Me.Panel4.TabIndex = 1
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.AutoScroll = True
        Me.XtraTabPage3.Controls.Add(Me.g30)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1744, 642)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.AutoScroll = True
        Me.XtraTabPage4.Controls.Add(Me.g40)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1744, 642)
        Me.XtraTabPage4.Text = "XtraTabPage4"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.AutoScroll = True
        Me.XtraTabPage5.Controls.Add(Me.g50)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1744, 642)
        Me.XtraTabPage5.Text = "XtraTabPage5"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.AutoScroll = True
        Me.XtraTabPage6.Controls.Add(Me.g60)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1744, 642)
        Me.XtraTabPage6.Text = "XtraTabPage6"
        '
        'g60
        '
        Me.g60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g60.Location = New System.Drawing.Point(0, 0)
        Me.g60.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g60.Name = "g60"
        Me.g60.Size = New System.Drawing.Size(1744, 642)
        Me.g60.TabIndex = 0
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.AutoScroll = True
        Me.XtraTabPage7.Controls.Add(Me.g70)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(1744, 642)
        Me.XtraTabPage7.Text = "XtraTabPage7"
        '
        'g70
        '
        Me.g70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g70.Location = New System.Drawing.Point(0, 0)
        Me.g70.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g70.Name = "g70"
        Me.g70.Size = New System.Drawing.Size(1744, 642)
        Me.g70.TabIndex = 0
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.AutoScroll = True
        Me.XtraTabPage8.Controls.Add(Me.g80)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(1744, 642)
        Me.XtraTabPage8.Text = "XtraTabPage8"
        '
        'g80
        '
        Me.g80.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g80.Location = New System.Drawing.Point(0, 0)
        Me.g80.Name = "g80"
        Me.g80.Size = New System.Drawing.Size(1744, 642)
        Me.g80.TabIndex = 2
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.AutoScroll = True
        Me.XtraTabPage9.Controls.Add(Me.g90)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(1744, 642)
        Me.XtraTabPage9.Text = "XtraTabPage9"
        '
        'g90
        '
        Me.g90.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g90.Location = New System.Drawing.Point(0, 0)
        Me.g90.Name = "g90"
        Me.g90.Size = New System.Drawing.Size(1744, 642)
        Me.g90.TabIndex = 1
        '
        'chk1
        '
        Me.chk1.Location = New System.Drawing.Point(446, 24)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(236, 21)
        Me.chk1.TabIndex = 66
        Me.chk1.Title = "Asset Group <> Calculation Formula"
        Me.chk1.TitleLocation = Frame9.TitleLocation.Right
        Me.chk1.TitleWidth = 70
        '
        'chk2
        '
        Me.chk2.Location = New System.Drawing.Point(446, 49)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(236, 21)
        Me.chk2.TabIndex = 67
        Me.chk2.Title = "Depreciation Method <> 1"
        Me.chk2.TitleLocation = Frame9.TitleLocation.Right
        Me.chk2.TitleWidth = 70
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.Size = New System.Drawing.Size(1744, 642)
        Me.g20.TabIndex = 3
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g30.Name = "g30"
        Me.g30.Size = New System.Drawing.Size(1744, 642)
        Me.g30.TabIndex = 1
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g40.Name = "g40"
        Me.g40.Size = New System.Drawing.Size(1744, 642)
        Me.g40.TabIndex = 1
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g50.Name = "g50"
        Me.g50.Size = New System.Drawing.Size(1744, 642)
        Me.g50.TabIndex = 1
        '
        'FE900
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FE900"
        Me.Size = New System.Drawing.Size(1750, 750)
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
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents EPanel3 As Frame9.ePanel
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents q_asset_group As Frame9.eText
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
    Friend WithEvents chk2 As Frame9.eCheck
    Friend WithEvents chk1 As Frame9.eCheck
    Friend WithEvents g20 As Frame9.eGrid
    Friend WithEvents g30 As Frame9.eGrid
    Friend WithEvents g40 As Frame9.eGrid
    Friend WithEvents g50 As Frame9.eGrid
End Class
