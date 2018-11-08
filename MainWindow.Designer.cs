namespace ValidationChecker
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.browseButton = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.accountsCheckbox = new System.Windows.Forms.CheckBox();
            this.amountsCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.launcherButton = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.listLabel = new System.Windows.Forms.Label();
            this.validationGroup = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.validationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(220, 40);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 24);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Przeglądaj...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filePath.Location = new System.Drawing.Point(20, 40);
            this.filePath.Multiline = true;
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(190, 24);
            this.filePath.TabIndex = 1;
            // 
            // accountsCheckbox
            // 
            this.accountsCheckbox.AutoSize = true;
            this.accountsCheckbox.Location = new System.Drawing.Point(15, 30);
            this.accountsCheckbox.Name = "accountsCheckbox";
            this.accountsCheckbox.Size = new System.Drawing.Size(78, 17);
            this.accountsCheckbox.TabIndex = 2;
            this.accountsCheckbox.Text = "Okres kont";
            this.accountsCheckbox.UseVisualStyleBackColor = true;
            // 
            // amountsCheckbox
            // 
            this.amountsCheckbox.AutoSize = true;
            this.amountsCheckbox.Location = new System.Drawing.Point(103, 30);
            this.amountsCheckbox.Name = "amountsCheckbox";
            this.amountsCheckbox.Size = new System.Drawing.Size(100, 17);
            this.amountsCheckbox.TabIndex = 3;
            this.amountsCheckbox.Text = "Zgodność kwot";
            this.amountsCheckbox.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(526, 10);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 24);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.Settings_Click);
            // 
            // launcherButton
            // 
            this.launcherButton.Location = new System.Drawing.Point(20, 346);
            this.launcherButton.Name = "launcherButton";
            this.launcherButton.Size = new System.Drawing.Size(310, 34);
            this.launcherButton.TabIndex = 5;
            this.launcherButton.Text = "Sprawdzaj";
            this.launcherButton.UseVisualStyleBackColor = true;
            this.launcherButton.Click += new System.EventHandler(this.Launcher_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(350, 40);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(250, 342);
            this.fileList.TabIndex = 6;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(20, 20);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(93, 13);
            this.pathLabel.TabIndex = 7;
            this.pathLabel.Text = "Ścieżka do plików";
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(350, 20);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(139, 13);
            this.listLabel.TabIndex = 8;
            this.listLabel.Text = "Lista plików do sprawdzenia";
            // 
            // validationGroup
            // 
            this.validationGroup.Controls.Add(this.accountsCheckbox);
            this.validationGroup.Controls.Add(this.amountsCheckbox);
            this.validationGroup.Location = new System.Drawing.Point(20, 80);
            this.validationGroup.Name = "validationGroup";
            this.validationGroup.Size = new System.Drawing.Size(220, 70);
            this.validationGroup.TabIndex = 9;
            this.validationGroup.TabStop = false;
            this.validationGroup.Text = "Obszary sprawdzania";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 300);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(310, 30);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 10;
            this.progressBar.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 400);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.validationGroup);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.launcherButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.browseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprawdzanie plików (by Rafal Kluzinski)";
            this.validationGroup.ResumeLayout(false);
            this.validationGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.CheckBox accountsCheckbox;
        private System.Windows.Forms.CheckBox amountsCheckbox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button launcherButton;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.GroupBox validationGroup;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

