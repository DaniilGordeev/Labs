class Lab7
{

    public static void Task7(string[] args)
    {

        Walls w = new Walls(128, 29);
        w.Draw();
        Console.WriteLine();
        Point p = new Point(4, 5, '*');
        Snake snake = new Snake(p, 4, Direction.RIGHT);
        snake.Draw();

		while(true)
		{
        	snake.Move();
            Thread.Sleep( 100 );
		}

    }

}