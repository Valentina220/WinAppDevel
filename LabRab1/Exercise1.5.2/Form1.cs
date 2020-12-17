using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Course124.Exercise1._5._3
{
    public partial class GreenForm : Form
    {
        public GreenForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            //myPath.AddRectangle(0, 0, this.Width, this.Height);
            myPath.AddLines(new[]
           {
                 new Point(0, this.Height / 2),
                 new Point(this.Width / 2, 0),
                 new Point(this.Width, this.Height / 2),
                 new Point(this.Width / 2, this.Height)
             });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
