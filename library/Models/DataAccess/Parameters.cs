using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models.DataAccess
{
    public class Parameters
    {
        public class Parametro
        {
            public string nombre { get; set; }
            public string valor { get; set; }

            public int Type { get; set; }
        }
    }
}
