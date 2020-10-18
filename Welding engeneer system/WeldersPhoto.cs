using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        String mypath = @"\\veles-srv46-fs\Велесстрой\Служба сварочно-монтажных работ\ОГС\004-qualifications\02. Аттестационное удостоверение сварщиков\Фото сварщиков\новое фото сварщиков\";
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Specialist spec = new Specialist();
            pbFotoWelder.Image = spec.SpecialistPhoto(comboBox1.SelectedValue.ToString());
            pbFotoWelder.SizeMode = PictureBoxSizeMode.StretchImage;
            comboBox1.SelectionStart = comboBox1.Text.Length;
        }
        private void comboBox1_Enter(object sender, EventArgs e)
        {
            String mypath = @"\\veles-srv46-fs\Велесстрой\Служба сварочно-монтажных работ\ОГС\004-qualifications\02. Аттестационное удостоверение сварщиков\Фото сварщиков\новое фото сварщиков\";
            List<string> filelist = (from a in Directory.GetFiles(mypath) select Path.GetFileName(a).Replace(".jpg", "")).ToList();
            comboBox1.DataSource = filelist;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                comboBox1.DataSource = finallist;
                comboBox1.DroppedDown = true;
            }

        }
    }
}
