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
    public partial class PlayArea : Panel
    {
        public PlayArea()
        {
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Location = new System.Drawing.Point(76, 78);
            this.Size = new System.Drawing.Size(1275, 511);
        }
    }
}
