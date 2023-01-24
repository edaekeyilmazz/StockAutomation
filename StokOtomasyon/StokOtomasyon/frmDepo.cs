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
    public partial class frmDepo : Form
    {
        Depo _Depo;
        IUnitOfWork uow;
        public frmDepo(IUnitOfWork _uow)
        {
            InitializeComponent();
            this.uow = _uow;
        }

        public frmDepo(IUnitOfWork _uow, Depo _depo)
        {
            InitializeComponent();
            this.uow = _uow;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //UPDATE işlemi
            if (_Depo != null && _Depo.ID != Guid.Empty)
            {
                _Depo.ModifiedDate = DateTime.Now;
                _Depo.DepoAd = txtAdi.Text;
                _Depo.DepoKod = txtKodu.Text;
                uow.DepoRep.Update(_Depo);
                if (uow.SaveChanges())
                    MessageBox.Show("Güncelleme işlemi başarılı.");
                RefreshControls();
            }

            //INSERT İşlemi
            else
            {
                Depo depo = new Depo();
                depo.CreatedDate=DateTime.Now;
                depo.DepoAd = txtAdi.Text;
                depo.DepoKod = txtKodu.Text;
                uow.DepoRep.Insert(depo);
                if (uow.SaveChanges())
                {
                    MessageBox.Show("Kayıt işlemi başarılı.");
                }
                RefreshControls();
            }

        }

        private void RefreshControls()
        {
            dgvDepo.DataSource = uow.DepoRep.GetAll();
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = new TextBox();
                    txt.Clear();
                    _Depo = null;
                }
            }
        }

        private void dgvDepo_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDepo.SelectedRows.Count > 0)
            {
                _Depo = (Depo)dgvDepo.SelectedRows[0].DataBoundItem;
                txtAdi.Text = _Depo.DepoAd;
                txtKodu.Text = _Depo.DepoKod;
            }
        }

        private void frmDepo_Load(object sender, EventArgs e)
        {
            dgvDepo.AutoGenerateColumns = false;
            RefreshControls();
        }
    }
}
