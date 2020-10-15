using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welding_engeneer_system
{
    class Specialist
    {
        public Specialist()
        {

        }
        public Image SpecialistPhoto(string specialistName)
        {
            Image SpecialistPhoto = Metafile.FromFile(@"\\veles-srv46-fs\Велесстрой\Служба сварочно-монтажных работ\ОГС\004-qualifications\02. Аттестационное удостоверение сварщиков\Фото сварщиков\новое фото сварщиков\"+specialistName);
            return SpecialistPhoto;
        }        
    }
}
