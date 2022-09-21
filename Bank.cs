public class Bank
{
    public string name { get; set; }
    public List<Customer> customers { get; set; } 
    public List<Loan> loans { get; set; }

    public Bank(string name)
    {
        this.name = name;
        Customer customer1 = new Customer("Daniele", "Ciccarelli", "CCCDNL86A13D810A", 1000);
        Customer customer2 = new Customer("Mario", "Rossi", "MRARSS81A11R210Z", 2000);
        this.customers = new List<Customer> { customer1, customer2 };
        this.loans = loans;
    }
}
