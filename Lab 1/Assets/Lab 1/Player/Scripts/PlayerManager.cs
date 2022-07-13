using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int Health;
    void Start()
    {
        UIManager.Instance.SetHealth(Health);
    }

}
