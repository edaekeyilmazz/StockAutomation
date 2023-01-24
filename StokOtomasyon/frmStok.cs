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
    public partial class frmStok : Form
    {
        Stok _stok;
        IUnitOfWork uow;
        public frmStok(IUnitOfWork _uow)
        {
            InitializeComponent();
            this.uow = _uow;
        }

        public frmStok(IUnitOfWork _uow, Stok stok)
        {
            InitializeComponent();
            _stok = stok;
            this.uow = _uow;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //UPDATE İşlemi
            if (_stok != null && _stok.ID != Guid.Empty)
            {
                _stok.StokAd = txtAdi.Text;
                _stok.StokKod = txtKodu.Text;
                _stok.AlisFiyat = string.IsNullOrEmpty(txtAlis.Text) ? 0 : decimal.Parse(txtAlis.Text);
                _stok.SatisFiyat = string.IsNullOrEmpty(txtSatis.Text) ? 0 : decimal.Parse(txtSatis.Text);
                _stok.ModifiedDate = DateTime.Now;
                uow.StokRep.Update(_stok);
                if (uow.SaveChanges())
                {
                    MessageBox.Show("Güncelleme işlemi başarılı.");
                }
                RefreshControls();
            }

            //INSERT İşlemi
            else
            {
                Stok stok = new Stok();
                stok.StokAd = txtAdi.Text;
                stok.StokKod = txtKodu.Text;
                stok.AlisFiyat = string.IsNullOrEmpty(txtAlis.Text) ? 0 : decimal.Parse(txtAlis.Text);
                stok.SatisFiyat = string.IsNullOrEmpty(txtSatis.Text) ? 0 : decimal.Parse(txtSatis.Text);
                stok.CreatedDate = DateTime.Now;
                uow.StokRep.Insert(stok);
                if (uow.SaveChanges())
                {
                    MessageBox.Show("Kayıt işlemi başarılı.");
                }
                RefreshControls();
            }
        }

        private void RefreshControls()
        {
            dgvStok.DataSource = uow.StokRep.GetAll();
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = new TextBox();
                    txt.Clear();
                }
            }
            _stok = null;
        }

        private void dgvStok_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStok.SelectedRows.Count > 0)
            {
                _stok = (Stok)dgvStok.SelectedRows[0].DataBoundItem;
                txtAdi.Text = _stok.StokAd;
                txtKodu.Text = _stok.StokKod;
                txtAlis.Text = _stok.AlisFiyat.ToString();
                txtSatis.Text = _stok.SatisFiyat.ToString();
            }
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            dgvStok.AutoGenerateColumns = false;
            RefreshControls();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (dgvStok.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Some Title", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedRow = dgvStok.SelectedRows[0].Index;
                    this._stok = (Stok)dgvStok.Rows[selectedRow].DataBoundItem;
                    uow.StokRep.Delete(_stok.ID);
                    uow.SaveChanges();
                    RefreshControls();
                }
            }

        }

    }
}
