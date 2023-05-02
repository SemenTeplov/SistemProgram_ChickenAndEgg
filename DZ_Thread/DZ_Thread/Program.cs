class Program
{

    static Thread chickenVoice;
    static Thread eggVoice;
    static int count = 0;
    static void Main(string[] args)
    {
        chickenVoice = new Thread(new ThreadStart(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(new Random().Next(100, 500));
                Console.WriteLine(count++ + ") Chicken # " + i);
            }
            if (!eggVoice.IsAlive) Console.WriteLine("Первым появилось курица");
        }));

        eggVoice = new Thread(new ThreadStart(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(new Random().Next(100, 500));
                Console.WriteLine(count++ + ") Egg! # " + i);
            }
            if (!chickenVoice.IsAlive) Console.WriteLine("Первым появилось яйцо");
        }));

        eggVoice.Start();
        chickenVoice.Start();

    }
}