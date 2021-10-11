using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glazariy
{
    public class DatabaseWord
    {
        public int Id;
        public string WordName;
        public string Translation;
        public string Description;

        public DatabaseWord(int id, string wordName, string translation, string description)
        {
            this.Id = id;
            this.WordName = wordName;
            this.Translation = translation;
            this.Description = description;
        }
    }
}
