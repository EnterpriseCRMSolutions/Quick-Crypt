using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BradCrypt
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void maskedTextBoxKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.passCode = maskedTextBoxKey.Text;
                this.Close();
            }
        }

        private void maskedTextBoxKey_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public string passCode = "";
    }
}
