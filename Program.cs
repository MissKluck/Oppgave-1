namespace Oppgave_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        int loop = 10;
        Console.WriteLine(loop);
        double dee = 12.5;
        Console.WriteLine(dee + loop);
        string tinkaton = "Tinkaton is the best!";
        Console.WriteLine(tinkaton);
        char b = 'y'; 

        Console.WriteLine(b);

        int[] myIntArray = {2,4,6,3,8,39,5,8};
        Console.WriteLine(myIntArray);

        for (int i = 0; i < myIntArray; i++)
        {
            Console.WriteLine(myIntArray[i]);
        }

    }
}