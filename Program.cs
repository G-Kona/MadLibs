using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Author: Geri Kona
             * Name: MadLib Spy
             * Purpose: Input and output user submitted information to console while using various data types.
             * MadLib Source: Spy Mad Libs Book - Spy Video Games
             * 
             * CLASS: HTTP 5101 - Web Application Development 1
             * Professor: Lee Situ
            */

            // - - - - - Variable Declaration - - - - -

            //MadLib input variables
            string itm1, itm2, itm3, itm4, itm5, itm6, itm7, itm8, itm9, itm10, itm11, itm12, itm13, itm14, itm15, itm16, itm17, itm19, itm20, itm21;
            int itm18;

            //Operative variables
            string name;
            int age;
            double years;

            //Mathimatical processing variables
            int days = 365;
            double months = 52;
            decimal serviceM, serviceD, serviceP;

            //Delay Variables
            int delay = 500;
            string d = ".";

            //Rerun program variables
            string repeat;
            bool run = true;

            // - - - - - MadLib START - - - - -

            Console.WriteLine("     -Super Secret Spy Business-");
            Thread.Sleep(delay);
            Console.WriteLine();
            Console.WriteLine("                - - -           ");
            Console.WriteLine("          ~ACCESS GRANTED!~     ");
            Console.WriteLine("                - - -           ");

            //Simulate processing delay
            Thread.Sleep(delay);
            Console.WriteLine(d);
            Thread.Sleep(delay);
            Console.WriteLine(d);
            Thread.Sleep(delay);
            Console.WriteLine(d);
            Thread.Sleep(delay);

            //Rerun program loop
            while (run)
            {
                Console.WriteLine("\nInput operative identification...");
                Thread.Sleep(delay);
                
                //User input of operative details
                Console.WriteLine("\nName:");
                name = Console.ReadLine().Trim();
                Console.WriteLine("\nAge:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nYears in Service:");
                years = Convert.ToDouble(Console.ReadLine());

                //Calculations - Service in months 
                serviceM = Convert.ToDecimal((years * days) / months);
                serviceM = Math.Round(serviceM, 2);

                //Calculations - Service in days 
                serviceD = Convert.ToDecimal(years * days);

                //Calculations - Percentage of lifespan to service
                serviceP = Convert.ToDecimal((years / age) * 100);
                serviceP = Math.Round(serviceP, 2);

                Console.WriteLine("\nCommencing data decryption protocol..");
                Thread.Sleep(delay);

                //Simulate processing delay
                Thread.Sleep(delay);
                Console.WriteLine(d);
                Thread.Sleep(delay);
                Console.WriteLine(d);
                Thread.Sleep(delay);
                Console.WriteLine(d);
                Thread.Sleep(delay);

                Console.WriteLine("\nInput appropriate intel to the following fields.");
                
                //user input for MadLib
                Console.WriteLine("\n01_Part of the Body (Plural):");
                itm1 = Console.ReadLine();
                Console.WriteLine("\n02_Adjective:");
                itm2 = Console.ReadLine();
                Console.WriteLine("\n03_Colour:");
                itm3 = Console.ReadLine();
                Console.WriteLine("\n04_Plural Noun:");
                itm4 = Console.ReadLine();
                Console.WriteLine("\n05_Adjective:");
                itm5 = Console.ReadLine();
                Console.WriteLine("\n06_A Place:");
                itm6 = Console.ReadLine();
                Console.WriteLine("\n07_Plural Noun:");
                itm7 = Console.ReadLine();
                Console.WriteLine("\n08_Noun:");
                itm8 = Console.ReadLine();
                Console.WriteLine("\n09_Person in Room:");
                itm9 = Console.ReadLine();
                Console.WriteLine("\n10_Adjective:");
                itm10 = Console.ReadLine();
                Console.WriteLine("\n11_Plural Noun:");
                itm11 = Console.ReadLine();
                Console.WriteLine("\n12_Noun:");
                itm12 = Console.ReadLine();
                Console.WriteLine("\n13_Plural Noun:");
                itm13 = Console.ReadLine();
                Console.WriteLine("\n14_Plural Noun:");
                itm14 = Console.ReadLine();
                Console.WriteLine("\n15_Verb ending in 'ing':");
                itm15 = Console.ReadLine();
                Console.WriteLine("\n16_Adjective:");
                itm16 = Console.ReadLine();
                Console.WriteLine("\n17_Noun:");
                itm17 = Console.ReadLine();
                Console.WriteLine("\n18_Number (integer):");
                itm18 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n19_Plural Noun:");
                itm19 = Console.ReadLine();
                Console.WriteLine("\n20_Plural Noun:");
                itm20 = Console.ReadLine();
                Console.WriteLine("\n21_Noun:");
                itm21 = Console.ReadLine();

                Console.WriteLine("\n- - - Decryption Complete! - - -");
                Thread.Sleep(delay);
                
                //Output of Madlib
                //Formatted for readability in console window & IDEs
                Console.WriteLine("\nGrab your favourite controller, flex your " + itm1 + ", and get ready to play spy in these " + itm2 + " video games:");
                Console.WriteLine("\n+Operation " + itm3 + " " + itm4 + ":");
                Console.WriteLine("You are a spy in the hot, " + itm5 + " jungles of (the) " + itm6 + "." +
                    "\nYour mission? Vaporize poisonous " + itm7 + " as you search for the missing and priceless " + itm8 + " Diamond," +
                    "\nstolen by the rogue operative, " + itm9 + ".");
                Console.WriteLine("\n+Spies in Space:");
                Console.WriteLine("The " + itm10 + ", evil scientist, Dr. Smarty " + itm11 + ", has launched a/an " + itm12 + " into space containing" +
                    "\ndeadly " + itm13 + " that, if sprinkled into the Earth's atmosphere, will destroy all living " + itm14 + ".");
                Console.WriteLine("\n+Speedway Spies:");
                Console.WriteLine("It's spy-on-spy " + itm15 + " action on the racetrack! You and your " + itm16 + " opponent burn up the race " + itm17 + 
                    "\nat speeds topping " + itm18 + " mph as you swerve to avoid toppling " + itm19 + ", slippery spills of " + itm20 + "," +
                    "\nand occasionally, a/an " + itm21 + " trying to cross the road.");

                //Pause between content
                Console.WriteLine("\nPress any key to advance...");
                Console.ReadKey(true);
                
                //Output of Operative details
                Console.WriteLine("\n- - - Operative Report! - - -");
                Thread.Sleep(delay);
                Thread.Sleep(delay);
                Console.WriteLine("\nAgent: " + name.ToUpper());
                Thread.Sleep(delay);
                Console.WriteLine("Age: " + age);
                Thread.Sleep(delay);
                Console.WriteLine("Years in service: " + years);
                Thread.Sleep(delay);
                Console.WriteLine("Months in service: " + serviceM);
                Thread.Sleep(delay);
                Console.WriteLine("Days in service: " + serviceD);
                Thread.Sleep(delay);
                Console.WriteLine("You have given " + serviceP + "% of your life to the cause.");
                Thread.Sleep(delay);

                //Input to rerun program
                Console.WriteLine("\nRetrieve new report? (y/n)");
                repeat = Console.ReadLine();

                //Determines program repeat or termination
                if (repeat == "n")
                {
                    run = false;
                    Console.WriteLine("\nCommencing 'Self Destruct' protocol...");

                    //Countdown delay
                    Thread.Sleep(delay);
                    Console.WriteLine(".");
                    Thread.Sleep(delay);
                    Console.WriteLine("3");
                    Thread.Sleep(delay);
                    Console.WriteLine(".");
                    Thread.Sleep(delay);
                    Console.WriteLine("2");
                    Thread.Sleep(delay);
                    Console.WriteLine(".");
                    Thread.Sleep(delay);
                    Console.WriteLine("1");
                    Thread.Sleep(delay);
                    Console.WriteLine(":D");
                    Thread.Sleep(delay);
                }
                else
                {
                    //"run" remains as true and repeats the program
                    //Simulate processing delay
                    Thread.Sleep(delay);
                    Console.WriteLine(d);
                    Thread.Sleep(delay);
                    Console.WriteLine(d);
                    Thread.Sleep(delay);
                    Console.WriteLine(d);
                    Thread.Sleep(delay);
                }
            }
        }
    }
}
