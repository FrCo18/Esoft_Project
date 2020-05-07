using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            //if (FormAuthorization.users.type == "agent")
            //{
            //    buttonOpenAgents.Visible = false;
            //    buttonOpenRealEstates.Location = new Point(2, buttonOpenRealEstates.Location.Y);
            //    buttonOpenSupplys.Location = new Point(2, buttonOpenSupplys.Location.Y);
            //    buttonOpenDemands.Location = new Point(2, buttonOpenDemands.Location.Y);
            //    buttonOpenDeals.Location = new Point(2, buttonOpenDeals.Location.Y);
            //}
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            FormAgents formAgents = new FormAgents();
            formAgents.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            FormRealEstate realEstate = new FormRealEstate();
            realEstate.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            FormSupply formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenDemands_Click_1(object sender, EventArgs e)
        {
            FormDemandSet formDemand = new FormDemandSet();
            formDemand.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            FormDeal formDeal = new FormDeal();
            formDeal.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (FormAuthorization.users.type == "admin")
            {
                buttonOpenAgents.Visible = true;
                buttonOpenRealEstates.Location = new Point(2, buttonOpenRealEstates.Location.Y + 52);
                buttonOpenSupplys.Location = new Point(2, buttonOpenSupplys.Location.Y + 52);
                buttonOpenDemands.Location = new Point(2, buttonOpenDemands.Location.Y + 52);
                buttonOpenDeals.Location = new Point(2, buttonOpenDeals.Location.Y + 52);
            }
            if (FormAuthorization.users.type == "agent")
            {
                buttonOpenAgents.Visible = false;
                buttonOpenRealEstates.Location = new Point(2, buttonOpenRealEstates.Location.Y);
                buttonOpenSupplys.Location = new Point(2, buttonOpenSupplys.Location.Y);
                buttonOpenDemands.Location = new Point(2, buttonOpenDemands.Location.Y);
                buttonOpenDeals.Location = new Point(2, buttonOpenDeals.Location.Y);
            }

            //else if (FormAuthorization.users.type == "admin")
            //{
            //    buttonOpenAgents.Visible = true;
            //    buttonOpenRealEstates.Location = new Point(2, buttonOpenRealEstates.Location.Y + 52);
            //    buttonOpenSupplys.Location = new Point(2, buttonOpenSupplys.Location.Y + 52);
            //    buttonOpenDemands.Location = new Point(2, buttonOpenDemands.Location.Y + 52);
            //    buttonOpenDeals.Location = new Point(2, buttonOpenDeals.Location.Y+ 52);
            //}
        }
    }
}
