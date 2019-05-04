using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map2
{
    public static class Class1
    {
      
        public static IList<string> gr = Properties.Resources.gr.Split('-').Reverse().ToList();
        public static IList<string> ger = Properties.Resources.ger.Split('-').Reverse().ToList();
        public static IList<string> it = Properties.Resources.it.Split('-').Reverse().ToList();
        public static IList<string> sw = Properties.Resources.sw.Split('-').Reverse().ToList();
        public static IList<string> gb = Properties.Resources.gb.Split('-').Reverse().ToList();
        public static IList<string> fr = Properties.Resources.fra.Split('-').Reverse().ToList();
        public static IList<string> sp = Properties.Resources.sp.Split('-').Reverse().ToList();
        public static IList<string> rom = Properties.Resources.rom.Split('-').Reverse().ToList();
        public static IList<string> ned = Properties.Resources.ned.Split('-').Reverse().ToList();
        public static IList<string> rus = Properties.Resources.rus.Split('-').Reverse().ToList();
        public static IList<string> ch = Properties.Resources.ch.Split('-').Reverse().ToList();
    }
}
