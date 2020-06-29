using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        List<BillInfoDTO> _list;
        string _total, _cash, _change, _date, _dateCheckout;

        private void frmHoaDon_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public frmHoaDon(List<BillInfoDTO> dataSource, string total, string cash, string change, string date, string dateCheckout)
        {
            InitializeComponent();
            _list = dataSource;
            _total = total;
            _cash = cash;
            _change = change;
            _date = date;
            _dateCheckout = dateCheckout;
        }
        
        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            
            this.reportViewer1.RefreshReport();
        }

        

    }
}
