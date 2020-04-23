using Labs.Builder;
using Labs.ChainofRespon;
using Labs.CommandPattern;
using Labs.Decorator;
using Labs.Singletone;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Singleton - securitate, rapiditate, accesibilitate



namespace Labs
{

    class Program
    {
        static void Main(string[] args)
        {
            //LiveStreaming liveStreaming = LiveStreaming.GetInstance();
            //Auth lg = new Auth();
            //Receiver rec = new Receiver();
            //===============================================================Singleton Pattern===========================================================
            //x: while (true)
            //{

            //    Console.WriteLine("1) Log In");
            //    Console.WriteLine("2) Log Off");
            //    Console.WriteLine("3) Exit");
            //    Console.WriteLine(" Choice an option: ");

            //    int options = Convert.ToInt32(Console.ReadLine());


            //    switch (options)
            //    {
            //        case 1:
            //            lg.Login();

            //            goto y;
            //            break;
            //        case 2:
            //            lg.Logoff();
            //            Console.WriteLine("You logged off.");
            //            goto x;
            //            break;
            //        case 3:
            //            Environment.Exit(0);
            //            break;

            //    }
            //    a: while(true)
            //    {
            //        Console.WriteLine("1) Administrare depozit");
            //        Console.WriteLine("2) Piese dupa marca automobilului");
            //        switch (options)
            //        {
            //            case 1:
            //                lg.Login();

            //                goto y;
            //                break;
            //            case 2:
            //                lg.Logoff();
            //                Console.WriteLine("You logged off.");
            //                goto x;
            //                break;
            //            case 3:
            //                Environment.Exit(0);
            //                break;

            //        }
            //    }

            //===============================================================Command Pattern===========================================================
            //y: while (true)
            //    {

            //        Console.WriteLine("1) Add product");
            //        Console.WriteLine("2) Update product");
            //        Console.WriteLine("3) Delete product");
            //        Console.WriteLine("4) Log off");
            //        Console.WriteLine("5) View Form");
            //        Console.WriteLine("6) Exit");
            //        Console.WriteLine(" Choice an option: ");
            //        int product = Convert.ToInt32(Console.ReadLine());
            //        switch (product)
            //        {
            //            case 1:
            //                rec.AddProduct();

            //                break;
            //            case 2:
            //                rec.UpdateProduct();
            //                goto y;
            //                break;
            //            case 3:
            //                rec.DeleteProduct();
            //                goto y;
            //                break;
            //            case 4:
            //                lg.Logoff();
            //                goto x;
            //                break;
            //            case 5:
            //                rec.ViewProducts();
            //                break;
            //            case 6:
            //                Environment.Exit(0);
            //                break;
            //        }
            //    }



            //===============================================================Builder Pattern===========================================================
            //    User1 director = new User1();

            //    Parts p1 = new KYB();
            //    Parts p2 = new Monroe();
            //    Parts p3 = new Bilstein();

            //b: while (true)
            //    {

            //        Console.WriteLine("\n\tPiese disponibile după producător:");
            //        Console.WriteLine("1) Bilstein");
            //        Console.WriteLine("2) KYB");
            //        Console.WriteLine("3) Monroe");
            //        Console.WriteLine("4) Exit");
            //        Console.WriteLine(" Choice an option: ");
            //        int product = Convert.ToInt32(Console.ReadLine());
            //        switch (product)
            //        {
            //            case 1:
            //                director.assembly(p1);
            //                Car prod1 = p1.GetCar();
            //                Console.WriteLine("\t Bilstein");
            //                prod1.Show();
            //                break;
            //            case 2:
            //                director.assembly(p2);
            //                Car prod2 = p2.GetCar();
            //                Console.WriteLine("\t Monroe");
            //                prod2.Show();
            //                break;
            //            case 3:
            //                director.assembly(p3);
            //                Car prod3 = p3.GetCar();
            //                Console.WriteLine("\t Monroe");
            //                prod3.Show();
            //                break;

            //            case 4:
            //                Environment.Exit(0);
            //                break;
            //        }
            //    }
            //===============================================================Chain of Responsability===============================================================
            bool a1 = false, a2 = false, a3 = false;

            Console.WriteLine("\n\tDelivery part");
            Console.WriteLine("1) Delivery on adress");
            Console.WriteLine("2) Local");
            Console.WriteLine("3) Exit");
            Console.WriteLine(" Choice an option: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                a1 = true; a2 = false; a3 = false;
            }
            else if (x == 2)
            {
                Console.WriteLine("1) Install in our service ");
                Console.WriteLine("2) Get from our store    ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                if (x1 == 1)
                {
                    a1 = false; a2 = false; a3 = true;
                }
                else if (x1 == 2)
                {
                    a1 = false; a2 = true; a3 = false;
                }
            }

            Receiver receiver = new Receiver(a1, a2, a3);
            DelHandle d1 = new HomeDel();
            DelHandle d2 = new Install();
            DelHandle d3 = new Store();
            d3.Successor = d2;
            d2.Successor = d1;
            d3.Handle(receiver);
            //===============================================================Decorator===============================================================
            //    Decorator.User1 director = new Decorator.User1();

            //    Decorator.Parts p1 = new Mercedes();
            //    Decorator.Parts p2 = new BMW();
            //b: while (true)
            //    {

            //        Console.WriteLine("\n\tPiese disponibile după marcă:");
            //        Console.WriteLine("1) Mercedes");
            //        Console.WriteLine("2) BMW");
            //        Console.WriteLine("3) Exit");
            //        Console.WriteLine(" Choice an option: ");
            //        int product = Convert.ToInt32(Console.ReadLine());
            //        switch (product)
            //        {
            //            case 1:
            //                director.assembly(p1);
            //                Car prod1 = p1.GetCar();
            //                Console.WriteLine("\t Mercedes");
            //                prod1.Show();
            //                break;
            //            case 2:
            //                director.assembly(p2);
            //                Car prod2 = p2.GetCar();
            //                Console.WriteLine("\t BMW");
            //                prod2.Show();
            //                break;
            //            case 3:
            //                Environment.Exit(0);
            //                break;
            //        }
            //    }
            //===============================================================Proxy===============================================================
        //    CReceiver rec = new CReceiver();
        //    Proxy.Proxy proxy = new Proxy.Proxy();
        //y: while (true)
        //    {

        //        Console.WriteLine("1) Add product");
        //        Console.WriteLine("2) Update product");
        //        Console.WriteLine("3) Delete product");
        //        Console.WriteLine("4) Log off");
        //        Console.WriteLine("5) View Form");
        //        Console.WriteLine("6) Exit");
        //        Console.WriteLine(" Choice an option: ");
        //        int product = Convert.ToInt32(Console.ReadLine());
        //        switch (product)
        //        {
        //            case 1:
        //                rec.AddProduct();

        //                break;
        //            case 2:
        //                rec.UpdateProduct();
        //                goto y;
        //                break;
        //            case 3:
        //                rec.DeleteProduct();
        //                goto y;
        //                break;
        //            case 4:
        //                proxy.ViewProducts();
        //                break;
        //            case 5:
        //                Environment.Exit(0);
        //                break;
        //        }
        //    }

            Console.ReadLine();
        
        }
    }
}

