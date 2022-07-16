using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Annotations
{
	class CustomAttribute : Attribute
	{
		public string Tittle, Description;

		public CustomAttribute(string Tittle, string Description)
		{
			this.Tittle = Tittle;
			this.Description = Description;
		}


		// Method to show the Fields 
		// of the NewAttribute 
		// using reflection 
		public static void AttributeDisplay(Type classType)
		{
			Console.WriteLine("Methods of class {0}", classType.Name);

			// Array to store all methods of a class 
			// to which the attribute may be applied 

			MethodInfo[] methods = classType.GetMethods();

			foreach (MethodInfo method in methods)
			{
				Console.WriteLine(method.Name);//it will prit each method we are using
			}

			// for loop to read through all methods 
			Console.WriteLine();
			for (int i = 0; i < methods.GetLength(0); i++)
			{

				// Creating object array to receive 
				// method attributes returned 
				// by the GetCustomAttributes method 

				object[] attributesArray = methods[i].GetCustomAttributes(true);//getcustomattribute method it will
																				//returns all teh custom attributes
																				//applied for that methdo


				// foreach loop to read through 
				// all attributes of the method 

				foreach (Attribute item in attributesArray)
				{
					if (item is CustomAttribute)
					{
						// Display the fields of the CustomAttribute 
						CustomAttribute attributeObject = (CustomAttribute)item;
						if (attributeObject != null)
						{
							Console.WriteLine("Applying Custom Attribute on methods");
							Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,
							attributeObject.Tittle, attributeObject.Description);//here we are dispalyign the the title and
																				 //description of all the methods which are
																				 //having custom attributes
						}
					}
				}
			}
		}
	}
}
