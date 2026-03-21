using UnityEngine;

public class CoinObject : MonoBehaviour, ICollectable, IAnimatable
{
    [SerializeField]
    private int amountToAdd = 50;

    public void Animate()
    {
        
    }

    public void Collect(GameObject collector)
    {
        CurrencyManager.Instance.AddCurrency(CurrencyType.Coin, amountToAdd);
        Destroy(gameObject);
    }
}
