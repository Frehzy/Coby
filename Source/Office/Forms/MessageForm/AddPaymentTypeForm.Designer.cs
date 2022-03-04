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
            this.PaymentTypeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
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
            this.SaveButton.Location = new System.Drawing.Point(3, 125);
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
            // AddPaymentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 164);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PaymentTypeTextBox);
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
    }
}