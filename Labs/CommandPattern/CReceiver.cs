using Grpc.Core;
using Labs.Proxy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Labs.CommandPattern
{
    public class CReceiver : IView
    {


        public void AddProduct()
        {
            int i = 0;
            // Creating an ArrayList 
            
            string[] lines = File.ReadAllLines(@"C:\Labs\file.txt");
            ArrayList myList = new ArrayList(10);

            // Adding elements to ArrayList 
            Console.WriteLine("\n" + "Add product details: ");
            string b = Console.ReadLine();
            // Display the file contents by using a foreach loop.
            foreach (string Actor in lines)
            {
                myList.Add(Actor);
            }
            myList.Add(b);
           
            Console.WriteLine("\n" + "Add product details: ");
            foreach (string str in myList)
            {
                File.WriteAllText(@"C:\Labs\file.txt", str) ;
                Console.WriteLine("{0}. " + str, ++i);
            }
                    

            //try
            //{

            //    StreamWriter streamWriter = new StreamWriter(@"C:\Labs\file.txt");
            //    foreach (string s in myList)
            //        streamWriter.WriteLine(s + "\n");
            //    streamWriter.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception" + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("An product was added.");
            //}
        }
        public void DeleteProduct()
        {
            Console.WriteLine("Delete Product");
            // Creating an ArrayList 
            ArrayList myList = new ArrayList(10);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Labs\file.txt");
            // Display the file contents by using a foreach loop.
            foreach (string Actor in lines)
            {
                myList.Add(Actor);
            }
            Console.WriteLine("Enter ID product which you want to delete:");
            int b = Convert.ToInt32(Console.ReadLine());

            int i = 0 ;
            // Displaying the elements in ArrayList 
            Console.WriteLine("Elements are:");
            foreach (string str in myList)
                    Console.WriteLine("{0}." + str, ++i);

            Console.WriteLine("Modified:\n");
            // Removing the element present at index 4 
           myList.Remove(b);

            foreach (string str in myList)
            {
                
                Console.WriteLine(str);
                File.WriteAllText(@"C:\Labs\file.txt", str);
                    }
                

          
                Console.WriteLine("An product was removed.");


        }
        public void UpdateProduct()
        {
            Console.WriteLine("Update Product");
        }
        public override void ViewProducts()
        {
            ArrayList myList = new ArrayList(10);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Labs\file.txt");

            // Display the file contents by using a foreach loop.
            foreach (string Actor in lines)
            {
                myList.Add(Actor);
            }
            // Displaying the elements in ArrayList 
            Console.WriteLine("Piesel in stoc:");
            int i = 0;
            foreach (string str in myList)
                    Console.WriteLine("{0}. " + str+"\n",++i);

        }
                

        

    }
}
