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
           
            Author author = new Author();
            author.FirstName = "Kavitha";
            author.LastName = "NSK";
            author.Age = 25;
            author.Email = "abc@gmail.com";
            author.Phone = "8233042356";
            ValidateAuthorObject(author);//go inside the validateauthor method
            CustomAttribute.AttributeDisplay(typeof(MoodAnalyser));
            
            Console.ReadLine();
        }

        public static void ValidateAuthorObject(Author author)
        {
            ValidationContext context = new ValidationContext(author);//it will describe the which context to be validates
            List<ValidationResult> list = new List<ValidationResult>();
            bool res = Validator.TryValidateObject(author, context, list, true);//validator it is used as
                                                                                //a helper class to
                                                                                //validate the object, properties,methods
                                                                                //to validate the attributes
                                                                                //returns the boolean type true or false
            if (!res)//if it is false it will display the error message 
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
