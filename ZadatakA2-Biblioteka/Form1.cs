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

namespace ZadatakA2_Biblioteka
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skola\MATURA\Programiranje\ZadatakA2-Biblioteka\ZadatakA2-Biblioteka\A2.mdf;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        int ID = 0;
        public void PrikaziLV()
        {
            string sqlUpit = "SELECT * FROM Autor";
            SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                listView1.Items.Clear();

                foreach (DataRow red in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(red[0].ToString());
                    item.SubItems.Add(red[1].ToString());
                    item.SubItems.Add(red[2].ToString());
                    var dat = DateTime.Parse(red[3].ToString());
                    item.SubItems.Add(dat.ToString("dd/MM/yyyy"));
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearData()
        {
            textBoxSifra.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxRodjen.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrikaziLV();
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            textBoxSifra.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxIme.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxPrezime.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxRodjen.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void toolStripButtonBrisanje_Click(object sender, EventArgs e)
        {
            if (textBoxSifra.Text != "")
            {
                string sqlUpit = "Delete from Autor where AutorID = @parSifra";
                SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
                komanda.Parameters.AddWithValue("@parSifra", textBoxSifra.Text);

                try
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Podaci o autoru su obrisani!");
                    PrikaziLV();
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
            else
            {
                MessageBox.Show("Niste oznacili autora za brisanje!");
            }
        }

        private void toolStripButtonIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonOAplikaciji_Click(object sender, EventArgs e)
        {
            OAplikaciji form = new OAplikaciji();
            form.Show();
        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza form = new Analiza();
            form.Show();

        }
    }
}
