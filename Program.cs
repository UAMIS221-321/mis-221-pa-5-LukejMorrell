using System;
using PA5;
//start main
//Declare Object Arrays and instanciate them
Trainer[] trainers = new Trainer[100];
TrainerUtility trainerUtility = new TrainerUtility(trainers);
Listing[] listings = new Listing[100];
ListingUtility listingUtility = new ListingUtility(listings);
Transaction[] transactions = new Transaction[100];
TransactionUtility transactionUtility = new TransactionUtility(transactions);
MainMenu(trainers, trainerUtility, listings, listingUtility, transactions, transactionUtility);

static void MainMenu(Trainer[] trainers, TrainerUtility trainerUtility, Listing[] listings, ListingUtility listingUtility, Transaction[] transactions, TransactionUtility transactionUtility)
{
    while (true)
    {
        System.Console.WriteLine("============================");
        System.Console.WriteLine("For Faculty Menu, Enter: 1");
        System.Console.WriteLine("----------------------------");
        System.Console.WriteLine("For Customer Menu, Enter: 2");
        System.Console.WriteLine("----------------------------");
        System.Console.WriteLine("To Exit The Program, Enter: 3");
        System.Console.WriteLine("============================");

        string userInput = Console.ReadLine();
        int userInput1;

                if (int.TryParse(userInput, out userInput1))
                {
                    if (userInput1 == 1)
                    {
                        System.Console.WriteLine("Faculty Menu Selected.");
                        FacultyMenu(trainers, trainerUtility, listings, listingUtility, transactions, transactionUtility);
                    }
                    else if (userInput1 == 2)
                    {
                        System.Console.WriteLine("Customer Menu Selected.");
                        CustomerMenu(transactions, transactionUtility);
                    }
                    else if (userInput1 == 3)
                    {
                        System.Console.WriteLine("Program Exit...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Input Detected...");
                    }
                }
    }
}
//End Main 

//Start Faculty Menu Method
static void FacultyMenu(Trainer[] trainers, TrainerUtility trainerUtility, Listing[] listings, ListingUtility listingUtility, Transaction[] transactions, TransactionUtility transactionUtility)
{
    System.Console.WriteLine("=======================================");
    System.Console.WriteLine("To Manage Trainer Information, Enter: 1");
    System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("To Manage Listing Information, Enter: 2");
    System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("To Manage Booking Information, Enter: 3");
    System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("To View Reports, Enter 4");
    System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("To Exit The Program, Enter 5");
    System.Console.WriteLine("=======================================");

        string userInput = Console.ReadLine();
        int userInput1;

                if (int.TryParse(userInput, out userInput1))
                {
                    if (userInput1 == 1)
                    {
                        System.Console.WriteLine("Trainer Menu Selected");
                        ManageTrainerData(trainers, trainerUtility);
                    }
                    else if (userInput1 == 2)
                    {
                        System.Console.WriteLine("Listing Menu Selected");
                        ManageListingData(listings, listingUtility);
                    }
                    else if (userInput1 == 3)
                    {
                        System.Console.WriteLine("Booking Menu Selected");
                        ManageBookingData(transactions, transactionUtility);
                    }
                    else if (userInput1 == 4)
                    {
                        System.Console.WriteLine("Report Menu Selected");
                        ManageReportData(transactions, transactionUtility);
                    }
                    else if (userInput1 == 5)
                    {
                        System.Console.WriteLine("Program Exit...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Input");
                    }
                }
                
}
//End Faculty Menu Method

//Start Customer Menu Method
static void CustomerMenu(Transaction[] transactions, TransactionUtility transactionUtility)
{
    System.Console.WriteLine("Customer Menu");
    while (true) 
    {
    System.Console.WriteLine("====================================");
    System.Console.WriteLine("To View Available Sessions, Enter: 1");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To Book A Session, Enter: 2");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To View Workout Plans, Enter: 3");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To Exit The Program, Enter: 4");
    System.Console.WriteLine("====================================");

        string userInput = Console.ReadLine();
        int userInput1;

        if (int.TryParse(userInput, out userInput1))
        {
            if (userInput1 == 1)
            {
            System.Console.WriteLine("View Available Sessions Selected");
            transactionUtility.GetTransactionsFile();
            transactionUtility.DisplayAvailableTransactions();
            }
            else if (userInput1 == 2)
            {
            System.Console.WriteLine("Edit Listing Information Selected");
            transactionUtility.GetTransactionsFile();
            transactionUtility.ChangeStatus();
            }
            else if (userInput1 == 3)
            {
                GetWorkoutPlan();
            }
            else if (userInput1 == 4)
            {
            System.Console.WriteLine("Program Exit...");
            Environment.Exit(0);
            }
            else
            {
            System.Console.WriteLine("Invalid Input...");
            }
        }
    }
}
//End Customer Menu Method

