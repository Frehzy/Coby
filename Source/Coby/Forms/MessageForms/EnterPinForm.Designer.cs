namespace Coby.Forms.MessageForms
{
    partial class EnterPinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterPinForm));
            this.PinTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.EnterPinButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // PinTextBox
            // 
            this.PinTextBox.AnimateReadOnly = false;
            this.PinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PinTextBox.Depth = 0;
            this.PinTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PinTextBox.Hint = "Pin";
            this.PinTextBox.LeadingIcon = null;
            this.PinTextBox.Location = new System.Drawing.Point(6, 67);
            this.PinTextBox.MaxLength = 50;
            this.PinTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PinTextBox.Multiline = false;
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(231, 50);
            this.PinTextBox.TabIndex = 0;
            this.PinTextBox.Text = "";
            this.PinTextBox.TrailingIcon = null;
            this.PinTextBox.UseAccent = false;
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
            this.EnterPinButton.Size = new System.Drawing.Size(237, 36);
            this.EnterPinButton.TabIndex = 2;
            this.EnterPinButton.Text = "Enter";
            this.EnterPinButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EnterPinButton.UseAccentColor = false;
            this.EnterPinButton.UseVisualStyleBackColor = true;
            this.EnterPinButton.Click += new System.EventHandler(this.AddPaymentButton_Click);
            // 
            // EnterPinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 161);
            this.Controls.Add(this.EnterPinButton);
            this.Controls.Add(this.PinTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterPinForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox PinTextBox;
        private MaterialSkin.Controls.MaterialButton EnterPinButton;
    }
}