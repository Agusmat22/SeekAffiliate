﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Libraries;


namespace SeekAffiliate
{
    public partial class Search : Form
    {
        List<Affiliate> affiliateList;
        public Search()
        {
            InitializeComponent();
            this.dataGridView1.ScrollBars = ScrollBars.Vertical;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dataJoin = this.txbSearch.Text;
            string dataType = "";

            if (this.rdbName.Checked == true)
            {

                dataType = "name";
            }
            else if (this.rdbNumber.Checked == true)
            {
                dataType = "number";
            }
            else if (this.rdbDni.Checked == true)
            {
                dataType = "dni";

            }

            dataGridView1.Rows.Clear();
            affiliateList = Functions.GetAffiliate(dataJoin, dataType);

            foreach (Affiliate af in affiliateList)
            {
                int rowIndex = this.dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["EntityColumn"].Value = af.GetEntity;
                dataGridView1.Rows[rowIndex].Cells["NameColumn"].Value = af.GetName;
                dataGridView1.Rows[rowIndex].Cells["NumberColumn"].Value = af.GetNumber;
                dataGridView1.Rows[rowIndex].Cells["InternColumn"].Value = af.GetIntern;
                dataGridView1.Rows[rowIndex].Cells["TypeDuColumn"].Value = af.GetTypeDu;
                dataGridView1.Rows[rowIndex].Cells["DuColumn"].Value = af.GetDni;
            }
            this.txbSearch.Text = "";

        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void linkLbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int columnIndex = dataGridView1.SelectedCells[0].ColumnIndex;
                DataGridViewCell cell = dataGridView1.Rows[rowIndex].Cells[columnIndex];

                string cellValue = cell.Value.ToString();
                bool removeValue = Functions.RemoveAffiliate(cellValue);

                if (removeValue) 
                { 
                    MessageBox.Show("Eliminado correctamente");
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Error, seleccione un item");
                }
            }
            
        }

        

    }
}
