namespace PA5;
    public class TrainerUtility
    {
        private Trainer[] trainers;

        public TrainerUtility(Trainer[] trainers) 
        {
            this.trainers = trainers;
        }

        public void GetTrainersFile() 
        {
            // Open The File


            StreamReader inFile = new StreamReader("trainers.txt");

            // Processing File
            
            string fileContents = inFile.ReadLine();
            Trainer.SetCount(0);

            while(fileContents != null) 
            {
                string[] temp = fileContents.Split('#');
                trainers[Trainer.GetCount()] = new Trainer(temp[0], temp[1], temp[2], temp[3]);
                
                fileContents = inFile.ReadLine();
                Trainer.IncCount();
            } 

            // CLose File
            
            inFile.Close();
        }
        
        public int FindTrainer(string trainerIDSearch) 
        {  // searches for trainer id, returns -1 when found
            for(int i = 0; i < Trainer.GetCount(); i++) 
            {
                if(trainers[i].GetTrainerID() == trainerIDSearch.ToLower()) 
                {
                    return i;
                }
            }
            return -1;
        }
        
       
        private void Save() { // saves changes made to file 
            StreamWriter outFile = new StreamWriter("trainers.txt");

            for(int i = 0; i < Trainer.GetCount(); i++) 
            {
                outFile.WriteLine(trainers[i].ToFile());
            }

            outFile.Close();
        }
        public void AddTrainer() // adds new trainer to object and file
        {
            Console.WriteLine("Enter The New Trainer's ID: ");
            Trainer myTrainer = new Trainer();
            myTrainer.SetTrainerID(Console.ReadLine());

            Console.WriteLine("Enter The New Trainer's Name: ");
            myTrainer.SetTrainerName(Console.ReadLine());

            Console.WriteLine("Enter The New Trainer's Mailing Address: ");
            myTrainer.SetMailingAddress(Console.ReadLine());

            Console.WriteLine("Enter The New Trainer's Email Address: ");
            myTrainer.SetTrainerEmailAddress(Console.ReadLine());

            trainers[Trainer.GetCount()] = myTrainer;
            Trainer.IncCount();
            Save();
        }

      

    

        public void EditTrainer() // edits trainer after providing trainer id
        {
            Console.WriteLine("Enter Trainer's ID To Edit The Trainer's Information: ");
            string trainerIDSearch = Console.ReadLine();
            int foundIndex = FindTrainer(trainerIDSearch);

            if(foundIndex != -1) {
                
                Console.WriteLine("Enter a new trainer ID: ");
                trainers[foundIndex].SetTrainerID(Console.ReadLine());
                Console.WriteLine("Enter a new trainer name: ");
                trainers[foundIndex].SetTrainerName(Console.ReadLine());
                Console.WriteLine("Enter a new trainer mailing address: ");
                trainers[foundIndex].SetMailingAddress(Console.ReadLine());
                Console.WriteLine("Enter a new trainer email address: ");
                trainers[foundIndex].SetTrainerEmailAddress(Console.ReadLine());

                Save();
            }
            else {
                Console.WriteLine("Invalid Trainer ID..."); 
            }
        }

        public void DeleteTrainer() // Finds and Deletes all trainer information based off Trainer id
        {
            Console.WriteLine("Enter Trainer's ID To Delete The Trainer's Information: ");
            string trainerIDSearch = Console.ReadLine();
            if(trainerIDSearch.ToUpper() == "CANCEL") 
            {
                return;
            }
            else 
            {
            int foundIndex = FindTrainer(trainerIDSearch);
            string[] lines = File.ReadAllLines("trainers.txt");

            if(foundIndex != -1) 
            {
                if(foundIndex >= 0 && foundIndex < lines.Length) 
                {
                    lines[foundIndex] = null;
                    lines = lines.Where(x => x != null).ToArray();
                }
                File.WriteAllLines("trainers.txt", lines);
                 
                Console.WriteLine("Trainer deleted");
                
            }
            else 
            {
                
                Console.WriteLine("Invalid Trainer ID...");
                
            }
            }
        }   


    }
