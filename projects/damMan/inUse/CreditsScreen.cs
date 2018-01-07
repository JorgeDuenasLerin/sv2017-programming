// 
// DamMan
// CreditsScreen: Credits for the authors
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.02 14-Dic-2017 Mois�s, Ra�l, Marcos: things (???)
// V0.03 20-Dic-2017 Guillermo, Ra�l, Marcos: a little more text

using System;

public class CreditsScreen
{
    string[] names = {"Creditos", "Mois�s", "Ra�l", "Marcos"
                    , "Dise�adores del juego", "Guille", "Ra�l", "Marcos"};

    public void Run()
    {
        Console.SetWindowSize(80, 24);
        Console.CursorVisible = false;

        for (int i = 0; i < 24 - (names.Length) * 2; i++)
        {
            PrintNames(i);
            System.Threading.Thread.Sleep(200);
            Console.Clear();
        }
        PrintFinalScreen();
        Console.ReadLine();

    }

    void PrintNames(int position)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.SetCursorPosition(40 - (names[i].Length / 2), position + i);
            Console.Write(names[i]);
            position++;
            //    if (i % 4 == 3)
            //        Console.ReadLine();
        }

        Console.WriteLine();
    }

    void PrintFinalScreen()
    {
        string text1 = "We hope you've enjoyed the game!";
        string text2 = "�IES San Vicente 1� DAM-B 2017-2018";

        Console.SetCursorPosition(40 - text1.Length / 2, 12);
        Console.WriteLine(text1);
        Console.SetCursorPosition(40 - text2.Length / 2, 14);
        Console.WriteLine(text2);
    }

}/* end class CreditsScreen */