using System;

public class Account
{
    double _balance;
    int _id;

    public Account(int id, double balance)
    {
        this._id = id;
        this._balance = balance;
    }
    public int ID
    {
        get
        {
            return _id;
        }
    }

    public void _WithDraw(double amount)
    {
        _balance -= amount;
    }
    public void Deposit(double amount)
    {
        _balance += amount;
    }
}
    
public class AccountManager
{
    Account _fromAccount; 
    Account _toAccount;
    double _amountToTransfer;

    public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
    {
        this._fromAccount = fromAccount;
        this._toAccount = toAccount;
        this._amountToTransfer = amountToTransfer;
    }

    public void Transfer()
    {
        object _lock1, _lock2;
        if(_fromAccount.ID < _toAccount.ID)
        {
            _lock1 = _fromAccount; _lock2 = _toAccount;
        }
        else
        {
            _lock1 = _toAccount; _lock2 = _fromAccount;
        }
            lock (_lock1)
            {
                Console.WriteLine(((Account)_lock1).ID.ToString());
                Thread.Sleep(1000);
                lock (_lock2)
                {
                    Console.WriteLine(((Account)_lock2).ID.ToString());
                    _fromAccount._WithDraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
    }
}

public class MainClass
{
    public static void Main()
    {

        Console.WriteLine("Transfer Started");
        Account account1 = new Account(101, 5000);
        Account account2 = new Account(102, 3000);

        AccountManager A1 = new AccountManager(account1, account2, 1000);
        Thread acc1 = new Thread(A1.Transfer);
        acc1.Name = "T1";

        AccountManager A2 = new AccountManager(account2, account1, 500);      
        Thread acc2 = new Thread(A2.Transfer);
        acc2.Name = "T2";
        acc1.Start();
        //acc2.Start();

        Console.WriteLine("Transfer finished");

    }
}
