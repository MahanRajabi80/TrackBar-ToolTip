using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_16_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------
        ToolTip toolTipAll = new ToolTip();
        //-----------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            int r, g, b;
            r = trackBarRed.Value;
            g = trackBarGreen.Value;
            b = trackBarBlue.Value;
            this.BackColor = Color.FromArgb(r,g,b);
        }
        //-----------------------------------------------------------
        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            this.OnLoad(new EventArgs());
            toolTipAll.SetToolTip(trackBarRed, "R="+trackBarRed.Value.ToString());
        }
        //-----------------------------------------------------------
        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            this.OnLoad(new EventArgs());
            toolTipAll.SetToolTip(trackBarGreen, "G=" + trackBarGreen.Value.ToString());
        }
        //-----------------------------------------------------------
        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            this.OnLoad(new EventArgs());
            toolTipAll.SetToolTip(trackBarBlue, "B=" + trackBarBlue.Value.ToString());
        }
    }
}
