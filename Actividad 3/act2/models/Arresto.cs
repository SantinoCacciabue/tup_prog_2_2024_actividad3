using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    internal class Arresto : Incidente
    {
        public Arresto(Policia p, Persona suj) : base(suj, p)
        {

        }
        public override string VerDescripcion()
        {
            return $"Orden de arresto, emitida a las {Hora}:{Minuto}" +
                    $" Motivo:{Motivo}" +
                    $" Oficial a cargo: {OficialACargo.VerDatos()} " +
                    $"Sujeto a arrestar: {Sujeto.VerDatos()} " +
                    $"Orden: Por la presente se ordena el arresto inmediato de {Sujeto.VerDatos()} El Agente {OficialACargo.VerDatos()} está autorizado a proceder con el arresto conforme a las leyes y regulaciones aplicadas";
        }
    }
}
