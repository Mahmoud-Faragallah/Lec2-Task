/*----------- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Description <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< ------------------------------------------
-- Developer Name  : Mahmoud Faragallah
-- Creation Date   : 29 - 11 - 2025
-- Modify Date     : 29 - 11 - 2025
-- Description     : Lec2 Task1 (Islam's Carpet Cleaning Service)
---------- - >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Core of Procedure <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<-------------------------------------------*/


Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");               // Welcome Message 
decimal TaxFactor = 0.06M;                                                     // Defining Tax Factor as a Parameter to easly access and use in all project

Console.WriteLine("Please Enter Number of Your small carpets");                // Asking for Number of Small Carpets
int CountOfSmallCarpets = Convert.ToInt32(Console.ReadLine());                 // Getting Number of Small Carpets from User
Console.WriteLine("Please Enter Number of Your large carpets");                // Asking for Number of Large Carpets
int CountOfLargeCarpets = Convert.ToInt32(Console.ReadLine());                 // Getting Number of Large Carpets from User

decimal CostOfSmallCarpets = CountOfSmallCarpets * 25;                         // Calculationg Price of Small Carpets
decimal CostOfLargeCarpets = CountOfLargeCarpets * 35;                         // Calculationg Price of Large Carpets
decimal TotalCost = (CostOfSmallCarpets + CostOfLargeCarpets);                 // Calculationg Total Price without Tax
decimal Tax = TotalCost * TaxFactor;                                           // Calculating Tax
decimal TotalCost2 = (TotalCost + Tax);                                        // Calculationg Total Price With Tax

Console.WriteLine("your Cost is >>  " + TotalCost + "$");                      // Dispalying Total Price without Tax 
Console.WriteLine("Tax is >>  " + Tax + "$");                                  // Displaying Total Tax 

Console.WriteLine("your Total Cost is >> " + TotalCost2 + "$");                // Displaying Total Price With Tax

Console.WriteLine("This estimate is valid for 30 days");

/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------*/
