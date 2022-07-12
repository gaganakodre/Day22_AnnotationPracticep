using Day22_Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Annotations
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            //MoodAnalyser mood = new MoodAnalyser();
            //mood.Test();
            //TypesOfExceptions.TestNullReferenceException(null);
            //Console.WriteLine("Welcome");
            //TestAssemblyUsingReflection();
            Author author = new Author();
            author.FirstName = "Kavitha";
            author.LastName = "NSK";
            author.Age = 25;
            author.Email = "abc@gmail.com";
            author.Phone = "8233042356";
            ValidateAuthorObject(author);
            CustomAttribute.AttributeDisplay(typeof(MoodAnalyser));
            //string assemblyPath = @"C:\Users\Pavithra N S\source\repos\DatastructureDemo131Batch\DatastructureDemo131Batch\bin\Debug\DatastructureDemo131Batch.exe";
            //TestAssemblyUsingReflection(assemblyPath);
            Console.ReadLine();
        }

        public static void ValidateAuthorObject(Author author)
        {
            ValidationContext context = new ValidationContext(author);
            List<ValidationResult> list = new List<ValidationResult>();
            bool res = Validator.TryValidateObject(author, context, list, true);
            if (!res)
            {
                foreach (ValidationResult result in list)
                {
                    Console.WriteLine(result.ErrorMessage);
                }
            }
            else
                Console.WriteLine("Satisfied all the rules specified by the annotations");
        }

        public static void TestAssemblyUsingReflection(string path)
        {
            //string path = @"C:\Users\Pavithra N S\source\repos\DatastructureDemo131Batch\DatastructureDemo131Batch\bin\Debug\DatastructureDemo131Batch.exe";
            Assembly assembly = Assembly.LoadFrom(path);
            if (assembly != null)
            {
                Type[] types = assembly.GetTypes();
                if (types != null)
                {
                    foreach (Type type in types)
                    {
                        Console.WriteLine(type.Name);
                    }
                }
            }
        }
    }
}
