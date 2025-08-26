using System;


public class Customer
{
    protected int Id;
}

public class RetailCustomer : Customer
{

    public void Information()
    {
        RetailCustomer RC = new RetailCustomer();   
        RC.Id = Id;
    }
    

    
}

public class Program
{
    public static void Main()
    {

    }
}