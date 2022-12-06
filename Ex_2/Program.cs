Console.WriteLine("\nВведите тип координат:\n 1 - координаты на плоскости (X,Y)\n 2 - координаты в пространстве (X,Y,Z) :\t ");
int elementsCont = Convert.ToInt32(Console.ReadLine());

if (elementsCont == 1 || elementsCont == 2)
{
    if (elementsCont == 1)
    {
        int[] myArray = new int[2];

        for (int i = 0; i < 2; i++)
        {
            Console.Write($"\nВведите координату 1 точки ({i + 1}):\t");
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] myArray_1 = new int[2];

        for (int i = 0; i < 2; i++)
        {
            Console.Write($"\nВведите координату 2 точки ({i + 1}):\t");
            myArray_1[i] = Convert.ToInt32(Console.ReadLine());
        }

        double distance = Math.Sqrt(((myArray_1[0] - myArray[0]) * (myArray_1[0] - myArray[0])) + ((myArray_1[1] - myArray[1]) * (myArray_1[1] - myArray[1])));
        Console.WriteLine($"\nРасстояние между точками: {distance}");
    }
    else
    {
        if (elementsCont == 2)
        {
            int[] myArray = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nВведите координату 1 точки ({i + 1}):\t");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] myArray_1 = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nВведите координату 2 точки ({i + 1}):\t");
                myArray_1[i] = Convert.ToInt32(Console.ReadLine());
            }

            double distance = Math.Sqrt(((myArray_1[0] - myArray[0]) * (myArray_1[0] - myArray[0])) + ((myArray_1[1] - myArray[1]) * (myArray_1[1] - myArray[1]))+((myArray_1[2]-myArray[2])*(myArray_1[2]-myArray[2])));
            Console.WriteLine($"\nРасстояние между точками: {distance}");
        }
    }
}
else
{
    Console.WriteLine("Не распознан тип координат. Прочтит еще раз первый пункт!");
}

