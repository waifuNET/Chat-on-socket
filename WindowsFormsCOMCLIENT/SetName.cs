using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCOMCLIENT
{
    public partial class SetName : Form
    {
        public SetName()
        {
            InitializeComponent();
        }

        private void SetName_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.nick = richTextBox1.Text;
            this.Close();
        }
    }
}
