using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour, IPlayerAttack
{
    [SerializeField]
    private GameObject _bulletPrefab; // ÃÑ¾Ë ÇÁ¸®ÆÕ
    [SerializeField]
    private Transform _firingPos; // ¹ß»ç À§Ä¡

    [SerializeField]
    private float _delay;
    private float _lastShootTime;
    private float _shootTime = float.MaxValue;

    public void Shoot()
    {
        if(_shootTime - _lastShootTime > _delay)
        {
            Instantiate(_bulletPrefab, _firingPos.position, transform.rotation);
            _lastShootTime = Time.time;
        }
        _shootTime = Time.time;
    }
}
