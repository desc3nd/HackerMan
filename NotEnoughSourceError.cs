using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerMan
{
    public partial class NotEnoughSourceError : Form
    {
        public NotEnoughSourceError()
        {
            InitializeComponent();
        }
        /// <summary>
        /// przycisk wyłączający okienko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
