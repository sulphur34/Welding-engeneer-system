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
using System.Xml.Serialization;

namespace Welding_engeneer_system
{
    public partial class FilePathStorage : Form
    {
        public FilePathStorage()
        {
            InitializeComponent();
        }

        private void bFilePath_Click(object sender, EventArgs e)
        { 
            Tool tool = new Tool();
            string filepath = tool.ExcelFilePath();
            if (filepath.Length > 0)
            {
                tFilePath.Text = filepath;
                if (cbTableName.Text.Length == 0)
                {
                    cbTableName.Focus();
                    cbTableName.DroppedDown = true;
                }
            }
            else
            {
                tFilePath.Clear();
            }
        }

        private void bToMemory_Click(object sender, EventArgs e)
        {
            Tool.ProjectTable Table = new Tool.ProjectTable(cbTableName.Text,tFilePath.Text);
            ListViewItem LVI = new ListViewItem(Table.TableName);
            LVI.Tag = Table;
            LVI.SubItems.Add(Table.TablePath);
            lvTables.Items.Add(LVI); 
        }

        private void SerealizeXML(Tool.ProjectTables projectTables)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Tool.ProjectTables));
            using (FileStream fs = new FileStream("ProjectTablesPath.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, projectTables);
            }
        }
        private Tool.ProjectTables DeserializeXML()
        {

            XmlSerializer xml = new XmlSerializer(typeof(Tool.ProjectTables));
            using (FileStream fs = new FileStream("ProjectTablesPath.xml", FileMode.OpenOrCreate))
            {
                return (Tool.ProjectTables)xml.Deserialize(fs);
            }

        }

        private void bSaveTablePath_Click(object sender, EventArgs e)
        {
            Tool.ProjectTables Tablepath = new Tool.ProjectTables();
            foreach (ListViewItem item in lvTables.Items)
            {
                if (item.Tag != null)
                {
                    Tablepath.Tables.Add((Tool.ProjectTable)item.Tag);
                }
                SerealizeXML(Tablepath);
            }
        }
        private void Add(Tool.ProjectTable projectTable)
        {
            ListViewItem LVI = new ListViewItem(projectTable.TableName);
            LVI.Tag = projectTable;
            LVI.SubItems.Add(projectTable.TablePath);
            lvTables.Items.Add(LVI);
        } 
        private void FilePathStorage_Load(object sender, EventArgs e)
        {
            Tool.ProjectTables projectTables = DeserializeXML();

            foreach (Tool.ProjectTable projectTable in projectTables.Tables)
            {
                Add(projectTable);
            }
        }
    }
}
