using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Welding_engeneer_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog OpenExcel = new OpenFileDialog();
            OpenExcel.ShowDialog();
            if (OpenExcel.FileName=="")
            {

            }
            Excel ex = new Excel(OpenExcel.FileName, 1);
            ex.Close();

        }
    }
}
