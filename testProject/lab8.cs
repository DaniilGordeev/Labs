class Lab8
{

    public static void Task8(string[] args)
    {
        Console.Clear();
        Walls walls = new Walls(128, 29);
        walls.Draw();
           
            
        Point p = new Point(4, 5, '*');
        Snake snake = new Snake(p, 4, Direction.RIGHT);
        snake.Draw();

        Point food = new Point(4,2,'$');
	    food.Draw();
		while (true)
		{
			if(snake.Eat( food ) )
			{
                food = new Point(food.x + 2, food.y + 1, '$');
				food.Draw();
			}
			else
			{
			    snake.Move();
			}
            Thread.Sleep( 100 );
			if ( Console.KeyAvailable )
			{
			    ConsoleKeyInfo key = Console.ReadKey();
				snake.HandleKey( key.Key );
			}
		}
    }

}