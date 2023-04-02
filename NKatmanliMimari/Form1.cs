using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> personelListesi = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = personelListesi.ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel entp = new EntityPersonel();
            entp.Ad = txtAd.Text;
            entp.Soyad = txtSoyad.Text;
            entp.Sehir = txtSehir.Text;
            entp.Maas = short.Parse(txtMaas.Text);
            entp.Gorev = txtGorev.Text;
            LogicPersonel.LLPersonelInsert(entp);
            btnListele_Click(this, null);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel entp = new EntityPersonel();
            entp.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPersonelSil(entp.Id);
            btnListele_Click(this, null);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel entp = new EntityPersonel();
            entp.Id = Convert.ToInt32(textBox1.Text);
            entp.Ad = txtAd.Text;
            entp.Soyad = txtSoyad.Text;
            entp.Gorev = txtGorev.Text;
            btnListele_Click(this, null);
            entp.Sehir = txtSehir.Text;
            entp.Maas = short.Parse(txtMaas.Text);
            LogicPersonel.LLPersonelGuncelle(entp);
        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textBox1.Text = dataGridView1[0, rowIndex].Value.ToString();
            txtAd.Text = dataGridView1[1, rowIndex].Value.ToString();
            txtSoyad.Text = dataGridView1[2, rowIndex].Value.ToString();
            txtGorev.Text = dataGridView1[3, rowIndex].Value.ToString();
            txtSehir.Text = dataGridView1[4, rowIndex].Value.ToString();
            txtMaas.Text = dataGridView1[5, rowIndex].Value.ToString();
        }
    }
}
