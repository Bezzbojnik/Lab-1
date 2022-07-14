using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    public GameObject VisibleObject;
    private EnemyAudio _enemyAudioScript;
    private EnemyEffects _enemyEffects;

    private void Start()
    {
        _enemyAudioScript = GetComponent<EnemyAudio>();
        _enemyEffects = GetComponent<EnemyEffects>();
    }

    public void DestroyEnemy()
    {
        Instantiate(_enemyEffects.ParticalEffect, gameObject.transform);
        VisibleObject.SetActive(false);
        gameObject.GetComponent<SphereCollider>().enabled = false;
        _enemyAudioScript.PlayAudioDestroy();
        Destroy(gameObject, 0.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EndZone")
        {
            UIManager.OnReduceHealth?.Invoke();
            DestroyEnemy();
        }
    }
}
