using UnityEngine;
[CreateAssetMenu(menuName = "abilities/Fireball")]
public class Fireball : AbilityBaseClass
{
    [SerializeField] private GameObject _fireball;
    
    public override void Activate(Transform abilitySpawnPoint)
    {
        Debug.Log("Launched Fireball");
        Instantiate(_fireball, abilitySpawnPoint.position, abilitySpawnPoint.rotation);
    }
}