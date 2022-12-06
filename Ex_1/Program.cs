Console.Write("\n Введите число для проверки на палиндром: ");
int numder = Convert.ToInt32(Console.ReadLine());
if (numder <= 10)
{
    Console.Write("\n Числа-палиндромы — числа, которые в определённой позиционной системе исчисления (как правило — в десятичной) читаются одинаково как справа налево, так и слева направо");
}

else
{
    char[] myArray = numder.ToString().ToCharArray();

    char[] newArray = myArray.Reverse().ToArray();


    for (var i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Equals(newArray[i]))
        {
            if (i == myArray.Length - 1)
            {
                Console.WriteLine($"\nЧисло: {numder} является палиндромом.");
            }

        }
        else
        {
            Console.WriteLine($"\nЧисло: {numder} не является палиндромом.");
            break;

        }
    }
}

