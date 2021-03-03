using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MaikPasswordManager
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int left,
        int top,
        int right,
        int bottom,
        int width,
        int height);
        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Password-");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("-Cleared-");
        }
    }
}
