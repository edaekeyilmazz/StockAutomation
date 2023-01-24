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
    public partial class frmDepoSec : Form
    {
        frmHareket hForm;
        public frmDepoSec(frmHareket hForm)
        {
            InitializeComponent();
            this.hForm = hForm;
        }
        UnitOfWork uow;
        private void frmDepoSec_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            dgvDepoSec.DataSource = uow.DepoRep.GetAll();
        }
        public void btnDepoAktar_Click(object sender, EventArgs e)
        {
            if (dgvDepoSec.SelectedRows.Count > 0)
            {
                int selectedRow = dgvDepoSec.SelectedRows[0].Index;
                hForm._depo = (Depo)dgvDepoSec.Rows[selectedRow].DataBoundItem;
                hForm.lblDepoAdiGoster1.Text = hForm._depo.DepoAd;
            }
            this.Close();
           
        }

    }
}
