//Oppgave 1
namespace Oppgave_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        //Oppgave 2
        int integer = 10;
        Console.WriteLine(integer);
        double dobbel = 12.5;
        Console.WriteLine(dobbel + integer);
        string text = "Hello there!";
        Console.WriteLine(text);
        char b = 'y'; 

        Console.WriteLine(b);

        int[] myIntArray = {2,4,6,3,8,39,5,8};

        for (int i = 0; i < myIntArray.Length; i++) 
        /* 
        Itererer fra indeks 0 til arrayets lengde
        i = 0 --> det sier at indeksen, altså elementets posisjon i arrayet, begynner å telle fra null. 
        Det betyr at selv om det første tallet er i arrayet skulle være 1, så er posisjonen i arrayet fortsatt 0
        */
        {
            Console.WriteLine(myIntArray[i]);
        }

        string [] myStringArray = {"Dette", "Er", "En", "String!"};
        foreach (string s in myStringArray)
        {
            Console.WriteLine(s);
        }

        List<string> myStringList = new List<string>();
        myStringList.Add("Pink");
        myStringList.Add("Yellow");
        myStringList.Add("Blue");
        myStringList.Add("Turquoise");

        foreach (string s in myStringList)
        {
            Console.WriteLine(s);
        }

        // Oppgave 3
        // Opprett dictionary med int som nøkkel og string som verdi
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        // Legg til verdier til dictionarien
        myDictionary.Add(1, "Obi-Wan Kenobi");
        myDictionary.Add(2, "Anakin Skywalker");
        myDictionary.Add(3, "Yoda");
        myDictionary.Add(4, "Mace Windu");

        // Bruk en foreach-løkke med var for å skrive ut verdiene i dictionary
        foreach (var item in myDictionary)
        {
            Console.WriteLine($"Nøkkel: {item.Key}, Verdi: {item.Value}");
        } 

        int sum = MyIntMethod(5, 10);
        Console.WriteLine($"Summen av 5 og 10 er: {sum}");

        string navn = MyGreetingMethod("Kenobi");
        Console.WriteLine(navn);

    }

     static public int MyIntMethod(int a, int b)
    {
        return a + b;
    }

    static public string MyGreetingMethod(string navn)
    {
        return $"Hello there! General {navn}!";
    }
}