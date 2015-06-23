
namespace RPGGame.UI
{
    using System;
    using Interfaces;
    class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
