using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTypeComponent : HealthComponent, ITypeDamageReceiver
{
    [SerializeField]
    Type type;

    public void GetTypeDamage(ITypeDamage damage)
    {
        if (type.strongType == damage.type)
            Health -= (damage.Amount * 0.5f);
        else if (type.weakType == damage.type)
            Health -= (damage.Amount * 1.5f);
        else
            Health -= damage.Amount;
    }
}