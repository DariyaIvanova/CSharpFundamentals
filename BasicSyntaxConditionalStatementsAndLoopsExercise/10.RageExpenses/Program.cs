internal class Program
{
    /*
On the first input line – lost games count – integer in the range [0…1000].
On the second line – headset price – floating-point number in the range [0…1000].
On the third line – mouse price – floating-point number in the range [0…1000].
On the fourth line – keyboard price – floating-point number in the range [0…1000].
On the fifth line – display price – floating-point number in the range [0… 1000].

Every second lost game, Petar trashes his headset.
Every third lost game, Petar trashes his mouse.
When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
Every second time, when he trashes his keyboard, he also trashes his display. 
     */


    static void Main()
    {
       
        int lostGamesCount=int.Parse(Console.ReadLine());
        decimal headsetPrice=decimal.Parse(Console.ReadLine());
        decimal mousePrice = decimal.Parse(Console.ReadLine());
        decimal keyboardPrice = decimal.Parse(Console.ReadLine());
        decimal displayPrice = decimal.Parse(Console.ReadLine());

        decimal rageExpenses = 0;

        int headsetTrashes = lostGamesCount/2;
        int mouseTrashes=lostGamesCount/3;
        int keyboardTrashes= mouseTrashes / 2;
        int displayTrashes=keyboardTrashes/2;
       
        rageExpenses = headsetTrashes* headsetPrice + mouseTrashes* mousePrice+ keyboardTrashes* keyboardPrice+ displayTrashes* displayPrice;

        Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");




    }
}

