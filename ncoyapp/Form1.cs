using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ncoyapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void m_Click(object sender, EventArgs e)
        {
            try
            {
                String koneksi = "Server=localhost;Database=pendaftran;tb_pendaftran=root;pass=";
                MySqlConnection conn = new MySqlConnection(koneksi);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_pendaftran WHERE u_name='" + textUsername.Text + "' AND u_pasSword='" + textpass.Text+"'", conn);
                MySqlDataReader result = cmd.ExecuteReader();
                result.Read();
                if(result.HasRows){
                    PendaftaranSiswa main = new PendaftaranSiswa();
                    main.Show();
                    this.Hide();
                }else{
                    MessageBox.Show("Username / password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                String koneksi = "Server=localhost;Database=pendaftran;tb_pendaftran=root;pass=";
                MySqlConnection conn = new MySqlConnection(koneksi);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_pendaftran WHERE u_name='" + textUsername.Text + "' AND u_pasSword='" + textpass.Text + "'", conn);
                MySqlDataReader result = cmd.ExecuteReader();
                result.Read();
                if (result.HasRows)
                {
                    PendaftaranSiswa main = new PendaftaranSiswa();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username / password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
