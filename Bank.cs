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

        this.loans = new List<Loan> { };
    }

    public Customer SearchCustomer (string fiscalCode)
    {
        foreach (Customer customer in this.customers)
        {
            if(customer.fiscalCode == fiscalCode)
            {
                Console.WriteLine("il codice fiscale e' presente nella nostra banca"); 
            } 
        }
        return null;
    }

    public void AddCustomer (Customer customer)
    {
        customers.Add(customer);
    }

    public void EditCustomer (Customer customer)
    {

    }
    public void AddLoan(Loan loan)
    {
        this.loans.Add(loan);
    }
}

