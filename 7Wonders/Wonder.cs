using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Wonder : PictureBox, System.ComponentModel.ISupportInitialize
    {
        public Wonder()
        {

        }

        public string WonderName { get; set; }

        public int Stage { get; set; }
    }
}
