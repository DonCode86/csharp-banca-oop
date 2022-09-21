public class Loan
{
    public int id { get; set; }
    public Customer customer { get; set; }
    public int loanAmount { get; set; }
    public int loanInstalament { get; set; }

    public DateTime? startDate { get; set; }
    public DateTime? endDate { get; set; }

    public Loan (Customer customer, int loanAmount, int loanInstalament, DateTime? startDate, DateTime? endDate)
    {
        this.id = id;
        this.customer = customer;
        this.loanAmount = loanAmount;
        this.loanInstalament = loanInstalament;
        this.startDate = startDate;
        this.endDate = endDate;
    }
}