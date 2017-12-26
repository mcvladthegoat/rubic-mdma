using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace mdma
{
    public partial class MDMa : Form
    {
        public Dictionary<string, List<int>> proceedInputData()
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();
            //TODO validation while splitting
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Debug.WriteLine(row.Cells);
                if (row.Cells[0].EditedFormattedValue.ToString() != "")
                {
                    data.Add(row.Cells[0].EditedFormattedValue.ToString(),
                        new List<int>(Array.ConvertAll<string, int>(row.Cells[1].EditedFormattedValue.ToString().Split(','), int.Parse)));
                }
            }
            return data;
        }

        public MDMa()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void MDMa_Load(object sender, EventArgs e)
        {

        }

        private void validateSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.proceedInputData().Count > 0)
            {
                MessageBox.Show("Data is OK");
            }
        }
    }
}
