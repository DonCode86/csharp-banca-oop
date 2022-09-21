// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
//La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)
//I clienti sono caratterizzati da
//nome,
//cognome,
//codice fiscale
//stipendio
//I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.
//Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.
//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.
public class Bank
{
    public string name { get; set; }
    public List<Customer> customers { get; set; } 
    public List<Loan> loans { get; set; }

}

public class Customer
{
    public string name { get; set; }
    public string lastName { get; set; }
    public string fiscalCode { get; set; }
    public int salary { get; set; }
}

public class Loan
{
    public int id { get; set; }
    public Customer customer { get; set; }
    public int loanAmount { get; set; }
    public int loanInstalament { get; set; }

    public DateTime? startDate { get; set; }
    public DateTime? endDate { get; set; }
}