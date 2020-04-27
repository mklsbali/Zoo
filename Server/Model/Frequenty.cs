using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Frequenty
    {
        private string name;
        private int val;
        public Frequenty(string name)
        {
            this.name = name;
            val = 1;
        }
        public string getName()
        {
            return name;
        }
        public int getVal()
        {
            return val;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setVal(int val)
        {
            this.val = val;
        }

    }
}
