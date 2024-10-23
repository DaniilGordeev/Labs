using System;

class Point
{
    int x;
    int y;
    char sym;

    public Point(int x, int y, char sym) {
        this.x = x;
        this.y = y;
        this.sym = sym;
    }

    // public void SetX(int value)
    // {
    //     if (value < 0)
    //     {
    //         throw new Exception("Координата X не может быть отрицательной.");
    //     }
    //     x = value;
    // }

    // public void SetY(int value)
    // {
    //     if (value < 0)
    //     {
    //         throw new Exception("Координата Y не может быть отрицательной.");
    //     }
    //     y = value;
    // }

    // public void SetSym(char symbol)
    // {
    //     sym = symbol;
    // }
    
    public void Draw(int x, int y, char sym)
    {
        // SetX(x);
        // SetY(y);
        // SetSym(sym);

        Console.SetCursorPosition(this.x, this.y);
        Console.Write(sym);
    }
    
    // internal void Draw()
    // {
    //     throw new NotImplementedException();
        
    // }
}

class Figure
{
    protected List<Point> pList;

    public void Draw()
    {
        foreach(Point p in pList)
        {
            p.Draw(0, 0, '*');
        }
    }
}

class VerticalLine:Figure
{
    public VerticalLine(int yUp, int yDown,
                        int x, char sym)
    {
        pList = new List<Point>();
        for (int y = yUp; y <= yDown; y++)
        {
            Point p = new Point(x,y,sym);
            pList.Add(p);
        }
    }
}

class HorizontalLine:Figure
{
    public HorizontalLine(int xLeft, int xRight,
                        int y, char sym)
    {
        // Console.WriteLine("task 1 Successfully");
        pList = new List<Point>();
        for (int x = xLeft; x <= xRight; x++)
        {
            Point p = new Point(x,y,sym);
            pList.Add(p);
        }
        // Console.WriteLine("task 2 Successfully");
    }
}