using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Model
{
    public class MesaModel
    {
        public int codigo { get; set; }
        public int numero { get; set; }
        public string status { get; set; }
        public string seqAbreMesa { get; set; }

    }

}
