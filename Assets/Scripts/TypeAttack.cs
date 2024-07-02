using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeAttack : Bullet, ITypeDamage
{
    public Type Type => _type;

    [SerializeField]
    Type _type;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<ITypeDamageReceiver>(out var typeDamage))
        {
            typeDamage.GetTypeDamage(this);
        }
    }
}