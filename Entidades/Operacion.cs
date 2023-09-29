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
                    if (this.primerOperando == this.segundoOperando)
                    {
                        return this.primerOperando - this.segundoOperando;
                    }
                    else
                    {
                        throw new InvalidOperationException("La operación no es válida para numeraciones con sistemas diferentes.");
                    }
                    

                case '*':
                    if (this.primerOperando == this.segundoOperando)
                    {
                        return this.primerOperando * this.segundoOperando;
                    }
                    else
                    {
                        throw new InvalidOperationException("La operación no es válida para numeraciones con sistemas diferentes.");
                    }

                case '/':
                    if (this.primerOperando == this.segundoOperando)
                    {
                        return this.primerOperando / this.segundoOperando;
                    }
                    else
                    {
                        throw new InvalidOperationException("La operación no es válida para numeraciones con sistemas diferentes.");
                    }

                default:
                    if (this.primerOperando == this.segundoOperando)
                    {
                        return this.primerOperando + this.segundoOperando;
                    }
                    else
                    {
                        throw new InvalidOperationException("La operación no es válida para numeraciones con sistemas diferentes.");
                    }
            }
        }
    }
}
