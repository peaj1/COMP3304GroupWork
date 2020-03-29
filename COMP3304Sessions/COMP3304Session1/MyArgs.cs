using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public class MyArgs : EventArgs
    {

        public String Data { get; }

        public MyArgs(String data)
        {
            Data = data;
        }
    }
}
