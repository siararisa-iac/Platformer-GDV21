using System.Collections.Generic;
using UnityEngine;

public class BalanceView : MonoBehaviour
{
    [SerializeField]
    private List<CurrencyUIData> currencyUI;

    public CurrencyUIData GetCurrencyUI(CurrencyType type)
    {
        foreach (CurrencyUIData currency in currencyUI)
        {
            if (currency.CurrencyType == type)
            {
                return currency;
            }
        }
        return null;
    }
}
