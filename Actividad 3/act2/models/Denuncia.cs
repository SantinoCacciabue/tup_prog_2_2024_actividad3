using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    internal class Denuncia : Incidente
    {
        public Denuncia(Policia p, Persona suj) : base(suj, p)
        {

        }
        public override string VerDescripcion()
        {
            return $"Denuncia policial, emitida a las {Hora}:{Minuto}" +
                    $" Motivo:{Motivo}" +
                    $" Oficial a cargo: {OficialACargo.VerDatos()} " +
                    $"Sujeto denunciante: {Sujeto.VerDatos()}";
        }
    }
}
