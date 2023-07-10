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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=LAPTOP-8O5MUCC6;Initial Catalog=konut;Integrated Security=True
        private void btngiris_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=konut;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("danısmangiris", connection);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@kullaniciAdi", txtkulanıcıad.Text);
                komut.Parameters.AddWithValue("@sifre", txtsifre.Text);



                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {


                    Form2 ft = new Form2();
                    ft.Show();
                    this.Hide();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }

                dr.Close();
            }
        }
    }
}
