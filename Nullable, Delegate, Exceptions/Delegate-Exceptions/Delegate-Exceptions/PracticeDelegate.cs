using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Exceptions
{
    internal class PracticeDelegate

    {
        public delegate bool CheckNums(int num);
        public bool CheckNumByOdd(int number)
        {
            return number % 2 == 1;




        }


        public bool CheckNumByEven(int number)
        {
            return number % 2 == 0;




        }


        public bool CheckNumByFive(int number)
        {
            return number >5 ;




        }



        public void CheckDelegate()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Console.WriteLine(SumOfListItem(CheckNumByFive, nums));

        }
        static int SumOfListItem(CheckNums func, List<int> nums)
        {


            int sum = 0;



            foreach (int item in nums)
            {
                if (func(item))
                {
                    sum += item;
                }

            }

            return sum;
        }

        public int SumOfListItem(Predicate<int> func,List<int>nums)
        {
            int sum = 0;

            foreach (var item in nums)

            {

                if (func(item))
                {
                    sum += item;

                }

                return sum;

            }
            
           




            
            
        }
        

        public delegate void ChangeString(string str);


        public void StringToUpper(string word)
        {

            Console.WriteLine(word.ToUpper());
        }
        public void CheckWord()
        {
            ShowWord(StringToUpper, "cavid");
        }



        //public void ShowWord(ChangeString func,string str)
        //{
        //    func(str);
        //}



        public delegate int CheckString(string str, int age);

        public void GetStringLength(Func<string,int,int> func, string text)
        {
            Console.WriteLine(func(text,10));
        }
        public int GetStringLength(string word ,int num)
        {
            return word.Length;

        }

        public void ShowString()
        {
            GetStringLength(GetStringLength, "CAVID");
        }



    }
}
