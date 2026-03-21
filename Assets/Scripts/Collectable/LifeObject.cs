using UnityEngine;

public class LifeObject : MonoBehaviour, ICollectable
{
    public void Collect(GameObject collector)
    {
        if(collector.TryGetComponent<Health>(out var health))
        {
            health.UpdateHealth(1);
            Destroy(gameObject);
        }
    }
}
