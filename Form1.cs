﻿using System;
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
        private static int candCount;
        public Dictionary<string, List<int>> proceedInputData()
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();
            //TODO validation while splitting
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Debug.WriteLine(row.Cells);
                if (row.Cells[0].EditedFormattedValue.ToString() != "")
                {
                    List<int> votes = new List<int>();
                    for (int i = 1; i< row.Cells.Count; i++)
                    {
                        votes.Add(Convert.ToInt32(row.Cells[i].EditedFormattedValue.ToString()));
                        Debug.WriteLine(row.Cells[i].EditedFormattedValue);
                    }
                    data.Add(row.Cells[0].EditedFormattedValue.ToString(), votes);
                    //data.Add(row.Cells[0].EditedFormattedValue.ToString(),
                        //new List<int>(Array.ConvertAll<string, int>(row.Cells[1].EditedFormattedValue.ToString().Split(','), int.Parse)));
                }
            }
            return data;
        }

        public MDMa()
        {
            InitializeComponent();
            candCount = 0;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            candCount++;
            DataGridViewColumn newCol = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Position " + candCount;
            newCol.Name = "Position " + candCount;
            newCol.Visible = true;
            newCol.Width = 100;
            dataGridView1.Columns.Add(newCol);
        }

        private void bordaMethod_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            var cndList = new List<int>();
            for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            {
                cndList.Add(0);
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                {
                    cndList[j - 1] += Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
            }

            for (int i = 0; i < cndList.Count; i++)
            {
                dataGridView2.Rows.Add(1);
                dataGridView2.Rows[i].Cells[0] = new DataGridViewTextBoxCell() { Value = "Candidate " + (i + 1) };
                dataGridView2.Rows[i].Cells[1] = new DataGridViewTextBoxCell() { Value = cndList[i] };
            }

        }

        private void compRulesMethod_Click(object sender, EventArgs e)
        {
            //maximin implementation
            var data = this.proceedInputData();
            int [,] res = new int[candCount,candCount] ;
            for (int i = 0; i < candCount; i++)
            {
                res[i,i] = 0;
            }
            for (int i = 0; i < candCount; i++)
            {
                for (int j = 0; j < candCount; j++)
                {
                    if (i > j) continue;
                    foreach (KeyValuePair<string, List<int>> k in data)
                    {
                        Debug.WriteLine(k.Value.Find(x => x == i+1));
                    }
                }
            }
        }
    }
}
