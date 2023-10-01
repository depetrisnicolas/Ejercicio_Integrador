using Entidades;

namespace PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion primerNumero = new Numeracion(20, ESistema.Decimal);
            Numeracion segundoNumero = new Numeracion("10", ESistema.Decimal);

            Console.WriteLine("PRIMER OPERADOR: ");
            Console.WriteLine(primerNumero.Valor);
            Console.WriteLine("\nSEGUNDO OPERADOR: ");
            Console.WriteLine(segundoNumero.Valor);
 
            Operacion nuevaOperacion = new Operacion(primerNumero, segundoNumero);
            Numeracion resultado = nuevaOperacion.Operar('+');

            Console.WriteLine("\nRESULTADO: ");
            Console.WriteLine(resultado.Valor);
            Console.WriteLine($"\nCONVERTIR A: {ESistema.Binario}");
            Console.WriteLine(resultado.ConvertirA(ESistema.Binario));

        }
    }
}