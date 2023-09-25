using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Numeracion;

namespace Entidades
{
    public class Operacion
    {
        //ATRIBUTOS
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        //CONSTRUCTOR
        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        //PROPIEDADES
        public Numeracion PrimerOperando
        {
            get
            {
                return this.primerOperando;
            }
            set 
            {
                this.primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set
            {
                this.segundoOperando = value;   
            }
        }

        //METODO
        public Numeracion Operar(char operador)
        {

            switch (operador)
            {
                case '-':
                    return this.primerOperando - this.segundoOperando;

                case '*':
                    return this.primerOperando * this.segundoOperando;

                case '/':
                    return this.primerOperando / this.segundoOperando;

                default:
                    return this.primerOperando + this.segundoOperando;
            }
        }
    }
}
