using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA5;

public class TransactionUtility
{
        private Transaction[] transactions;

        public TransactionUtility(Transaction[] transactions) 
        {
            this.transactions = transactions;
        }
        // Start Methods
        public void GetTransactionsFile() 
        {
            // Open The File
        
            StreamReader inFile2 = new StreamReader("transactions.txt");

            
            // Process File
            
            string fileContents2 = inFile2.ReadLine();
            Transaction.SetCount(0);

            while(fileContents2 != null) 
            {
                string[] temp2 = fileContents2.Split('#');
                transactions[Transaction.GetCount()] = new Transaction(temp2[0], temp2[1], temp2[2], temp2[3], temp2[4], temp2[5], temp2[6]);
                
                fileContents2 = inFile2.ReadLine();
                Transaction.IncCount();
            } 

            //close The file

            inFile2.Close();
        }
        
        public int FindTransaction(string statusSearch) 
        { 
            for(int i = 0; i < Transaction.GetCount(); i++) {
                if(transactions[i].GetSessionID() == statusSearch.ToLower()) 
                {
                    return i;
                }
            }
            return -1;
        }
        
       
        private void Save() 
        {
            StreamWriter outFile2 = new StreamWriter("transactions.txt");

            for(int i = 0; i < Transaction.GetCount(); i++) {
                outFile2.WriteLine(transactions[i].ToFile());
            }

            outFile2.Close();
        }
        public void DisplayAvailableTransactions()
        {
            StreamReader inFile2 = new StreamReader("transactions.txt"); // displays bookings that have status set to "available"

            string fileContents2 = inFile2.ReadLine();

            while (fileContents2 != null)
                {
                string[] temp2 = fileContents2.Split('#');

                 if (temp2[6].ToLower() == "available")
                {
                Console.WriteLine(fileContents2);
                }

                fileContents2 = inFile2.ReadLine();
                }
            inFile2.Close();
        }

        public void DisplayPastCustomerByEmail() // Displays customer bookings by their email address
        {
            StreamReader inFile2 = new StreamReader("transactions.txt");

            string fileContents2 = inFile2.ReadLine();

            while (fileContents2 != null)
                {
                string[] temp2 = fileContents2.Split('#');

                 if (temp2[2].ToLower() == Console.ReadLine())
                {
                Console.WriteLine(fileContents2);
                }

                fileContents2 = inFile2.ReadLine();
                }
            inFile2.Close();
        }

        public void ChangeStatus()  // allows booking status to be changed
        {
            Console.WriteLine("Enter Session ID To Edit The Session's Status: ");
            string sessionIDSearch = Console.ReadLine();
            int foundIndex = FindTransaction(sessionIDSearch);

            if(foundIndex != -1) 
            {
                
                System.Console.WriteLine("Enter A New Status: ");
                transactions[foundIndex].SetStatus(Console.ReadLine());
                


                Save();
            }
            else 
            {
                Console.WriteLine("Invalid Session ID..."); 
            }
        }
}
// end utility MEthods