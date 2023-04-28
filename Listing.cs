namespace PA5;
public class Listing
{
    private string listingID;
    
    private string trainerName;

    private string sessionDate;
    
    private string sessionTime;
    
    private string sessionCost;

    private string sessionTakenStatus;

    
    private static int count;
// constructors
// no arg
    public Listing()
    {

    }
    // overloaded constructor
    public Listing(string listingID, string trainerName, string sessionDate, string sessionTime, string sessionCost, string sessionTakenStatus)
    {
        this.listingID = listingID;
        this.trainerName = trainerName;
        this.sessionDate = sessionDate;
        this.sessionTime = sessionTime;
        this.sessionCost = sessionCost;
        this.sessionTakenStatus = sessionTakenStatus;
    }

    static public void IncCount()
    {
        Listing.count++;
    }
    // start getters and setters 
   
    static public void SetCount(int count) 
    { 
        Listing.count = count;
    }
    static public int GetCount() 
    {
        return Listing.count;
    }

    public void SetListingID(string listingID)
    {
        this.listingID = listingID;
    }
    public string GetListingID()
    {
        return listingID;
    }
    public void SetTrainerName(string trainerName)
    {
        this.trainerName = trainerName;
    }
    public string GetTrainerName()
    {
        return trainerName;
    }
    public void SetSessionDate(string sessionDate)
    {
        this.sessionDate = sessionDate;
    }
    public string GetSessionDate()
    {
        return sessionDate;
    }
    public void SetSessionTime(string sessionTime)
    {
        this.sessionTime = sessionTime;
    }
    public string GetSessionTime()
    {
        return sessionTime;
    }
    public void SetSessionCost(string sessionCost)
    {
        this.sessionCost = sessionCost;
    }
    public string GetSessionCost()
    {
        return sessionCost;
    }
    public void SetSessionTakenStatus(string sessionTakenStatus)
    {
        this.sessionTakenStatus = sessionTakenStatus;
    }
    public string GetSessionTakenStatus()
    {
        return sessionTakenStatus;
    }
    // end getters and setters 
    
    public override string ToString()
    {
        return $"Listing ID: {listingID} | Trainer Name: {trainerName} | Session Date: {sessionDate} | Session Time: {sessionTime} | Session Cost: {sessionCost} | Session Taken Status: {sessionTakenStatus}";
    }
    public string ToFile()
    {
        return $"{listingID}#{trainerName}#{sessionDate}#{sessionTime}#{sessionCost}#{sessionTakenStatus}";
    }
}
    