//Start Manage Trainer Data Method

static void ManageTrainerData(Trainer[] trainers, TrainerUtility trainerUtility) 
{
    while (true) 
    {
    System.Console.WriteLine("========================================");
    System.Console.WriteLine("To Add Trainer Information, Enter: 1");
    System.Console.WriteLine("----------------------------------------");
    System.Console.WriteLine("To Edit Trainer Information, Enter: 2");
    System.Console.WriteLine("----------------------------------------");
    System.Console.WriteLine("To Delete Training Information, Enter: 3");
    System.Console.WriteLine("----------------------------------------");
    System.Console.WriteLine("To Exit The Program, Enter 4");
    System.Console.WriteLine("========================================");

        string userInput = Console.ReadLine();
        int userInput1;

        if (int.TryParse(userInput, out userInput1))
        {
            if (userInput1 == 1)
            {
            System.Console.WriteLine("Add Trainer Information Selected");
            trainerUtility.GetTrainersFile();
            trainerUtility.AddTrainer();
            }
            else if (userInput1 == 2)
            {
            System.Console.WriteLine("Edit Trainer Information Selected");
            trainerUtility.GetTrainersFile();
            trainerUtility.EditTrainer();
            }
            else if (userInput1 == 3)
            {
            System.Console.WriteLine("Delete Trainer Information Selected");
            trainerUtility.GetTrainersFile();
            trainerUtility.DeleteTrainer();
            }
            else if (userInput1 == 4)
            {
            System.Console.WriteLine("Program Exit...");
            Environment.Exit(0);
            }
            else
            {
            System.Console.WriteLine("Invalid Input...");
            }
        }
    }
}
//End Manage trainer Method

//Start Manage Listing Data Method
static void ManageListingData(Listing[] listings, ListingUtility listingUtility) 
{
    while (true) 
    {
    System.Console.WriteLine("=======================================");
    System.Console.WriteLine("To Add Listing Information, Enter: 1");
    System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("To Edit Listing Information, Enter: 2");
    System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("To Delete Listing Information, Enter: 3");
    System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("To Exit The Program, Enter 4");
    System.Console.WriteLine("=======================================");

        string userInput = Console.ReadLine();
        int userInput1;

        if (int.TryParse(userInput, out userInput1))
        {
            if (userInput1 == 1)
            {
            System.Console.WriteLine("Add Listing Information Selected");
            listingUtility.GetListingsFile();
            listingUtility.AddListing();
            }
            else if (userInput1 == 2)
            {
            System.Console.WriteLine("Edit Listing Information Selected");
            listingUtility.GetListingsFile();
            listingUtility.EditListing();
            }
            else if (userInput1 == 3)
            {
            System.Console.WriteLine("Delete Listing Information Selected");
            listingUtility.GetListingsFile();
            listingUtility.DeleteListing();
            }
            else if (userInput1 == 4)
            {
            System.Console.WriteLine("Program Exit...");
            Environment.Exit(0);
            }
            else
            {
            System.Console.WriteLine("Invalid Input...");
            }
        }
    }
}
// End Listing Data Method

// Start Manage Booking Data Method
static void ManageBookingData(Transaction[] transactions, TransactionUtility transactionUtility) 
{
    while (true) 
    {
    System.Console.WriteLine("====================================");
    System.Console.WriteLine("To View Available Sessions, Enter: 1");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To Change Booking Status, Enter: 2");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To Exit The Program, Enter 3");
    System.Console.WriteLine("====================================");

        string userInput = Console.ReadLine();
        int userInput1;

        if (int.TryParse(userInput, out userInput1))
        {
            if (userInput1 == 1)
            {
            System.Console.WriteLine("View Available Sessions Selected");
            transactionUtility.GetTransactionsFile();
            transactionUtility.DisplayAvailableTransactions();
            }
            else if (userInput1 == 2)
            {
            System.Console.WriteLine("Edit Listing Information Selected");
            transactionUtility.GetTransactionsFile();
            transactionUtility.ChangeStatus();
            }
            else if (userInput1 == 3)
            {
            System.Console.WriteLine("Program Exit...");
            Environment.Exit(0);
            }
            else
            {
            System.Console.WriteLine("Invalid Input...");
            }
        }
    }
}
//End Manage Booking Data Method

