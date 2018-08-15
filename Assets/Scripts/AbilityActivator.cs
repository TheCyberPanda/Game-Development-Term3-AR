using UnityEngine;

public class AbilityActivator : MonoBehaviour
{
    private GameObject _firePoint;
    [SerializeField] private AbilityBaseClass _ability1;

    private void Awake()
    {
        _firePoint = GameObject.Find("FirePoint");
    }

    private void Update()
    {
        Abilityinput();
    }

    private void Abilityinput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _ability1.Activate(_firePoint.transform);
            Debug.Log("Input recieved");
        }
    }
}