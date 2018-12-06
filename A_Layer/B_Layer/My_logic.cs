using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D_LAYER;
namespace B_LAYER
{

    public class My_logic
    {
        public string logic(string m, int n)
        {
            data_handler d = new data_handler();
            return d.datasave(m, n);
        }
    }

}
