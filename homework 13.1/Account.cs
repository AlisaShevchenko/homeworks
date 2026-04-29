namespace homework_13._1;

public class Account
{
    public Account(string nameOfAccount)
    {
        NameOfAccount = nameOfAccount;
    }

    public string NameOfAccount { get; }
    public List<Transaction> Transactions { get; } = new List<Transaction>();

    public void Deposit(decimal amount)
    {
        Transaction newTransaction = new Transaction(amount, TransactionKind.Deposit);
        Transactions.Add(newTransaction);
    }

    public void Withdrawal(decimal amount)
    {
        Transaction newTransaction = new Transaction(amount, TransactionKind.Withdrawal);
        Transactions.Add(newTransaction);
    }
    public decimal GetBalance()
    {
        return Transactions.Sum(t => t.Kind == TransactionKind.Deposit ? t.Amount: -t.Amount);
    }
}