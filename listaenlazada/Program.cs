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

            Console.Write("\nIndique un valor a buscar: ");
            int valor = int.Parse(Console.ReadLine());
            bool Encontrado = b.Buscar(valor);
            if (Encontrado)
                Console.WriteLine("Valor encontrado.");
            else
                Console.WriteLine("Valor no encontrado.");
            b.EliminarSegundo();
            b.Imprime();
            b.EliminarSegundo();
            b.Imprime();
        }
    }
}



