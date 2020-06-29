using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
<<<<<<< HEAD
using Microsoft.Reporting.WinForms;
=======
>>>>>>> d87ad6287aa2d11f00defadc1326879aaa8d94ec

namespace GUI
{
    public partial class ThongKeTheoMon : UserControl
    {
<<<<<<< HEAD:GUI/ThongKeTheoMon.cs
        public ThongKeTheoMon()
=======

        public uctThongKe()
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2:GUI/uctThongKe.cs
        {

            InitializeComponent();
        }
<<<<<<< HEAD
        private void uctThongKe_Load(object sender, EventArgs e)
        {
            showListHD();
            this.reportViewer1.RefreshReport();
        }
        public void showListHD()
        {
            List<BillDTO> list = BUS.BillBus.Instance.getListHD();
            this.reportViewer1.LocalReport.ReportPath = "../../rptThongKeHD.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBill", list));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paTuNgay", DateTime.Now.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paDenNgay", DateTime.Now.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.DataSources.Clear();
            List<BillDTO> list = BUS.BillBus.Instance.getListHD(dtpTuNgay.Value.ToString(), dtpDenNgay.Value.ToString());
            this.reportViewer1.LocalReport.ReportPath = "../../rptThongKeHD.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBill", list));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paTuNgay", dtpTuNgay.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paDenNgay", dtpDenNgay.Value.ToString()));
            this.reportViewer1.RefreshReport();
=======

        private void uctThongKe_Load(object sender, EventArgs e)
        {
            ShowTatCaHD();
        }
        public void ShowTatCaHD()
        {
            List<BillDTO> lstHD = new List<BillDTO>();
            lstHD = BUS.BillBus.Instance.getListHD(dtpTuNgay.Value.ToString(), dtpDenNgay.Value.ToString());
            this.reportViewer1.LocalReport.ReportPath = "GUI.rptThongKeHD.rdlc";
            //do du lieu
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsBill", lstHD));
            this.reportViewer1.RefreshReport();

>>>>>>> d87ad6287aa2d11f00defadc1326879aaa8d94ec
        }
    }
}
