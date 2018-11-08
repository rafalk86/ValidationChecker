namespace ValidationChecker
{
    partial class Settings
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
            this.currencyLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(20, 20);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(122, 13);
            this.currencyLabel.TabIndex = 0;
            this.currencyLabel.Text = "Komórka z kwotą waluty";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(20, 60);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(113, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Komórka z kwotą PLN";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(20, 100);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(93, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Komórka z opisem";
            // 
            // currency
            // 
            this.currency.Location = new System.Drawing.Point(180, 20);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(40, 20);
            this.currency.TabIndex = 3;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(180, 60);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(40, 20);
            this.amount.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(180, 100);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(40, 20);
            this.description.TabIndex = 5;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(150, 156);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(70, 24);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Zatwierdź";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.accept_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 200);
            this.ControlBox = false;
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.description);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.currencyLabel);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox currency;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button acceptButton;
    }
}