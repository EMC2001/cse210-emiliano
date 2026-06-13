class Program
{
    public static void Main(string[] args)
    {
        // Console.CursorVisible = false;
        // for(int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine("+");
        //     Thread.Sleep(sleepTime);
        //     Console.WriteLine("\b");
        //     Console.WriteLine("-");
        //     Thread.Sleep(sleepTime);
        //     Console.WriteLine("\b");

        // }
        
        // string animationString = "\\-|/";
        // //int index = 0;
        // for(int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine(animationString[i % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.WriteLine("\b");
        //     Console.WriteLine("-");
        //     Thread.Sleep(sleepTime);
        //     Console.WriteLine("\b");

        // }
        // Console.CursorVisible = true;

                
        // string animationString = "\\-|/";
        // DateTime now = DateTime.Now;
        // DateTime endTime = now.AddSeconds(10);
        // int index = 0;
        // while(DateTime.Now < endTime)
        // {
        //     Console.WriteLine(animationString[i % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.WriteLine("\b");
        // //     Console.WriteLine("-");
        // //     Thread.Sleep(sleepTime);
        // //     Console.WriteLine("\b");

        // // }
        // // Console.CursorVisible = true;

        int count = 15;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(count);
        while(DateTime.Now < endTime)
        {
            Console.Write($"{count--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }

        Console.CursorVisible = true;


    }
}