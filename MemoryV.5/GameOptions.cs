using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryV._5
{
    public class GameOptions
    {
        private string selectedIconSet = "kapsyler";

        public string SelectedIconSet
        {
            get { return selectedIconSet; }
            set { selectedIconSet = value; }
        }
        private List<string> availibleIconSets = new List<string>()
        {
            "misc",
            "kapsyler",
            "frukt"
        };

        public List<string> AvailibleIconSets
        {
            get { return availibleIconSets; }
        }
        public GameOptions()
        {

        }
    }
}
