class Lab5
{

    public static void Task5(string[] args)
    {

        Point p1 = new Point(10, 10, '*');
        Point p2 = new Point(9, 9, '&');

        if(p1.IsHit(p2))
        {
            Console.WriteLine("Пересекаются");
        }
        else
        {
            Console.WriteLine("Не пересекаются");
        }

        VerticalLine v1 = new VerticalLine(15, 20, 3, '|');
        HorizontalLine h1 = new HorizontalLine(1, 5, 16, '_');

        if(v1.IsHit(h1))
        {
            Console.WriteLine("Пересекаются");
        }
        else
        {
            Console.WriteLine("Не пересекаются");
        }

    }

}