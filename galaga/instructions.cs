using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galaga
{
    public partial class instructions : UserControl
    {
        public instructions()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new menuScreen());
        }
    }
}
