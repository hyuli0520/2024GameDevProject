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

    public void LookAtMouse(Vector2 inputMousePos)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(inputMousePos);
        Vector2 direction = mousePos - (Vector2)transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
