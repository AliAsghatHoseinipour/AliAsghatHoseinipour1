partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
        this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
        this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
        this.pictureEditLogo = new DevExpress.XtraEditors.PictureEdit();
        this.txtUsername = new DevExpress.XtraEditors.TextEdit();
        this.txtPassword = new DevExpress.XtraEditors.TextEdit();
        this.chkRememberMe = new DevExpress.XtraEditors.CheckEdit();
        this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
        this.hyperLinkEditForgotPassword = new DevExpress.XtraEditors.HyperLinkEdit();
        this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
        this.layoutControlItemImage = new DevExpress.XtraLayout.LayoutControlItem();
        this.emptySpaceItemTop = new DevExpress.XtraLayout.EmptySpaceItem();
        this.layoutControlItemUsername = new DevExpress.XtraLayout.LayoutControlItem();
        this.layoutControlItemPassword = new DevExpress.XtraLayout.LayoutControlItem();
        this.layoutControlItemRememberMe = new DevExpress.XtraLayout.LayoutControlItem();
        this.layoutControlItemLoginButton = new DevExpress.XtraLayout.LayoutControlItem();
        this.emptySpaceItemBottom = new DevExpress.XtraLayout.EmptySpaceItem();
        this.layoutControlItemForgotPassword = new DevExpress.XtraLayout.LayoutControlItem();
        this.emptySpaceItemLeft = new DevExpress.XtraLayout.EmptySpaceItem();
        this.emptySpaceItemRight = new DevExpress.XtraLayout.EmptySpaceItem();
        this.lblTitle = new DevExpress.XtraEditors.LabelControl();
        this.layoutControlItemTitle = new DevExpress.XtraLayout.LayoutControlItem();
        this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
        this.layoutControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureEditLogo.Properties)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe.Properties)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditForgotPassword.Properties)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImage)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemTop)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemUsername)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPassword)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRememberMe)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLoginButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemBottom)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForgotPassword)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemLeft)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemRight)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTitle)).BeginInit();
        this.SuspendLayout();
        //
        // ribbonControl1
        //
        this.ribbonControl1.ExpandCollapseItem.Id = 0;
        this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
        this.ribbonControl1.ExpandCollapseItem,
        this.ribbonControl1.SearchEditItem});
        this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
        this.ribbonControl1.MaxItemId = 1;
        this.ribbonControl1.Name = "ribbonControl1";
        this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
        this.ribbonPage1});
        this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
        this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
        this.ribbonControl1.ShowToolbarCustomizeItem = false;
        this.ribbonControl1.Size = new System.Drawing.Size(498, 60); // Reduced ribbon height
        this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
        this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
        //
        // ribbonPage1
        //
        this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
        this.ribbonPageGroup1});
        this.ribbonPage1.Name = "ribbonPage1";
        this.ribbonPage1.Text = "ribbonPage1";
        //
        // ribbonPageGroup1
        //
        this.ribbonPageGroup1.Name = "ribbonPageGroup1";
        this.ribbonPageGroup1.Text = "ribbonPageGroup1";
        //
        // layoutControl1
        //
        this.layoutControl1.Controls.Add(this.lblTitle);
        this.layoutControl1.Controls.Add(this.pictureEditLogo);
        this.layoutControl1.Controls.Add(this.txtUsername);
        this.layoutControl1.Controls.Add(this.txtPassword);
        this.layoutControl1.Controls.Add(this.chkRememberMe);
        this.layoutControl1.Controls.Add(this.btnLogin);
        this.layoutControl1.Controls.Add(this.hyperLinkEditForgotPassword);
        this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.layoutControl1.Location = new System.Drawing.Point(0, 60);
        this.layoutControl1.Name = "layoutControl1";
        this.layoutControl1.Root = this.Root;
        this.layoutControl1.Size = new System.Drawing.Size(498, 378);
        this.layoutControl1.TabIndex = 1;
        this.layoutControl1.Text = "layoutControl1";
        //
        // pictureEditLogo
        //
        // A default placeholder image or your logo path
        // For a real application, you would load your logo here.
        // For example, using: this.pictureEditLogo.EditValue = Image.FromFile("path_to_your_logo.png");
        // Or add it via the designer.
        // For now, a simple placeholder:
        this.pictureEditLogo.EditValue = null; // Can be set to a default image in resources
        this.pictureEditLogo.Location = new System.Drawing.Point(172, 52);
        this.pictureEditLogo.MenuManager = this.ribbonControl1;
        this.pictureEditLogo.Name = "pictureEditLogo";
        this.pictureEditLogo.Properties.AllowFocused = false;
        this.pictureEditLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
        this.pictureEditLogo.Properties.Appearance.Options.UseBackColor = true;
        this.pictureEditLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        this.pictureEditLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
        this.pictureEditLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze; // Or Zoom, Stretch, etc.
        this.pictureEditLogo.Size = new System.Drawing.Size(154, 100);
        this.pictureEditLogo.StyleController = this.layoutControl1;
        this.pictureEditLogo.TabIndex = 4;
        //
        // txtUsername
        //
        this.txtUsername.Location = new System.Drawing.Point(132, 190);
        this.txtUsername.MenuManager = this.ribbonControl1;
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtUsername.Properties.Appearance.Options.UseFont = true;
        this.txtUsername.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtUsername.Properties.ContextImageOptions.SvgImage"))); // User icon
        this.txtUsername.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
        this.txtUsername.Size = new System.Drawing.Size(294, 22);
        this.txtUsername.StyleController = this.layoutControl1;
        this.txtUsername.TabIndex = 5;
        //
        // txtPassword
        //
        this.txtPassword.Location = new System.Drawing.Point(132, 216);
        this.txtPassword.MenuManager = this.ribbonControl1;
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtPassword.Properties.Appearance.Options.UseFont = true;
        this.txtPassword.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtPassword.Properties.ContextImageOptions.SvgImage"))); // Key icon
        this.txtPassword.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
        this.txtPassword.Properties.UseSystemPasswordChar = true;
        this.txtPassword.Size = new System.Drawing.Size(294, 22);
        this.txtPassword.StyleController = this.layoutControl1;
        this.txtPassword.TabIndex = 6;
        //
        // chkRememberMe
        //
        this.chkRememberMe.Location = new System.Drawing.Point(72, 242);
        this.chkRememberMe.MenuManager = this.ribbonControl1;
        this.chkRememberMe.Name = "chkRememberMe";
        this.chkRememberMe.Properties.Caption = "مرا به خاطر بسپار";
        this.chkRememberMe.Size = new System.Drawing.Size(354, 20);
        this.chkRememberMe.StyleController = this.layoutControl1;
        this.chkRememberMe.TabIndex = 7;
        //
        // btnLogin
        //
        this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnLogin.Appearance.Options.UseFont = true;
        this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage"))); // Login icon
        this.btnLogin.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
        this.btnLogin.Location = new System.Drawing.Point(72, 266);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(354, 22);
        this.btnLogin.StyleController = this.layoutControl1;
        this.btnLogin.TabIndex = 8;
        this.btnLogin.Text = "ورود";
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        //
        // hyperLinkEditForgotPassword
        //
        this.hyperLinkEditForgotPassword.EditValue = "فراموشی رمز عبور؟";
        this.hyperLinkEditForgotPassword.Location = new System.Drawing.Point(72, 292);
        this.hyperLinkEditForgotPassword.MenuManager = this.ribbonControl1;
        this.hyperLinkEditForgotPassword.Name = "hyperLinkEditForgotPassword";
        this.hyperLinkEditForgotPassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
        this.hyperLinkEditForgotPassword.Properties.Appearance.Options.UseBackColor = true;
        this.hyperLinkEditForgotPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        this.hyperLinkEditForgotPassword.Size = new System.Drawing.Size(354, 20);
        this.hyperLinkEditForgotPassword.StyleController = this.layoutControl1;
        this.hyperLinkEditForgotPassword.TabIndex = 9;
        this.hyperLinkEditForgotPassword.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEditForgotPassword_OpenLink);
        //
        // Root
        //
        this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        this.Root.GroupBordersVisible = false;
        this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
        this.emptySpaceItemTop,
        this.emptySpaceItemBottom,
        this.emptySpaceItemLeft,
        this.emptySpaceItemRight,
        this.layoutControlItemImage,
        this.layoutControlItemUsername,
        this.layoutControlItemPassword,
        this.layoutControlItemRememberMe,
        this.layoutControlItemLoginButton,
        this.layoutControlItemForgotPassword,
        this.layoutControlItemTitle});
        this.Root.Name = "Root";
        this.Root.Size = new System.Drawing.Size(498, 378);
        this.Root.TextVisible = false;
        //
        // layoutControlItemImage
        //
        this.layoutControlItemImage.Control = this.pictureEditLogo;
        this.layoutControlItemImage.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
        this.layoutControlItemImage.Location = new System.Drawing.Point(160, 40);
        this.layoutControlItemImage.MinSize = new System.Drawing.Size(100, 100); // Min size for logo
        this.layoutControlItemImage.MaxSize = new System.Drawing.Size(180, 120); // Max size for logo
        this.layoutControlItemImage.Name = "layoutControlItemImage";
        this.layoutControlItemImage.Size = new System.Drawing.Size(158, 104);
        this.layoutControlItemImage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        this.layoutControlItemImage.TextSize = new System.Drawing.Size(0, 0);
        this.layoutControlItemImage.TextVisible = false;
        //
        // emptySpaceItemTop
        //
        this.emptySpaceItemTop.AllowHotTrack = false;
        this.emptySpaceItemTop.Location = new System.Drawing.Point(60, 26); // Space above logo
        this.emptySpaceItemTop.Name = "emptySpaceItemTop";
        this.emptySpaceItemTop.Size = new System.Drawing.Size(358, 14);
        this.emptySpaceItemTop.TextSize = new System.Drawing.Size(0, 0);
        //
        // layoutControlItemUsername
        //
        this.layoutControlItemUsername.Control = this.txtUsername;
        this.layoutControlItemUsername.Location = new System.Drawing.Point(60, 178);
        this.layoutControlItemUsername.Name = "layoutControlItemUsername";
        this.layoutControlItemUsername.Size = new System.Drawing.Size(358, 26);
        this.layoutControlItemUsername.Text = "نام کاربری:";
        this.layoutControlItemUsername.TextSize = new System.Drawing.Size(57, 13);
        //
        // layoutControlItemPassword
        //
        this.layoutControlItemPassword.Control = this.txtPassword;
        this.layoutControlItemPassword.Location = new System.Drawing.Point(60, 204);
        this.layoutControlItemPassword.Name = "layoutControlItemPassword";
        this.layoutControlItemPassword.Size = new System.Drawing.Size(358, 26);
        this.layoutControlItemPassword.Text = "رمز عبور:";
        this.layoutControlItemPassword.TextSize = new System.Drawing.Size(57, 13);
        //
        // layoutControlItemRememberMe
        //
        this.layoutControlItemRememberMe.Control = this.chkRememberMe;
        this.layoutControlItemRememberMe.Location = new System.Drawing.Point(60, 230);
        this.layoutControlItemRememberMe.Name = "layoutControlItemRememberMe";
        this.layoutControlItemRememberMe.Size = new System.Drawing.Size(358, 24);
        this.layoutControlItemRememberMe.TextSize = new System.Drawing.Size(0, 0);
        this.layoutControlItemRememberMe.TextVisible = false;
        //
        // layoutControlItemLoginButton
        //
        this.layoutControlItemLoginButton.Control = this.btnLogin;
        this.layoutControlItemLoginButton.Location = new System.Drawing.Point(60, 254);
        this.layoutControlItemLoginButton.Name = "layoutControlItemLoginButton";
        this.layoutControlItemLoginButton.Size = new System.Drawing.Size(358, 26);
        this.layoutControlItemLoginButton.TextSize = new System.Drawing.Size(0, 0);
        this.layoutControlItemLoginButton.TextVisible = false;
        //
        // emptySpaceItemBottom
        //
        this.emptySpaceItemBottom.AllowHotTrack = false;
        this.emptySpaceItemBottom.Location = new System.Drawing.Point(60, 304); // Space below forgot password
        this.emptySpaceItemBottom.Name = "emptySpaceItemBottom";
        this.emptySpaceItemBottom.Size = new System.Drawing.Size(358, 54);
        this.emptySpaceItemBottom.TextSize = new System.Drawing.Size(0, 0);
        //
        // layoutControlItemForgotPassword
        //
        this.layoutControlItemForgotPassword.Control = this.hyperLinkEditForgotPassword;
        this.layoutControlItemForgotPassword.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
        this.layoutControlItemForgotPassword.Location = new System.Drawing.Point(60, 280);
        this.layoutControlItemForgotPassword.Name = "layoutControlItemForgotPassword";
        this.layoutControlItemForgotPassword.Size = new System.Drawing.Size(358, 24);
        this.layoutControlItemForgotPassword.TextSize = new System.Drawing.Size(0, 0);
        this.layoutControlItemForgotPassword.TextVisible = false;
        //
        // emptySpaceItemLeft
        //
        this.emptySpaceItemLeft.AllowHotTrack = false;
        this.emptySpaceItemLeft.Location = new System.Drawing.Point(0, 0);
        this.emptySpaceItemLeft.MaxSize = new System.Drawing.Size(60, 0); // Max width for left margin
        this.emptySpaceItemLeft.MinSize = new System.Drawing.Size(60, 24); // Min width for left margin
        this.emptySpaceItemLeft.Name = "emptySpaceItemLeft";
        this.emptySpaceItemLeft.Size = new System.Drawing.Size(60, 358);
        this.emptySpaceItemLeft.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        this.emptySpaceItemLeft.TextSize = new System.Drawing.Size(0, 0);
        //
        // emptySpaceItemRight
        //
        this.emptySpaceItemRight.AllowHotTrack = false;
        this.emptySpaceItemRight.Location = new System.Drawing.Point(418, 0);
        this.emptySpaceItemRight.MaxSize = new System.Drawing.Size(60, 0); // Max width for right margin
        this.emptySpaceItemRight.MinSize = new System.Drawing.Size(60, 24); // Min width for right margin
        this.emptySpaceItemRight.Name = "emptySpaceItemRight";
        this.emptySpaceItemRight.Size = new System.Drawing.Size(60, 358);
        this.emptySpaceItemRight.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        this.emptySpaceItemRight.TextSize = new System.Drawing.Size(0, 0);
        //
        // lblTitle
        //
        this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTitle.Appearance.Options.UseFont = true;
        this.lblTitle.Appearance.Options.UseTextOptions = true;
        this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
        this.lblTitle.Location = new System.Drawing.Point(72, 12);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(354, 25);
        this.lblTitle.StyleController = this.layoutControl1;
        this.lblTitle.TabIndex = 10;
        this.lblTitle.Text = "ورود به سامانه";
        //
        // layoutControlItemTitle
        //
        this.layoutControlItemTitle.Control = this.lblTitle;
        this.layoutControlItemTitle.Location = new System.Drawing.Point(60, 0);
        this.layoutControlItemTitle.MinSize = new System.Drawing.Size(67, 17);
        this.layoutControlItemTitle.Name = "layoutControlItemTitle";
        this.layoutControlItemTitle.Size = new System.Drawing.Size(358, 29);
        this.layoutControlItemTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        this.layoutControlItemTitle.TextSize = new System.Drawing.Size(0, 0);
        this.layoutControlItemTitle.TextVisible = false;
        this.layoutControlItemTitle.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // defaultLookAndFeel1
        //
        this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
        //
        // MainForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(498, 438);
        this.Controls.Add(this.layoutControl1);
        this.Controls.Add(this.ribbonControl1);
        this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainForm.IconOptions.SvgImage"))); // App Icon
        this.Name = "MainForm";
        this.Ribbon = this.ribbonControl1;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "فرم ورود";
        ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
        this.layoutControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.pictureEditLogo.Properties)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe.Properties)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditForgotPassword.Properties)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImage)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemTop)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemUsername)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPassword)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRememberMe)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLoginButton)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemBottom)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForgotPassword)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemLeft)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemRight)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTitle)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraEditors.PictureEdit pictureEditLogo;
    private DevExpress.XtraEditors.TextEdit txtUsername;
    private DevExpress.XtraEditors.TextEdit txtPassword;
    private DevExpress.XtraEditors.CheckEdit chkRememberMe;
    private DevExpress.XtraEditors.SimpleButton btnLogin;
    private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEditForgotPassword;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImage;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemTop;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItemUsername;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPassword;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRememberMe;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLoginButton;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemBottom;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItemForgotPassword;
    private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemLeft;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemRight;
    private DevExpress.XtraEditors.LabelControl lblTitle;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTitle;
}
