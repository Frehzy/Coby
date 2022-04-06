namespace Office.Forms.MessageForm
{
    partial class AddNomenclatureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNomenclatureForm));
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.AmountTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ChildProductComboBox = new MaterialSkin.Controls.MaterialComboBox();
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
            // AmountTextBox
            // 
            this.AmountTextBox.AnimateReadOnly = false;
            this.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountTextBox.Depth = 0;
            this.AmountTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AmountTextBox.Hint = "Amount";
            this.AmountTextBox.LeadingIcon = null;
            this.AmountTextBox.Location = new System.Drawing.Point(6, 123);
            this.AmountTextBox.MaxLength = 50;
            this.AmountTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AmountTextBox.Multiline = false;
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(231, 50);
            this.AmountTextBox.TabIndex = 3;
            this.AmountTextBox.Text = "";
            this.AmountTextBox.TrailingIcon = null;
            // 
            // ChildProductComboBox
            // 
            this.ChildProductComboBox.AutoResize = false;
            this.ChildProductComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChildProductComboBox.Depth = 0;
            this.ChildProductComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChildProductComboBox.DropDownHeight = 174;
            this.ChildProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChildProductComboBox.DropDownWidth = 121;
            this.ChildProductComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ChildProductComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChildProductComboBox.FormattingEnabled = true;
            this.ChildProductComboBox.IntegralHeight = false;
            this.ChildProductComboBox.ItemHeight = 43;
            this.ChildProductComboBox.Location = new System.Drawing.Point(6, 68);
            this.ChildProductComboBox.MaxDropDownItems = 4;
            this.ChildProductComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ChildProductComboBox.Name = "ChildProductComboBox";
            this.ChildProductComboBox.Size = new System.Drawing.Size(231, 49);
            this.ChildProductComboBox.StartIndex = 0;
            this.ChildProductComboBox.TabIndex = 4;
            // 
            // AddNomenclatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 216);
            this.Controls.Add(this.ChildProductComboBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNomenclatureForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add nomenclature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialTextBox AmountTextBox;
        private MaterialSkin.Controls.MaterialComboBox ChildProductComboBox;
    }
}