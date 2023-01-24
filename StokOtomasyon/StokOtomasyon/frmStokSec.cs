using StokOtomasyon.DLL;
using StokOtomasyon.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokOtomasyon
{
    public partial class frmStokSec : Form
    {
        frmHareket hForm;
        public frmStokSec(frmHareket hForm)
        {
            InitializeComponent();
            this.hForm = hForm;
        }

        UnitOfWork uow;
        private void frmStokSec_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            dgvStokSec.DataSource = uow.StokRep.GetAll();
        }

        public void btnStokAktar_Click(object sender, EventArgs e)
        {
            if (dgvStokSec.SelectedRows.Count > 0)
            {
                int selectedRow = dgvStokSec.SelectedRows[0].Index;
                hForm._stok = (Stok)dgvStokSec.Rows[selectedRow].DataBoundItem;
                hForm.lblStokAdiGoster2.Text = hForm._stok.StokAd;

            }
            this.Close();
        }

    }
}
