﻿
namespace BloodApp
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.pnlContenrRegister = new System.Windows.Forms.Panel();
            this.txtUserPosition = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnGoLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegisterUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtRepeatPasswordRegister = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserEmailRegister = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserPasswordRegister = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserNameRegister = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblRegister = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.erpUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkViewHide2 = new System.Windows.Forms.CheckBox();
            this.chkViewHide3 = new System.Windows.Forms.CheckBox();
            this.pnlContenrRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenrRegister
            // 
            this.pnlContenrRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlContenrRegister.Controls.Add(this.chkViewHide3);
            this.pnlContenrRegister.Controls.Add(this.chkViewHide2);
            this.pnlContenrRegister.Controls.Add(this.txtUserPosition);
            this.pnlContenrRegister.Controls.Add(this.lblAlert);
            this.pnlContenrRegister.Controls.Add(this.btnGoLogin);
            this.pnlContenrRegister.Controls.Add(this.btnRegisterUser);
            this.pnlContenrRegister.Controls.Add(this.txtRepeatPasswordRegister);
            this.pnlContenrRegister.Controls.Add(this.txtUserEmailRegister);
            this.pnlContenrRegister.Controls.Add(this.txtUserPasswordRegister);
            this.pnlContenrRegister.Controls.Add(this.txtUserNameRegister);
            this.pnlContenrRegister.Controls.Add(this.lblRegister);
            this.pnlContenrRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenrRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlContenrRegister.Name = "pnlContenrRegister";
            this.pnlContenrRegister.Size = new System.Drawing.Size(689, 488);
            this.pnlContenrRegister.TabIndex = 0;
            // 
            // txtUserPosition
            // 
            this.txtUserPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPosition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPosition.ForeColor = System.Drawing.Color.White;
            this.txtUserPosition.HintForeColor = System.Drawing.Color.White;
            this.txtUserPosition.HintText = "Write the user Position";
            this.txtUserPosition.isPassword = false;
            this.txtUserPosition.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtUserPosition.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtUserPosition.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtUserPosition.LineThickness = 4;
            this.txtUserPosition.Location = new System.Drawing.Point(101, 318);
            this.txtUserPosition.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserPosition.Name = "txtUserPosition";
            this.txtUserPosition.Size = new System.Drawing.Size(462, 54);
            this.txtUserPosition.TabIndex = 18;
            this.txtUserPosition.Text = "Write the user Position.";
            this.txtUserPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserPosition.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserPosition_Validating);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.White;
            this.lblAlert.Location = new System.Drawing.Point(355, 400);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(279, 20);
            this.lblAlert.TabIndex = 17;
            this.lblAlert.Text = "Already have an account? Login here.";
            // 
            // btnGoLogin
            // 
            this.btnGoLogin.ActiveBorderThickness = 1;
            this.btnGoLogin.ActiveCornerRadius = 20;
            this.btnGoLogin.ActiveFillColor = System.Drawing.Color.MidnightBlue;
            this.btnGoLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnGoLogin.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.btnGoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGoLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoLogin.BackgroundImage")));
            this.btnGoLogin.ButtonText = "Loging";
            this.btnGoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoLogin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLogin.ForeColor = System.Drawing.Color.Black;
            this.btnGoLogin.IdleBorderThickness = 1;
            this.btnGoLogin.IdleCornerRadius = 20;
            this.btnGoLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnGoLogin.IdleForecolor = System.Drawing.Color.Black;
            this.btnGoLogin.IdleLineColor = System.Drawing.Color.Black;
            this.btnGoLogin.Location = new System.Drawing.Point(359, 425);
            this.btnGoLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnGoLogin.Name = "btnGoLogin";
            this.btnGoLogin.Size = new System.Drawing.Size(217, 41);
            this.btnGoLogin.TabIndex = 16;
            this.btnGoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoLogin.Click += new System.EventHandler(this.btnGoLogin_Click);
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.ActiveBorderThickness = 1;
            this.btnRegisterUser.ActiveCornerRadius = 20;
            this.btnRegisterUser.ActiveFillColor = System.Drawing.Color.MidnightBlue;
            this.btnRegisterUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegisterUser.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.btnRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRegisterUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegisterUser.BackgroundImage")));
            this.btnRegisterUser.ButtonText = "Register Account";
            this.btnRegisterUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterUser.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterUser.IdleBorderThickness = 1;
            this.btnRegisterUser.IdleCornerRadius = 20;
            this.btnRegisterUser.IdleFillColor = System.Drawing.Color.White;
            this.btnRegisterUser.IdleForecolor = System.Drawing.Color.Black;
            this.btnRegisterUser.IdleLineColor = System.Drawing.Color.Black;
            this.btnRegisterUser.Location = new System.Drawing.Point(83, 400);
            this.btnRegisterUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(217, 41);
            this.btnRegisterUser.TabIndex = 15;
            this.btnRegisterUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // txtRepeatPasswordRegister
            // 
            this.txtRepeatPasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepeatPasswordRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatPasswordRegister.ForeColor = System.Drawing.Color.White;
            this.txtRepeatPasswordRegister.HintForeColor = System.Drawing.Color.White;
            this.txtRepeatPasswordRegister.HintText = "Rewrite your Password";
            this.txtRepeatPasswordRegister.isPassword = false;
            this.txtRepeatPasswordRegister.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtRepeatPasswordRegister.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtRepeatPasswordRegister.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtRepeatPasswordRegister.LineThickness = 4;
            this.txtRepeatPasswordRegister.Location = new System.Drawing.Point(101, 190);
            this.txtRepeatPasswordRegister.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRepeatPasswordRegister.Name = "txtRepeatPasswordRegister";
            this.txtRepeatPasswordRegister.Size = new System.Drawing.Size(462, 54);
            this.txtRepeatPasswordRegister.TabIndex = 14;
            this.txtRepeatPasswordRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepeatPasswordRegister.Validating += new System.ComponentModel.CancelEventHandler(this.txtRepeatPasswordRegister_Validating);
            // 
            // txtUserEmailRegister
            // 
            this.txtUserEmailRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserEmailRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmailRegister.ForeColor = System.Drawing.Color.White;
            this.txtUserEmailRegister.HintForeColor = System.Drawing.Color.White;
            this.txtUserEmailRegister.HintText = "Write your Email";
            this.txtUserEmailRegister.isPassword = false;
            this.txtUserEmailRegister.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtUserEmailRegister.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtUserEmailRegister.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtUserEmailRegister.LineThickness = 4;
            this.txtUserEmailRegister.Location = new System.Drawing.Point(101, 254);
            this.txtUserEmailRegister.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserEmailRegister.Name = "txtUserEmailRegister";
            this.txtUserEmailRegister.Size = new System.Drawing.Size(462, 54);
            this.txtUserEmailRegister.TabIndex = 13;
            this.txtUserEmailRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserEmailRegister.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserEmailRegister_Validating);
            // 
            // txtUserPasswordRegister
            // 
            this.txtUserPasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPasswordRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPasswordRegister.ForeColor = System.Drawing.Color.White;
            this.txtUserPasswordRegister.HintForeColor = System.Drawing.Color.White;
            this.txtUserPasswordRegister.HintText = "Write a Password";
            this.txtUserPasswordRegister.isPassword = false;
            this.txtUserPasswordRegister.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtUserPasswordRegister.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtUserPasswordRegister.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtUserPasswordRegister.LineThickness = 4;
            this.txtUserPasswordRegister.Location = new System.Drawing.Point(101, 126);
            this.txtUserPasswordRegister.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserPasswordRegister.Name = "txtUserPasswordRegister";
            this.txtUserPasswordRegister.Size = new System.Drawing.Size(462, 54);
            this.txtUserPasswordRegister.TabIndex = 12;
            this.txtUserPasswordRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserPasswordRegister.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserPasswordRegister_Validating);
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameRegister.ForeColor = System.Drawing.Color.White;
            this.txtUserNameRegister.HintForeColor = System.Drawing.Color.White;
            this.txtUserNameRegister.HintText = "Write Your New Username";
            this.txtUserNameRegister.isPassword = false;
            this.txtUserNameRegister.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtUserNameRegister.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtUserNameRegister.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtUserNameRegister.LineThickness = 4;
            this.txtUserNameRegister.Location = new System.Drawing.Point(101, 62);
            this.txtUserNameRegister.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Size = new System.Drawing.Size(462, 54);
            this.txtUserNameRegister.TabIndex = 11;
            this.txtUserNameRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserNameRegister.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserNameRegister_Validating);
            // 
            // lblRegister
            // 
            this.lblRegister.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(208, 23);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(212, 34);
            this.lblRegister.TabIndex = 10;
            this.lblRegister.Text = "Register User";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erpUser
            // 
            this.erpUser.ContainerControl = this;
            this.erpUser.Icon = ((System.Drawing.Icon)(resources.GetObject("erpUser.Icon")));
            // 
            // chkViewHide2
            // 
            this.chkViewHide2.AutoSize = true;
            this.chkViewHide2.ForeColor = System.Drawing.SystemColors.Control;
            this.chkViewHide2.Location = new System.Drawing.Point(572, 162);
            this.chkViewHide2.Name = "chkViewHide2";
            this.chkViewHide2.Size = new System.Drawing.Size(48, 17);
            this.chkViewHide2.TabIndex = 19;
            this.chkViewHide2.Text = "Hide";
            this.chkViewHide2.UseVisualStyleBackColor = true;
            this.chkViewHide2.CheckedChanged += new System.EventHandler(this.chkViewHide2_CheckedChanged);
            // 
            // chkViewHide3
            // 
            this.chkViewHide3.AutoSize = true;
            this.chkViewHide3.ForeColor = System.Drawing.SystemColors.Control;
            this.chkViewHide3.Location = new System.Drawing.Point(571, 227);
            this.chkViewHide3.Name = "chkViewHide3";
            this.chkViewHide3.Size = new System.Drawing.Size(48, 17);
            this.chkViewHide3.TabIndex = 20;
            this.chkViewHide3.Text = "Hide";
            this.chkViewHide3.UseVisualStyleBackColor = true;
            this.chkViewHide3.CheckedChanged += new System.EventHandler(this.chkViewHide3_CheckedChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(689, 488);
            this.Controls.Add(this.pnlContenrRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.pnlContenrRegister.ResumeLayout(false);
            this.pnlContenrRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenrRegister;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegisterUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRepeatPasswordRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserEmailRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserPasswordRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserNameRegister;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRegister;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGoLogin;
        private System.Windows.Forms.Label lblAlert;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserPosition;
        private System.Windows.Forms.ErrorProvider erpUser;
        private System.Windows.Forms.CheckBox chkViewHide2;
        private System.Windows.Forms.CheckBox chkViewHide3;
    }
}