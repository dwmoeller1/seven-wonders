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
    public partial class MainForm : Form
    {
        protected static Random random;
        public Game game;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            setup.ShowDialog();
            if (setup.DialogResult == DialogResult.OK)
            {
                game = new Game((int)setup.numberofPlayers.Value);
                setup.Dispose();
                game.GameBoard.MdiParent = this;
                game.GameBoard.WindowState = FormWindowState.Maximized;
                game.StartRound();
            }
            else
                setup.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Game Game { get {return game; } }

        public static Random Random
        { get { return random; } }
    }
}


