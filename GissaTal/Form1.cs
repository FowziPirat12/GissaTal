namespace GissaTal
{
    public partial class Form1 : Form
    {

        int datornstal;
        int antalgissningar;
        public Form1()
        {
            InitializeComponent();

            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);

            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0]; 


        }

        private void lblSpelData_Click(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornstal = slump.Next(1, störst + 1);

            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornstal.Text = "....";

            antalgissningar = 0;

        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalgissningar++;
            string Gissa = tbxGissa.Text;
            int gissatal = int.Parse(Gissa);

            if (gissatal == datornstal)
            {
                lblResultat.Text = "Du gissa rätt efter " + antalgissningar + " försök";
                gbxSpelet.Enabled = false; 
                btnSpelaIgen.Enabled = true;

                lblDatornstal.Text = datornstal.ToString();
                tbxMinaResultat.AppendText(antalgissningar + " försök\n");
            }

            else if (gissatal < datornstal)
            {
                lblResultat.Text = "Försöksök igen, lågt svar";

            }

            else 
            {
                lblResultat.Text = "Försök igen, högt svar";
            }
        }


    }
}