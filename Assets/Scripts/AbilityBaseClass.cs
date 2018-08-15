using UnityEngine;

public abstract class AbilityBaseClass : ScriptableObject
{
    public abstract void Activate(Transform abilitySpawnPoint);
}