using adeudoSepa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adeudoSepa.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string crearContenido(ClienteDto cliente)
        {
            EmpresaDto empresa = new EmpresaDto();

            string contenido = 
                "Diseñar lo de arriba\n" +
                $"Referencia de la orden de domiciliacion: {cliente.ReferenciaOrden}" +
                $"Identificador del acredor: {empresa.NifEmpresa}" +
                "Diseñar lo de abajo\n";

            return contenido;

        }

        public void crearNuevoCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Nombre deudor: ");
            cliente.NombreDeudor = Console.ReadLine();
            Console.WriteLine("Dirección deudor: ");
            cliente.DireccionDeudor = Console.ReadLine();
            Console.WriteLine("CP deudor: ");
            cliente.CpDeudor = Console.ReadLine();
            Console.WriteLine("IBAN deudor: ");
            cliente.IbanDeudor = Console.ReadLine();
            Console.WriteLine("Swift deudor: ");
            cliente.SwiftBancoDeudor = Console.ReadLine();
            Console.WriteLine("Tipo pago: ");
            cliente.TipoPagoDeudor = Convert.ToChar(Console.ReadLine());

            cliente.ReferenciaOrden = siguienteReferencia(listaClientes);

            listaClientes.Add(cliente);

        }

        private long siguienteReferencia(List<ClienteDto> listaClientes)
        {
            int tamanioLista = listaClientes.Count;
            long nuevaReferencia;
            if (tamanioLista > 0)
            {
                nuevaReferencia = listaClientes[tamanioLista - 1].ReferenciaOrden + 1;
            }
            else
            {
                nuevaReferencia = 1;
            }

            return nuevaReferencia;
        }
    }
}
