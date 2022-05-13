using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Tools.FormComms
{
    public interface ICommPedidoCliente
    {
        public void RefeshDir(ClienteEntity cliente);

    }
}
