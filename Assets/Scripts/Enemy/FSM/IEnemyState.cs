using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyState
{
    public Transform PlayerTransform { get; }

    void EnterState();
    void UpdateState();
    void ExitState();
}
