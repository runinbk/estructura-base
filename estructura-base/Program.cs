

namespace estructura_base
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Iniciando aplicación...");
                using (Game game = new Game(800, 800, "LearnOpenTK"))
                {
                    game.Run();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                Console.ReadLine(); // Para mantener la consola abierta
            }
        }
    }
}