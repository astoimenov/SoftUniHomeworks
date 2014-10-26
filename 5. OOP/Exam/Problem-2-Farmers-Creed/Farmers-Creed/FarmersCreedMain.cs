namespace FarmersCreed
{
    using Simulator;

    public class FarmersCreedMain
    {
        public static void Main()
        {
            FarmSimulator simulator = new CustomSimulator();
            simulator.Run();
        }
    }
}
