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
    public partial class frmHareket : Form
    {
        Hareket _hareket;
        public Depo _depo;
        public Stok _stok;
        IUnitOfWork uow;
        public frmHareket(IUnitOfWork _uow)
        {
            InitializeComponent();
            this.uow = _uow;
        }

        public frmHareket(IUnitOfWork _uow, Hareket hareket)
        {
            InitializeComponent();
            _hareket = hareket;
            this.uow = _uow;
        }


        private void frmHareket_Load(object sender, EventArgs e)
        {
            dgvHareket.AutoGenerateColumns = false;
            RefreshControls();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmStokSec sForm = new frmStokSec(this);
            frmDepoSec dForm = new frmDepoSec(this);

            //UPDATE İşlemi
                if (_hareket!=null && _hareket.ID!=Guid.Empty)
              {
                  _hareket.ModifiedDate = DateTime.Now;
                  _hareket.Miktar = string.IsNullOrEmpty(txtMiktar.Text) ? 0 : decimal.Parse(txtMiktar.Text);
                  _hareket.FirmaAdi = txtFirmaAd.Text;
                  int hareketTur = cmbHareketTuru.SelectedIndex;
                  _hareket.HareketTuru = (byte)hareketTur;
                  _hareket.StokID = _stok.ID;
                  _hareket.DepoID = _depo.ID;
                _hareket.CreatedDate=DateTime.Now;
                uow.HareketRep.Update(_hareket);
                if (uow.SaveChanges())
                {
                    MessageBox.Show("Güncelleme işlemi başarılı.");
                    RefreshControls();
                }
               
              }
              //INSERT İşlemi
              else
              {
                  Hareket hareket=new Hareket();
                  hareket.CreatedDate = DateTime.Now;
                  hareket.Miktar = string.IsNullOrEmpty(txtMiktar.Text) ? 0 : decimal.Parse(txtMiktar.Text);
                  hareket.FirmaAdi = txtFirmaAd.Text;
                  int hareketTur = cmbHareketTuru.SelectedIndex;
                  hareket.HareketTuru = (byte)hareketTur;
                  hareket.StokID = _stok.ID;
                  hareket.DepoID = _depo.ID;
                  uow.HareketRep.Insert(hareket);
                  if (uow.SaveChanges())
                  {
                      MessageBox.Show("Kayıt işlemi başarılı.");
                      RefreshControls();
                  }
                 
              } 
        }

        private void btnDepoAktar_Click(object sender, EventArgs e)
        {
            
        } 
        private void RefreshControls()
        {
            dgvHareket.DataSource = uow.HareketRep.GetAll();
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = new TextBox();
                    txt.Clear();
                }
                if (item is RadioButton)
                {
                    RadioButton rb = new RadioButton();
                    rb.Checked = false;
                }
            }
            _hareket = null;
        }

        private void btnDepoSec_Click(object sender, EventArgs e)
        {
            frmDepoSec dForm = new frmDepoSec(this);
            dForm.btnDepoAktar.Click += new EventHandler(btnDepoAktar_Click);
            dForm.ShowDialog();
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            frmStokSec sForm = new frmStokSec(this);
            sForm.btnStokAktar.Click += new EventHandler(sForm.btnStokAktar_Click);
            sForm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvHareket.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedRow = dgvHareket.SelectedRows[0].Index;
                    this._hareket = (Hareket)dgvHareket.Rows[selectedRow].DataBoundItem;
                    uow.HareketRep.Delete(_hareket.ID);
                    uow.SaveChanges();
                    RefreshControls();
                }
            }
        }

    }
}
