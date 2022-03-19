namespace homework1;

public class Program
{
    public static void Display(IEnumerable<Client> clients)
    {
        foreach (var client in clients) Console.WriteLine(client);
    }

    public static void DisplayOlder(IEnumerable<Client> clients)
    {
        foreach (var client in clients.Where(c => DateTime.Now.Year - c.BirthYear > 40)) Console.WriteLine(client);
    }

    public static void Main(string[] args)
    {
        IEnumerable<Client> clients = new List<Client>()
        {
            new Client() {Id = 1, FirstName = "Ana", LastName = "Popescu", BirthYear = 1984},
            new Client() {Id = 2, FirstName = "Mara", LastName = "Radu", BirthYear = 1974},
            new Client() {Id = 3, FirstName = "Marius", LastName = "Paun", BirthYear = 1954},
            new Client() {Id = 4, FirstName = "Flavia", LastName = "Dumitrescu", BirthYear = 1993},
            new Client() {Id = 5, FirstName = "Ioan", LastName = "Vasilescu", BirthYear = 1984},
            new Client() {Id = 6, FirstName = "Dana", LastName = "Constantinescu", BirthYear = 2005},
            new Client() {Id = 7, FirstName = "Ana", LastName = "Popescu", BirthYear = 2000},
            new Client() {Id = 8, FirstName = "Flavia", LastName = " Dumitrescu ", BirthYear = 1993}
        };
        Console.WriteLine("Ex1:");
        Display(clients);
        Console.WriteLine("Ex2: ");
        DisplayOlder(clients);

        IEnumerable<Client> clients2 = new List<Client>()
        {
            new Client() {Id = 9, FirstName = "Anaaaa", LastName = "Popescuuuu", BirthYear = 1964},
            new Client() {Id = 10, FirstName = "aaaa", LastName = "Raduuuu", BirthYear = 1954},
            new Client() {Id = 11, FirstName = "Mariusssss", LastName = "Paunnnn", BirthYear = 2000},
            new Client() {Id = 12, FirstName = "Flaviaaa", LastName = "Dumitrescuuu", BirthYear = 2001},
            new Client() {Id = 13, FirstName = "Ioannnn", LastName = "Vasilescuuuu", BirthYear = 1934},
            new Client() {Id = 8, FirstName = "Flavia", LastName = " Dumitrescu ", BirthYear = 1993}
        };
        var result = clients.Concat(clients2).OrderBy(c=>c.FirstName);
        Console.WriteLine("Concat:");
        Display(result);
        var result1 = clients.Union(clients2);
        Console.WriteLine("Union:");
        Display(result1);
        Console.WriteLine("Order:");
        Display(clients.OrderBy(c => c.LastName.Length).ThenByDescending(c => c.BirthYear));
    }
}