public class Customer
{
    public string name { get; set; }
    public string lastName { get; set; }
    public string fiscalCode { get; set; }
    public int salary { get; set; }

    public Customer (string name, string lastName, string fiscalCode, int salary)
    {
        this.name = name;
        this.lastName = lastName;
        this.fiscalCode = fiscalCode;
        this.salary = salary;
    }
}
