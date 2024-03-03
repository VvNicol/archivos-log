using adeudoSepa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adeudoSepa.Servicios
{
    internal interface OperativaInterfaz
    {

        public void crearNuevoCliente(List<ClienteDto> listaclientes);

        public string crearContenido(ClienteDto cliente);

    }
}
