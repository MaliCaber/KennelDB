namespace KennelDB
{
    partial class LoginPage
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
            this.tbUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.AnimateReadOnly = false;
            this.tbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUser.Depth = 0;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUser.HideSelection = true;
            this.tbUser.LeadingIcon = null;
            this.tbUser.Location = new System.Drawing.Point(63, 77);
            this.tbUser.MaxLength = 32767;
            this.tbUser.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUser.Name = "tbUser";
            this.tbUser.PasswordChar = '\0';
            this.tbUser.PrefixSuffixText = null;
            this.tbUser.ReadOnly = false;
            this.tbUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUser.SelectedText = "";
            this.tbUser.SelectionLength = 0;
            this.tbUser.SelectionStart = 0;
            this.tbUser.ShortcutsEnabled = true;
            this.tbUser.Size = new System.Drawing.Size(250, 48);
            this.tbUser.TabIndex = 0;
            this.tbUser.TabStop = false;
            this.tbUser.Text = "Username";
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUser.TrailingIcon = null;
            this.tbUser.UseSystemPasswordChar = false;
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // tbPass
            // 
            this.tbPass.AnimateReadOnly = false;
            this.tbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPass.Depth = 0;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPass.HideSelection = true;
            this.tbPass.LeadingIcon = null;
            this.tbPass.Location = new System.Drawing.Point(63, 131);
            this.tbPass.MaxLength = 32767;
            this.tbPass.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.PrefixSuffixText = null;
            this.tbPass.ReadOnly = false;
            this.tbPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPass.SelectedText = "";
            this.tbPass.SelectionLength = 0;
            this.tbPass.SelectionStart = 0;
            this.tbPass.ShortcutsEnabled = true;
            this.tbPass.Size = new System.Drawing.Size(250, 48);
            this.tbPass.TabIndex = 1;
            this.tbPass.TabStop = false;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPass.TrailingIcon = null;
            this.tbPass.UseSystemPasswordChar = false;
            this.tbPass.Enter += new System.EventHandler(this.tbPass_Enter);
            this.tbPass.Leave += new System.EventHandler(this.tbPass_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(134, 188);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(100, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 240);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbUser;
        private MaterialSkin.Controls.MaterialTextBox2 tbPass;
        private MaterialSkin.Controls.MaterialButton btnLogin;
    }
}

