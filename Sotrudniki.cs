using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace курсовая_работа_Дзякун
{
    public partial class Sotrudniki
    {
        public int id_сотрудника {  get; set; }
        public string Фамилия {  get; set; }
        public string Имя {  get; set; }
        public string Отчество {  get; set; }
        public string Фото {  get; set; }
        [NotMapped]
        public Image Picture
        {
            get
            {
                if (!string.IsNullOrEmpty(Фото))
                {
                    if (File.Exists(Фото))
                        return Image.FromFile(Фото);
                }
                return null;
            }
        }
    }
}
