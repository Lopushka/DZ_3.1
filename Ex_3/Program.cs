Console.Write("\nЧисло до которого надо вывести таблицу Кубов: ");
long numder = Convert.ToInt32(Console.ReadLine());
long i;

// Ввывод в консоль
// Console.WriteLine("Число\tКуб");

// if (numder >= 0)
// {
//     for (i = 0; i <= numder; i++)
//         Console.WriteLine("{0}\t{1}", i, i * i * i);
// }

// else
// {
//     if (numder <= 0)
//     {
//         for (i = 0; i >= numder; i--)
//             Console.WriteLine("{0}\t{1}", i, i * i * i);
//     }
// }

// ввывод в текстовый файл
if (numder >= 0)
{
    try
    {

        // StreamWriter sw = new StreamWriter("C:\\text.txt"); // Для проверки на другом км)
        StreamWriter sw = new StreamWriter("C:\\Users\\sv13y\\Desktop\\DZ_3.1\\Ex_3\\text.txt"); // у меня. 

        sw.WriteLine("Число\tКуб"); // начало таблицы


        for (i = 0; i <= numder; i++)
            sw.WriteLine("{0}    \t{1}", i, i * i * i);

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
    if (numder <= 0)
    {
        try
        {

            // StreamWriter sw = new StreamWriter("C:\\text_1.txt"); // Для проверки на другом кмпе)
            StreamWriter sw = new StreamWriter("C:\\Users\\sv13y\\Desktop\\DZ_3.1\\EX_3\\text_1.txt"); // у меня. 

            sw.WriteLine("Число\tКуб"); // начало таблицы


            for (i = 0; i >= numder; i--)
                sw.WriteLine("{0}    \t{1}", i, i * i * i); // 

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


