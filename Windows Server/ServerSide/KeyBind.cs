using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSide
{
    public partial class KeyBind : Form
    {
        public KeyBind()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save keybind
            this.Close();
        }

        private void KeyBind_Load(object sender, EventArgs e)
        {

        }
    }
}
