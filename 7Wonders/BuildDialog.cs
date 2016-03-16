using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BuildDialog : Form
    {
        protected Player player;
        protected Dictionary<Resource, int> buildResources, availableResources, neededResources;
        protected Dictionary<Resource, int> availableResourcesLeft, availableResourcesRight;

        public BuildDialog(Player player, Card card)
        {
            InitializeComponent();
            this.player = player;
            this.card = card;
            availableResources = player.Resources;
            availableResourcesLeft = player.LeftNeighbor.Resources;
            availableResourcesRight = player.RightNeighbor.Resources;
            buildResources = card.BuildCost;
            //populate dictionary and set all values to 0
            neededResources = new Dictionary<Resource, int>();
            for (int i = 0; i < 8; i++)
            {
                Resource r = (Resource)i;
                neededResources[r] = 0;
            }
            CheckNeededResources();

            player.TradesPending.Add(player.LeftNeighbor, 0);
            player.TradesPending.Add(player.RightNeighbor, 0);
        }

        private bool CheckNeededResources()
        {            
            //update display lists of resources available
            btn_TradeLeft.Enabled = false;
            btn_TradeRight.Enabled=false;
            btn_BuildConfirm.Enabled = false;
            lst_RightResources.Text = "";
            lst_LeftResources.Text = "";
            lbl_BuildResources.Text = "";
            foreach (Resource r in availableResourcesLeft.Keys)
                if (availableResourcesLeft[r] > 0)
                    lst_LeftResources.Text += r.ToString() + "(" + availableResourcesLeft[r] + ")" + "\r\n";

            foreach (Resource r in availableResourcesRight.Keys)
                if (availableResourcesRight[r] > 0)
                    lst_RightResources.Text += r.ToString() + "(" + availableResourcesRight[r] + ")" + "\r\n";

            foreach (Resource r in availableResources.Keys)
                if (availableResourcesRight[r] > 0)
                    lbl_BuildResources.Text += r.ToString() + "(" + availableResources[r] + ")" + "\r\n";

            //calculate the needed resources
            foreach (Resource r in Enum.GetValues(typeof(Resource)))
            {
                int x = buildResources[r] - availableResources[r];
                if (x < 0)
                    neededResources[r] = 0;
                else
                    neededResources[r] = x;

                //display the needed available and needed resources
                //if(neededResources[r] > 0)
                    //for(int i=0; i<neededResources[r]; i++)    
                        //lbl_.Items.Add(r.ToString());
            }

            //if there are still resources needed return false
            foreach (var x in neededResources)
                if (x.Value != 0)
                {
                    btn_BuildConfirm.Enabled = false;
                    lbl_Instructions.Text = "Please select a resource to trade.";
                    return false;
                }

            btn_BuildConfirm.Enabled = true;
            lbl_Instructions.Text = "You have all needed resources. \r\nClick Build to proceed or Cancel to choose a different card.";
            return true;

        }

        private void btn_TradeRight_Click(object sender, EventArgs e)
        {
            bool confirm;
            int amount;
            int availableGold = availableResources[Resource.Gold];
            player.CheckTrade(player.RightNeighbor, SelectedResource, availableGold, out confirm, out amount);

            if (confirm)
            {
                player.TradesPending[player.RightNeighbor] += amount;
                availableResources[Resource.Gold] -= amount;
                availableResources[SelectedResource]++;
            }
            else
                lbl_Instructions.Text = "You can't afford that. \r\nPlease select a different neighbor/resource or cancel.";

            CheckNeededResources();
        }

        private void btn_TradeLeft_Click(object sender, EventArgs e)
        {
            bool confirm;
            int amount;
            int availableGold = availableResources[Resource.Gold];
            player.CheckTrade(player.LeftNeighbor, SelectedResource, availableGold, out confirm, out amount);

            if (confirm)
            {
                player.TradesPending[player.LeftNeighbor] += amount;
                availableResources[Resource.Gold] -= amount;
                availableResources[SelectedResource]++;
            }
            else
                lbl_Instructions.Text = "You can't afford that. \r\nPlease select a different neighbor/resource or cancel.";

            CheckNeededResources();
        }

        private void btn_BuildCancel_Click(object sender, EventArgs e)
        {
            player.TradesPending[player.LeftNeighbor] = 0;
            player.TradesPending[player.RightNeighbor] = 0;
        }

        private Resource SelectedResource
        {
            get 
            { 
                string str = (string)neededResourcesListBox.SelectedItem;
                return (Resource)Enum.Parse(typeof(Resource), str);
            }
        }

        private void neededResourcesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neededResourcesListBox.SelectedIndex != -1)
            {
                if (availableResourcesLeft[SelectedResource] > 0)
                    btn_TradeLeft.Enabled = true;
                if (availableResourcesRight[SelectedResource] > 0)
                    btn_TradeRight.Enabled = true;

                if (btn_TradeRight.Enabled || btn_TradeLeft.Enabled)
                    lbl_Instructions.Text = "Choose which neighbor to buy this from.";
                else
                    lbl_Instructions.Text = "Neither neighbor has this resource. Cancel to choose a different card.";
            }
        }

        private void BuildDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
