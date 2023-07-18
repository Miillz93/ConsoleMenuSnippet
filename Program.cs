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

