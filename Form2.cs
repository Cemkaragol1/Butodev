using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtkonum.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtm2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtyasi.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtkati.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtoda.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtkıralıkfiyat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtsatılıkfiyat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtkiralıkdurumu.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtsatılıkdurum.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtanlasıalnmısteri.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=konut;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("KonutlarrListele", connection);
                komut.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=konut;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("KonutlarrSil", connection);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@konutID", int.Parse(txtid.Text));

                komut.ExecuteNonQuery();
            }
        }

        private void satınal_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=konut;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("KonutlarrrEklee", connection);
                komut.CommandType = CommandType.StoredProcedure;


                komut.Parameters.AddWithValue("@konutKonumu", Convert.ToString(txtkonum.Text));
                komut.Parameters.AddWithValue("@konutM2", int.Parse(txtm2.Text));
                komut.Parameters.AddWithValue("@konutYasi", int.Parse(txtyasi.Text));
                komut.Parameters.AddWithValue("@konutKat", int.Parse(txtkati.Text));
                komut.Parameters.AddWithValue("@konutOda", int.Parse(txtoda.Text));
                komut.Parameters.AddWithValue("@kiralikFiyati", int.Parse(txtkıralıkfiyat.Text));
                komut.Parameters.AddWithValue("@satilikFiyati", int.Parse(txtsatılıkfiyat.Text));
                komut.Parameters.AddWithValue("@kiralikDurumu", bool.Parse(txtkiralıkdurumu.Text));
                komut.Parameters.AddWithValue("@satilikDurumu", bool.Parse(txtsatılıkdurum.Text));
              


                komut.ExecuteNonQuery();
            }
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=konut;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("KonutlarrrGuncelle", connection);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@konutID", int.Parse(txtid.Text));
                komut.Parameters.AddWithValue("@konutKonumu", Convert.ToString(txtkonum.Text));
                komut.Parameters.AddWithValue("@konutM2", int.Parse(txtm2.Text));
                komut.Parameters.AddWithValue("@konutYasi", int.Parse(txtyasi.Text));
                komut.Parameters.AddWithValue("@konutKat", int.Parse(txtkati.Text));
                komut.Parameters.AddWithValue("@konutOda", int.Parse(txtoda.Text));
                komut.Parameters.AddWithValue("@kiralikFiyati", int.Parse(txtkıralıkfiyat.Text));
                komut.Parameters.AddWithValue("@satilikFiyati", int.Parse(txtsatılıkfiyat.Text));
                komut.Parameters.AddWithValue("@kiralikDurumu", bool.Parse(txtkiralıkdurumu.Text));
                komut.Parameters.AddWithValue("@satilikDurumu", bool.Parse(txtsatılıkdurum.Text));
                komut.Parameters.AddWithValue("@anlasilanMusteriID", int.Parse(txtanlasıalnmısteri.Text));

                komut.ExecuteNonQuery();
            }
        }
    }
}
