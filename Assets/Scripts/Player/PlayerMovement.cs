using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IPlayerMovement
{
    [SerializeField]
    private float _speed;

    private Rigidbody2D _rigid;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 inputVec)
    {
        Vector2 nextVec = inputVec * _speed * Time.deltaTime;
        _rigid.MovePosition(_rigid.position + nextVec);
    }

    public void MoveTo(Vector2 des)
    {
        // TODO   
    }
}
