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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZadatakA2_Biblioteka
{
    public partial class Analiza : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skola\MATURA\Programiranje\ZadatakA2-Biblioteka\ZadatakA2-Biblioteka\A2.mdf;Integrated Security=True;");

        public Analiza()
        {
            InitializeComponent();
        }

        public void PopuniCB()
        {
            string sqlUpit = "SELECT AutorID, CONCAT(Ime, ' ', Prezime) as ImePrezime FROM Autor";
            SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                comboBoxAutor.DataSource = dt;
                comboBoxAutor.DisplayMember = "ImePrezime";
                comboBoxAutor.ValueMember = "AutorID";
                comboBoxAutor.SelectedItem = null;
                comboBoxAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            PopuniCB();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            /*
                string sql = "SELECT YEAR(DatumUzimanja) as Godina, " +
                "COUNT(DatumUzimanja) as Broj " +
                "FROM Na_Citanju, Knjiga, Napisali " +
                "WHERE Na_Citanju.KnjigaID = Knjiga.KnjigaID " +
                "AND Knjiga.KnjigaID = Napisali.KnjigaID " +
                "AND Napisali.AutorID = @param1 " +
                "AND Year(DatumUzimanja) BETWEEN @param3 AND @param2  " +
                "GROUP BY YEAR(DatumUzimanja)";
            SqlCommand komanda = new SqlCommand(sql, konekcija);
            komanda.Parameters.AddWithValue("@param1", comboBoxAutor.SelectedValue);
            komanda.Parameters.AddWithValue("@param2", DateTime.Now.Year);
            komanda.Parameters.AddWithValue("@param3", DateTime.Now.AddYears((int)-numericUpDown1.Value).Year);
             */
            string sqlUpit = "Select YEAR(DatumUzimanja) as Godina, count(DatumUzimanja) as Broj " +
                "from Na_Citanju " +
                "inner join Knjiga on Knjiga.KnjigaID = Na_Citanju.KnjigaID " +
                "inner join Napisali on Napisali.KnjigaID = Knjiga.KnjigaID " +
                "where Napisali.AutorID = @parSifra and " +
                "YEAR(DatumUzimanja) between @parOd and @parDo " +
                "group by YEAR(DatumUzimanja)";
            SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
            komanda.Parameters.AddWithValue("@parSifra", comboBoxAutor.SelectedValue);
            komanda.Parameters.AddWithValue("@parOd", DateTime.Now.AddYears((int)-numericUpDownPeriod.Value).Year);
            komanda.Parameters.AddWithValue("@parDo", DateTime.Now.Year);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                chart1.DataSource = dt;
                chart1.Series[0].XValueMember = "Godina";
                chart1.Series[0].YValueMembers = "Broj";
                chart1.Series[0].IsValueShownAsLabel = true;
                //chart1.Series[0].Color = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
