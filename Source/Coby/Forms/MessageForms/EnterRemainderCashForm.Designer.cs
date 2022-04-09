namespace Coby.Forms.MessageForms
{
    partial class EnterRemainderCashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterRemainderCashForm));
            this.CashBalanceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.EnterPinButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CashBalanceTextBox
            // 
            this.CashBalanceTextBox.AnimateReadOnly = false;
            this.CashBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CashBalanceTextBox.Depth = 0;
            this.CashBalanceTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CashBalanceTextBox.Hint = "Cash balance";
            this.CashBalanceTextBox.LeadingIcon = null;
            this.CashBalanceTextBox.Location = new System.Drawing.Point(3, 67);
            this.CashBalanceTextBox.MaxLength = 50;
            this.CashBalanceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CashBalanceTextBox.Multiline = false;
            this.CashBalanceTextBox.Name = "CashBalanceTextBox";
            this.CashBalanceTextBox.Size = new System.Drawing.Size(401, 50);
            this.CashBalanceTextBox.TabIndex = 0;
            this.CashBalanceTextBox.Text = "";
            this.CashBalanceTextBox.TrailingIcon = null;
            this.CashBalanceTextBox.UseAccent = false;
            // 
            // EnterPinButton
            // 
            this.EnterPinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnterPinButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EnterPinButton.Depth = 0;
            this.EnterPinButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EnterPinButton.HighEmphasis = true;
            this.EnterPinButton.Icon = null;
            this.EnterPinButton.Location = new System.Drawing.Point(3, 122);
            this.EnterPinButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EnterPinButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EnterPinButton.Name = "EnterPinButton";
            this.EnterPinButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EnterPinButton.Size = new System.Drawing.Size(401, 36);
            this.EnterPinButton.TabIndex = 2;
            this.EnterPinButton.Text = "Enter";
            this.EnterPinButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EnterPinButton.UseAccentColor = false;
            this.EnterPinButton.UseVisualStyleBackColor = true;
            this.EnterPinButton.Click += new System.EventHandler(this.EnterPinButton_Click);
            // 
            // EnterRemainderCashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 161);
            this.Controls.Add(this.EnterPinButton);
            this.Controls.Add(this.CashBalanceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterRemainderCashForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter the cash balance of the cash register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox CashBalanceTextBox;
        private MaterialSkin.Controls.MaterialButton EnterPinButton;
    }
}