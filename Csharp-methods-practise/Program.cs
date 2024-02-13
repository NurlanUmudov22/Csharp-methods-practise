//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");





//Csharp-Methods,practise



//void ShowText()
//{
//    Console.WriteLine("Welcome PB-101");
//}

//ShowText();




//void ShowText()
//{
//    Console.WriteLine("hello 101");
//}

//ShowText();



//void AddData()
//{
//    Console.WriteLine("add this data");
//}
//AddData();




//void Sum()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
//Sum();



//void Result()
//{
//    string a = "salam";
//    string b = "sagol";
//    string result = a +" , " + b;
//Console.WriteLine(result);
//}
//Result();


//int SumOFNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return sum;
//}

//Console.WriteLine(SumOFNumbers());




//int SumOFNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return sum;
//}
//int result = SumOFNumbers();
//Console.WriteLine(result);



//int Numbers()
//{
//    int m = 18;
//    int n = 19;
//    int sum = m + n;
//    return sum;
//}

//int result = Numbers();
//Console.WriteLine(result);


//string SumOFNumbers()
//{
//    int a = 5;
//    int b = 3;
//    int sum = a + b;
//    return "salam";
//}
//var result = SumOFNumbers();
//Console.WriteLine(result);


//string SumOFNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    string res = $"Sum of number is - {sum}";
//    return res;
//}
//var result = SumOFNumbers();
//Console.WriteLine(result);



//string Sum()
//{
//    int m = 21;
//    int n = 18;
//    int sum = m + n;
//    string res = $"sum = {sum}";
//    return res;
//}
//string result = Sum();
//Console.WriteLine(result);



//void SumOFEvenNumbers()
//{
//    int[] elems = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//    int sum = 0;
//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }

//    }


//    Console.WriteLine(sum);

//}

//SumOFEvenNumbers();






//void Sum(int num1, int num2)
//{

//    int sum = num1 + num2;
//////    Console.WriteLine(sum);
//}
//Sum(1212,12121);
//Sum(23, 54);







//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}

//bool isMarried = true;

//if (isMarried)
//{
//    ShowText("salam");
//}
//else
//{
//    ShowText("Azerbaijan");
//}







//void SumOFEvenNumbers(int[] elems, int number)
//{
//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }

//    }

//    int result = sum + number;
//    Console.WriteLine(result);

//}

//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 7, };

//SumOFEvenNumbers(nums, 4);




//int[] nums2 = { 3, 4, 5, 3, 2, };
//SumOFEvenNumbers(nums2, 7);



//Console.WriteLine(" Add your name");

//string name = Console.ReadLine();

//Console.WriteLine("Add your surname");

//string surname = Console.ReadLine();

//Console.WriteLine(name + " " + surname);






//Console.WriteLine("Add first number");
//string num1 = Console.ReadLine();

//Console.WriteLine("Add second number");
//string num2 = Console.ReadLine();

//string result = num1 + num2;

//Console.WriteLine(result);




//Console.WriteLine("Add first number:");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Add second number:");
//int  num2 = int.Parse(Console.ReadLine());

//int result = num1 + num2;

//Console.WriteLine(result);




//int[] GetDatas(int num, int num2 , params int[] nums)
//{
//    return nums;
//}

//var result = GetDatas(1,2,3,4,5,6,7);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}




//????

//int SumOfDatas(int num1, int num2, params int[] nums)
//{
//    int sumNumbers = num1+ num2;

//    int sumOfArrayItems = 0;

//    foreach (var item in nums)
//    {
//        sumOfArrayItems += item;
//    }

//    int result = sumNumbers + sumOfArrayItems;

//    return result;

//}

//var result = SumOfDatas(1, 2, 3, 4, 5, 6, 7);

//Console.WriteLine(result);




//string GetName(string name = "XXX")
//{
//    return name;
//}

//Console.WriteLine(GetName(Console.ReadLine()));





string Login(string username, string password)
{

    if (username == "Cavid123" && password == "cavid123_")
    {
        return "Login success";
    }
    else
    {
        return "Email or password is wrong";
    }

}

Console.WriteLine("Username: ");
string username = Console.ReadLine();


Console.WriteLine("Password: ");
string password = Console.ReadLine();



string result = Login(username, password);

Console.WriteLine(result);





