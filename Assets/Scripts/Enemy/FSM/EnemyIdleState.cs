using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
    [SerializeField]
    private float _idleToMoveDistance;

    public override void EnterState()
    {

    }

    public override void UpdateState()
    {
        if(Vector2.Distance(transform.position, PlayerTransform.position) <= _idleToMoveDistance)
        {

        }
    }

    public override void ExitState()
    {

    }
}
