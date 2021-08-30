using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QUANLYTHICU.BAL;

namespace QUANLYTHICU
{
    public partial class frmRpKq : Form
    {
        private readonly CHITIETMONHOC_BAL _chiTietMonHocBAL;
        public frmRpKq()
        {
            InitializeComponent();
            _chiTietMonHocBAL = new CHITIETMONHOC_BAL();
        }

        private void frmRpKq_Load(object sender, EventArgs e)
        {
            rpKq.Visible = true;
            rpKq.RefreshReport();
            this.rpKq.LocalReport.ReportPath = ("./ReportDsKetQua/RpDsKetQua.rdlc");
            var ReportDataSource = new ReportDataSource("KETQUADATASET", _chiTietMonHocBAL.LayDanhSachKetQua());
            this.rpKq.LocalReport.DataSources.Clear();
            this.rpKq.LocalReport.DataSources.Add(ReportDataSource);
            this.rpKq.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
