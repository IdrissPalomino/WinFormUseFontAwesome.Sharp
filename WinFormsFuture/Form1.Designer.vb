<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelMenu = New Panel()
        btnSetting = New FontAwesome.Sharp.IconButton()
        btnMarketing = New FontAwesome.Sharp.IconButton()
        btnCustomers = New FontAwesome.Sharp.IconButton()
        btnProducts = New FontAwesome.Sharp.IconButton()
        btnOrders = New FontAwesome.Sharp.IconButton()
        btnDashboard = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        ImgHome = New PictureBox()
        PanelTitleBar = New Panel()
        btnMinimize = New Button()
        btnMaximize = New Button()
        btnExit = New Button()
        lblFormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        PictureBox1 = New PictureBox()
        PanelMenu.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(ImgHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelDesktop.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelMenu.Controls.Add(btnSetting)
        PanelMenu.Controls.Add(btnMarketing)
        PanelMenu.Controls.Add(btnCustomers)
        PanelMenu.Controls.Add(btnProducts)
        PanelMenu.Controls.Add(btnOrders)
        PanelMenu.Controls.Add(btnDashboard)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Margin = New Padding(4, 3, 4, 3)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(257, 601)
        PanelMenu.TabIndex = 2
        ' 
        ' btnSetting
        ' 
        btnSetting.Dock = DockStyle.Top
        btnSetting.FlatAppearance.BorderSize = 0
        btnSetting.FlatStyle = FlatStyle.Flat
        btnSetting.ForeColor = Color.Gainsboro
        btnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools
        btnSetting.IconColor = Color.Gainsboro
        btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSetting.IconSize = 32
        btnSetting.ImageAlign = ContentAlignment.MiddleLeft
        btnSetting.Location = New Point(0, 507)
        btnSetting.Margin = New Padding(4, 3, 4, 3)
        btnSetting.Name = "btnSetting"
        btnSetting.Padding = New Padding(12, 0, 23, 0)
        btnSetting.Size = New Size(257, 69)
        btnSetting.TabIndex = 6
        btnSetting.Text = "Setting"
        btnSetting.TextAlign = ContentAlignment.MiddleLeft
        btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSetting.UseVisualStyleBackColor = True
        ' 
        ' btnMarketing
        ' 
        btnMarketing.Dock = DockStyle.Top
        btnMarketing.FlatAppearance.BorderSize = 0
        btnMarketing.FlatStyle = FlatStyle.Flat
        btnMarketing.ForeColor = Color.Gainsboro
        btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        btnMarketing.IconColor = Color.Gainsboro
        btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMarketing.IconSize = 32
        btnMarketing.ImageAlign = ContentAlignment.MiddleLeft
        btnMarketing.Location = New Point(0, 438)
        btnMarketing.Margin = New Padding(4, 3, 4, 3)
        btnMarketing.Name = "btnMarketing"
        btnMarketing.Padding = New Padding(12, 0, 23, 0)
        btnMarketing.Size = New Size(257, 69)
        btnMarketing.TabIndex = 5
        btnMarketing.Text = "Marketing"
        btnMarketing.TextAlign = ContentAlignment.MiddleLeft
        btnMarketing.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMarketing.UseVisualStyleBackColor = True
        ' 
        ' btnCustomers
        ' 
        btnCustomers.Dock = DockStyle.Top
        btnCustomers.FlatAppearance.BorderSize = 0
        btnCustomers.FlatStyle = FlatStyle.Flat
        btnCustomers.ForeColor = Color.Gainsboro
        btnCustomers.IconChar = FontAwesome.Sharp.IconChar.User
        btnCustomers.IconColor = Color.Gainsboro
        btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCustomers.IconSize = 32
        btnCustomers.ImageAlign = ContentAlignment.MiddleLeft
        btnCustomers.Location = New Point(0, 369)
        btnCustomers.Margin = New Padding(4, 3, 4, 3)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Padding = New Padding(12, 0, 23, 0)
        btnCustomers.Size = New Size(257, 69)
        btnCustomers.TabIndex = 4
        btnCustomers.Text = "Customers"
        btnCustomers.TextAlign = ContentAlignment.MiddleLeft
        btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.Dock = DockStyle.Top
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.ForeColor = Color.Gainsboro
        btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag
        btnProducts.IconColor = Color.Gainsboro
        btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProducts.IconSize = 32
        btnProducts.ImageAlign = ContentAlignment.MiddleLeft
        btnProducts.Location = New Point(0, 300)
        btnProducts.Margin = New Padding(4, 3, 4, 3)
        btnProducts.Name = "btnProducts"
        btnProducts.Padding = New Padding(12, 0, 23, 0)
        btnProducts.Size = New Size(257, 69)
        btnProducts.TabIndex = 3
        btnProducts.Text = "Products"
        btnProducts.TextAlign = ContentAlignment.MiddleLeft
        btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnOrders
        ' 
        btnOrders.Dock = DockStyle.Top
        btnOrders.FlatAppearance.BorderSize = 0
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.ForeColor = Color.Gainsboro
        btnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        btnOrders.IconColor = Color.Gainsboro
        btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnOrders.IconSize = 32
        btnOrders.ImageAlign = ContentAlignment.MiddleLeft
        btnOrders.Location = New Point(0, 231)
        btnOrders.Margin = New Padding(4, 3, 4, 3)
        btnOrders.Name = "btnOrders"
        btnOrders.Padding = New Padding(12, 0, 23, 0)
        btnOrders.Size = New Size(257, 69)
        btnOrders.TabIndex = 2
        btnOrders.Text = "Orders"
        btnOrders.TextAlign = ContentAlignment.MiddleLeft
        btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText
        btnOrders.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.Gainsboro
        btnDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        btnDashboard.IconColor = Color.Gainsboro
        btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDashboard.IconSize = 32
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 162)
        btnDashboard.Margin = New Padding(4, 3, 4, 3)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(12, 0, 23, 0)
        btnDashboard.Size = New Size(257, 69)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(ImgHome)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Margin = New Padding(4, 3, 4, 3)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(257, 162)
        PanelLogo.TabIndex = 0
        ' 
        ' ImgHome
        ' 
        ImgHome.Image = My.Resources.Resources.logo_Paltarumi
        ImgHome.Location = New Point(26, 36)
        ImgHome.Margin = New Padding(4, 3, 4, 3)
        ImgHome.Name = "ImgHome"
        ImgHome.Size = New Size(208, 92)
        ImgHome.SizeMode = PictureBoxSizeMode.Zoom
        ImgHome.TabIndex = 0
        ImgHome.TabStop = False
        ' 
        ' PanelTitleBar
        ' 
        PanelTitleBar.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        PanelTitleBar.Controls.Add(btnMinimize)
        PanelTitleBar.Controls.Add(btnMaximize)
        PanelTitleBar.Controls.Add(btnExit)
        PanelTitleBar.Controls.Add(lblFormTitle)
        PanelTitleBar.Controls.Add(IconCurrentForm)
        PanelTitleBar.Dock = DockStyle.Top
        PanelTitleBar.Location = New Point(257, 0)
        PanelTitleBar.Margin = New Padding(4, 3, 4, 3)
        PanelTitleBar.Name = "PanelTitleBar"
        PanelTitleBar.Size = New Size(740, 87)
        PanelTitleBar.TabIndex = 3
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Image = My.Resources.Resources.minimize_icon_24
        btnMinimize.Location = New Point(651, 0)
        btnMinimize.Margin = New Padding(4, 3, 4, 3)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(30, 30)
        btnMinimize.TabIndex = 4
        btnMinimize.UseVisualStyleBackColor = True
        ' 
        ' btnMaximize
        ' 
        btnMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximize.FlatAppearance.BorderSize = 0
        btnMaximize.FlatStyle = FlatStyle.Flat
        btnMaximize.Image = My.Resources.Resources.icon_maximize_24
        btnMaximize.Location = New Point(680, 0)
        btnMaximize.Margin = New Padding(4, 3, 4, 3)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(30, 30)
        btnMaximize.TabIndex = 3
        btnMaximize.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources.exit_icon_24
        btnExit.Location = New Point(709, 0)
        btnExit.Margin = New Padding(4, 3, 4, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(30, 30)
        btnExit.TabIndex = 2
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.ForeColor = Color.Gainsboro
        lblFormTitle.Location = New Point(54, 36)
        lblFormTitle.Margin = New Padding(4, 0, 4, 0)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(40, 15)
        lblFormTitle.TabIndex = 1
        lblFormTitle.Text = "Home"
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        IconCurrentForm.ForeColor = Color.MediumPurple
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        IconCurrentForm.IconColor = Color.MediumPurple
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.IconSize = 37
        IconCurrentForm.Location = New Point(10, 24)
        IconCurrentForm.Margin = New Padding(4, 3, 4, 3)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(37, 37)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        PanelDesktop.Controls.Add(PictureBox1)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(257, 87)
        PanelDesktop.Margin = New Padding(4, 3, 4, 3)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(740, 514)
        PanelDesktop.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.logo_Paltarumi
        PictureBox1.Location = New Point(140, 125)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(495, 284)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 601)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenu)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        PanelMenu.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(ImgHome, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleBar.ResumeLayout(False)
        PanelTitleBar.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelDesktop.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents ImgHome As PictureBox
    Friend WithEvents btnSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMarketing As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOrders As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnExit As Button
End Class
