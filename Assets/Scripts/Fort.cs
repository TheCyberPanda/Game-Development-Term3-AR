using UnityEngine;

public class Fort : MonoBehaviour
{
    [SerializeField] private int _health = 100;

    [SerializeField] private Canvas _gameOverCanvas;

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
            
            //REFACTOR INTO OWN CLASS
            _gameOverCanvas.gameObject.SetActive(true);
        }
    }
}