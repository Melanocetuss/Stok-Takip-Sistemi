using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace C_sharp_Kerem_Cesur_Odev
{
    public partial class Form1 : Form
    {
        void gridDoldur()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MELANOCETUS\SQLEXPRESS;Initial Catalog=Kerem_Cesur_C#;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select URUN_KODU as 'Ürün Kodu', URUN_TURU as 'Ürün Türü', URUN_MARKASI as 'Ürün Markası', DURUMU as 'Ürün Durumu'," +
                " TOPTAN_FIYAT as 'Alış Fiyatı', KAR_MARJI as 'Kar Marjı', SATIS_FIYATI as 'Satış Fiyatı' from TBL_URUNLER", connection);
            DataSet dataSet = new DataSet();
            
            connection.Open();
            sqlDataAdapter.Fill(dataSet,"TBL_URUNLER");
            
            dgvUrunler.DataSource = dataSet.Tables["TBL_URUNLER"];
            connection.Close();          
        }

        void gridDoldur2()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MELANOCETUS\SQLEXPRESS;Initial Catalog=Kerem_Cesur_C#;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(URUN_KODU) as 'Toplam Ürün' , sum(TOPTAN_FIYAT) as'Maliyet' from TBL_URUNLER", connection);
            DataSet dataSet = new DataSet();

            connection.Open();
            sqlDataAdapter.Fill(dataSet, "TBL_URUNLER");

            dgvToplamUrunSayisi.DataSource = dataSet.Tables["TBL_URUNLER"];
            connection.Close();

        }

        bool UrunSorgulama(string UrunKodu)
        {
            
            SqlConnection connection = new SqlConnection(@"Data Source=MELANOCETUS\SQLEXPRESS;Initial Catalog=Kerem_Cesur_C#;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(*) from TBL_URUNLER where URUN_KODU = '" + txtModelAra.Text + "'" , connection);
            DataSet dataSet = new DataSet();

            connection.Open();
            sqlDataAdapter.Fill(dataSet, "TBL_URUNLER");
            connection.Close();

            if (dataSet.Tables["TBL_URUNLER"].Rows[0][0].ToString() == "0")
            {
                return false;
            }

            else
            {
                return true;
            }
           
        }
        bool UrunSorgulama2(string UrunKodu)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MELANOCETUS\SQLEXPRESS;Initial Catalog=Kerem_Cesur_C#;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(*) from TBL_URUNLER where URUN_KODU = '" + txtModel.Text + "'", connection);
            DataSet dataSet = new DataSet();

            connection.Open();
            sqlDataAdapter.Fill(dataSet, "TBL_URUNLER");
            connection.Close();

            if (dataSet.Tables["TBL_URUNLER"].Rows[0][0].ToString() == "0")
            {
                return false;
            }

            else
            {
                return true;
            }
        }
        
        Urunler urunler = new Urunler();
        public Form1()
        {
            InitializeComponent();
            gridDoldur();
            gridDoldur2();
            
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection connection = new SqlConnection(@"Data Source=MELANOCETUS\SQLEXPRESS;Initial Catalog=Kerem_Cesur_C#;Integrated Security=True");
                connection.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into TBL_URUNLER(URUN_KODU, URUN_TURU, URUN_MARKASI, DURUMU, TOPTAN_FIYAT, KAR_MARJI, SATIS_FIYATI) values('" +                                                    //>_
                int.Parse(txtModel.Text) + "', '" + cbxUrununTuru.SelectedItem.ToString() + "', '" + txtMarka.Text + "', '" + cbxDurumu.SelectedItem.ToString() + "', '" + int.Parse(txtFiyat.Text) + "', '" //>  QUERY
                + int.Parse(txtKarMarji.Text) + "', '" + ((int.Parse(txtFiyat.Text)) + (int.Parse(txtFiyat.Text) * int.Parse(txtKarMarji.Text) / 100)) + "')";                                               //>-

                cmd.Connection = connection;

                cmd.ExecuteNonQuery();

                connection.Close();
                gridDoldur();
                gridDoldur2();

                MessageBox.Show("Başarıyla Eklendi","Ürün Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Ekleme Başarısız", "Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*
            Urun urun = new Urun(cbxUrununTuru.SelectedItem.ToString(), txtMarka.Text, txtModel.Text, cbxDurumu.SelectedItem.ToString(), Convert.ToInt32(txtFiyat.Text), Convert.ToInt32(txtKarMarji.Text));

            bool kontrol = urunler.ekle(urun);

            if (kontrol)
            {             
                MessageBox.Show("Ürün Başarıyla Eklendi", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lsbTumUrunler.Items.Add(urun.listele());
            }

            else
            {
                MessageBox.Show("İşlem Başarısız", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/


        }

        private void txtMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtKarMarji_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void btnSil1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silme istediğinize emin misiniz", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
            {
                if (UrunSorgulama(txtModelAra.Text))
                {
                    try
                    {

                        SqlConnection connection = new SqlConnection(@"Data Source=MELANOCETUS\SQLEXPRESS;Initial Catalog=Kerem_Cesur_C#;Integrated Security=True");
                        connection.Open();


                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "delete from TBL_URUNLER where URUN_KODU = '" + txtModelAra.Text + "'";
                        cmd.Connection = connection;

                        cmd.ExecuteNonQuery();

                        connection.Close();
                        gridDoldur();
                        gridDoldur2();
                        MessageBox.Show("Başarıyla Silindi", "Ürün Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Silme Başarasız", "Ürün Sil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Stokta yok", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                              
            }

            

            /*
            DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz", "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int kontrol = urunler.sil(txtModelAra.Text);
            if (sonuc == DialogResult.Yes)
            {
                if (kontrol!=-1)
                {
                    MessageBox.Show("Ürüm stoktan silindi ", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //lsbTumUrunler.Items.RemoveAt(kontrol);
                    
                }                 
                    
                else
                    MessageBox.Show("İşlem Başarısız", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Güncellemek istediğinize emin misiniz", "Ürün Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                if (UrunSorgulama2(txtModel.Text))
                {
                    try
                    {
                        
                        SqlConnection connection = new SqlConnection(@"Data Source=MELANOCETUS\SQLEXPRESS;Initial Catalog=Kerem_Cesur_C#;Integrated Security=True");
                        connection.Open();


                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "update TBL_URUNLER set URUN_TURU = '" + cbxUrununTuru.SelectedItem.ToString() + "', URUN_MARKASI = '" + txtMarka.Text + "', DURUMU = '" +
                        cbxDurumu.SelectedItem.ToString() + "', " + "TOPTAN_FIYAT = '" + int.Parse(txtFiyat.Text) + "', KAR_MARJI = '" + int.Parse(txtKarMarji.Text) + "', " +
                        "SATIS_FIYATI = '" + ((int.Parse(txtFiyat.Text)) + (int.Parse(txtFiyat.Text) * int.Parse(txtKarMarji.Text) / 100)) + "' where URUN_kODU = '" + txtModel.Text + "'";

                        cmd.Connection = connection;

                        cmd.ExecuteNonQuery();

                        connection.Close();
                        gridDoldur();
                        gridDoldur2();
                        MessageBox.Show("Başarıyla Güncelledi", "Ürün Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Stokta yok", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Stokta yok", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
            /*int guncelle_index = urunler.guncelle(txtModel.Text,Convert.ToInt32(txtFiyat.Text), Convert.ToInt32(txtKarMarji.Text));
            if (guncelle_index != -1)
            {
                MessageBox.Show("Başarıyla Güncellendi" , "Stok" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                //lsbTumUrunler.Items[guncelle_index] = urunler.urunler[guncelle_index].listele();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void dgvUrunler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbxUrununTuru.SelectedItem = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtMarka.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            txtModel.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
            cbxDurumu.SelectedItem = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            txtFiyat.Text = dgvUrunler.CurrentRow.Cells[4].Value.ToString();
            txtKarMarji.Text = dgvUrunler.CurrentRow.Cells[5].Value.ToString();
            

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtModel.Text = "";
            txtMarka.Text = "";
            txtFiyat.Text = "";
            txtKarMarji.Text = "";

        }
    }
}

