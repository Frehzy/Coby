namespace Coby.Forms.Face
{
    partial class FaceDetectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceDetectionForm));
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            this.ExitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CameraBox
            // 
            this.CameraBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraBox.Location = new System.Drawing.Point(3, 45);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(607, 426);
            this.CameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CameraBox.TabIndex = 3;
            this.CameraBox.TabStop = false;
            // 
            // ExitPanel
            // 
            this.ExitPanel.Controls.Add(this.ExitButton);
            this.ExitPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitPanel.Location = new System.Drawing.Point(3, 0);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(607, 45);
            this.ExitPanel.TabIndex = 7;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExitButton.Depth = 0;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(543, 0);
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
            // FaceDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 474);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.ExitPanel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaceDetectionForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add waiter face";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaceDetectionForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            this.ExitPanel.ResumeLayout(false);
            this.ExitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CameraBox;
        private System.Windows.Forms.Panel ExitPanel;
        private MaterialSkin.Controls.MaterialButton ExitButton;
    }
}