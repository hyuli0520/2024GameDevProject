using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour, IDamageReceiver
{
    public float startHealth;

    [field: SerializeField]
    public float Health
    {
        get; protected set;
    }

    protected void Start()
    {
        Health = startHealth;
    }

    private void Update()
    {
        if (Health < 0)
            Die();
    }

    public void GetDamage(IDamage damage)
    {
        Health -= damage.Amount;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}