using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _enemyPrefabList;

    [SerializeField]
    private float spawnRate = 3;

    void Start()
    {
        StartCoroutine(OnSpawnEnemy());
    }

    IEnumerator OnSpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int rand = Random.Range(0, _enemyPrefabList.Count);
            GameObject enemyToSpawn = _enemyPrefabList[rand];

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        }
    }
}
