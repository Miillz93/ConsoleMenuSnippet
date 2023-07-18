// // Part 1
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.CursorVisible = false;
//         ConsoleKeyInfo cki;
//         int selectedMenuItem = 0;
//         string[] menuItems = { "Option 1", "Option 2", "Option 3", "Option 4" };

//         do
//         {
//             Console.Clear();
//             Console.WriteLine("Main Menu\n");

//             for (int i = 0; i < menuItems.Length; i++)
//             {
//                 if (i == selectedMenuItem)
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine(menuItems[i]);
//                     Console.ResetColor();
//                 }
//                 else
//                 {
//                     Console.WriteLine(menuItems[i]);
//                 }
//             }

//             cki = Console.ReadKey();

//             switch (cki.Key)
//             {
//                 case ConsoleKey.UpArrow:
//                     selectedMenuItem--;
//                     if (selectedMenuItem < 0)
//                     {
//                         selectedMenuItem = menuItems.Length - 1;
//                     }
//                     break;

//                 case ConsoleKey.DownArrow:
//                     selectedMenuItem++;
//                     if (selectedMenuItem >= menuItems.Length)
//                     {
//                         selectedMenuItem = 0;
//                     }
//                     break;

//                 case ConsoleKey.Enter:
//                     Console.Clear();
//                     Console.WriteLine("You selected: " + menuItems[selectedMenuItem]);
//                     Console.ReadKey();
//                     break;

//                 default:
//                     break;
//             }

//         } while (cki.Key != ConsoleKey.Escape);
//     }
// }

// Part 2
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Submenu");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Option 1.");
                    break;
                case 2:
                    Console.WriteLine("You selected Option 2.");
                    break;
                case 3:
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Submenu:");
                        Console.WriteLine("1. Suboption 1");
                        Console.WriteLine("2. Suboption 2");
                        Console.WriteLine("3. Back");

                        int subChoice = int.Parse(Console.ReadLine());

                        switch (subChoice)
                        {
                            case 1:
                                Console.WriteLine("You selected Suboption 1.");
                                break;
                            case 2:
                                Console.WriteLine("You selected Suboption 2.");
                                break;
                            case 3:
                                goto EndSubmenu;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }

                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey(true);
                    }

                EndSubmenu:
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
}
