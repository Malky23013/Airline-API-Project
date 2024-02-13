namespace Solid.API.Entities
{
    public class Flight
    {
        public int Id { get; private set; }

        public static int id { private get; set; }

        public string Company { get; set; }

        public string Destination { get; set; }

        public string Source { get; set; }

        public List<Ticket> tickets { get; set; }

        public List<Passenger> passengers { get; set; }

        public Flight(string company, string destination, string source)
        {
            id += 1;
            Id = id;
            Company = company;
            Destination = destination;
            Source = source;
        }

        public Flight()
        {
            id++;
            Id = id;
        }
    }
}
