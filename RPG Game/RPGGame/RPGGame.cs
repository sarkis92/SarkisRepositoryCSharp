
namespace RPGGame
{
    using Interfaces;
    using UI;
    using Engine;
    public class RPGGame
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            IInputReader reader = new ConsoleInputReader();

            SuperEngine engine = new SuperEngine(reader, renderer);

            engine.Run();
        }
    }
}
