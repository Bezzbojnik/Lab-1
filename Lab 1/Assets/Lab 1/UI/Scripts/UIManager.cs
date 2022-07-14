using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public static Action OnReduceEnemy;
    public static Action OnReduceHealth;

    public UIEnemyCount UIEnemyCountScript;
    public UIHealth UIHealthScript;
    public UIWinPanel UIWinPanelScript;
    public UILosePanel UILosePanelScript;

    private int _enemyCount;
    private int _health;

    void Awake()
    {
        Instance = this;
        OnReduceEnemy += ReduceEnemy;
        OnReduceHealth += ReduceHealth;
    }

    public void SetEnemyCount(int enemyCount)
    {
        _enemyCount = enemyCount;
        UIEnemyCountScript.EnemyCountText.text = _enemyCount.ToString();
    }

    public void SetHealth(int health)
    {
        _health = health;
        UIHealthScript.HealthText.text = _health.ToString();
    }

    public void OnWin()
    {
        UIWinPanelScript.WinPanel.SetActive(true);
        OnReduceEnemy -= ReduceEnemy;
        OnReduceHealth -= ReduceHealth;
    }

    public void OnLose()
    {
        UILosePanelScript.LosePanel.SetActive(true);
        OnReduceEnemy -= ReduceEnemy;
        OnReduceHealth -= ReduceHealth;
    }

    private void ReduceEnemy()
    {
        _enemyCount--;
        UIEnemyCountScript.EnemyCountText.text = _enemyCount.ToString();
        if(_enemyCount == 0)
        {
            OnWin();
        }
    }

    private void ReduceHealth()
    {
        _health--;
        UIHealthScript.HealthText.text = _health.ToString();
        if(_health == 0)
        {
            OnLose();
        }
    }
}
