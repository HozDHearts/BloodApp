
namespace BloodApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlToolBarLogin = new System.Windows.Forms.Panel();
            this.lblAppName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExitApp2 = new System.Windows.Forms.PictureBox();
            this.btnExitApp = new System.Windows.Forms.PictureBox();
            this.pnlContentLogin = new System.Windows.Forms.Panel();
            this.chkViewHide = new System.Windows.Forms.CheckBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnGoRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPasswordLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserNameLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.erpUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.DragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlToolBarLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApp)).BeginInit();
            this.pnlContentLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolBarLogin
            // 
            this.pnlToolBarLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlToolBarLogin.Controls.Add(this.lblAppName);
            this.pnlToolBarLogin.Controls.Add(this.btnExitApp2);
            this.pnlToolBarLogin.Controls.Add(this.btnExitApp);
            this.pnlToolBarLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBarLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBarLogin.Name = "pnlToolBarLogin";
            this.pnlToolBarLogin.Size = new System.Drawing.Size(800, 39);
            this.pnlToolBarLogin.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(12, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(111, 20);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Blood Bank";
            // 
            // btnExitApp2
            // 
            this.btnExitApp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApp2.Image = global::BloodApp.Properties.Resources.ギャー_汎用アイコン;
            this.btnExitApp2.Location = new System.Drawing.Point(702, 3);
            this.btnExitApp2.Name = "btnExitApp2";
            this.btnExitApp2.Size = new System.Drawing.Size(30, 30);
            this.btnExitApp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExitApp2.TabIndex = 1;
            this.btnExitApp2.TabStop = false;
            this.btnExitApp2.Click += new System.EventHandler(this.btnExitApp2_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApp.Image = global::BloodApp.Properties.Resources.ネプギア_ごみばこ_いっぱい__128;
            this.btnExitApp.Location = new System.Drawing.Point(758, 3);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(30, 30);
            this.btnExitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExitApp.TabIndex = 0;
            this.btnExitApp.TabStop = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // pnlContentLogin
            // 
            this.pnlContentLogin.Controls.Add(this.chkViewHide);
            this.pnlContentLogin.Controls.Add(this.lblAlert);
            this.pnlContentLogin.Controls.Add(this.btnGoRegister);
            this.pnlContentLogin.Controls.Add(this.btnLogin);
            this.pnlContentLogin.Controls.Add(this.txtPasswordLogin);
            this.pnlContentLogin.Controls.Add(this.txtUserNameLogin);
            this.pnlContentLogin.Controls.Add(this.lblLogin);
            this.pnlContentLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentLogin.Location = new System.Drawing.Point(0, 39);
            this.pnlContentLogin.Name = "pnlContentLogin";
            this.pnlContentLogin.Size = new System.Drawing.Size(800, 411);
            this.pnlContentLogin.TabIndex = 1;
            // 
            // chkViewHide
            // 
            this.chkViewHide.AutoSize = true;
            this.chkViewHide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkViewHide.Location = new System.Drawing.Point(620, 253);
            this.chkViewHide.Name = "chkViewHide";
            this.chkViewHide.Size = new System.Drawing.Size(48, 17);
            this.chkViewHide.TabIndex = 19;
            this.chkViewHide.Text = "Hide";
            this.chkViewHide.UseVisualStyleBackColor = true;
            this.chkViewHide.CheckedChanged += new System.EventHandler(this.chkViewHide_CheckedChanged);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.White;
            this.lblAlert.Location = new System.Drawing.Point(365, 335);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(37, 28);
            this.lblAlert.TabIndex = 18;
            this.lblAlert.Text = "Or";
            // 
            // btnGoRegister
            // 
            this.btnGoRegister.ActiveBorderThickness = 1;
            this.btnGoRegister.ActiveCornerRadius = 20;
            this.btnGoRegister.ActiveFillColor = System.Drawing.Color.MidnightBlue;
            this.btnGoRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnGoRegister.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.btnGoRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnGoRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoRegister.BackgroundImage")));
            this.btnGoRegister.ButtonText = "Create Account";
            this.btnGoRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoRegister.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoRegister.ForeColor = System.Drawing.Color.Black;
            this.btnGoRegister.IdleBorderThickness = 1;
            this.btnGoRegister.IdleCornerRadius = 20;
            this.btnGoRegister.IdleFillColor = System.Drawing.Color.White;
            this.btnGoRegister.IdleForecolor = System.Drawing.Color.Black;
            this.btnGoRegister.IdleLineColor = System.Drawing.Color.Black;
            this.btnGoRegister.Location = new System.Drawing.Point(411, 326);
            this.btnGoRegister.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnGoRegister.Name = "btnGoRegister";
            this.btnGoRegister.Size = new System.Drawing.Size(217, 41);
            this.btnGoRegister.TabIndex = 7;
            this.btnGoRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoRegister.Click += new System.EventHandler(this.btnGoRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.Black;
            this.btnLogin.IdleLineColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(139, 326);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(217, 41);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.txtPasswordLogin.HintForeColor = System.Drawing.Color.White;
            this.txtPasswordLogin.HintText = "Write Your Password";
            this.txtPasswordLogin.isPassword = false;
            this.txtPasswordLogin.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtPasswordLogin.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtPasswordLogin.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtPasswordLogin.LineThickness = 4;
            this.txtPasswordLogin.Location = new System.Drawing.Point(150, 216);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(462, 54);
            this.txtPasswordLogin.TabIndex = 5;
            this.txtPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordLogin.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordLogin_Validating);
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameLogin.ForeColor = System.Drawing.Color.White;
            this.txtUserNameLogin.HintForeColor = System.Drawing.Color.White;
            this.txtUserNameLogin.HintText = "Write Your Username";
            this.txtUserNameLogin.isPassword = false;
            this.txtUserNameLogin.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtUserNameLogin.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtUserNameLogin.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtUserNameLogin.LineThickness = 4;
            this.txtUserNameLogin.Location = new System.Drawing.Point(150, 137);
            this.txtUserNameLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(462, 54);
            this.txtUserNameLogin.TabIndex = 4;
            this.txtUserNameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserNameLogin.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserNameLogin_Validating);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(275, 44);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(212, 34);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login Process";
            // 
            // erpUser
            // 
            this.erpUser.ContainerControl = this;
            this.erpUser.Icon = ((System.Drawing.Icon)(resources.GetObject("erpUser.Icon")));
            // 
            // DragControl2
            // 
            this.DragControl2.Fixed = true;
            this.DragControl2.Horizontal = true;
            this.DragControl2.TargetControl = this.pnlToolBarLogin;
            this.DragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContentLogin);
            this.Controls.Add(this.pnlToolBarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlToolBarLogin.ResumeLayout(false);
            this.pnlToolBarLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApp)).EndInit();
            this.pnlContentLogin.ResumeLayout(false);
            this.pnlContentLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolBarLogin;
        private System.Windows.Forms.Panel pnlContentLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserNameLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGoRegister;
        private System.Windows.Forms.Label lblAlert;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAppName;
        private System.Windows.Forms.PictureBox btnExitApp2;
        private System.Windows.Forms.PictureBox btnExitApp;
        private System.Windows.Forms.ErrorProvider erpUser;
        private Bunifu.Framework.UI.BunifuDragControl DragControl2;
        private System.Windows.Forms.CheckBox chkViewHide;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasswordLogin;
    }
}

