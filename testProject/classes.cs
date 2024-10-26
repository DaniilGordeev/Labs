class Point
{
        public int x;
        public int y;
        public char sym;

        public Point(){}

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
        }

    public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }


}

class Figure
{
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
		public bool IsHit( Figure figure )
		{
			foreach(var p in pList)
			{
				if ( figure.IsHit( p ) )
					return true;
			}
			return false;
		}

		private bool IsHit( Point point )
		{
			foreach(var p in pList)
			{
				if ( p.IsHit( point ) )
					return true;
			}
			return false;
		}
}

class VerticalLine : Figure
{
        public VerticalLine(int yUp, int yDown, 
                            int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }

class HorizontalLine : Figure
{
        public HorizontalLine(int xLeft, int xRight, 
                              int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
}
