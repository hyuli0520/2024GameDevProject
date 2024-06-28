using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageReceiver
{

    public void GetDamage(IDamage damage);

}

public interface ITypeDamageReceiver : IDamageReceiver
{
    public void GetTypeDamage(ITypeDamage damage);
}

public interface IDamage
{
    public float Amount { get; }


    public void ApplyDamage(IDamageReceiver receiver) { }

}

public interface ITypeDamage : IDamage
{
    public Type type { get; }
}