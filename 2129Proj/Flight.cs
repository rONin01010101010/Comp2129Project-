namespace COMP2129;

public class Flight
{
    public int flightNumber; //not supposed to be public but works with the logic of my flight manager class fix later on 
    private string origin;
    private string destination;
    private int maxSeats;
    private int numOfPassengers;

    public Flight(int flightNumber, string origin, string destination, int maxSeats, int numOfPassengers)
    {
        this.flightNumber = flightNumber;
        this.origin = origin;
        this.destination = destination;
        this.maxSeats = maxSeats;
        this.numOfPassengers = numOfPassengers;
    }

    public int getFlightNum()
    {
        Random rnd = new Random();
        return this.flightNumber = rnd.Next();
    }

    public string getflightOrigin()
    {
        return origin;
    }

    public string getflightDestination()
    {
        return destination;
    }

    public int getflightMaxSeats()
    {
        return maxSeats;
    }

    public int getnumOfPassengers()
    {
        return numOfPassengers; //won't the number of passengers be based on the number of customers who booked that flight 

    }

}
