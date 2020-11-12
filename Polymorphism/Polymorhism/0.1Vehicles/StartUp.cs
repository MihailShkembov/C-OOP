using _0._1Vehicles.Core;
using _0._1Vehicles.Core.Interfaces;

namespace _0._1Vehicles
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            IEnginge engine = new Engine();
            engine.Run();
        }
    }
}
