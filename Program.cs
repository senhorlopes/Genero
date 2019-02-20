using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var genero = new Genero();
            Console.WriteLine($"o nome 'Marcelo Rodrigo Lopes' é masculino: { genero.NomeEhMasculino("Marcelo Rodrigo Lopes")}");
            Console.WriteLine($"o nome 'Marcio Hassegawa' é masculino: { genero.NomeEhMasculino("Marcio Hassegawa")}");

            Console.WriteLine($"o nome 'Vivian' é feminino: { genero.NomeEhFeminino("Vivian")}");
            Console.WriteLine($"o nome 'Marcia Hassegawa' é feminino: { genero.NomeEhFeminino("Marcia Hassegawa")}");
            
            

            Console.ReadKey();

        }
    }
}
