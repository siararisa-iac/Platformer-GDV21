using UnityEngine;

public class PlayerHealthController : Health
{
    protected override void OnDeath()
    {
        GameManager.Instance.SetEndGameStatus(false);
    }

    protected override void OnHealthUpdated(int currentHealth)
    {
       // logic for ui
    }
}
