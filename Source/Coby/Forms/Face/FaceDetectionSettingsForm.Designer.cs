namespace Coby.Forms.Face
{
    partial class FaceDetectionSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceDetectionSettingsForm));
            this.SaveSettingsButton = new MaterialSkin.Controls.MaterialButton();
            this.ResolutionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResolutionsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MethodComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.MethodLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ResolutionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MaxFaceDetectValueSlider = new MaterialSkin.Controls.MaterialSlider();
            this.CamerasComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveSettingsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveSettingsButton.Depth = 0;
            this.SaveSettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveSettingsButton.HighEmphasis = true;
            this.SaveSettingsButton.Icon = null;
            this.SaveSettingsButton.Location = new System.Drawing.Point(3, 283);
            this.SaveSettingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveSettingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveSettingsButton.Size = new System.Drawing.Size(607, 36);
            this.SaveSettingsButton.TabIndex = 2;
            this.SaveSettingsButton.Text = "Save settings";
            this.SaveSettingsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveSettingsButton.UseAccentColor = false;
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResolutionToolTip
            // 
            this.ResolutionToolTip.AutoPopDelay = 5000;
            this.ResolutionToolTip.InitialDelay = 50;
            this.ResolutionToolTip.IsBalloon = true;
            this.ResolutionToolTip.ReshowDelay = 100;
            this.ResolutionToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // ResolutionsComboBox
            // 
            this.ResolutionsComboBox.AutoResize = false;
            this.ResolutionsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResolutionsComboBox.Depth = 0;
            this.ResolutionsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ResolutionsComboBox.DropDownHeight = 174;
            this.ResolutionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionsComboBox.DropDownWidth = 121;
            this.ResolutionsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ResolutionsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResolutionsComboBox.FormattingEnabled = true;
            this.ResolutionsComboBox.IntegralHeight = false;
            this.ResolutionsComboBox.ItemHeight = 43;
            this.ResolutionsComboBox.Location = new System.Drawing.Point(120, 105);
            this.ResolutionsComboBox.MaxDropDownItems = 4;
            this.ResolutionsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ResolutionsComboBox.Name = "ResolutionsComboBox";
            this.ResolutionsComboBox.Size = new System.Drawing.Size(478, 49);
            this.ResolutionsComboBox.StartIndex = 0;
            this.ResolutionsComboBox.TabIndex = 2;
            this.ResolutionToolTip.SetToolTip(this.ResolutionsComboBox, "Высокое разрешение может негативно сказаться на производительности");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MethodComboBox);
            this.panel1.Controls.Add(this.MethodLabel);
            this.panel1.Controls.Add(this.ResolutionLabel);
            this.panel1.Controls.Add(this.ResolutionsComboBox);
            this.panel1.Controls.Add(this.MaxFaceDetectValueSlider);
            this.panel1.Controls.Add(this.CamerasComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 219);
            this.panel1.TabIndex = 20;
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.AutoResize = false;
            this.MethodComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MethodComboBox.Depth = 0;
            this.MethodComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MethodComboBox.DropDownHeight = 174;
            this.MethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodComboBox.DropDownWidth = 121;
            this.MethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MethodComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.IntegralHeight = false;
            this.MethodComboBox.ItemHeight = 43;
            this.MethodComboBox.Location = new System.Drawing.Point(120, 163);
            this.MethodComboBox.MaxDropDownItems = 4;
            this.MethodComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(478, 49);
            this.MethodComboBox.StartIndex = 0;
            this.MethodComboBox.TabIndex = 6;
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Depth = 0;
            this.MethodLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MethodLabel.Location = new System.Drawing.Point(3, 167);
            this.MethodLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(55, 19);
            this.MethodLabel.TabIndex = 5;
            this.MethodLabel.Text = "Method";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Depth = 0;
            this.ResolutionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ResolutionLabel.Location = new System.Drawing.Point(0, 107);
            this.ResolutionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(114, 19);
            this.ResolutionLabel.TabIndex = 4;
            this.ResolutionLabel.Text = "Resolution (X,Y)";
            // 
            // MaxFaceDetectValueSlider
            // 
            this.MaxFaceDetectValueSlider.Depth = 0;
            this.MaxFaceDetectValueSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaxFaceDetectValueSlider.Location = new System.Drawing.Point(3, 58);
            this.MaxFaceDetectValueSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaxFaceDetectValueSlider.Name = "MaxFaceDetectValueSlider";
            this.MaxFaceDetectValueSlider.RangeMin = 1;
            this.MaxFaceDetectValueSlider.Size = new System.Drawing.Size(595, 40);
            this.MaxFaceDetectValueSlider.TabIndex = 1;
            this.MaxFaceDetectValueSlider.Text = "Face detection percentage";
            this.MaxFaceDetectValueSlider.Value = 1;
            this.MaxFaceDetectValueSlider.ValueMax = 100;
            this.MaxFaceDetectValueSlider.ValueSuffix = "%";
            // 
            // CamerasComboBox
            // 
            this.CamerasComboBox.AutoResize = false;
            this.CamerasComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CamerasComboBox.Depth = 0;
            this.CamerasComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CamerasComboBox.DropDownHeight = 174;
            this.CamerasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamerasComboBox.DropDownWidth = 121;
            this.CamerasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CamerasComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CamerasComboBox.FormattingEnabled = true;
            this.CamerasComboBox.IntegralHeight = false;
            this.CamerasComboBox.ItemHeight = 43;
            this.CamerasComboBox.Location = new System.Drawing.Point(3, 3);
            this.CamerasComboBox.MaxDropDownItems = 4;
            this.CamerasComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CamerasComboBox.Name = "CamerasComboBox";
            this.CamerasComboBox.Size = new System.Drawing.Size(595, 49);
            this.CamerasComboBox.StartIndex = 0;
            this.CamerasComboBox.TabIndex = 0;
            // 
            // FaceDetectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveSettingsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaceDetectionSettingsForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton SaveSettingsButton;
        private System.Windows.Forms.ToolTip ResolutionToolTip;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox MethodComboBox;
        private MaterialSkin.Controls.MaterialLabel MethodLabel;
        private MaterialSkin.Controls.MaterialLabel ResolutionLabel;
        private MaterialSkin.Controls.MaterialComboBox ResolutionsComboBox;
        private MaterialSkin.Controls.MaterialSlider MaxFaceDetectValueSlider;
        private MaterialSkin.Controls.MaterialComboBox CamerasComboBox;
    }
}