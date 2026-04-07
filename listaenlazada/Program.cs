using listaenlazada;
namespace LocomotoraVagones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Locomotora b = new Locomotora();
            //Console.Write("Ingrese un valor: ");
            //int valor1 = int.Parse(Console.ReadLine());
            //b.AgregaIni(valor1);

            //Console.Write("\nIngrese un valor: ");
            //int valor2 = int.Parse(Console.ReadLine());
            //b.AgregaIni(valor2);
            //b.AgregaIni(10);
            //b.AgregaFin(1);
            //b.Imprime();
            b.EliminarSegundo();
            b.Imprime();
            //    b.EliminarSegundo();
            //    b.Imprime();
        }
    }
}



