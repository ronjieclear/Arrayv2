using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Array - no need to include this line


namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     === ARRAY PROGRAM ===");

            //create an array names which could hold 5 elements
            string[] names = new string[5];
            //names list
            //0. 
            //1. 
            //2. 
            //3. 
            //4. 
            Console.WriteLine(names[1]); //display the element of the array 
            //since there are no value, null or blank will be displayed


            //assign a value to the array names
            names[0] = "kenneth";
            names[1] = "neilven";
            names[3] = "ronjie";
            names[2] = "charles";
            //names list
            //0. kenneth
            //1. neilven
            //2. charles
            //3. 
            //4. 

            //show or display the element of an array
            Console.WriteLine(names); //this is not the correct way to display elements
            Console.WriteLine(names[1]); //include the index 

            //add more value to the array
            names[4] = "lovely";
            //names[5] = "beauty"; //this produce error outofrange because our array can handle only 5 elements 

            //resize the array
            Console.WriteLine(names.Length);//show the current size of the array
            Array.Resize(ref names, names.Length + 2); //add 2 more elements in the existing size of the array
            Console.WriteLine(names.Length); //check size
            names[5] = "beauty"; //add 

/*            names[0] = "kenneth";
            names[1] = "neilven";
            names[3] = "ronjie";
            names[2] = "charles";*/

            //create an array together with assigning a value to each elements
            string[] students = new string[] {"kenneth","neilven","ronjie","charles","lovely","beauty" };
            //                                     0      1          2        3         4       5
            //How to display all the elements?????
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);
            Console.WriteLine(students[4]);
            Console.WriteLine(students[5]);

            Console.WriteLine("");
            Console.WriteLine(" - Use Loop - ");

            Console.WriteLine("FOR Loop");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]); //since the value of i change in every iteration
            }

            //FOR EACH LOOP - dedicated for array
            Console.WriteLine("Foreach Loop");
            foreach(string v in students)
            {
                Console.WriteLine(v);
            }




            Console.ReadLine();
        }
    }
}
