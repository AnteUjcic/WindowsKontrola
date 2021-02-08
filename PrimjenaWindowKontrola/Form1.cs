using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWindowKontrola
{
    public partial class FormaProgram : Form
    {
        public FormaProgram()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RunProgram_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Paint") {

                System.Diagnostics.Process.Start(@"C:\windows\system32\mspaint.exe");
            } else
            {
                System.Diagnostics.Process.Start(@"C:\windows\system32\notepad.exe");
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
                groupBox1.Visible = false;
            else
                groupBox1.Visible = true;

        }

        private void FormaProgram_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtProgramClear_TextChanged(object sender, EventArgs e)
        {
          
            }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProgramClear.Text = " ";
            textBox1.Text = " ";
        }
    }
}
