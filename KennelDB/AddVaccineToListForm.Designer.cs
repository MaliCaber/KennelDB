namespace KennelDB
{
    partial class AddVaccineToListForm
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
            this.btnInsertVaccine = new MaterialSkin.Controls.MaterialButton();
            this.tbNameOfVaccine = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDOV = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnInsertVaccine
            // 
            this.btnInsertVaccine.AutoSize = false;
            this.btnInsertVaccine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertVaccine.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsertVaccine.Depth = 0;
            this.btnInsertVaccine.HighEmphasis = true;
            this.btnInsertVaccine.Icon = null;
            this.btnInsertVaccine.Location = new System.Drawing.Point(141, 165);
            this.btnInsertVaccine.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsertVaccine.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertVaccine.Name = "btnInsertVaccine";
            this.btnInsertVaccine.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsertVaccine.Size = new System.Drawing.Size(146, 36);
            this.btnInsertVaccine.TabIndex = 5;
            this.btnInsertVaccine.Text = "Add Vaccine";
            this.btnInsertVaccine.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsertVaccine.UseAccentColor = false;
            this.btnInsertVaccine.UseVisualStyleBackColor = true;
            this.btnInsertVaccine.Click += new System.EventHandler(this.btnInsertVaccine_Click);
            // 
            // tbNameOfVaccine
            // 
            this.tbNameOfVaccine.AnimateReadOnly = false;
            this.tbNameOfVaccine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNameOfVaccine.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNameOfVaccine.Depth = 0;
            this.tbNameOfVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNameOfVaccine.HideSelection = true;
            this.tbNameOfVaccine.LeadingIcon = null;
            this.tbNameOfVaccine.Location = new System.Drawing.Point(119, 82);
            this.tbNameOfVaccine.MaxLength = 32767;
            this.tbNameOfVaccine.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNameOfVaccine.Name = "tbNameOfVaccine";
            this.tbNameOfVaccine.PasswordChar = '\0';
            this.tbNameOfVaccine.PrefixSuffixText = null;
            this.tbNameOfVaccine.ReadOnly = false;
            this.tbNameOfVaccine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNameOfVaccine.SelectedText = "";
            this.tbNameOfVaccine.SelectionLength = 0;
            this.tbNameOfVaccine.SelectionStart = 0;
            this.tbNameOfVaccine.ShortcutsEnabled = true;
            this.tbNameOfVaccine.Size = new System.Drawing.Size(250, 48);
            this.tbNameOfVaccine.TabIndex = 4;
            this.tbNameOfVaccine.TabStop = false;
            this.tbNameOfVaccine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNameOfVaccine.TrailingIcon = null;
            this.tbNameOfVaccine.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(46, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Name:";
            // 
            // dtpDOV
            // 
            this.dtpDOV.Location = new System.Drawing.Point(119, 136);
            this.dtpDOV.Name = "dtpDOV";
            this.dtpDOV.Size = new System.Drawing.Size(250, 20);
            this.dtpDOV.TabIndex = 6;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(46, 136);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(38, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Date:";
            // 
            // AddVaccineToListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 215);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dtpDOV);
            this.Controls.Add(this.btnInsertVaccine);
            this.Controls.Add(this.tbNameOfVaccine);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "AddVaccineToListForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vaccine";
            this.Load += new System.EventHandler(this.AddVaccineToListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnInsertVaccine;
        private MaterialSkin.Controls.MaterialTextBox2 tbNameOfVaccine;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpDOV;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}