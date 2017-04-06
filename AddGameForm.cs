using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChessClubManager
{
    public partial class AddGameForm : Form
    {
        ChessClubManager manager;

        public AddGameForm(ChessClubManager m)
        {
            InitializeComponent();
            manager = m;
            updateListView();
            if (whiteList.Items.Count > 0)
                whiteList.Items[0].Selected = true;
            if (blackList.Items.Count > 0)
                blackList.Items[0].Selected = true;
        }


        private void updateListView()
        {
            foreach (Player newPlayer in manager.rankPlayers())
            {
                String addString = newPlayer.firstName + " " + newPlayer.lastName;

                ListViewItem addPlayer = new ListViewItem(addString);
                whiteList.Items.Add(addPlayer);
            }

            foreach (Player newPlayer in manager.rankPlayers())
            {
                String addString = newPlayer.firstName + " " + newPlayer.lastName;

                ListViewItem addPlayer = new ListViewItem(addString);
                blackList.Items.Add(addPlayer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
