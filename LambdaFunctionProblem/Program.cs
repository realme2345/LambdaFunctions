using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda function");
            List<Lambda> list=new List<Lambda>();
            AddPersonIntoList(list);
            TopTwoAgelessThanSixty(list);
            TeenAgeResult(list);
            AverageAge(list);
            SearchName(list,"Raja");
            RemovePersn(list, "Pavan");
        }
        public static void AddPersonIntoList(List<Lambda> list)
        {
            list.Add(new Lambda() { Address = "Abc", Age = 12, PhoneNumber = 123456789, Name = "Raja" });
            list.Add(new Lambda() { Address = "def", Age = 50, PhoneNumber = 0128894483, Name = "Prabha" });
            list.Add(new Lambda() { Address = "ghi", Age = 13, PhoneNumber = 924624244, Name = "Nagesh" });
            list.Add(new Lambda() { Address = "jkl", Age = 61, PhoneNumber = 986436473, Name = "Nari" });
            list.Add(new Lambda() { Address = "mno", Age = 70, PhoneNumber = 987383728, Name = "Pavan" });
            Display(list);
        }
        public static void Display(List<Lambda> list)
        {
            foreach (Lambda lambda in list)
            {
               Console.WriteLine("Name:{0} \t Phonenumber:{1} \t Age={2} \t Address={3}",lambda.Name,lambda.PhoneNumber,lambda.Age,lambda.Address);
            }
        }
        public static void TopTwoAgelessThanSixty(List<Lambda> list)
        {
            Console.WriteLine();
            Console.WriteLine("Top 2 records based on Age less than 60");
            var topTwoRecords=list.Where(p=>p.Age<60).OrderBy(p=>p.Age).Take(2).ToList();
            Display(topTwoRecords);
        }
        public static void TeenAgeResult(List<Lambda> list)
        {
            var teenAge=list.FindAll(p=>p.Age>=13 && p.Age<=20).ToList();
            Console.WriteLine("Teen Age persons in a list");
            Display(teenAge);
        }
        public static void AverageAge(List<Lambda> list)
        {
            Console.WriteLine("Average Age in list ");
            double result=list.Average(p=>p.Age);
            Console.WriteLine(result);
        }
        public static void SearchName(List<Lambda>list,string name)
        {
            Console.WriteLine("Search For a particular Name");
            var result=list.FindAll(p=>p.Name==name);
            if (result != null)
            {
                Console.WriteLine("Employee is presnt");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }
        }
        public static void RemovePersn(List<Lambda>list,string name)
        {
            var result = list.RemoveAll(p => p.Name == name);
            if(result != 0)
            {
                Console.WriteLine("person is removed succefull");
            }
            else
            {
                Console.WriteLine("person is not found");
            }
            Display(list);
        }

    }
}
