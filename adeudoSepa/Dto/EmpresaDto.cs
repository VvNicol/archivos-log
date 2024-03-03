using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adeudoSepa.Dto
{
    internal class EmpresaDto
    {

        string nifEmpresa = "123456789P";
        string nombreEmpresa = "S.A. CSI1";
        string domicilioEmpresa = "Calle Barbero de Sevilla 1";
        string cpEmpresa = "41006";
        string provinciaEmpresa = "Sevilla";
        string paisEmpresa = "España";

        public string NifEmpresa { get => nifEmpresa;}
        public string NombreEmpresa { get => nombreEmpresa;}
        public string DomicilioEmpresa { get => domicilioEmpresa;}
        public string CpEmpresa { get => cpEmpresa;}
        public string ProvinciaEmpresa { get => provinciaEmpresa;}
        public string PaisEmpresa { get => paisEmpresa;}
    }
}
