using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTypeComponent : HealthComponent, ITypeDamageReceiver
{
    [SerializeField]
    Type type;

    float weakMultiplier = 1.5f;
    float strongMultiplier = 0.5f;

    public void GetTypeDamage(ITypeDamage damage)
    {
        if (type.strongType == damage.Type)
            GetDamage(damage, strongMultiplier);
        else if (type.weakType == damage.Type)
            GetDamage(damage, weakMultiplier);
        else
            GetDamage(damage);
    }

    private void GetDamage(ITypeDamage damage, float multiplier = 1f)
    {
        Health -= damage.Amount * multiplier;
    }
}