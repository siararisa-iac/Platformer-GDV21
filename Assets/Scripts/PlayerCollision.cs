using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<ICollectable>(out var collectable))
        {
            collectable.Collect(this.gameObject);
        }
    }
}
