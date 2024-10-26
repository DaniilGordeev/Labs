class Lab3
{
    public static void Task3(string[] args)
    {
        try
        {
            Point point = new Point();
            point.Draw(2, 3, '(');
            point.Draw(3, 3, ')'); 
            point.Draw(6, 3, '('); 
            point.Draw(7, 3, ')'); 
            point.Draw(4, 4, '/'); 
            point.Draw(5, 4, '\\'); 

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}