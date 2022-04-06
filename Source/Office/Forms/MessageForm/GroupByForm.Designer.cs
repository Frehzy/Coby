namespace Office.Forms.MessageForm
{
    partial class GroupByForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupByForm));
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.GroupByComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.DateComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(3, 177);
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
            // GroupByComboBox
            // 
            this.GroupByComboBox.AutoResize = false;
            this.GroupByComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GroupByComboBox.Depth = 0;
            this.GroupByComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GroupByComboBox.DropDownHeight = 174;
            this.GroupByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupByComboBox.DropDownWidth = 121;
            this.GroupByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.GroupByComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupByComboBox.FormattingEnabled = true;
            this.GroupByComboBox.IntegralHeight = false;
            this.GroupByComboBox.ItemHeight = 43;
            this.GroupByComboBox.Location = new System.Drawing.Point(6, 68);
            this.GroupByComboBox.MaxDropDownItems = 4;
            this.GroupByComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.GroupByComboBox.Name = "GroupByComboBox";
            this.GroupByComboBox.Size = new System.Drawing.Size(231, 49);
            this.GroupByComboBox.StartIndex = 0;
            this.GroupByComboBox.TabIndex = 4;
            this.GroupByComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupByComboBox_SelectedIndexChanged);
            // 
            // DateComboBox
            // 
            this.DateComboBox.AutoResize = false;
            this.DateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DateComboBox.Depth = 0;
            this.DateComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DateComboBox.DropDownHeight = 174;
            this.DateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DateComboBox.DropDownWidth = 121;
            this.DateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DateComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.IntegralHeight = false;
            this.DateComboBox.ItemHeight = 43;
            this.DateComboBox.Location = new System.Drawing.Point(6, 119);
            this.DateComboBox.MaxDropDownItems = 4;
            this.DateComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DateComboBox.Name = "DateComboBox";
            this.DateComboBox.Size = new System.Drawing.Size(231, 49);
            this.DateComboBox.StartIndex = 0;
            this.DateComboBox.TabIndex = 5;
            // 
            // GroupByForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 216);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.GroupByComboBox);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupByForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GroupBy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialComboBox GroupByComboBox;
        private MaterialSkin.Controls.MaterialComboBox DateComboBox;
    }
}