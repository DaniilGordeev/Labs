class Program 
{
    static void Main(string[] args)
    {
        bool continueProgram = true;
        Console.WriteLine("Программу сделал Гордеев Даниил");
        while (continueProgram)
        {
            try
            {
                Console.Write("Введите номер программы: ");
                int key = int.Parse(Console.ReadLine()!);

                switch (key)
                {
                    case 0:
                        continueProgram = false;
                        break;

                    case 3:
                        Lab3.Task3(args);
                        break;

                    case 4:
                        Lab4.Task4(args);
                        break;

                    case 5:
                        Lab5.Task5(args);
                        break;

                    case 6:
                        Lab6.Task6(args);
                        break;
                    
                    case 7:
                        Lab7.Task7(args);
                        break;
                    
                    case 8:
                        Lab8.Task8(args);
                        break;

                    default:
                        Console.WriteLine("Такой программы нет...");
                        break;
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

        }
    }
}