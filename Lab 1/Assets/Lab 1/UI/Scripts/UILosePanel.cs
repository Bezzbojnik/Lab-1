using UnityEngine;
using UnityEngine.SceneManagement;

public class UILosePanel : MonoBehaviour
{
    public GameObject LosePanel;

    public void OnClick_Reset()
    {
        SceneManager.LoadScene("MainScene");
    }
}
