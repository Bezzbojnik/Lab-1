using UnityEngine;

public class BulletCollider : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            UIManager.OnReduceEnemy?.Invoke();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
