namespace KennelDB
{
    partial class AddOwner
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbOwnerName = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnInsertOwner = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(51, 104);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Name:";
            // 
            // tbOwnerName
            // 
            this.tbOwnerName.AnimateReadOnly = false;
            this.tbOwnerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbOwnerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbOwnerName.Depth = 0;
            this.tbOwnerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbOwnerName.HideSelection = true;
            this.tbOwnerName.LeadingIcon = null;
            this.tbOwnerName.Location = new System.Drawing.Point(124, 90);
            this.tbOwnerName.MaxLength = 32767;
            this.tbOwnerName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbOwnerName.Name = "tbOwnerName";
            this.tbOwnerName.PasswordChar = '\0';
            this.tbOwnerName.PrefixSuffixText = null;
            this.tbOwnerName.ReadOnly = false;
            this.tbOwnerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOwnerName.SelectedText = "";
            this.tbOwnerName.SelectionLength = 0;
            this.tbOwnerName.SelectionStart = 0;
            this.tbOwnerName.ShortcutsEnabled = true;
            this.tbOwnerName.Size = new System.Drawing.Size(250, 48);
            this.tbOwnerName.TabIndex = 1;
            this.tbOwnerName.TabStop = false;
            this.tbOwnerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbOwnerName.TrailingIcon = null;
            this.tbOwnerName.UseSystemPasswordChar = false;
            // 
            // btnInsertOwner
            // 
            this.btnInsertOwner.AutoSize = false;
            this.btnInsertOwner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertOwner.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsertOwner.Depth = 0;
            this.btnInsertOwner.HighEmphasis = true;
            this.btnInsertOwner.Icon = null;
            this.btnInsertOwner.Location = new System.Drawing.Point(156, 147);
            this.btnInsertOwner.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsertOwner.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertOwner.Name = "btnInsertOwner";
            this.btnInsertOwner.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsertOwner.Size = new System.Drawing.Size(146, 36);
            this.btnInsertOwner.TabIndex = 2;
            this.btnInsertOwner.Text = "Add Owner";
            this.btnInsertOwner.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsertOwner.UseAccentColor = false;
            this.btnInsertOwner.UseVisualStyleBackColor = true;
            this.btnInsertOwner.Click += new System.EventHandler(this.btnInsertOwner_Click);
            // 
            // AddOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 215);
            this.Controls.Add(this.btnInsertOwner);
            this.Controls.Add(this.tbOwnerName);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "AddOwner";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Owner";
            this.Load += new System.EventHandler(this.AddOwner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 tbOwnerName;
        private MaterialSkin.Controls.MaterialButton btnInsertOwner;
    }
}