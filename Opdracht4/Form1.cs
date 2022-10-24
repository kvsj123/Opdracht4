using System.Windows.Forms;

namespace Opdracht4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshBtn();
        }

        FouteRij<TeDoen> rij = new FouteRij<TeDoen>();

        private bool BeepGeluid = false;
        private bool PopUp = false;

        private void RefreshRij()
        {
            TextBox_rij.Text = rij.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_tijd.Checked)
            {
                box_tijd.Visible = false;
            }
            else
            {
                box_tijd.Visible = true;
            }
        }

        private async void Plannen(TeDoen taak)
        {
            DateTime ExcecutieTijd = (DateTime)taak.Tijdstip;
            await Task.Delay((int)ExcecutieTijd.Subtract(DateTime.Now).TotalMilliseconds);

            taak.MeeDelen(TextBox_toon, PopUp, BeepGeluid);
        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
            string output = TextBox_informatie.Text;
            string[] informatie = output.Split(" , ");

            TeDoen ToDo = new TeDoen(TextBox_titel.Text, informatie, box_tijd.Value);

            if (CheckBox_tijd.Checked || ToDo.Tijdstip == null)
            {
                rij.Toevoegen(ToDo);
                RefreshRij();
            }
            else if (!CheckBox_tijd.Checked && ToDo.Tijdstip > DateTime.Now)
            {
                Plannen(ToDo);
                
            }
        }

        private void btn_volgende_Click(object sender, EventArgs e)
        {
            rij.Volgende();

            if (rij.Huidig != null)
            { 
                rij.Huidig.MeeDelen(TextBox_toon, PopUp, BeepGeluid);
            }
            else
            {
                MessageBox.Show("Voeg een TeDoen toe!");
            }
        }

        private void btn_verwijderen_Click(object sender, EventArgs e)
        {
            if(rij.Huidig != null)
            {
                rij.Verwijderen();
                RefreshRij();
            }
        }

        private void btn_zetAchteraan_Click(object sender, EventArgs e)
        {
            rij.ZetAchteraan();
            RefreshRij();
        }

        private void refreshBtn()
        {
            if (PopUp == false)
            {
                btn_tb.BackColor = Color.Green;
                btn_mb.BackColor = Color.Red;
            }
            if (PopUp == true)
            {

                btn_tb.BackColor = Color.Red;
                btn_mb.BackColor = Color.Green;
            }
            if (BeepGeluid == false)
            {
                btn_beep.BackColor = Color.Red;
            }
            if (BeepGeluid == true)
            {
                btn_beep.BackColor = Color.Green;
            }
        }

        private void btn_mb_Click(object sender, EventArgs e)
        {
            PopUp = true;
            refreshBtn();
        }

        private void btn_beep_Click(object sender, EventArgs e)
        {
            if (BeepGeluid == true)
            {
                BeepGeluid = false;
            }
            else
            {
                BeepGeluid = true;
            }
            refreshBtn();
        }

        private void TextBox_toon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tb_Click(object sender, EventArgs e)
        {
            PopUp = false;
            refreshBtn();
        }
    }
}