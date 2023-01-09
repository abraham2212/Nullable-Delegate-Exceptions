// See https://aka.ms/new-console-template for more information


using Delegate_Exceptions;
using Delegate_Exceptions.Models;

PracticeDelegate calculate = new PracticeDelegate();
//c/*alculate.CheckDelegate();*/
//calculate.CheckWord();


//Divide(10, 0);

//int m = 5;
//int n = 0;
//var res = m / n;
//try
//{


//    int m = 10;
//    int n = 0;
//    Divide(n, m);
//    //var res = m / n;
//    //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
//    //arr[10] = 300;

//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine();
//}

//static void Divide(int n, int m)
//{
//    var result = n / m;
//    Console.WriteLine(result);
//}

static void Divide(int n, int m)
{
	bool isSuccess = false;
	try
	{
		int[] arr = { 1, 2, 3 };
		arr[5] = 100;
		var result = n / m;
		Console.WriteLine(result);
	}
	catch (Exception ex)
	{

		Console.WriteLine(ex.Message);
		isSuccess = true;

	}
	finally
	{
		if (isSuccess)
		{



			SendEmail("register is ok");
		}
		else
		{
			SendEmail("someting is wrong");
		}





	}

}
static void SendEmail(string message)
{
	Console.WriteLine(message);
}


IPerson	persons =new Person();
//persons.GetSalary(2000);