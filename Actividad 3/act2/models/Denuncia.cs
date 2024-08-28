using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    internal class Denuncia : Incidente
    {
        public Denuncia(Policia p, Persona suj, string motivo) : base(suj, p,motivo)
        {

        }
        public override string VerDescripcion()
        {
            return $"{Environment.NewLine}Denuncia policial, emitida a las {Hora}:{Minuto}" +
                    $"{Environment.NewLine} Motivo:{Motivo}" +
                    $"{Environment.NewLine} Oficial a cargo: {OficialACargo.VerDatos()} " +
                    $"{Environment.NewLine}Sujeto denunciante: {Sujeto.VerDatos()}";
        }
    }
}
