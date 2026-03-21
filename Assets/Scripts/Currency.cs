using UnityEngine;

// It's just a class that is a data container
public class Currency 
{
    public CurrencyType CurrencyType;
    public int Balance;
    public int MaxBalance;

    public Currency(CurrencyType currencyType, int balance, int maxBalance)
    {
        CurrencyType = currencyType;
        Balance = balance;
        MaxBalance = maxBalance;
    }
}
