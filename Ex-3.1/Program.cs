Console.Write("\nЧисло до которого надо вывести таблицу Кубов: ");
long numder = Convert.ToInt32(Console.ReadLine());
long i;
// Print Console.

// if (numder == 0)
// {
//     Console.WriteLine("Число\tКуб");
//     Console.WriteLine("{0}\t{1}", 0, 0);
// }
// else
// {
//     numder ++;
//     Console.WriteLine("Число\tКуб");
//     if (numder >= 1)
//     {
//         long[] myArray = new long[numder];
//         for (i = 0; i < myArray.Length; i++)

//         {
//             Console.WriteLine("{0}\t{1}", myArray[i]=i, myArray[i]=i*i*i);
//         }

//     }
// }

// Print text

if (numder == 0)
{
    try
    {

        // StreamWriter sw = new StreamWriter("C:\\zero cube.txt"); // Для проверки на другом км)
        StreamWriter sw = new StreamWriter("C:\\Users\\sv13y\\Desktop\\DZ_3.1\\Ex-3.1\\zero cube.txt"); // у меня. 

        sw.WriteLine("Число\tКуб"); // начало таблицы



        sw.WriteLine("{0}    \t{1}", numder, numder * numder * numder);

        sw.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Запись окончена.");
    }
}
else
{
    if (numder > 1)
    {
        numder++;

        try
        {

            // StreamWriter sw = new StreamWriter("C:\\cube of positive numbers.txt"); // Для проверки на другом кмпе)
            StreamWriter sw = new StreamWriter("C:\\Users\\sv13y\\Desktop\\DZ_3.1\\EX-3.1\\cube of positive numbers.txt"); // у меня. 

            sw.WriteLine("Число\tКуб"); // начало таблицы

            long[] myArray = new long[numder];
            for (i = 1; i < myArray.Length; i++)
                sw.WriteLine("{0}    \t{1}", myArray[i] = i, myArray[i] = i * i * i); // 

            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Запись окончена.");
        }
    }

    if (numder < -1)
    {
        numder = numder * (-1);
         numder++;

        try
        {

            // StreamWriter sw = new StreamWriter("C:\\cube of negative numbers.txt"); // Для проверки на другом кмпе)
            StreamWriter sw = new StreamWriter("C:\\Users\\sv13y\\Desktop\\DZ_3.1\\EX-3.1\\cube of negative numbers.txt"); // у меня. 

            sw.WriteLine("Число\tКуб"); // начало таблицы

            long[] myArray = new long[numder];
            for (i = 1; i < myArray.Length; i++)
                sw.WriteLine("{0}    \t{1}", myArray[i] = i * (-1), myArray[i] = i * i * i * -1); // 

            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Запись окончена.");
        }
    }
}

if (numder == 1)
{
    try
    {

        // StreamWriter sw = new StreamWriter("C:\\cube unit.txt"); // Для проверки на другом км)
        StreamWriter sw = new StreamWriter("C:\\Users\\sv13y\\Desktop\\DZ_3.1\\Ex-3.1\\cube unit.txt"); // у меня. 

        sw.WriteLine("Число\tКуб"); // начало таблицы

        sw.WriteLine("{0}    \t{1}", numder, numder * numder * numder);

        sw.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Запись окончена.");
    }
}

if (numder == -1)
{
    try
    {

        // StreamWriter sw = new StreamWriter("C:\\cube negative units.txt"); // Для проверки на другом км)
        StreamWriter sw = new StreamWriter("C:\\Users\\sv13y\\Desktop\\DZ_3.1\\Ex-3.1\\cube negative unitstxt"); // у меня. 

        sw.WriteLine("Число\tКуб"); // начало таблицы

        sw.WriteLine("{0}    \t{1}", numder, numder * numder * numder);

        sw.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Запись окончена.");
    }
}
