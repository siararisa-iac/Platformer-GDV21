using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour 
{
    [SerializeField]
    protected int maxHealth = 3;

    private int currentHealth;

    private void Start()
    {
        Initialize();
    }

    // TODO: We need to have a way to call this when the Game Starts
    private void Initialize()
    {
        currentHealth = maxHealth;
        LogHealth();
    }

    public void UpdateHealth(int value)
    {
        currentHealth += value;
        LogHealth();

        if (currentHealth <= 0)
        {
            GameManager.Instance.SetEndGameStatus(false);
        }
    }

    private void LogHealth()
    {
        Debug.Log($"{gameObject.name}'s Health = {currentHealth} / {maxHealth}");
    }
}