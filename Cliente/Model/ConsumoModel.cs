﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Model
{
    public class ConsumoModel
    {

        public int codigo { get; set; }
        public string codMesa { get; set; }
        public string codProduto { get; set; }
        public string seqAbreMesa { get; set; }
        public DateTime horaPedido { get; set; }
        public ProdutoModel produto { get; set; }

    }
}
