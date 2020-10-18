using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Welding_engeneer_system
{
    class Tool
    {
        public Tool()
        {

        }
        public List<string> FindItemInList(List<string> inputlist, string inputstring)
        {
            //List<string> filelist = (from a in Directory.GetFiles(mypath) select Path.GetFileName(a).Replace(".jpg", "")).ToList();
            List<string> finallist = new List<string>();
            Regex regex = new Regex(inputstring);
            for (int i = 0; i < inputlist.Count(); i++)
            {
                if (regex.IsMatch(inputlist[i]))
                {
                    finallist.Add(inputlist[i]);
                }

            }
            return finallist;
        }
        public Image ImageByName(string imageName)
        {
            Image Image = Metafile.FromFile(@"\\veles-srv46-fs\Велесстрой\Служба сварочно-монтажных работ\ОГС\004-qualifications\02. Аттестационное удостоверение сварщиков\Фото сварщиков\новое фото сварщиков\" + imageName + ".jpg");
            return Image;
        }

    }
}
