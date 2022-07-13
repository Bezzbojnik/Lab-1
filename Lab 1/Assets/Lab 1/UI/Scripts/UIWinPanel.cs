using UnityEngine;
using UnityEngine.SceneManagement;

public class UIWinPanel : MonoBehaviour
{
    public GameObject WinPanel;

    public void OnClick_Reset()
    {
        SceneManager.LoadScene("MainScene");
    }
}
