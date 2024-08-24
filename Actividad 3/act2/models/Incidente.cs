using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    abstract class Incidente
    {
        public Persona Sujeto { get; private set; }
        public Policia OficialACargo { get; private set; }
        public string Motivo {  get; set; }
        public int Hora {  get; set; }
        public int Minuto {  get; set; }
        public int TipoIncidente {  get; private set; }
        public Incidente(Persona sujeto, Policia oficialACargo)
        {
            Sujeto = sujeto;
            OficialACargo = oficialACargo;
        }
        public abstract string VerDescripcion();
    }
}
