using UnityEngine;
using System.Collections.Generic;
public class CurrencyManager : Singleton<CurrencyManager>
{
    // data collection that will store all currencies in game
    private List<Currency> currencies;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        currencies = new List<Currency>()
        {
            new(CurrencyType.Coin, 100, 99999),
            new(CurrencyType.Gem, 0, 99999)
        };
    }

    public void AddCurrency(CurrencyType currencyType, int amountToAdd)
    {
        foreach (Currency currency in currencies)
        {
            if (currency.CurrencyType == currencyType)
            {
                currency.Balance += amountToAdd;
                currency.Balance = Mathf.Min(currency.Balance, currency.MaxBalance);
                Debug.Log($"{currencyType} Balance is: {currency.Balance} / {currency.MaxBalance}");
            }
        }
    }
}
