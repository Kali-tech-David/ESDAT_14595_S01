using listaenlazada;
namespace LocomotoraVagones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Locomotora b = new Locomotora();
            b.AgregaIni(5);
            b.AgregaIni(3);
            b.AgregaIni(10);
            b.AgregaFin(1);
            b.Imprime();
            b.Buscar(10);
            b.EliminarSegundo();
            b.Imprime();
            b.EliminarSegundo();
            b.Imprime();
        }
    }
}



