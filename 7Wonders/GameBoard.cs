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
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        public PlayArea PlayArea
        {
            get { return playArea; }
        }

        public FlowLayoutPanel HandArea
        {
            get { return handArea; }
        }

        public string Instructions
        {
            set { instructions.Text = value; }
        }

        public Button Btn_Discard
        {
            get { return btn_discard; }
        }

        public Button Btn_Wonder
        {
            get { return btn_Wonder; }
        }

        public Button Btn_Cancel
        {
            get { return btn_Cancel; }
        }

        public Button Btn_Build
        {
            get { return btn_Build; }
        }

        public Panel CardPlayButtons
        {
            get { return cardPlayButtons; }
        }

        public string ResourceInfo
        {
            set { resourceInfo.Text = value; }
        }
    }
}
