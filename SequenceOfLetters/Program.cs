/*Console.WriteLine("Введите текст");
string l = Console.ReadLine();
char[] c = l.ToCharArray();
int MaxCount = 0;
int currentcount = 0;
int coun=0;
char[] max= new char[59];
foreach (char c2 in c)
{
    if (char.IsLetter(c2))
    {
        
        currentcount++;
        if (MaxCount <= currentcount)
        {
            MaxCount = currentcount;
            
            max[coun] = c2;
        }
        else if(MaxCount > currentcount)
        {
            MaxCount = MaxCount;

        }       
    }
    if (MaxCount > coun)
    {
        coun++;
    }
    else if (char.IsLetter(c2) == false)
    {
        currentcount = 0;
        continue;
    }
}
foreach(char c3 in max)
        {
            Console.WriteLine(c3);
        }
Console.WriteLine($"максимальная последовательность букв идущих подряд - {MaxCount}");
*/









Console.WriteLine("Введите текст");
string l = Console.ReadLine();
char[] c = l.ToCharArray();
int MaxCount = 0;
int currentcount = 0;
int coun = 0;
void GetQuantity()
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
    Console.WriteLine($"максимальная последовательность букв идущих подряд - {MaxCount}");
}
void GetWord()//самое длинное слово
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
    foreach (char c3 in max)
    {
        Console.Write(c3);
       
    }
    Console.WriteLine();

}
GetQuantity();
GetWord();
