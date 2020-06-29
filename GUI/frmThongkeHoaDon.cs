using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongkeHoaDon : Form
    {
        public frmThongkeHoaDon()
        {
            InitializeComponent();
        }

        private void frmThongkeHoaDon_Load(object sender, EventArgs e)
        {
            showListHD();
            this.reportViewer1.RefreshReport();
        }
        public void showListHD()
        {
            List<BillDTO> list = BUS.BillBus.Instance.getListHD();
            this.reportViewer1.LocalReport.ReportPath = "../../rptThongKeHD.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBill", list));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paTuNgay", DateTime.Now.ToString("dd/MM/yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paDenNgay", DateTime.Now.ToString("dd/MM/yyyy")));
            this.reportViewer1.RefreshReport();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.DataSources.Clear();
            List<BillDTO> list = BUS.BillBus.Instance.getListHD(dtpTuNgay.Value.ToString(), dtpDenNgay.Value.ToString());
            this.reportViewer1.LocalReport.ReportPath = "../../rptThongKeHD.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBill", list));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paTuNgay", dtpTuNgay.Value.ToString("dd/MM/yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paDenNgay", dtpDenNgay.Value.ToString("dd/MM/yyyy")));
            this.reportViewer1.RefreshReport();
        }
    }
}
