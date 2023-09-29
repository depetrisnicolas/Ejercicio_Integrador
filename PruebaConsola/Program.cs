using Entidades;

namespace PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion primerNumero = new Numeracion(50, Numeracion.ESistema.Decimal);
            Numeracion segundoNumero = new Numeracion(0, Numeracion.ESistema.Decimal);

            Console.WriteLine(primerNumero.Valor);
            Console.WriteLine(primerNumero.Sistema);
            Console.WriteLine(segundoNumero.Valor);
            Console.WriteLine(segundoNumero.Sistema);
            Operacion nuevaOperacion = new Operacion(primerNumero, segundoNumero);
            Numeracion resultado = nuevaOperacion.Operar('*');
            Console.WriteLine(resultado.Valor);


            //Numeracion tercerNumero = operacion.Operar('/');
            //Console.WriteLine(tercerNumero.Valor);


        }
    }
}