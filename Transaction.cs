using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA5;

    public class Transaction
    {
        //fields
        private string sessionID;
        private string customerName;
        private string customerEmail;
        private string trainingDate;
        private string trainerID;
        private string trainerName;
        private string status;
        
        private static int count;
        //Methods
        //Constructors

        public Transaction()
        {
            
        }
        public Transaction(string sessionID, string customerName, string customerEmail, string trainingDate, string trainerID, string trainerName, string status)
        {
            this.sessionID = sessionID;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.status = status;
        }
        //EndConstructors
        static public void IncCount() 
        {
            Transaction.count++;
        }
        //Start Getters And Setters
        static public void SetCount(int count) 
        { 
            Transaction.count = count;
        }
        static public int GetCount() 
        {
            return Transaction.count;
        }
        public void SetSessionID(string sessionID)
        {
            this.sessionID = sessionID;
        }
        public string GetSessionID()
        {
            return sessionID;
        }
        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
        public string GetCustomerName()
        {
            return customerName;
        }
        public void SetCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }
        public string GetCustomerEmail()
        {
            return customerEmail;
        }
        public void SetTrainingDate(string trainingDate)
        {
            this.trainingDate = trainingDate;
        }
        public string GetTrainingDate()
        {
            return trainingDate;
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
        public void SetStatus(string status)
        {
            this.status = status;
        }
        public string GetStatus()
        {
            return status;
        } 
        // End Getters And Setters

        public override string ToString()
        {
            return $"Session ID: {sessionID} | Customer Name: {customerName} | Customer Email: {customerEmail} | Training Date: {trainingDate} | Trainer ID: {trainerID} | Trainer Name: {trainerName} | Status: {status}";
        }
        public string ToFile()
        {
            return $"{sessionID}#{customerName}#{customerEmail}#{trainingDate}#{trainerID}#{trainerName}#{status}";
        }

    }
    //End Methods
