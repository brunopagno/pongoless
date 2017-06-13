using System;

namespace pongoless
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PongolessGame.InitializeInstance();
            using (var game = PongolessGame.Instance) {
                game.Run();
            }
        }
    }
}
