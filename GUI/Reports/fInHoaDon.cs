using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using Microsoft.Reporting.WinForms;

namespace GUI.Reports
{
    public partial class fInHoaDon : Form
    {
        public int idHD;
        
        public fInHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonReport hoaDonReport = BillBLL.Instance.HoaDonReport(idHD);
            DataTable data = BillBLL.Instance.CTHDTheoHD(idHD);
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(data);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "HoaDonBanHang";
            rds.Value = dataSet.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(rds);

            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter ("pSoHoaDon", hoaDonReport.ID.ToString()),
                new ReportParameter("pNguoiLap", hoaDonReport.DisplayName.ToString()),
                new ReportParameter("pTenBan",hoaDonReport.TableName.ToString()),
                new ReportParameter("pKhuyenMai",hoaDonReport.Discount.ToString()),
                new ReportParameter("pThanhTien",hoaDonReport.TotalPrice.ToString())
            };

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Reports.InHoaDon.rdlc";
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
