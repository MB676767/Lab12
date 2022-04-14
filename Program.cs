public class MazeProgram
{
    //Main program
    static void Main()
    {
        string fileName = @"C:\Users\meylis.berdiyev\source\repos\MazeReDo\map.txt";
        string[] mapRow = File.ReadAllLines(fileName);
        Console.Clear();
        for (int i = 0; i < mapRow.Length; i++)
        {
            Console.WriteLine(mapRow[i]);
        }
        Console.WriteLine("This program will allow you to solve a maze by using the arrow sign");
        Console.CursorLeft = 0;
        Console.CursorTop = 0;
        ConsoleKey action;
        do
        {
            action = Console.ReadKey(true).Key;
            switch (action)
            {
                case ConsoleKey.UpArrow:
                    TryAction(Console.CursorTop - 1, Console.CursorLeft, mapRow);
                    break;
                case ConsoleKey.DownArrow:
                    TryAction(Console.CursorTop + 1, Console.CursorLeft, mapRow);
                    break;
                case ConsoleKey.LeftArrow:
                    TryAction(Console.CursorTop, Console.CursorLeft - 1, mapRow);
                    break;
                case ConsoleKey.RightArrow:
                    TryAction(Console.CursorTop, Console.CursorLeft + 1, mapRow);
                    break;
            }

        } while (action != ConsoleKey.Escape && mapRow[Console.CursorTop][Console.CursorLeft] != '*');

        if (mapRow[Console.CursorTop][Console.CursorLeft] == '*')
        {
            Console.Clear();
            Console.WriteLine("Game Ended");
            Console.WriteLine("Congrats!");
        }
    }

    //Tty action method
    static void TryAction(int proposedTop, int proposedLeft, string[] mazeRows)
    {
        if ((proposedTop < mazeRows.Length) && (proposedTop >= 0) && (proposedLeft < mazeRows[0].Length) && (proposedLeft >= 0) && (mazeRows[proposedTop][proposedLeft] != '#'))
        {
            Console.CursorLeft = proposedLeft;
            Console.CursorTop = proposedTop;
        }
    }
}