using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBaseState : MonoBehaviour, IEnemyState
{
    protected Transform _playerTransform;
    public Transform PlayerTransform => _playerTransform;
    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
}
