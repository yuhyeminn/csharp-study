using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_23_DataTable_DataSet
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckIsTable = false;

            // DataSet 안에 해당하는 DataTable이 있는지 확인
            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckIsTable = true;
            }

            DataTable dt = null;

            // DataTable이 없으면 생성
            if (!bCheckIsTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                // DataColumn 생성
                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                // 생성된 Column을 DataTable에 Add
                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                // DataTable이 있으면 가져옴
                dt = ds.Tables[cboxRegClass.Text];
            }

            // Row 생성
            DataRow row = dt.NewRow();
            row["Name"] = tboxRegName.Text;

            if (rdoRegSexFemale.Checked)
            {
                row["SEX"] = "여자";
            }
            else if (rdoRegSexMale.Checked)
            {
                row["SEX"] = "남자";
            }
            row["REF"] = tboxRegRef.Text;

            //dt.Rows.Add(row);
            ////// DataTable이 존재하면 Table을 지웠다 다시 생성 - 비효율적
            //if (bCheckIsTable)
            //{
            //    ds.Tables.Remove(cboxRegClass.Text);
            //    ds.Tables.Add(dt);
            //}
            //ds.Tables.Add(dt);

            // 생성된 Row를 DataTable에 Add
            if(bCheckIsTable)
            {
                // DataSet에 해당 DataTable이 있을 경우 기존 Table에 Row를 추가
                ds.Tables[cboxRegClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);    // 신규로 작성한 DataTable에 Row를 등록하고,
                ds.Tables.Add(dt);   // 등록한 DataTable을 DataSet에 추가
            }

            cboxViewClass_SelectedIndexChanged(this, null);
        }


        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgViewInfo.SelectedRows[0].Index;
            ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);

            cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tboxRegName.Text))
            {
                foreach (DataRow oitem in ds.Tables[cboxRegClass.Text].Rows)
                {
                    if (oitem["Name"].Equals(tboxRegName.Text))
                    {
                        if (rdoRegSexFemale.Checked)
                        {
                            oitem["SEX"] = "여자";
                        }
                        else if (rdoRegSexMale.Checked)
                        {
                            oitem["SEX"] = "남자";
                        }
                        oitem["REF"] = tboxRegRef.Text;
                    }
                }
                cboxViewClass_SelectedIndexChanged(this, null);
            }
        }


        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];

            // DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
