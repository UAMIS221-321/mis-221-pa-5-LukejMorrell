namespace PA5;

    public class Trainer
    {
        private string trainerID;
        private string trainerName;
        private string mailingAddress;
        private string trainerEmailAddress;
        static private int count;

        // constructors
        // no arg
        public Trainer() 
        {

        }
        // overloaded constructor

        public Trainer(string trainerID, string trainerName, string mailingAddress, string trainerEmailAddress) 
        {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmailAddress = trainerEmailAddress;
        }

        static public void IncCount() // increases count
        {
            Trainer.count++;
        }
        // start getters and setters
        static public void SetCount(int count) 
        { 
            Trainer.count = count;
        }
        static public int GetCount() 
        {
            return Trainer.count;
        }
        public void SetTrainerID(string trainerID) 
        {
            this.trainerID = trainerID;
        }

        public string GetTrainerID() 
        {
            return trainerID;
        }
        public void SetTrainerName(string trainerName) 
        {
            this.trainerName = trainerName;
        }

        public string GetTrainerName() 
        {
            return trainerName;
        }
        public void SetMailingAddress(string mailingAddress) 
        {
            this.mailingAddress = mailingAddress;
        }
        public string GetMailingAddress() 
        {
            return mailingAddress;
        }
        public void SetTrainerEmailAddress(string trainerEmailAddress) 
        {
            this.trainerEmailAddress = trainerEmailAddress;
        }

        public string GetTrainerEmailAddress() 
        {
            return trainerEmailAddress;
        }
// end getters and setters 
        public override string ToString()
        {
            return $"Trainer ID: {trainerID} | Name: {trainerName} | Mailing Address: {mailingAddress} | Email Address: {trainerEmailAddress}";
        }

        public string ToFile()
        {
            return $"{trainerID}#{trainerName}#{mailingAddress}#{trainerEmailAddress}";
        }
    } 
