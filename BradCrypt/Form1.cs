using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BradCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            var p = new Password();
            p.ShowDialog();
            passcode = p.passCode;
            if (passcode == "")
            {
                Application.Exit();
                return;
            }

            int magnitude = 0;
            foreach (char c in passcode)
                magnitude += (int)c;
            var by = File.ReadAllBytes(Program.filePath);
            for (int i = by.Length-1; i>=0; --i)
            {
                magnitude += (int)(passcode[i % passcode.Length]);
                int offset = magnitude * (i + 1);
                by[i] = (byte)(((int)by[i] + offset)%256);
            }
            baseText = System.Text.Encoding.ASCII.GetString(by);
            textBoxMain.Text = baseText;
        }

        string passcode = "";
        string baseText = "";

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBoxMain.Text != baseText)
            {
                var res = MessageBox.Show("Do you want to save?", "", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    int magnitude = 0;
                    foreach (char c in passcode)
                        magnitude += (int)c;
                    var by = System.Text.Encoding.ASCII.GetBytes(textBoxMain.Text);
                    for (int i = by.Length - 1; i >= 0; --i)
                    {
                        magnitude += (int)(passcode[i % passcode.Length]);
                        int offset = magnitude * (i + 1);
                        by[i] = (byte)(((int)by[i] - offset) % 256);
                    }
                    File.WriteAllBytes(Program.filePath, by);
                }
                else if (res == DialogResult.No)
                {
                    // Do nothing
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
