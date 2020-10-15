using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welding_engeneer_system
{
    public partial class WeldersPhoto : Form
    {
        
        public WeldersPhoto()
        {
            InitializeComponent();
        }

        private void WeldersPhoto_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            String mypath = @"\\veles-srv46-fs\Велесстрой\Служба сварочно-монтажных работ\ОГС\004-qualifications\02. Аттестационное удостоверение сварщиков\Фото сварщиков\новое фото сварщиков\";
            List<string> filelist = (from a in Directory.GetFiles(mypath) select Path.GetFileName(a)).ToList();
            comboBox1.DataSource = filelist;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Specialist spec = new Specialist();
            pbFotoWelder.Image = spec.SpecialistPhoto(comboBox1.SelectedValue.ToString());
            pbFotoWelder.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
