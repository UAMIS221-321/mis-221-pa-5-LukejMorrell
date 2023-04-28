using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA5;

    public class ListingUtility
    {
        private Listing[] listings;

        public ListingUtility(Listing[] listings) 
        {
            this.listings = listings;
        }

        public void GetListingsFile() 
        {
            //open the file

            StreamReader inFile1 = new StreamReader("listings.txt");

            //process file
            
            string fileContents1 = inFile1.ReadLine();
            Listing.SetCount(0);

            while(fileContents1 != null) 
            {
                string[] temp1 = fileContents1.Split('#');
                listings[Listing.GetCount()] = new Listing(temp1[0], temp1[1], temp1[2], temp1[3], temp1[4], temp1[5]);
                
                fileContents1 = inFile1.ReadLine();
                
                Listing.IncCount();
            } 

            //close the file

            inFile1.Close();
        }
        
        public int FindListing(string listingIDSearch) 
        { 
            for(int i = 0; i < Listing.GetCount(); i++) {
                if(listings[i].GetListingID() == listingIDSearch.ToLower()) 
                {
                    return i;
                }
            }
            return -1;
        }
        
       
        private void Save() 
        {
            StreamWriter outFile1 = new StreamWriter("listings.txt");

            for(int i = 0; i < Listing.GetCount(); i++) {
                outFile1.WriteLine(listings[i].ToFile());
            }

            outFile1.Close();
        }
        public void AddListing() 
        {
            System.Console.WriteLine("Enter The New Listing ID: ");
            Listing myListing = new Listing();
            myListing.SetListingID(Console.ReadLine());

            System.Console.WriteLine("Enter The New Trainer's Name: ");
            myListing.SetTrainerName(Console.ReadLine());

            System.Console.WriteLine("Enter The New Session Date: ");
            myListing.SetSessionDate(Console.ReadLine());

            System.Console.WriteLine("Enter The New Session Time: ");
            myListing.SetSessionTime(Console.ReadLine());

            System.Console.WriteLine("Enter The New Session Cost: ");
            myListing.SetSessionCost(Console.ReadLine());

            System.Console.WriteLine("Enter The New Session Taken Status: ");
            myListing.SetSessionTakenStatus(Console.ReadLine());

            listings[Listing.GetCount()] = myListing;
            Listing.IncCount();
            Save();
        }

      

    

        public void EditListing() 
        {
            Console.WriteLine("Enter Listing ID To Edit The Listing Information: ");
            string listingIDSearch = Console.ReadLine();
            int foundIndex = FindListing(listingIDSearch);

            if(foundIndex != -1) 
            {
                
                System.Console.WriteLine("Enter A New Listing ID: ");
                listings[foundIndex].SetListingID(Console.ReadLine());
                System.Console.WriteLine("Enter A New trainer name: ");
                listings[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Enter A New Session Date: ");
                listings[foundIndex].SetSessionDate(Console.ReadLine());
                System.Console.WriteLine("Enter A New Session Time: ");
                listings[foundIndex].SetSessionTime(Console.ReadLine());
                System.Console.WriteLine("Enter A New Session Cost: ");
                listings[foundIndex].SetSessionCost(Console.ReadLine());
                System.Console.WriteLine("Enter A New Session Status: ");
                listings[foundIndex].SetSessionTakenStatus(Console.ReadLine());


                Save();
            }
            else 
            {
                Console.WriteLine("Invalid Listing ID..."); 
            }
        }

        public void DeleteListing() 
        {
            Console.WriteLine("Enter Listing ID To Delete The Listing's Information: ");
            string listingIDSearch = Console.ReadLine();
            if(listingIDSearch.ToUpper() == "CANCEL") 
            {
                return;
            }
            else 
            {
            int foundIndex = FindListing(listingIDSearch);
            string[] lines = File.ReadAllLines("listings.txt");

            if(foundIndex != -1) 
            {
                if(foundIndex >= 0 && foundIndex < lines.Length) 
                {
                    lines[foundIndex] = null;
                    lines = lines.Where(x => x != null).ToArray();
                }
                File.WriteAllLines("listings.txt", lines);
                 
                Console.WriteLine("Listing Deleted");
                
            }
            else 
            {
                
                Console.WriteLine("Invalid Listing ID...");
                
            }
            }
        }   
    }
