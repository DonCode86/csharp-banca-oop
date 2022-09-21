// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
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
Bank myBank = new Bank("Banca Sharp");
Console.WriteLine("Benvenuto in " + myBank.name);

Customer Giuseppe = new Customer("Giuseppe", "Vinelli", "GSPVNL81D20C810A", 500);
myBank.AddCustomer(Giuseppe);

Loan loan1 = new Loan(Giuseppe, 5000, 10, "22/09/2022", "22/07/2023");
Loan loan2 = new Loan(Giuseppe, 10000, 10, "22/09/2022", "22/07/2023");
myBank.AddLoan(loan1);
myBank.AddLoan(loan2);

List<Customer> customerList = myBank.customers;
Console.WriteLine("I clienti totali della banca sono: " + myBank.customers.Count);

foreach (Customer customer in customerList)
{
    Console.WriteLine(customer.name);
}

Console.WriteLine("I prestiti totali della banca sono: " + myBank.loans.Count);

foreach (Loan loan in myBank.loans)
{
    Console.WriteLine("Valore prestito :" + loan.loanAmount);
}

//Console.WriteLine("Inserisci il codice fiscale da cercare: ");
//Customer fcInput = myBank.SearchCustomer(Console.ReadLine());

//Console.WriteLine("Inserisci il codice fiscale per vedere se c'e' un prestito collegato");
//List<Loan> loanInput = myBank.SearchLoan(Console.ReadLine());

Console.WriteLine("Inserisci il codice fiscale per sapere i tuoi prestiti totali");
int totLoanInput = myBank.TotalCustomerLoans(Console.ReadLine());







