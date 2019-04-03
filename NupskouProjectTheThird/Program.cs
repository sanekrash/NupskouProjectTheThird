using NupskouProjectTheThird.Core;

namespace NupskouProjectTheThird
{
    internal class Program
    {
        public static void Main (string[] args) {
            using (var game = new Game ()) {
                game.Run ();
            }
        }

    }
}