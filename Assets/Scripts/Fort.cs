using UnityEngine;

public class Fort : MonoBehaviour
{
    [SerializeField] private int _health = 100;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            _health--;
            CheckHealth();
        }
    }

    private void CheckHealth()
    {
        if (_health <= 0)
        {
            //Game Over
            Destroy(gameObject);
        }
    }
}