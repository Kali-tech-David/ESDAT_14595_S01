using listaenlazada;
namespace LocomotoraVagones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Locomotora b = new Locomotora();

            b.AgregaIni(7);
            b.AgregaIni(5);
            b.AgregaIni(3);
            b.AgregaIni(1);
            b.AgregaFin(10);
            b.Imprime();

            //b.EliminarSegundo();
            //b.Imprime();
            //b.EliminarSegundo();
            //b.Imprime();

            //Console.Write("\nIndique un valor a buscar: ");
            //int valor = int.Parse(Console.ReadLine());
            //bool Encontrado = b.Buscar(valor);
            //Console.WriteLine(Encontrado ? "Valor encontrado." : "Valor no encontrado.");

            //Console.WriteLine(b.Get(0));
            Console.WriteLine($"Hay {b.Lenght()} elementos.");
        }
    }
}



