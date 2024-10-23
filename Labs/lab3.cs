using System;

// class Point
// {
//     int x;
//     int y;
//     char sym;

//     public Point(int x, int y, char sym) {
//         this.x = x;
//         this.y = y;
//         this.sym = sym;
//     }

//     public void SetX(int value)
//     {
//         if (value < 0)
//         {
//             throw new Exception("Координата X не может быть отрицательной.");
//         }
//         x = value;
//     }

//     public void SetY(int value)
//     {
//         if (value < 0)
//         {
//             throw new Exception("Координата Y не может быть отрицательной.");
//         }
//         y = value;
//     }

//     public void Draw(int x, int y)
//     {
//         SetX(x);
//         SetY(y);

//         Console.SetCursorPosition(this.x, this.y);
//         Console.Write("()()");
//         Console.SetCursorPosition(this.x, this.y + 1);
//         Console.Write(" /\\ ");
//     }
// }


class Lab3
{
    public static void Task3(string[] args)
    {
        try
        {
            // Point point = new Point();
            // point.Draw(3, 3); 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}