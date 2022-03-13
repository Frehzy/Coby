namespace Office.Forms.MessageForm.Face
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
            this.AddFaceButton = new MaterialSkin.Controls.MaterialButton();
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFaceButton
            // 
            this.AddFaceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddFaceButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddFaceButton.Depth = 0;
            this.AddFaceButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddFaceButton.HighEmphasis = true;
            this.AddFaceButton.Icon = null;
            this.AddFaceButton.Location = new System.Drawing.Point(0, 0);
            this.AddFaceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddFaceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddFaceButton.Name = "AddFaceButton";
            this.AddFaceButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddFaceButton.Size = new System.Drawing.Size(90, 36);
            this.AddFaceButton.TabIndex = 2;
            this.AddFaceButton.Text = "Add face";
            this.AddFaceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddFaceButton.UseAccentColor = false;
            this.AddFaceButton.UseVisualStyleBackColor = true;
            this.AddFaceButton.Click += new System.EventHandler(this.AddFaceButton_Click);
            // 
            // CameraBox
            // 
            this.CameraBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraBox.Location = new System.Drawing.Point(3, 24);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(607, 411);
            this.CameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CameraBox.TabIndex = 3;
            this.CameraBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.AddFaceButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 36);
            this.panel1.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(543, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveButton.Size = new System.Drawing.Size(64, 36);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveButton.UseAccentColor = false;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FaceDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 474);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaceDetectionForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add waiter face";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaceDetectionForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton AddFaceButton;
        private System.Windows.Forms.PictureBox CameraBox;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton SaveButton;
    }
}