namespace Office.Forms.MessageForm
{
    partial class AddWaiterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWaiterForm));
            this.UsernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.AdminCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.AnimateReadOnly = false;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Depth = 0;
            this.UsernameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameTextBox.Hint = "Username";
            this.UsernameTextBox.LeadingIcon = null;
            this.UsernameTextBox.Location = new System.Drawing.Point(6, 67);
            this.UsernameTextBox.MaxLength = 50;
            this.UsernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UsernameTextBox.Multiline = false;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(231, 50);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.Text = "";
            this.UsernameTextBox.TrailingIcon = null;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AnimateReadOnly = false;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordTextBox.Hint = "Password";
            this.PasswordTextBox.LeadingIcon = null;
            this.PasswordTextBox.Location = new System.Drawing.Point(6, 123);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(231, 50);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "";
            this.PasswordTextBox.TrailingIcon = null;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(3, 219);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveButton.Size = new System.Drawing.Size(237, 36);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveButton.UseAccentColor = false;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Depth = 0;
            this.AdminCheckBox.Location = new System.Drawing.Point(6, 176);
            this.AdminCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.AdminCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AdminCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.ReadOnly = false;
            this.AdminCheckBox.Ripple = true;
            this.AdminCheckBox.Size = new System.Drawing.Size(81, 37);
            this.AdminCheckBox.TabIndex = 6;
            this.AdminCheckBox.Text = "Admin";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddWaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 258);
            this.Controls.Add(this.AdminCheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWaiterForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add waiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox UsernameTextBox;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextBox;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialCheckbox AdminCheckBox;
    }
}