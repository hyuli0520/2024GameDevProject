using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IDamage
{
    public float Amount => _damage;

    [SerializeField]
    private float _damage = 1;
    [SerializeField]
    private float _bulletSpeed;
    private float _destroyBulletTime = 2;

    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void Update()
    {
        transform.Translate(Vector2.right * _bulletSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<IDamageReceiver>(out var damageReceiver))
        {
            damageReceiver.GetDamage(this);
        }
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(_destroyBulletTime);
        Destroy(gameObject);
    }
}