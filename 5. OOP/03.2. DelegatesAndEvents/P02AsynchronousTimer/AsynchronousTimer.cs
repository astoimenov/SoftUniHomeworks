namespace P02AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsynchronousTimer
    {
        public static void Main()
        {
            AsyncTimer boomTimer = new AsyncTimer(BoomAction, 100, 10);
            AsyncTimer testTimer = new AsyncTimer(TestAction, 200, 40);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("...");
                Thread.Sleep(100);
            }
        }

        private static void BoomAction()
        {
            Console.WriteLine("Boom!");
        }

        private static void TestAction()
        {
            Console.WriteLine("Just test..");
        }
    }
}
