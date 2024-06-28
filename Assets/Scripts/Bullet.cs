using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IDamage
{
    public float Amount => damage;

    [SerializeField]
    float damage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<IDamageReceiver>(out var damageReceiver))
        {
            damageReceiver.GetDamage(this);
        }
    }
}