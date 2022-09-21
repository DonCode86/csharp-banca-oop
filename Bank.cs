using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

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

    public List<Loan> SearchLoan (string fiscalCode)
    {
        List<Loan> loans = new List<Loan>();
        {
            foreach (Loan loan in this.loans)
            {
                if (loan.customer.fiscalCode.Contains(fiscalCode))
                {
                    loans.Add((Loan)loan);
                    Console.WriteLine("E' presente un prestito per il codice fiscale inserito, " +
                        "l'ammontare del prestito è: " + loan.loanAmount + " euro");
                } else
                {
                    Console.WriteLine("Non è presente nessun prestito per il codice fiscale inserito");
                }
            }
        }
        return null;
    }
    
}

