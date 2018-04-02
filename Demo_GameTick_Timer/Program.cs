using System;
using System.Timers;

namespace Demo_GameTick_Timer
{
    class Program
    {
        static int gameTick = 1;

        static void Main(string[] args)
        {
            Timer gameTickTimer = new Timer(1000);

            gameTickTimer.Elapsed += GameTickTimer_Elapsed;

            gameTickTimer.Start();

            Console.ReadKey();
        }

        private static void GameTickTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Timer timer = (Timer)sender;
            TimeSpan gameTime = TimeSpan.FromSeconds(gameTick);

            Console.WriteLine("Real Time: {0:hh:mm:ss:fff}", e.SignalTime);
            Console.WriteLine("Game Ticks: {0}", gameTick++);
            Console.WriteLine("Game Time: {0}", gameTime);
            Console.WriteLine();

            if (gameTick > 5)
            {
                gameTick = 1;
                timer.Start();
            }
        }
    }
}
