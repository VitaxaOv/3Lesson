// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int input = Convert.ToInt32(Console.ReadLine());
int thirdDigit = GetThirdDigit(input);
//Console.WriteLine(thirdDigit);

bool CheckLengthNumber(int number)
{

 return  number > 99 && number < 1000;
}

int GetLengthNumber(int number)
{
    int count = 0;
    while(number > 0)
    {
        number /= 10;
        count++;
    }

    return count;
}


int GetThirdDigit(int number)
{
    int length = GetLengthNumber(number);
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = number % 10;
        number /= 10;
    }

    Console.WriteLine(array[length - 3]);

    /*for (int i = length - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }*/

    //for (int i = 0; i < length; i++)
    //{
     //   Console.Write(array[i]);
    //}


 /// какой-то код

 // bool result = CheckLengthNumber(number);
  //return 5;
//}














// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if(!isParsedX || !isParsedY)
{
    Console.WriteLine("Ошибка! Не правильно введены координаты!!!!");
    return;
}

int numberOfQuarter = DetermineNumberOfQuarter(x, y);

if(numberOfQuarter == -1)
{
    Console.WriteLine("Ошибка! Не правильно введены координаты");
}
else
{
    Console.WriteLine(numberOfQuarter);
}




int DetermineNumberOfQuarter(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }

    if(x < 0 && y > 0)
    {
        return 2;
    }

    if(x < 0 && y < 0)
    {
        return 3;
    }

    if( x > 0&& y < 0)
    {
        return 4;
    }

    return -1;
}



 


