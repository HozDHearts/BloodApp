
namespace BloodApp
{
    partial class frmDashboard
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlControllerDashboard = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblAppName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExitDashboard2 = new System.Windows.Forms.PictureBox();
            this.btnExitDashboard = new System.Windows.Forms.PictureBox();
            this.pnlSidebarMenu = new System.Windows.Forms.Panel();
            this.pnlMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LineL = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnProfiles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPaciente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlContentDashboard = new System.Windows.Forms.Panel();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.MinimizeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MaximizeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.BorderlandsMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BorderlandsForms = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormsAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlControllerDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitDashboard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitDashboard)).BeginInit();
            this.pnlSidebarMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlContentDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControllerDashboard
            // 
            this.pnlControllerDashboard.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlControllerDashboard.Controls.Add(this.btnMenu);
            this.pnlControllerDashboard.Controls.Add(this.lblAppName);
            this.pnlControllerDashboard.Controls.Add(this.btnExitDashboard2);
            this.pnlControllerDashboard.Controls.Add(this.btnExitDashboard);
            this.MinimizeTransition.SetDecoration(this.pnlControllerDashboard, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.pnlControllerDashboard, BunifuAnimatorNS.DecorationType.None);
            this.FormsAnimation.SetDecoration(this.pnlControllerDashboard, BunifuAnimatorNS.DecorationType.None);
            this.pnlControllerDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControllerDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlControllerDashboard.Name = "pnlControllerDashboard";
            this.pnlControllerDashboard.Size = new System.Drawing.Size(984, 44);
            this.pnlControllerDashboard.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsAnimation.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::BloodApp.Properties.Resources.ちっちゃいーすん_マイコンピュータ;
            this.btnMenu.Location = new System.Drawing.Point(11, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 5;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.FormsAnimation.SetDecoration(this.lblAppName, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.lblAppName, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.lblAppName, BunifuAnimatorNS.DecorationType.None);
            this.lblAppName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(47, 12);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(111, 20);
            this.lblAppName.TabIndex = 4;
            this.lblAppName.Text = "Blood Bank";
            // 
            // btnExitDashboard2
            // 
            this.btnExitDashboard2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsAnimation.SetDecoration(this.btnExitDashboard2, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.btnExitDashboard2, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.btnExitDashboard2, BunifuAnimatorNS.DecorationType.None);
            this.btnExitDashboard2.Image = global::BloodApp.Properties.Resources.ギャー_汎用アイコン;
            this.btnExitDashboard2.Location = new System.Drawing.Point(886, 3);
            this.btnExitDashboard2.Name = "btnExitDashboard2";
            this.btnExitDashboard2.Size = new System.Drawing.Size(30, 30);
            this.btnExitDashboard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExitDashboard2.TabIndex = 3;
            this.btnExitDashboard2.TabStop = false;
            this.btnExitDashboard2.Click += new System.EventHandler(this.btnExitDashboard2_Click);
            // 
            // btnExitDashboard
            // 
            this.btnExitDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsAnimation.SetDecoration(this.btnExitDashboard, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.btnExitDashboard, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.btnExitDashboard, BunifuAnimatorNS.DecorationType.None);
            this.btnExitDashboard.Image = global::BloodApp.Properties.Resources.ネプギア_ごみばこ_いっぱい__128;
            this.btnExitDashboard.Location = new System.Drawing.Point(942, 3);
            this.btnExitDashboard.Name = "btnExitDashboard";
            this.btnExitDashboard.Size = new System.Drawing.Size(30, 30);
            this.btnExitDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExitDashboard.TabIndex = 2;
            this.btnExitDashboard.TabStop = false;
            this.btnExitDashboard.Click += new System.EventHandler(this.btnExitDashboard_Click);
            // 
            // pnlSidebarMenu
            // 
            this.pnlSidebarMenu.Controls.Add(this.pnlMenu);
            this.MinimizeTransition.SetDecoration(this.pnlSidebarMenu, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.pnlSidebarMenu, BunifuAnimatorNS.DecorationType.None);
            this.FormsAnimation.SetDecoration(this.pnlSidebarMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlSidebarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebarMenu.Location = new System.Drawing.Point(0, 44);
            this.pnlSidebarMenu.Name = "pnlSidebarMenu";
            this.pnlSidebarMenu.Size = new System.Drawing.Size(250, 517);
            this.pnlSidebarMenu.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.LineL);
            this.pnlMenu.Controls.Add(this.btnProfiles);
            this.pnlMenu.Controls.Add(this.btnEmployee);
            this.pnlMenu.Controls.Add(this.btnPaciente);
            this.pnlMenu.Controls.Add(this.btnStart);
            this.pnlMenu.Controls.Add(this.pictureBox3);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.MinimizeTransition.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.FormsAnimation.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.pnlMenu.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.pnlMenu.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.pnlMenu.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnlMenu.Location = new System.Drawing.Point(12, 17);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Quality = 10;
            this.pnlMenu.Size = new System.Drawing.Size(200, 488);
            this.pnlMenu.TabIndex = 1;
            // 
            // LineL
            // 
            this.LineL.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeTransition.SetDecoration(this.LineL, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.LineL, BunifuAnimatorNS.DecorationType.None);
            this.FormsAnimation.SetDecoration(this.LineL, BunifuAnimatorNS.DecorationType.None);
            this.LineL.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LineL.LineThickness = 1;
            this.LineL.Location = new System.Drawing.Point(3, 139);
            this.LineL.Name = "LineL";
            this.LineL.Size = new System.Drawing.Size(200, 1);
            this.LineL.TabIndex = 0;
            this.LineL.Transparency = 255;
            this.LineL.Vertical = false;
            // 
            // btnProfiles
            // 
            this.btnProfiles.Activecolor = System.Drawing.Color.Transparent;
            this.btnProfiles.BackColor = System.Drawing.Color.Transparent;
            this.btnProfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfiles.BorderRadius = 0;
            this.btnProfiles.ButtonText = "Management";
            this.btnProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsAnimation.SetDecoration(this.btnProfiles, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.btnProfiles, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.btnProfiles, BunifuAnimatorNS.DecorationType.None);
            this.btnProfiles.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfiles.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfiles.Iconimage = global::BloodApp.Properties.Resources.ブラン;
            this.btnProfiles.Iconimage_right = null;
            this.btnProfiles.Iconimage_right_Selected = null;
            this.btnProfiles.Iconimage_Selected = null;
            this.btnProfiles.IconMarginLeft = 0;
            this.btnProfiles.IconMarginRight = 0;
            this.btnProfiles.IconRightVisible = true;
            this.btnProfiles.IconRightZoom = 0D;
            this.btnProfiles.IconVisible = true;
            this.btnProfiles.IconZoom = 70D;
            this.btnProfiles.IsTab = false;
            this.btnProfiles.Location = new System.Drawing.Point(0, 341);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProfiles.OnHovercolor = System.Drawing.Color.DarkRed;
            this.btnProfiles.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnProfiles.selected = false;
            this.btnProfiles.Size = new System.Drawing.Size(194, 48);
            this.btnProfiles.TabIndex = 6;
            this.btnProfiles.Text = "Management";
            this.btnProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfiles.Textcolor = System.Drawing.Color.White;
            this.btnProfiles.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Activecolor = System.Drawing.Color.Transparent;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.BorderRadius = 0;
            this.btnEmployee.ButtonText = "Employees";
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsAnimation.SetDecoration(this.btnEmployee, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.btnEmployee, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.btnEmployee, BunifuAnimatorNS.DecorationType.None);
            this.btnEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployee.Iconimage = global::BloodApp.Properties.Resources.ブーケ;
            this.btnEmployee.Iconimage_right = null;
            this.btnEmployee.Iconimage_right_Selected = null;
            this.btnEmployee.Iconimage_Selected = null;
            this.btnEmployee.IconMarginLeft = 0;
            this.btnEmployee.IconMarginRight = 0;
            this.btnEmployee.IconRightVisible = true;
            this.btnEmployee.IconRightZoom = 0D;
            this.btnEmployee.IconVisible = true;
            this.btnEmployee.IconZoom = 70D;
            this.btnEmployee.IsTab = false;
            this.btnEmployee.Location = new System.Drawing.Point(0, 274);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmployee.OnHovercolor = System.Drawing.Color.DarkRed;
            this.btnEmployee.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnEmployee.selected = false;
            this.btnEmployee.Size = new System.Drawing.Size(194, 48);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Textcolor = System.Drawing.Color.White;
            this.btnEmployee.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Activecolor = System.Drawing.Color.Transparent;
            this.btnPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaciente.BorderRadius = 0;
            this.btnPaciente.ButtonText = "Patients";
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsAnimation.SetDecoration(this.btnPaciente, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.btnPaciente, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.btnPaciente, BunifuAnimatorNS.DecorationType.None);
            this.btnPaciente.DisabledColor = System.Drawing.Color.Gray;
            this.btnPaciente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPaciente.Iconimage = global::BloodApp.Properties.Resources.ベール;
            this.btnPaciente.Iconimage_right = null;
            this.btnPaciente.Iconimage_right_Selected = null;
            this.btnPaciente.Iconimage_Selected = null;
            this.btnPaciente.IconMarginLeft = 0;
            this.btnPaciente.IconMarginRight = 0;
            this.btnPaciente.IconRightVisible = true;
            this.btnPaciente.IconRightZoom = 0D;
            this.btnPaciente.IconVisible = true;
            this.btnPaciente.IconZoom = 70D;
            this.btnPaciente.IsTab = false;
            this.btnPaciente.Location = new System.Drawing.Point(0, 210);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPaciente.OnHovercolor = System.Drawing.Color.DarkRed;
            this.btnPaciente.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnPaciente.selected = false;
            this.btnPaciente.Size = new System.Drawing.Size(194, 48);
            this.btnPaciente.TabIndex = 4;
            this.btnPaciente.Text = "Patients";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Textcolor = System.Drawing.Color.White;
            this.btnPaciente.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStart
            // 
            this.btnStart.Activecolor = System.Drawing.Color.Transparent;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.BorderRadius = 0;
            this.btnStart.ButtonText = "Start";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsAnimation.SetDecoration(this.btnStart, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.btnStart, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.btnStart, BunifuAnimatorNS.DecorationType.None);
            this.btnStart.DisabledColor = System.Drawing.Color.Gray;
            this.btnStart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStart.Iconimage = global::BloodApp.Properties.Resources.User;
            this.btnStart.Iconimage_right = null;
            this.btnStart.Iconimage_right_Selected = null;
            this.btnStart.Iconimage_Selected = null;
            this.btnStart.IconMarginLeft = 0;
            this.btnStart.IconMarginRight = 0;
            this.btnStart.IconRightVisible = true;
            this.btnStart.IconRightZoom = 0D;
            this.btnStart.IconVisible = true;
            this.btnStart.IconZoom = 70D;
            this.btnStart.IsTab = false;
            this.btnStart.Location = new System.Drawing.Point(0, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStart.OnHovercolor = System.Drawing.Color.DarkRed;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnStart.selected = false;
            this.btnStart.Size = new System.Drawing.Size(194, 48);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Textcolor = System.Drawing.Color.White;
            this.btnStart.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox3
            // 
            this.FormsAnimation.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::BloodApp.Properties.Resources.blood;
            this.pictureBox3.Location = new System.Drawing.Point(3, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.FormsAnimation.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::BloodApp.Properties.Resources.Donate_blood_definitive_chiquito;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlContentDashboard
            // 
            this.pnlContentDashboard.Controls.Add(this.pnlForms);
            this.MinimizeTransition.SetDecoration(this.pnlContentDashboard, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.pnlContentDashboard, BunifuAnimatorNS.DecorationType.None);
            this.FormsAnimation.SetDecoration(this.pnlContentDashboard, BunifuAnimatorNS.DecorationType.None);
            this.pnlContentDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentDashboard.Location = new System.Drawing.Point(250, 44);
            this.pnlContentDashboard.Name = "pnlContentDashboard";
            this.pnlContentDashboard.Size = new System.Drawing.Size(734, 517);
            this.pnlContentDashboard.TabIndex = 3;
            // 
            // pnlForms
            // 
            this.pnlForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimizeTransition.SetDecoration(this.pnlForms, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this.pnlForms, BunifuAnimatorNS.DecorationType.None);
            this.FormsAnimation.SetDecoration(this.pnlForms, BunifuAnimatorNS.DecorationType.None);
            this.pnlForms.Location = new System.Drawing.Point(24, 17);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(689, 488);
            this.pnlForms.TabIndex = 0;
            // 
            // MinimizeTransition
            // 
            this.MinimizeTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.MinimizeTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.MinimizeTransition.DefaultAnimation = animation3;
            // 
            // MaximizeTransition
            // 
            this.MaximizeTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.MaximizeTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.MaximizeTransition.DefaultAnimation = animation2;
            // 
            // BorderlandsMenu
            // 
            this.BorderlandsMenu.ElipseRadius = 10;
            this.BorderlandsMenu.TargetControl = this.pnlMenu;
            // 
            // BorderlandsForms
            // 
            this.BorderlandsForms.ElipseRadius = 10;
            this.BorderlandsForms.TargetControl = this.pnlForms;
            // 
            // FormsAnimation
            // 
            this.FormsAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.FormsAnimation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.FormsAnimation.DefaultAnimation = animation1;
            this.FormsAnimation.Interval = 20;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.pnlControllerDashboard;
            this.DragControl.Vertical = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlContentDashboard);
            this.Controls.Add(this.pnlSidebarMenu);
            this.Controls.Add(this.pnlControllerDashboard);
            this.FormsAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.pnlControllerDashboard.ResumeLayout(false);
            this.pnlControllerDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitDashboard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitDashboard)).EndInit();
            this.pnlSidebarMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlContentDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControllerDashboard;
        private System.Windows.Forms.PictureBox btnExitDashboard2;
        private System.Windows.Forms.PictureBox btnExitDashboard;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAppName;
        private System.Windows.Forms.Panel pnlSidebarMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMenu;
        private System.Windows.Forms.Panel pnlContentDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnStart;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfiles;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnPaciente;
        private Bunifu.Framework.UI.BunifuSeparator LineL;
        private BunifuAnimatorNS.BunifuTransition MinimizeTransition;
        private BunifuAnimatorNS.BunifuTransition MaximizeTransition;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnMenu;
        private Bunifu.Framework.UI.BunifuElipse BorderlandsMenu;
        private System.Windows.Forms.Panel pnlForms;
        private Bunifu.Framework.UI.BunifuElipse BorderlandsForms;
        private BunifuAnimatorNS.BunifuTransition FormsAnimation;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}