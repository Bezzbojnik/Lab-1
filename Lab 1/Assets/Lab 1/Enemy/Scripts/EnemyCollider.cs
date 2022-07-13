using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EndZone")
        {
            UIManager.OnReduceHealth?.Invoke();
            Destroy(gameObject);
        }
    }
}
