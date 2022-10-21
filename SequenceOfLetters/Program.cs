bool check = false;
Console.WriteLine("Введите текст");
string l = Console.ReadLine();
char[] c = l.ToCharArray();
int MaxCount = 0;
int currentcount = 0;
int coun = 0;
bool checktext = false;
if (l == "" || l == " ")
{
    checktext = false;
}
else
{
    checktext = true;
}

while (true)
{
    if (check == true)
    {
        Console.WriteLine();
        Console.WriteLine("Введите текст");
        Console.WriteLine();
        l = Console.ReadLine();
        c = l.ToCharArray();
        MaxCount = 0;
        currentcount = 0;
        coun = 0;
        checktext = false;
        if (l == "" || l == " ")
        {
            checktext = false;
        }
        else
        {
            checktext = true;
        }
    }
    GetQuantity();
    GetWord();
    check = true;
}
void GetQuantity()
{
    if (checktext == true)
    {

        foreach (char c2 in c)
        {
            if (char.IsLetter(c2))
            {

                currentcount++;
                if (MaxCount <= currentcount)
                {
                    MaxCount = currentcount;


                }
                else if (MaxCount > currentcount)
                {
                    MaxCount = MaxCount;

                }
            }

            else if (char.IsLetter(c2) == false)
            {
                currentcount = 0;
                continue;
            }

        }


        if (checktext == false)
        {
            Console.WriteLine("Вы не ввели текст");
            Console.WriteLine();
        }
        else
        {
            if (MaxCount != 0)
            {
                Console.WriteLine($"Максимальная последовательность букв идущих подряд - {MaxCount}");
            }
            else if (MaxCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы не ввели букв");
                Console.WriteLine();
            }
        }
    }
}
void GetWord()//самое длинное слово
{
    if (checktext == true)
    {
        if (MaxCount != 0)
        {

            char[] max = new char[MaxCount];

            foreach (char c2 in c)
            {
                if (char.IsLetter(c2))
                {
                    max[coun] = c2;
                    if (MaxCount > coun)
                    {
                        coun++;
                    }
                }

                else if (char.IsLetter(c2) == false)
                {
                    if (coun != MaxCount)
                    {
                        Array.Clear(max);
                    }
                    else
                    {
                        break;
                    }
                    coun = 0;
                    continue;
                }


            }
            Console.WriteLine();
            Console.WriteLine($"Первая буква слова: {max[0]}");
            Console.WriteLine();
            Console.Write("Самая длянная последовательность букв: ");
            foreach (char c3 in max)
            {

                Console.Write(c3);

            }
        }
        else 
        {
            
        }
        Console.WriteLine();
    }
    else if (checktext == false)
    {
        Console.WriteLine("Вы не ввели текст");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Непредусмотренная ошибка");
    }
}
