using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    internal class Arresto : Incidente
    {
        public Arresto(Policia p, Persona suj, string motivo) : base(suj, p, motivo)
        {

        }
        public override string VerDescripcion()
        {
            return $"{Environment.NewLine}Orden de arresto, emitida a las {Hora}:{Minuto}" +
                    $"{Environment.NewLine} Motivo:{Motivo}" +
                    $"{Environment.NewLine} Oficial a cargo: {OficialACargo.VerDatos()} " +
                    $"{Environment.NewLine}Sujeto a arrestar: {Sujeto.VerDatos()} " +
                    $"{Environment.NewLine}Orden: Por la presente se ordena el arresto inmediato de {Sujeto.VerDatos()} El Agente {OficialACargo.VerDatos()} está autorizado a proceder con el arresto conforme a las leyes y regulaciones aplicadas";
        }
    }
}
