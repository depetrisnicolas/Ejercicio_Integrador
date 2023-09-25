using Entidades;

namespace PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion primerNumero = new Numeracion(50, Numeracion.ESistema.Binario);
            Numeracion segundoNumero = new Numeracion("f", Numeracion.ESistema.Binario);

            Console.WriteLine(primerNumero.Valor);
            Console.WriteLine(primerNumero.Sistema);
            Console.WriteLine(segundoNumero.Valor);
            Console.WriteLine(segundoNumero.Sistema);
            Operacion nuevaOperacion = new Operacion(primerNumero, segundoNumero);
            //Numeracion resultado = nuevaOperacion.Operar('+');
            //Console.WriteLine(resultado.Valor);

            Operacion operacion = new Operacion(primerNumero, segundoNumero);

            //Numeracion tercerNumero = operacion.Operar('/');
            //Console.WriteLine(tercerNumero.Valor);


        }
    }
}