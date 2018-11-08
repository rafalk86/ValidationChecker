using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ValidationChecker
{
    public partial class Report : Form
    {
        public Report(List <Tuple<string, string, string>> tuple)
        {
            InitializeComponent();

            for (int i = 0; i < tuple.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(tuple[i].Item1);
                lvi.SubItems.Add(tuple[i].Item2);
                lvi.SubItems.Add(tuple[i].Item3);
                resultView.Items.Add(lvi);
            }

            if(resultView.Items.Count == 0)
            {
                MessageBox.Show("Brak błędnych plików.");
            }
        }
    }
}
