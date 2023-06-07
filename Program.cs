Console.Write("Введите количество элементов массива не более 10: ");
int input = Convert.ToInt32(Console.ReadLine());

if (!IsValid(input))
    return;

string[] strArr = new string[input];

PromtArr(strArr);

string[] result = SelectArr(strArr);
Console.WriteLine("[" + string.Join(", ", result) + "]");

bool IsValid(int input)
{
    if (input > 10)
    {
        Console.WriteLine("Слишком большое число, чтобы тратить время");
        return false;
    }
    if (input < 0)
    {
        Console.WriteLine("Количество элементов массива не может быть меньше нуля");
        return false;
    }
    return true;
}

void PromtArr(string[] strArr)
{
    for (int i = 0; i < strArr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива");
        strArr[i] = Console.ReadLine();
    }
}

string[] SelectArr(string[] strArr)
{
    int resultLen = 0;

    for (int i = 0; i < strArr.Length; i++)
    {
        if (IsSuitable(strArr[i]))
            resultLen++;
    }

    string[] result = new string[resultLen];

    int j = 0;

    for (int i = 0; i < strArr.Length && j < resultLen; i++)
    {
        if (IsSuitable(strArr[i]))
        {
            result[j] = strArr[i];
            j++;
        }
    }
    return result;
}

bool IsSuitable(string str)
{
    return str.Length <= 3;
}