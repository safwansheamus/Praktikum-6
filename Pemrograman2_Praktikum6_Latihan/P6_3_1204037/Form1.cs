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

namespace P6_3_1204044
{
    public partial class Form1 : Form
    {
        string prodi;
        public Form1()
        {
            InitializeComponent();
            rbJk1.Checked = false;
            rbJk2.Checked = false;
            

            SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra\p6_1204044; initial catalog = P6_1204044; integrated security=true;");

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand("SELECT * FROM msprodi", myConnection);
            SqlDataReader reader;

            reader = myCommand.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Columns.Add("id_prodi", typeof(string));
            myDataTable.Columns.Add("singkatan", typeof(string));
            myDataTable.Load(reader);

            cbProdi.ValueMember = "id_prodi";
            cbProdi.DisplayMember = "singkatan";
            cbProdi.DataSource = myDataTable;

            myConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string npm = tbNpm.Text;
            string nama = tbNama.Text;
            string tgllahir = mcTgllahir.Text;
            string jkelamin = "";
            if (rbJk1.Checked)
            {
                jkelamin = rbJk1.Text;
            }
            if (rbJk2.Checked)
            {
                jkelamin = rbJk2.Text;
            }
            string alamat = tbAlamat.Text;
            string telepon = tbNotelp.Text;
            string prodi = this.prodi;

            SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra\p6_1204044; initial catalog = P6_1204044; integrated security=true;");
            string sql = "INSERT INTO msmhs ([nim],[nama],[tgl_lahir],[jenis_kelamin],[alamat],"+"[telepon],[id_prodi]) VALUES(@npm,@nama,@tgllahir,@jkelamin,@alamat,@telepon,@idprodi)";

            using (SqlConnection Connection = new SqlConnection(@"data source=desktop-l726lra\p6_1204044; initial catalog = P6_1204044; integrated security=true"))
            {
                try
                {
                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand(sql, Connection))
                    {
                        Command.Parameters.Add("@npm", SqlDbType.VarChar).Value = npm;
                        Command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nama;
                        Command.Parameters.Add("@tgllahir", SqlDbType.VarChar).Value = tgllahir;
                        Command.Parameters.Add("@jkelamin", SqlDbType.VarChar).Value = jkelamin;
                        Command.Parameters.Add("@alamat", SqlDbType.VarChar).Value = alamat;
                        Command.Parameters.Add("@telepon", SqlDbType.VarChar).Value = telepon;
                        Command.Parameters.Add("@idprodi", SqlDbType.VarChar).Value = prodi;

                        int rowsAdded = Command.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show("Data berhasil di simpan");
                        else
                            MessageBox.Show("Data tidak tersimpan");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);

                }
            }
        }

        private void cbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.prodi = cbProdi.SelectedValue.ToString();
        }
    }
}
