namespace Office.Forms.MessageForm.Face
{
    partial class AddWaiterFaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWaiterFaceForm));
            this.CreateWaiterFaceButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WaiterTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MethodComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.MethodLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ResolutionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ResolutionsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.MaxFaceDetectValueSlider = new MaterialSkin.Controls.MaterialSlider();
            this.CamerasComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ResolutionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateWaiterFaceButton
            // 
            this.CreateWaiterFaceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateWaiterFaceButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateWaiterFaceButton.Depth = 0;
            this.CreateWaiterFaceButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateWaiterFaceButton.HighEmphasis = true;
            this.CreateWaiterFaceButton.Icon = null;
            this.CreateWaiterFaceButton.Location = new System.Drawing.Point(3, 435);
            this.CreateWaiterFaceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateWaiterFaceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateWaiterFaceButton.Name = "CreateWaiterFaceButton";
            this.CreateWaiterFaceButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateWaiterFaceButton.Size = new System.Drawing.Size(607, 36);
            this.CreateWaiterFaceButton.TabIndex = 2;
            this.CreateWaiterFaceButton.Text = "Create waiter face";
            this.CreateWaiterFaceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateWaiterFaceButton.UseAccentColor = false;
            this.CreateWaiterFaceButton.UseVisualStyleBackColor = true;
            this.CreateWaiterFaceButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.WaiterTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 371);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // WaiterTextBox
            // 
            this.WaiterTextBox.AnimateReadOnly = true;
            this.WaiterTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WaiterTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.WaiterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WaiterTextBox.Depth = 0;
            this.WaiterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaiterTextBox.HideSelection = true;
            this.WaiterTextBox.Location = new System.Drawing.Point(3, 3);
            this.WaiterTextBox.MaxLength = 32767;
            this.WaiterTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.WaiterTextBox.Name = "WaiterTextBox";
            this.WaiterTextBox.PasswordChar = '\0';
            this.WaiterTextBox.ReadOnly = true;
            this.WaiterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WaiterTextBox.SelectedText = "";
            this.WaiterTextBox.SelectionLength = 0;
            this.WaiterTextBox.SelectionStart = 0;
            this.WaiterTextBox.ShortcutsEnabled = true;
            this.WaiterTextBox.Size = new System.Drawing.Size(601, 142);
            this.WaiterTextBox.TabIndex = 18;
            this.WaiterTextBox.TabStop = false;
            this.WaiterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WaiterTextBox.UseAccent = false;
            this.WaiterTextBox.UseSystemPasswordChar = false;
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
            this.panel1.Location = new System.Drawing.Point(3, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 217);
            this.panel1.TabIndex = 19;
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
            // ResolutionToolTip
            // 
            this.ResolutionToolTip.AutoPopDelay = 5000;
            this.ResolutionToolTip.InitialDelay = 50;
            this.ResolutionToolTip.IsBalloon = true;
            this.ResolutionToolTip.ReshowDelay = 100;
            this.ResolutionToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // AddWaiterFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CreateWaiterFaceButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWaiterFaceForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add waiter face";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton CreateWaiterFaceButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 WaiterTextBox;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox CamerasComboBox;
        private MaterialSkin.Controls.MaterialSlider MaxFaceDetectValueSlider;
        private MaterialSkin.Controls.MaterialComboBox ResolutionsComboBox;
        private MaterialSkin.Controls.MaterialLabel ResolutionLabel;
        private MaterialSkin.Controls.MaterialComboBox MethodComboBox;
        private MaterialSkin.Controls.MaterialLabel MethodLabel;
        private System.Windows.Forms.ToolTip ResolutionToolTip;
    }
}