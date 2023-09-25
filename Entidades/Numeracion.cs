using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
namespace Entidades
{
    public class Numeracion
    {
        public enum ESistema
        {
            Decimal, Binario
        }

        //ATRIBUTOS
        private ESistema sistema;
        private double valorNumerico;

        //CONSTRUCTORES
        public Numeracion(double valor, ESistema sistema)
        {
            this.valorNumerico = valor;
            this.sistema = sistema;
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        //PROPIEDADES
        public ESistema Sistema
        {
            get
            {
                return this.sistema;
            }
        }
        public string Valor
        {
            get
            {
                return this.valorNumerico.ToString();
            }

        }

        //METODOS
        private void InicializarValores(string valor, ESistema sistema)
        {
            if (EsBinario(valor) && sistema == ESistema.Binario)
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if (double.TryParse(valor, out double valorDecimal))
            {
                this.valorNumerico = valorDecimal;
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this.Valor;

            }
            else 
            {
                return DecimalABinario(this.Valor);
            }
        }

        private bool EsBinario(string valor)
        {
            string patron = "^[0|1]+$";

            return Regex.IsMatch(valor, patron);
        }

        private double BinarioADecimal(string valor)
        {
            double resultado = 0;
            int cantidadCaracteres = valor.Length;

            foreach (char caracter in valor)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;   
        }

        private string DecimalABinario(int valor)
        {
            string numeroBinario = string.Empty;
            string resultado = string.Empty;
            int resultadoDivision = valor;

            while (true)
            {
                if (resultadoDivision >= 0)
                {
                    int bit = resultadoDivision % 2;
                    resultadoDivision = resultadoDivision / 2;

                    numeroBinario = bit.ToString() + numeroBinario;

                    if (resultadoDivision == 0)
                    {
                        resultado = numeroBinario;
                        break;
                    }
                }
                else
                {
                    resultado = "Número inválido";
                    break;
                }
            }
            return resultado;
        }

        private string DecimalABinario(string valor)
        {
            if (int.TryParse(valor, out int resultado))
            {
                return (DecimalABinario(resultado));
            }
            return "El valor ingresado es inválido";
        }



        //SOBRECARGAS
        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1.Sistema == n2.Sistema;
        }

        public static bool operator != (Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static bool operator == (ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }

        public static bool operator != (ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            if (n1 == n2)
            {
                return new Numeracion(n1.valorNumerico + n2.valorNumerico, n1.Sistema);
            }
            else
            {
                throw new InvalidOperationException("La operación no es válida para numeraciones con sistemas diferentes.");
            }
        }

        public static Numeracion operator - (Numeracion n1, Numeracion n2)
        {
            if (n1 == n2)
            {
                return new Numeracion(n1.valorNumerico - n2.valorNumerico, n1.Sistema);
            }
            else
            {
                throw new InvalidOperationException("La operación no es válida para numeraciones con sistemas diferentes.");
            }
        }

        public static Numeracion operator * (Numeracion n1, Numeracion n2)
        {
            if (n1 == n2)
            {
                return new Numeracion(n1.valorNumerico * n2.valorNumerico, n1.Sistema);
            }
            else
            {
                throw new InvalidOperationException("La operación no es válida para numeraciones con sistemas diferentes.");
            }
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            if (n1 == n2)
            {
                if (n2.valorNumerico != 0)
                {
                    return new Numeracion(n1.valorNumerico / n2.valorNumerico, n1.Sistema);
                }
                else
                {
                    throw new DivideByZeroException("No se puede dividir por 0");
                }
            }
            else
            {
                throw new InvalidOperationException("La operación no es válida para numeraciones con sistemas diferentes.");
            }

        }

    }
}