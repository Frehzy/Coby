namespace Coby.Forms.MessageForms
{
    partial class AddPaymentForm
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
            this.AddPaymentButton = new MaterialSkin.Controls.MaterialButton();
            this.AmountTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // PaymentTypeTextBox
            // 
            this.PaymentTypeTextBox.AnimateReadOnly = true;
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
            this.PaymentTypeTextBox.ReadOnly = true;
            this.PaymentTypeTextBox.Size = new System.Drawing.Size(231, 50);
            this.PaymentTypeTextBox.TabIndex = 0;
            this.PaymentTypeTextBox.Text = "";
            this.PaymentTypeTextBox.TrailingIcon = null;
            this.PaymentTypeTextBox.UseAccent = false;
            // 
            // AddPaymentButton
            // 
            this.AddPaymentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddPaymentButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddPaymentButton.Depth = 0;
            this.AddPaymentButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddPaymentButton.HighEmphasis = true;
            this.AddPaymentButton.Icon = null;
            this.AddPaymentButton.Location = new System.Drawing.Point(3, 181);
            this.AddPaymentButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddPaymentButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddPaymentButton.Name = "AddPaymentButton";
            this.AddPaymentButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddPaymentButton.Size = new System.Drawing.Size(237, 36);
            this.AddPaymentButton.TabIndex = 2;
            this.AddPaymentButton.Text = "Add";
            this.AddPaymentButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddPaymentButton.UseAccentColor = false;
            this.AddPaymentButton.UseVisualStyleBackColor = true;
            this.AddPaymentButton.Click += new System.EventHandler(this.AddPaymentButton_Click);
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
            // AddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 220);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.AddPaymentButton);
            this.Controls.Add(this.PaymentTypeTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPaymentForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox PaymentTypeTextBox;
        private MaterialSkin.Controls.MaterialButton AddPaymentButton;
        private MaterialSkin.Controls.MaterialTextBox AmountTextBox;
    }
}