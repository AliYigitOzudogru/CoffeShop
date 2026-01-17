using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // defining general variables
            int capital = 100;
            int order_count=0;
            int working_days=1;
            int choice;
            bool choiceiscorrect;
            bool isgamefinished=false;
            // defining variables related to coffe
            int packagenum_buy;
            int package_count=0;
            int coffee_shot_count=0;
            int coffee_package_buy_money = 5;
            int coffee_sell_money=2;
            int coffee_on_brewed_machine=0;
            int brew_counter = 0;
            // defining variables related to croissant
            int c_package_count=0;
            int c_element_count=0;
            int c_package_buy_money = 10;
            int c_element_sel_money = 3;
            int c_on_tray=0;
            int c_packagenumbuy;
            int c_tray_counter = 0;

          
            // printing menu function
            void PrintMenu()
            {
                
                Console.WriteLine("");
                Console.Write("Your current capital is ");
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine(capital + "Z");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.Write("The number of working days is ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(working_days);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("Please select the option you want to apply : ");
                Console.WriteLine("");
                Console.WriteLine("   1. Buy coffee package");
                Console.WriteLine("   2. Brew coffee");
                Console.WriteLine("   3. Sell cup(s) of coffee");
                Console.WriteLine("   4. Buy package(s) of Croissant");
                Console.WriteLine("   5. Open 1 package of Croissant");
                Console.WriteLine("   6. Sell Croissant");
                Console.WriteLine("   7. End of the Day >");
                Console.WriteLine("   8. Quit Game ");
                Console.WriteLine("");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Coffee Shop!");
            Console.ForegroundColor = ConsoleColor.White;
            // main game loop is initilazed with isgamefinisahed flag
            while (!isgamefinished)
            {
                // checking whether is the end of the day or not
                if (order_count >= 6)
                {
                    Console.WriteLine("The maximum number of orders is reached! ");
                    Console.WriteLine("It is end of the day!");
                    // doing clearing operations 
                    working_days++;
                    if (working_days % 2 == 1)
                    {
                        c_on_tray = 0;
                    }
                    order_count = 0;
                    coffee_on_brewed_machine = 0;

                    //print the end of day report 
                    Console.Write("The current budget is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(capital + "Z");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.Write("The remaining number of full packages of coffe is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(coffee_shot_count/3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.Write("The remaining number of shots of coffe is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(coffee_shot_count);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.Write("The remaining number of packages croissants is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c_package_count);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.Write("The remaining number of croissants on the tray is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c_on_tray);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                   
                }

                PrintMenu();

                // make choice from menu

                Console.Write("Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (choice >= 1 && choice <= 8)
                {
                    choiceiscorrect = true;
                }
                else
                {
                    choiceiscorrect = false;
                }
                while (!choiceiscorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Warning: Insufficient balance! Please re-enter the number");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice >= 1 && choice <= 8)
                    {
                        choiceiscorrect = true;
                    }
                    Console.WriteLine("");


                }
                
                switch (choice)
                {
                   
                    case 1:
                        Console.WriteLine("Operation is processed! Please enter the number of packages to buy : ");
                        Console.WriteLine("");
                        
                        do {
                           
                            Console.Write("Choice : ");
                            packagenum_buy = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                        }while(packagenum_buy<0);
                        int packagenum_cost = packagenum_buy * 5;
                        // capital check
                        if (capital >= packagenum_cost)
                        {


                            package_count += packagenum_buy;
                           
                            coffee_shot_count += packagenum_buy * 3;
                            capital = capital - packagenum_cost;

                            Console.Write("Operation is processed! Now, you have ");
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.Write(coffee_shot_count);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" shot of coffee to brew.");

                        }
                        else
                        {
                            while (capital < packagenum_cost)
                            {
                                do {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Warning: Insufficient balance! Please re-enter the number of packages to buy");
                                    Console.WriteLine("");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Choice : ");
                                    packagenum_buy = Convert.ToInt32(Console.ReadLine());
                                }while( packagenum_buy<0);
                                packagenum_cost = packagenum_buy * 5;



                            }
                            if (capital >= packagenum_cost)
                            {


                                package_count += packagenum_buy;

                                coffee_shot_count += packagenum_buy * 3;
                                capital = capital - packagenum_cost;
                                Console.Write("Operation is processed! Now, you have ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(coffee_shot_count);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" shot of coffee to brew.");
                                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                                
                                isgamefinished = false;

                            }
                        }
                        break;


                    case 2:
                        // package control
                        if (package_count > 0 && coffee_shot_count>0)
                        {
                            brew_counter++;
                            coffee_on_brewed_machine +=  5;
                            
                            coffee_shot_count = coffee_shot_count - 1;
                            Console.Write("Operation is processed! Now, there are ");
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.Write(coffee_on_brewed_machine);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" fresh cups of coffee.");

                            Console.Write("The remaining number of shots of coffee to brew is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(coffee_shot_count);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                        }else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: There is no fresh cup of coffee to brew. Please buy coffee or  change your selection");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                            
                        }
                        break;


                    case 3:
                        // coffee control
                        if (coffee_on_brewed_machine > 0)
                        {
                            order_count += 1; 

                            Console.Write("Operation is processed! The current number of orders is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(order_count);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Please enter the number of cups to sell : ");
                            int numcoffesell;
                            do
                            {
                                Console.Write("Choice : ");
                                numcoffesell = Convert.ToInt32(Console.ReadLine());

                                if (numcoffesell <= 0) 
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Warning: Please enter a positive number (greater than 0).");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            } while (numcoffesell <= 0);
                            // count control
                            while (numcoffesell > coffee_on_brewed_machine)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Warning: There are only " + coffee_on_brewed_machine + " fresh cups of coffee to sell. Please re-enter the number of cups to sell : ");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.White;
                                do
                                {
                                    Console.Write("Choice : ");
                                    numcoffesell = Convert.ToInt32(Console.ReadLine());

                                    if (numcoffesell <= 0) // control and if it is <= than zero print error message. 
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Warning: Please enter a positive number (greater than 0).");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                } while (numcoffesell <= 0);


                            }
                           
                         

                            if (numcoffesell <= coffee_on_brewed_machine)
                            {
                                
                                coffee_on_brewed_machine = coffee_on_brewed_machine - numcoffesell;
                                capital = capital + coffee_sell_money*numcoffesell;
                                Console.Write("Operation is processed! The remaining fresh cups of coffee are ");
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine(coffee_on_brewed_machine);
                                Console.ForegroundColor=ConsoleColor.White;

                                Console.Write("The remaining number of shots of coffee to brew is ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(coffee_shot_count);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");


                            }


                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: There is no fresh cup of coffee to sell. Please brew coffee or  change your selection");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                        }

                        break;


                    case 4:
                        Console.WriteLine("Operation is processed! Please enter the number of packages to buy : ");
                        Console.WriteLine("");
                        // choice control
                        do
                        {
                            Console.Write("Choice : ");
                            c_packagenumbuy = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                        } while (c_packagenumbuy < 0);
                        int c_packagenumcost = c_packagenumbuy*c_package_buy_money;
                        // control for capital 
                        while (capital < c_packagenumcost)
                        {
                            // control for negative numbers
                            do {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Warning! your capital is not enugh for operation ");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Choice : ");
                                c_packagenumbuy = Convert.ToInt32(Console.ReadLine());
                            } while (c_packagenumbuy<0);
                            c_packagenumcost = c_packagenumbuy * c_package_buy_money;
                        }
                        if (capital >= c_packagenumcost) // capital control
                        {

                            c_package_count += c_packagenumbuy;
                            c_element_count += c_packagenumbuy*5;
                            capital=capital - c_packagenumcost;
                            Console.Write("Operation is processed! There are currently ");
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.Write(c_package_count);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" packages of croissants to sell");

                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                        }
                        break;


                    case 5:
                        // package count control 
                        if (c_package_count > 0 && c_element_count > 0)
                        {
                            c_tray_counter++;
                            c_on_tray +=5;
                            c_package_count = c_package_count - 1;
                            c_element_count = c_element_count - 5;

                            Console.Write("Operation is processed! There are ");
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.Write(c_on_tray);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" croissants  on the tray.");

                            Console.Write("The remaining number of packages of croissants to sell is ");
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine(c_package_count);
                            Console.ForegroundColor=ConsoleColor.White; 
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: There is no package of croissant to open. Please buy package or change your selection");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                        }
                        break;


                    case 6:
                        if (c_on_tray > 0)
                        {
                            order_count++;
                            Console.Write("Operation is processed! The current number of orders is "); 
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(order_count);
                            Console.ForegroundColor = ConsoleColor.White;
                            int numc_sell;
                            do { Console.WriteLine("");
                                Console.WriteLine("Please enter the number of croissants to sell :");
                                Console.Write("Choice : ");

                                 numc_sell = Convert.ToInt32(Console.ReadLine());
                            }while(numc_sell <= 0);
                            while (numc_sell > c_on_tray)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Warning: There are only " + c_on_tray + " croissants on the tray. Please re-enter the number of croissants to sell : ");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.White;
                                do
                                {
                                    Console.Write("Choice : ");
                                    numc_sell = Convert.ToInt32(Console.ReadLine());
                                    if (numc_sell <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Warning: Please enter a positive number (greater than 0).");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                } while(numc_sell < 0);

                            }
                            if (numc_sell <= c_on_tray)
                            {
                                
                                c_on_tray = c_on_tray - numc_sell;
                                capital = capital + numc_sell * c_element_sel_money;
                                Console.Write("Operation is processed! There are currently ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(c_on_tray);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(" croissants on the tray");
                                Console.WriteLine("");

                                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                            }


                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: There is no croissants on the tray to sell. Please buy/open package or change your selection");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                        }
                            break;
                    
                    case 7:
                        if (order_count >= 3 && order_count <= 6)
                        {
                            Console.WriteLine("It is end of the day!");
                            // doing clearing operations
                            working_days++;
                            if (working_days % 2 == 1)
                            {
                                c_on_tray = 0;
                            }
                            order_count = 0;
                            coffee_on_brewed_machine = 0;
                            // printing the end of day report 
                            Console.Write("The current budget is ");
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.Write(capital+"Z");
                            Console.ForegroundColor=ConsoleColor.White;
                            Console.WriteLine("");
                            Console.Write("The remaining number of full packages of coffe is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(coffee_shot_count/3);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.Write("The remaining number of shots of coffe is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(coffee_shot_count);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.Write("The remaining number of packages croissants is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(c_package_count);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.Write("The remaining number of croissants on the tray is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(c_on_tray);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                           

                           


                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: The 'End of The Day>' will not be functional before 3 (worked) orders in a day.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                            break;

                    case 8:
                        Console.Write("The final capital is ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(capital);
                        Console.WriteLine("Z");
                        Console.ForegroundColor= ConsoleColor.Blue;
                        Console.WriteLine("");
                        Console.WriteLine("Thank you for choosing us. We look forward to seeing you again!!! ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                        isgamefinished = true;

                        break;

                }
            }
        }
    }
}
