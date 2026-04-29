using homework_13._1;

Account john = new Account("John`s account"); 
Account johnPolandAccount = new Account("John`s account in Poland");

john.Deposit(10_000);
johnPolandAccount.Deposit(5_000);
john.Withdrawal(1300);
johnPolandAccount.Withdrawal(2_320);
Console.WriteLine("The balance of John`s account is now: " + john.GetBalance());
Console.WriteLine("The balance of John`s other account is now: " + johnPolandAccount.GetBalance());
