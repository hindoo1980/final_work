//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    class Hello
    {
    static public string mkRandStr() 
    {
        Random rand = new Random();

        int strlen = rand.Next(1, 8);
        int rVal;
        string rStr = string.Empty;
        char ch;

        for( int i = 0; i < strlen; i++ )
        {
            rVal = rand.Next(97, 123);
            ch = Convert.ToChar(rVal);
            rStr = rStr + ch;
        }
        return rStr;
    }
    
    static public string[] makeRandArr() 
    {
        Random rand = new Random();

        int randArrlen = rand.Next(20, 30);

        string[] randArr  = new string[randArrlen];
        
        for( int i = 0; i < randArrlen; i++ )
        {
            randArr[i] = mkRandStr();
        }
        return randArr;
    }

    
    static public string[] makeFiltArr(string[] filtArr, string[] arr) 
    {
        int j = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                filtArr[j] = arr[i];
                j++;
            }
        }
        return filtArr;
    }
 
    static void Main() 
    {

    string[] randArr =  makeRandArr();


    Console.WriteLine($"из следующего сгенерированного массива строк:");

        for(int i = 0; i < randArr.Length; i++)
    {
        Console.Write($"{i}({randArr[i]}) ");
    }


    Console.WriteLine();
    Console.WriteLine($"получили следующий массив, где все строки содержат не более 3 символов:");

    int j = 0;

    for(int i = 0; i < randArr.GetLength(0); i++)
        {
           if (randArr[i].Length < 4) 
           {
            j++;
           }
        }

    string[] emptyFiltArr = new string[j];

    string[] cutArr = makeFiltArr(emptyFiltArr, randArr);

    for(int i = 0; i < cutArr.Length; i++)
        {
            Console.Write($"{i}({cutArr[i]}) ");
        }
  }
}