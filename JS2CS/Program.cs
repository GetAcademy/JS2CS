namespace JS2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = MyConsole.Ask("Hva heter du?");
            Console.WriteLine($"Hei, {name}!");

            var birthYear = MyConsole.AskForInt("I hvilket år ble du født?");
            var hadBirthDay = MyConsole.AskForBool("Har du hatt bursdag i år?");
            var age = 2023 - birthYear;
            if (!hadBirthDay) age--;
            Console.WriteLine($"Da er du {age} år gammel.");
        }
    }
}

//var isSuccess = true;
//var n = 0;
//var c = 'c';
//var s = "Terje";


//bool isSuccess = true;
//int n = 0;
//char c = 'c';
//string s = "Terje";

/*
 * Sterk typing
 * De viktigste datatypene
 *  - bool
 *  - int
 *  - char
 *  - string
 * Deklarasjon og var
 * Konvertering og casting
 * Dele opp i funksjoner/metoder
 * Input fra tastatur
 */