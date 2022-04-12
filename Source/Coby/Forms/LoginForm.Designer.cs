namespace Coby.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FaceDetectSettingsButton = new MaterialSkin.Controls.MaterialButton();
            this.LoginByFaceButton = new MaterialSkin.Controls.MaterialButton();
            this.MainImagePictureBox = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginByPinButton = new MaterialSkin.Controls.MaterialButton();
            this.ExitPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitPanel
            // 
            this.ExitPanel.Controls.Add(this.ExitButton);
            this.ExitPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitPanel.Location = new System.Drawing.Point(3, 0);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(513, 45);
            this.ExitPanel.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExitButton.Depth = 0;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(449, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExitButton.Size = new System.Drawing.Size(64, 45);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.panel2, 0, 3);
            this.MainPanel.Controls.Add(this.MainImagePictureBox, 0, 0);
            this.MainPanel.Controls.Add(this.PasswordTextBox, 0, 1);
            this.MainPanel.Controls.Add(this.panel1, 0, 2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 5;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainPanel.Size = new System.Drawing.Size(513, 185);
            this.MainPanel.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FaceDetectSettingsButton);
            this.panel2.Controls.Add(this.LoginByFaceButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 44);
            this.panel2.TabIndex = 10;
            // 
            // FaceDetectSettingsButton
            // 
            this.FaceDetectSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FaceDetectSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FaceDetectSettingsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.FaceDetectSettingsButton.Depth = 0;
            this.FaceDetectSettingsButton.HighEmphasis = true;
            this.FaceDetectSettingsButton.Icon = global::Coby.Properties.Resources.settings;
            this.FaceDetectSettingsButton.Location = new System.Drawing.Point(324, 3);
            this.FaceDetectSettingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FaceDetectSettingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FaceDetectSettingsButton.Name = "FaceDetectSettingsButton";
            this.FaceDetectSettingsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.FaceDetectSettingsButton.Size = new System.Drawing.Size(118, 36);
            this.FaceDetectSettingsButton.TabIndex = 2;
            this.FaceDetectSettingsButton.Text = "Settings";
            this.FaceDetectSettingsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.FaceDetectSettingsButton.UseAccentColor = false;
            this.FaceDetectSettingsButton.UseVisualStyleBackColor = true;
            this.FaceDetectSettingsButton.Click += new System.EventHandler(this.FaceDetectSettingsButton_Click);
            // 
            // LoginByFaceButton
            // 
            this.LoginByFaceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginByFaceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginByFaceButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginByFaceButton.Depth = 0;
            this.LoginByFaceButton.HighEmphasis = true;
            this.LoginByFaceButton.Icon = null;
            this.LoginByFaceButton.Location = new System.Drawing.Point(190, 2);
            this.LoginByFaceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginByFaceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginByFaceButton.Name = "LoginByFaceButton";
            this.LoginByFaceButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginByFaceButton.Size = new System.Drawing.Size(126, 36);
            this.LoginByFaceButton.TabIndex = 1;
            this.LoginByFaceButton.Text = "Login by face";
            this.LoginByFaceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginByFaceButton.UseAccentColor = false;
            this.LoginByFaceButton.UseVisualStyleBackColor = true;
            this.LoginByFaceButton.Click += new System.EventHandler(this.LoginByFaceButton_Click);
            // 
            // MainImagePictureBox
            // 
            this.MainImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainImagePictureBox.Image")));
            this.MainImagePictureBox.InitialImage = null;
            this.MainImagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.MainImagePictureBox.Name = "MainImagePictureBox";
            this.MainImagePictureBox.Size = new System.Drawing.Size(507, 15);
            this.MainImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImagePictureBox.TabIndex = 8;
            this.MainImagePictureBox.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.AnimateReadOnly = false;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordTextBox.Hint = "Password";
            this.PasswordTextBox.LeadingIcon = null;
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 24);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(507, 50);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "";
            this.PasswordTextBox.TrailingIcon = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginByPinButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 44);
            this.panel1.TabIndex = 9;
            // 
            // LoginByPinButton
            // 
            this.LoginByPinButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginByPinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginByPinButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginByPinButton.Depth = 0;
            this.LoginByPinButton.HighEmphasis = true;
            this.LoginByPinButton.Icon = null;
            this.LoginByPinButton.Location = new System.Drawing.Point(196, 2);
            this.LoginByPinButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginByPinButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginByPinButton.Name = "LoginByPinButton";
            this.LoginByPinButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginByPinButton.Size = new System.Drawing.Size(114, 36);
            this.LoginByPinButton.TabIndex = 1;
            this.LoginByPinButton.Text = "Login by pin";
            this.LoginByPinButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginByPinButton.UseAccentColor = false;
            this.LoginByPinButton.UseVisualStyleBackColor = true;
            this.LoginByPinButton.Click += new System.EventHandler(this.LoginByPinButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 233);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ExitPanel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ExitPanel.ResumeLayout(false);
            this.ExitPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ExitPanel;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private System.Windows.Forms.PictureBox MainImagePictureBox;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextBox;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton LoginByPinButton;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton LoginByFaceButton;
        private MaterialSkin.Controls.MaterialButton FaceDetectSettingsButton;
    }
}