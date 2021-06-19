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
    public partial class FormWin : Form
    {
        public FormWin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// funckja wyłączająca okno powiadomień o wygranej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
