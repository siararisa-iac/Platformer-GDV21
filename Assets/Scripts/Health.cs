using UnityEngine;
using UnityEngine.UI;

public abstract class Health : MonoBehaviour 
{
    [SerializeField]
    protected int maxHealth = 3;

    private int currentHealth;

    private void Start()
    {
        GameManager.Instance.OnGameStarted += Initialize;
        Initialize();
    }

    // TODO: We need to have a way to call this when the Game Starts
    private void Initialize()
    {
        currentHealth = maxHealth;
        OnHealthUpdated(currentHealth);
    }

    public void UpdateHealth(int value)
    {
        currentHealth += value;
        OnHealthUpdated(currentHealth);

        if (currentHealth <= 0)
        {
            OnDeath();
        }
    }

    protected abstract void OnDeath();
    protected abstract void OnHealthUpdated(int currentHealth);
}