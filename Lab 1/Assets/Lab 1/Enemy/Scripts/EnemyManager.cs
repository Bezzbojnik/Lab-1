using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int EnemyCount;
    public List<GameObject> Enemies = new List<GameObject>();

    private WaitForSeconds _wait = new WaitForSeconds(1f);

    void Start()
    {
        UIManager.Instance.SetEnemyCount(EnemyCount);
        //InvokeRepeating("SpawnEnemy", 0, 1f);
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            if (EnemyCount > 0)
            {
                var randomEnemy = Random.Range(0, Enemies.Count);
                var randomPos = Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);
                var posEnemy = new Vector3(transform.position.x + randomPos, transform.position.y, transform.position.z);
                var rotEnemy = Quaternion.Euler(0, 180, 0);
                Instantiate(Enemies[randomEnemy], posEnemy, rotEnemy);
                EnemyCount--;
            }
            else
            {
                UIManager.Instance.OnWin();
                break;
            }
            yield return _wait;
        }
    }
}
