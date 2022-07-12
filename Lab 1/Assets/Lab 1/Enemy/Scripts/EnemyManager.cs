using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 1f);
    }

    private void SpawnEnemy()
    {
        var randomEnemy = Random.Range(0, Enemies.Count);
        var randomPos = Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);
        var posEnemy = new Vector3(transform.position.x + randomPos, transform.position.y, transform.position.z);
        var rotEnemy = Quaternion.Euler(0, 180, 0);
        Instantiate(Enemies[randomEnemy], posEnemy, rotEnemy);
    }
}
