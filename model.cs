using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fid { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
