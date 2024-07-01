using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, IPlayerInput, IPlayerMovement
{
    [SerializeField]
    private float _speed;

    private Rigidbody2D _rigid;
    private Vector2 _inputVec;
    public Vector2 InputVec => _inputVec;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    public void OnMove(InputValue value)
    {
        _inputVec = value.Get<Vector2>();
    }

    public void Move()
    {
        Vector2 nextVec = _inputVec * _speed * Time.deltaTime;
        _rigid.MovePosition(_rigid.position + nextVec);
    }

    public void MoveTo(Vector2 des)
    {
        // TODO
    }
}
