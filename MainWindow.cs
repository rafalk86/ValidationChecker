using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ValidationChecker
{
    public partial class MainWindow : Form
    {
        FolderBrowserDialog browser;
        List<Tuple<string, string, string>> errors;
        string[] files;

        public MainWindow()
        {
            InitializeComponent();

            browser = new FolderBrowserDialog();
            errors = new List<Tuple<string, string, string>>();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (browser.ShowDialog() == DialogResult.OK)
            {
                fileList.Items.Clear();
                filePath.Text = browser.SelectedPath;
                files = Directory.GetFiles(filePath.Text);

                foreach(string file in files)
                {
                    fileList.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void Launcher_Click(object sender, EventArgs e)
        {
            if (!accountsCheckbox.Checked && !amountsCheckbox.Checked || filePath.Text == "")
            {
                MessageBox.Show("Brak zaznaczonych obszarów sprawdzania lub/i ustawionej ścieżki do plików.");
            }
            else
            {
                errors.Clear();

                progressBar.Visible = true;
                launcherButton.Enabled = false;

                Properties.Settings.Default.amountCheck= amountsCheckbox.Checked;
                Properties.Settings.Default.accountCheck = accountsCheckbox.Checked;
                Properties.Settings.Default.Save();

                Thread task = new Thread(new ThreadStart(() =>
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        using (ExcelPackage package = new ExcelPackage(new FileInfo(files[i])))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                            double curVal = Math.Round((double)worksheet.Cells[Properties.Settings.Default.currency.ToString()].Value, 2);
                            double plnVal = Math.Round((double)worksheet.Cells[Properties.Settings.Default.amount.ToString()].Value, 2);

                            double sumCurVal = Math.Round((double)worksheet.Cells[LastUsedRow(worksheet), 3].Value, 2);
                            double sumPlnVal = Math.Round((double)worksheet.Cells[LastUsedRow(worksheet), 4].Value, 2);

                            string number = worksheet.Cells["C1"].Value.ToString();
                            string desc = Regex.Replace(worksheet.Cells[Properties.Settings.Default.description.ToString()].Value.ToString(), "[^0-9.+-]", "");

                            int descMonth = Convert.ToInt32(desc.Substring(desc.Length - 7, 2));

                            CreateReport(number, CompareAmounts(curVal, plnVal, sumCurVal, sumPlnVal),
                                CompareAccounts(worksheet, descMonth, LastUsedRow(worksheet) - 2));
                        }
                        Invoke(new Action(() =>
                        {
                            progressBar.Value = (i + 1) * 100 / files.Length;
                        }));
                    }
                    Invoke(new Action(() =>
                    {
                        progressBar.Visible = false;
                        launcherButton.Enabled = true;
                        Report report = new Report(errors);
                        report.Show();
                    }));
                }));
                task.Start();
            }
        }

        private int LastUsedRow(ExcelWorksheet sheet)
        {
            var row = sheet.Dimension.End.Row;
            while (row >= 1)
            {
                var range = sheet.Cells[row, 1, row, sheet.Dimension.End.Column];
                if (range.Any(c => !string.IsNullOrEmpty(c.Text)))
                {
                    break;
                }
                row--;
            }
            return row;
        }

        private string CompareAmounts(double curVal, double plnVal, double sumCurVal, double sumPlnVal)
        {
            string match = "";

            if(amountsCheckbox.Checked)
            {
                if (curVal == plnVal)
                {
                    if (plnVal != sumPlnVal)
                    {
                        match = "Niezgodne kwoty";
                    }
                }
                else
                {
                    if (curVal != sumCurVal || plnVal != sumPlnVal)
                    {
                        match = "Niezgodne kwoty";
                    }
                }
            }
            return match;
        }

        private string CompareAccounts(ExcelWorksheet sheet, int descMonth, int limit)
        {
            string match = "";
            string acc = "";
            int marginMonth = 0;

            if (accountsCheckbox.Checked)
            {
                for (int i = 3; i < limit; i++)
                {
                    if (sheet.Cells[i, 4].Value != null)
                    {
                        acc = sheet.Cells[i, 4].Value.ToString();

                        if (acc.Substring(0, 1) == "6" && acc.Substring(0, 3) != "630")
                        {
                            marginMonth = Convert.ToInt32(acc.Substring(acc.IndexOf("-") + 1, acc.LastIndexOf("-") - acc.IndexOf("-") - 1));

                            if ((marginMonth < descMonth || marginMonth > descMonth + 1) && marginMonth != 0)
                            {
                                match = "Niezgodne konta";
                                break;
                            }
                        }
                    }
                }
            }
            return match;
        }

        private void CreateReport(string number, string amountMatch, string accountMatch)
        {
            if (amountMatch != "" || accountMatch != "")
            {
                errors.Add(new Tuple<string, string, string>(number, amountMatch, accountMatch));
            }
        }
    }
}
