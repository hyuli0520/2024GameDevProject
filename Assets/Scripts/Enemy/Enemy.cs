using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage
{
    public float Amount => _damage;

    [SerializeField]
    private float _damage = 1;

    public float speed;

    [SerializeField]
    private Transform _playerTransform;
    private Rigidbody2D _rigid;

    void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        Vector2 dirVec = _playerTransform.position - _rigid.transform.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.deltaTime;
        _rigid.MovePosition(_rigid.transform.position + (Vector3)nextVec);
        _rigid.velocity = Vector2.zero;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<IDamageReceiver>(out var damageReceiver))
        {
            damageReceiver.GetDamage(this);
        }
    }
}
