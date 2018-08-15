using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Transform _target;

    [SerializeField] private int _scoreValue = 1;

    private void Awake()
    {
        //When object pooling is implemented all the below logic will be put into OnEnable
        _agent = gameObject.GetComponent<NavMeshAgent>();
        _target = FindObjectOfType<Fort>().gameObject.transform;

        _agent.SetDestination(_target.position);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Fort"))
        {
            //When object pooling send back to queue do not destroy
            Destroy(gameObject);
        }
    }
}