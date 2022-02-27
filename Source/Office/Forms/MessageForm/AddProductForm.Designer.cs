namespace Office.Forms.MessageForm
{
    partial class AddProductForm
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
            this.ProductNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.PriceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.IsItForSaleCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.AnimateReadOnly = false;
            this.ProductNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductNameTextBox.Depth = 0;
            this.ProductNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductNameTextBox.Hint = "Product name";
            this.ProductNameTextBox.LeadingIcon = null;
            this.ProductNameTextBox.Location = new System.Drawing.Point(6, 67);
            this.ProductNameTextBox.MaxLength = 50;
            this.ProductNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductNameTextBox.Multiline = false;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(231, 50);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.Text = "";
            this.ProductNameTextBox.TrailingIcon = null;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(3, 218);
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
            // PriceTextBox
            // 
            this.PriceTextBox.AnimateReadOnly = false;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Depth = 0;
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceTextBox.Hint = "Price";
            this.PriceTextBox.LeadingIcon = null;
            this.PriceTextBox.Location = new System.Drawing.Point(6, 123);
            this.PriceTextBox.MaxLength = 50;
            this.PriceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PriceTextBox.Multiline = false;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(231, 50);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.Text = "";
            this.PriceTextBox.TrailingIcon = null;
            // 
            // IsItForSaleCheckBox
            // 
            this.IsItForSaleCheckBox.AutoSize = true;
            this.IsItForSaleCheckBox.Depth = 0;
            this.IsItForSaleCheckBox.Location = new System.Drawing.Point(3, 175);
            this.IsItForSaleCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.IsItForSaleCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsItForSaleCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsItForSaleCheckBox.Name = "IsItForSaleCheckBox";
            this.IsItForSaleCheckBox.ReadOnly = false;
            this.IsItForSaleCheckBox.Ripple = true;
            this.IsItForSaleCheckBox.Size = new System.Drawing.Size(122, 37);
            this.IsItForSaleCheckBox.TabIndex = 5;
            this.IsItForSaleCheckBox.Text = "Is It For Sale";
            this.IsItForSaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 257);
            this.Controls.Add(this.IsItForSaleCheckBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProductNameTextBox);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add payment type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox ProductNameTextBox;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialTextBox PriceTextBox;
        private MaterialSkin.Controls.MaterialCheckbox IsItForSaleCheckBox;
    }
}