using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{

    public class Computadora : Componente
    {
        private List<Componente> _hijos;

        public Computadora(string nombre) : base(nombre)
        {
            _hijos = new List<Componente>();
        }

        public override void AgregarHijo(Componente c)
        {
            _hijos.Add(c);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return _hijos.ToArray();
        }

        public override int ObtenerCosto
        {
            get
            {
                int total = 0;
                foreach (var item in _hijos)
                {
                    total += item.ObtenerCosto;
                }
                return total;
            }
        }
    }
}
