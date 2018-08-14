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
using Microsoft.VisualBasic;

namespace ncoyapp
{
    public partial class PendaftaranSiswa : Form
    {
        String gender;
        public PendaftaranSiswa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String koneksi = "Server=localhost;Database=pendaftran;tb_pendaftran=root;pass=";
           MySqlConnection conDataBase = new MySqlConnection(koneksi);
            conDataBase.Open();
            string query = "SELECT * FROM tb_pendaftran";
          MySqlCommand showdata = new MySqlCommand(query, conDataBase);
            DataTable data = new DataTable();
            MySqlDataAdapter result = new MySqlDataAdapter(showdata);
            result.Fill(data);
            grid.DataSource = data;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String koneksi = "Server=localhost;Database=pendaftran;tb_pendaftran=root;pass=";
            MySqlConnection conDataBase = new MySqlConnection(koneksi);
            conDataBase.Open();
            try
            {
                String Query =  string.Format("insert into pendaftran.tb_pendaftran values({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", "null", textNama.Text, txtUsername.Text, txtPwd.Text, txtAge.Text, txtNip.Text, gender, tglLahir.Value);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            cmdDatabase.ExecuteNonQuery();
            MessageBox.Show("Data berhasil di input");
            textNama.Text = "";
            txtPwd.Text = "";
            txtAge.Text = "";
            txtNip.Text = "";
            txtUsername.Text = "";
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Laki-laki";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Perempuan";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String koneksi = "Server=localhost;Database=pendaftran;tb_pendaftran=root;pass=";
            MySqlConnection conDataBase = new MySqlConnection(koneksi);
            conDataBase.Open();
            string query = "SELECT * FROM tb_pendaftran";
            MySqlCommand showdata = new MySqlCommand(query,conDataBase);
            DataTable data = new DataTable();
            MySqlDataAdapter result = new MySqlDataAdapter(showdata);
            result.Fill(data);
            grid.DataSource = data;

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String koneksi = "Server=localhost;Database=pendaftran;tb_pendaftaran=root;pass=";
            MySqlConnection conDataBase = new MySqlConnection(koneksi);
            conDataBase.Open();
            String ID = Interaction.InputBox("Masukan ID", "Hapus User");
            string query = "DELETE FROM tb_pendaftran where id = " + ID;
            try
            {
                MySqlCommand delete = new MySqlCommand(query, conDataBase);
                delete.ExecuteNonQuery();
                MessageBox.Show("User berhasil dihapus");
            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String koneksi = "Server=localhost;Database=pendaftran;tb_pendaftran=root;pass=";
            MySqlConnection conDataBase = new MySqlConnection(koneksi);
            conDataBase.Open();
            try
            {
               String Query =  string.Format("update tb_pendaftran SET u_nama ='{0}', u_name='{1}', u_password='{2}', u_age='{3}', u_nip='{4}', u_gender='{5}', ultah='{6}' WHERE id = {7}", textNama.Text, txtUsername.Text, txtPwd.Text, txtAge.Text, txtNip.Text, gender, tglLahir.Value, textID.Text);
               MySqlCommand update = new MySqlCommand(Query, conDataBase);
               update.ExecuteNonQuery();
               MessageBox.Show("Data berhasil di update");
               textNama.Text = "";
               txtPwd.Text = "";
               txtAge.Text = "";
               txtNip.Text = "";
               txtUsername.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtNip_TextChanged(object sender, EventArgs e)
        {

        }

        private void tglLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
