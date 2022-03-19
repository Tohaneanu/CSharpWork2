namespace homework1;

public class Client :IComparable
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }

    public override string ToString()
    {
        return $"Client id: {this.Id}, name: {this.FirstName + " " + this.LastName}, birth year: {this.BirthYear}";
    }

    public int CompareTo(object? obj)
    {
        return this.GetHashCode() - obj.GetHashCode();
    }


    public override bool Equals(object? obj)
    {
        return this.GetHashCode() - obj.GetHashCode() >= 0;
    }

    public override int GetHashCode()
    {
        return this.Id * 13 + this.FirstName.Length * 11;
    }
}