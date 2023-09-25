using Entidades;

namespace PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion primerNumero = new Numeracion("f", Numeracion.ESistema.Decimal);
            Numeracion segundoNumero = new Numeracion("f", Numeracion.ESistema.Decimal);

            Console.WriteLine(primerNumero.Valor);
            Console.WriteLine(segundoNumero.Valor);

            Operacion nuevaOperacion = new Operacion (primerNumero, segundoNumero);
            Numeracion resultado = nuevaOperacion.Operar('/');
            Console.WriteLine(resultado.ConvertirA(Numeracion.ESistema.Decimal));


            //Numeracion resultadoSuma = primerNumero / segundoNumero;
            //Console.WriteLine(resultadoSuma.Valor);

            //Operacion operacion = new Operacion(primerNumero, segundoNumero);

            //Numeracion tercerNumero = operacion.Operar('/');
            //Console.WriteLine(tercerNumero.Valor);

            //double nuevoNumero = Numeracion.BinarioADecimal("f");
            //Console.WriteLine(nuevoNumero.ToString());

        }
    }
}