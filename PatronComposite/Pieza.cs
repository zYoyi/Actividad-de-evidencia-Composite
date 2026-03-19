using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    public class Pieza : Componente
    {
        int _costo;

        public Pieza(string nombre, int costo) : base(nombre)
        {
            _costo = costo;
        }

        public override void AgregarHijo(Componente c)
        {
        }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }

        public override int ObtenerCosto
        {
            get { return _costo; }
        }
    }
}
