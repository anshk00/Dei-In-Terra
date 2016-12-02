using System;

namespace DeiInTerra
{
#if WINDOWS || LINUX

    /// <summary>
    /// The main class.
    /// </summary>
    public static class DeiInTerraRunner
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (var game = new DeiInTerra())
                game.Run();
        }

        public static void Method()
        {
            throw new System.NotImplementedException();
        }
    }

#endif
}