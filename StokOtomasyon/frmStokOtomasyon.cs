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
    public partial class frmStokOtomasyon : Form
    {
        public frmStokOtomasyon()
        {
            InitializeComponent();
        }

        private void tsSubStok_Click(object sender, EventArgs e)
        {
            UnitOfWork uow = new UnitOfWork();
            frmStok sForm = new frmStok(uow);
            sForm.ShowDialog();
        }

        private void tsSubDepo_Click(object sender, EventArgs e)
        {
            UnitOfWork uow = new UnitOfWork();
            frmDepo dForm = new frmDepo(uow);
            dForm.ShowDialog();
        }

        private void tsSubHareket_Click(object sender, EventArgs e)
        {
            UnitOfWork uow = new UnitOfWork();
            frmHareket hForm = new frmHareket(uow);
            hForm.ShowDialog();
        }
    }
}
