using System;
using System.Windows.Forms;

namespace MorraCinese
{
    public partial class Form1 : Form
    {
        private MorraCinese giocataComputer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            ButtonGiocateEnabled(true);
            btnNuovo.Enabled = false;
            lblGiocataComputer.Text = "";
            lblVincitore.Text = "";
        }

        private void ButtonGiocateEnabled(bool enabled)
        {
            btnSasso.Enabled = enabled;
            btnCarta.Enabled = enabled;
            btnForbici.Enabled = enabled;
        }

        private void btnSasso_Click(object sender, EventArgs e)
        {
            StampaGiocataComputerEVincitore(0);
        }

        private void StampaGiocataComputerEVincitore(MorraCinese giocataGiocatore)
        {
            lblGiocataComputer.Text = Convert.ToString(giocataComputer);
            Vincitore vincitore = ControllaVincitore(giocataComputer, MorraCinese.Sasso);
            lblVincitore.Text = Convert.ToString(vincitore);
            ButtonGiocateEnabled(false);
            btnNuovo.Enabled = true;
        }

        private Vincitore ControllaVincitore(MorraCinese giocataComputer, MorraCinese giocataGiocatore)
        {
            return Vincitore.Giocatore;
        }
    }
}
