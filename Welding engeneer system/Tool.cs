using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Welding_engeneer_system
{
    public class Tool
    {
        [Serializable]
        public class ProjectTables
        {
            public List<ProjectTable> Tables { get; set; } = new List<ProjectTable>();
        }
        [Serializable]
        public class ProjectTable
        {
            public string TableName { get; set; }
            public string TablePath { get; set; }
            public ProjectTable() 
            {

            }
            public ProjectTable(string TableName, string TablePath)
            {
                this.TableName = TableName;
                this.TablePath = TablePath;
            }
        }
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
        public string ExcelFilePath() 
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel files|*.xls;*.xlsx;*.xlsb|All files (*.*)|*.*";
            openFile.FilterIndex = 0;
            openFile.RestoreDirectory = true;
            openFile.ShowDialog();
            return openFile.FileName;
        }
       
    }
}
