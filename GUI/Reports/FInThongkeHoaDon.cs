using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Microsoft.Reporting.WinForms;

namespace GUI.Reports
{
    public partial class FInThongkeHoaDon : Form
    {
        public Bill bill;
        public DateTime tuNgay;
        public DateTime denNgay;
        public FInThongkeHoaDon()
        {
            InitializeComponent();
        }

        private void FInThongkeHoaDon_Load(object sender, EventArgs e)
        {
            DataTable data = BillBLL.Instance.ThongKeHoaDon(tuNgay, denNgay);
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(data);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ThongKeHoaDon2";
            rds.Value = dataSet.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(rds);
            
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Reports.ThongKeHoaDon2.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
