using UnityEngine;
using System.Collections.Generic;
using System;
public class CurrencyManager : Singleton<CurrencyManager>
{
    // data collection that will store all currencies in game
    private List<Currency> currencies;

    public Action<CurrencyType, int> OnCurrencyUpdated;

    // public delegate void CurrencyUpdatedDelegate(CurrencyType type, int balance);
    // public event CurrencyUpdatedDelegate OnCurrencyUpdate;

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
                OnCurrencyUpdated?.Invoke(currency.CurrencyType, currency.Balance);

                //if (OnCurrencyUpdated != null)
                //{
                //    OnCurrencyUpdated.Invoke();
                //
            }
        }
    }
}
