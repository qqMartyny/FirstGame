using UnityEngine;

public class Dameger : MonoBehaviour
{
    [SerializeField] private float Damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool hasHealth = collision.TryGetComponent<Character>(out var Character);
        bool otherHealth = !collision.CompareTag(tag);
        if (hasHealth && otherHealth)
        {
            Character.TakeDamage(Damage);
        }
    }
}