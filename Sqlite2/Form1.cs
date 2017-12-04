using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SLQTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connection c = new Connection();
            c.OpenConnection();
            if (c.IsCon())
            {
                label1.Text = "Connected";

            }
            else
            {
                label1.Text = "Not Connected";
            }
        }
    }
}