// Start Manage Report Data Method
static void ManageReportData(Transaction[] transactions, TransactionUtility transactionUtility) 
{
    while (true) 
    {
    System.Console.WriteLine("===============================");
    System.Console.WriteLine("To View Past Sessions, Enter: 1");
    System.Console.WriteLine("-------------------------------");
    System.Console.WriteLine("To Exit The Program, Enter: 2");
    System.Console.WriteLine("===============================");

        string userInput = Console.ReadLine();
        int userInput1;

        if (int.TryParse(userInput, out userInput1))
        {
            if (userInput1 == 1)
            {
            System.Console.WriteLine("View Past Sessions Selected");
            System.Console.WriteLine("Enter Customer Email: ");
            transactionUtility.GetTransactionsFile();
            transactionUtility.DisplayPastCustomerByEmail();
            }
            else if (userInput1 == 2)
            {
            System.Console.WriteLine("Program Exit...");
            Environment.Exit(0);
            }
            else
            {
            System.Console.WriteLine("Invalid Input...");
            }
        }
    }
}
//End Manage Report Data Method

//Start Get Workout Plan Method

static void GetWorkoutPlan()
{
    while (true) 
    {
    System.Console.WriteLine("====================================");
    System.Console.WriteLine("To View Abdominal Workouts, Enter: 1");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To View Arm Workouts, Enter: 2");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To View Chest Workouts, Enter: 3");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To View Leg Workouts, Enter: 4");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To View Back Workouts, Enter: 5");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To View Shoulder Workouts, Enter: 6");
    System.Console.WriteLine("------------------------------------");
    System.Console.WriteLine("To Exit, Enter: 7 ");
    System.Console.WriteLine("====================================");

        string userInput = Console.ReadLine();
        int userInput1;

        if (int.TryParse(userInput, out userInput1))
        {
            if (userInput1 == 1)
            {
            System.Console.WriteLine("Abdominal Workouts Selected");
            System.Console.WriteLine("Plank");
            System.Console.WriteLine("Crunch");
            System.Console.WriteLine("Cable Crunch");
            System.Console.WriteLine("Bicycle Crunch");
            System.Console.WriteLine("Russian Twist");
            System.Console.WriteLine("Jackknife");
            
            }
            else if (userInput1 == 2)
            {
            System.Console.WriteLine("Arm Workouts Selected");
            System.Console.WriteLine("Bicep Curl");
            System.Console.WriteLine("Overhead Triceps Extension");
            System.Console.WriteLine("Press Up");
            System.Console.WriteLine("Hammer Curl");
            System.Console.WriteLine("Triceps Dip");
            System.Console.WriteLine("Pull-Up");
            }
            else if (userInput1 == 3)
            {
                System.Console.WriteLine("BenchPress");
                System.Console.WriteLine("Cable Crossover");
                System.Console.WriteLine("Dip");
                System.Console.WriteLine("Pushup");
                System.Console.WriteLine("Dumbbell Bench Press");
                System.Console.WriteLine("Incline Dumbell Press");
            }
            else if (userInput1 == 4)
            {
                System.Console.WriteLine("Calf Raises");
                System.Console.WriteLine("Leg Curl");
                System.Console.WriteLine("Squats");
                System.Console.WriteLine("Leg Press");
                System.Console.WriteLine("Leg Extension");
                System.Console.WriteLine("Back Squat");
            }
            else if (userInput1 == 5)
            {
                System.Console.WriteLine("Bent-Over Row");
                System.Console.WriteLine("Pull-Down");
                System.Console.WriteLine("T-Bar Row");
                System.Console.WriteLine("Pull-Up");
                System.Console.WriteLine("Seated Cable Rows");
                System.Console.WriteLine("Back Extension");
            }
            else if (userInput1 == 6)
            {
                System.Console.WriteLine("Dumbell Lateral Raise");
                System.Console.WriteLine("Upright Row");
                System.Console.WriteLine("Face Pull");
                System.Console.WriteLine("Overhead Press");
                System.Console.WriteLine("Arnold Press");
                System.Console.WriteLine("Bent Over Reverse Fly");
            }
            else if (userInput1 == 7)
            {
                System.Console.WriteLine("Program Exit...");
                Environment.Exit(0);
            }
            else
            {
            System.Console.WriteLine("Invalid Input...");
            }
        }
    }
}
//End Workout Choice Method
// End Main Program


