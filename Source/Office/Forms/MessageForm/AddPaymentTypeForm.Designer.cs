namespace Office.Forms.MessageForm
{
    partial class AddPaymentTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPaymentTypeForm));
            this.PaymentTypeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.PaymentEnumComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // PaymentTypeTextBox
            // 
            this.PaymentTypeTextBox.AnimateReadOnly = false;
            this.PaymentTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentTypeTextBox.Depth = 0;
            this.PaymentTypeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PaymentTypeTextBox.Hint = "Payment type name";
            this.PaymentTypeTextBox.LeadingIcon = null;
            this.PaymentTypeTextBox.Location = new System.Drawing.Point(6, 67);
            this.PaymentTypeTextBox.MaxLength = 50;
            this.PaymentTypeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PaymentTypeTextBox.Multiline = false;
            this.PaymentTypeTextBox.Name = "PaymentTypeTextBox";
            this.PaymentTypeTextBox.Size = new System.Drawing.Size(231, 50);
            this.PaymentTypeTextBox.TabIndex = 0;
            this.PaymentTypeTextBox.Text = "";
            this.PaymentTypeTextBox.TrailingIcon = null;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(3, 182);
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
            // PaymentEnumComboBox
            // 
            this.PaymentEnumComboBox.AutoResize = false;
            this.PaymentEnumComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PaymentEnumComboBox.Depth = 0;
            this.PaymentEnumComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PaymentEnumComboBox.DropDownHeight = 174;
            this.PaymentEnumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentEnumComboBox.DropDownWidth = 121;
            this.PaymentEnumComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PaymentEnumComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PaymentEnumComboBox.FormattingEnabled = true;
            this.PaymentEnumComboBox.IntegralHeight = false;
            this.PaymentEnumComboBox.ItemHeight = 43;
            this.PaymentEnumComboBox.Location = new System.Drawing.Point(9, 123);
            this.PaymentEnumComboBox.MaxDropDownItems = 4;
            this.PaymentEnumComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PaymentEnumComboBox.Name = "PaymentEnumComboBox";
            this.PaymentEnumComboBox.Size = new System.Drawing.Size(231, 49);
            this.PaymentEnumComboBox.StartIndex = 0;
            this.PaymentEnumComboBox.TabIndex = 5;
            // 
            // AddPaymentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 221);
            this.Controls.Add(this.PaymentEnumComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PaymentTypeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPaymentTypeForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add payment type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox PaymentTypeTextBox;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialComboBox PaymentEnumComboBox;
    }
}