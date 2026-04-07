using listaenlazada;
namespace LocomotoraVagones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Locomotora a = new Locomotora();

            a.AgregaIni(5);
            a.AgregaIni(3);
            a.AgregaIni(1);
            //a.Imprime();

            //b.EliminarSegundo();
            //b.Imprime();
            //b.EliminarSegundo();
            //b.Imprime();

            //Console.Write("\nIndique un valor a buscar: ");
            //int valor = int.Parse(Console.ReadLine());
            //bool Encontrado = b.Buscar(valor);
            //Console.WriteLine(Encontrado ? "Valor encontrado." : "Valor no encontrado.");
            Locomotora b = new Locomotora();
            b.AgregaFin(2);
            b.AgregaFin(4);
            b.AgregaFin(6);

            a.MezclarAlFinal(b);
            //a.MezclaralFIN(b);
            a.Imprime();
            //b.Imprime();


            //Console.WriteLine($"Hay {b.Lenght()} elementos.");
        }
    }
}



