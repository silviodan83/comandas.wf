﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.Wf.Modelos
{
    internal class PedidoCozinha
    {
        public int Id { get; set; }
        public int ComandaId { get; set; }
        public int SituacaoId { get; set; }

    }
}
