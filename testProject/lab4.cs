class Lab4
{

    public static void Task4(string[] args)
    {
        HorizontalLine h1 = new HorizontalLine(1, 10, 10, '-');
        h1.Draw();
        HorizontalLine h2 = new HorizontalLine(1, 10, 14, '-');
        h2.Draw();
        VerticalLine v1 = new VerticalLine(10, 14, 1, '|');
        v1.Draw();
        VerticalLine v2 = new VerticalLine(10, 14, 10, '|');
        v2.Draw();
        Console.ReadKey();
    }

}