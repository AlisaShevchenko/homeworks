namespace homework_13._1;

public class Transaction
{
    public Transaction(decimal amount,  TransactionKind kind)
    {
        Amount = amount;
        Date = DateTime.Now;
        Kind = kind;
    }

    public decimal Amount { get; }
    public DateTime Date { get; }
    public TransactionKind Kind { get; }
    }
