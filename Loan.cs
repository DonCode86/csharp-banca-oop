public class Loan
{
    public int id { get; set; }
    public Customer customer { get; set; }
    public int loanAmount { get; set; }
    public int loanInstalament { get; set; }

    public DateTime? startDate { get; set; }
    public DateTime? endDate { get; set; }
}