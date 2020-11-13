using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private EnemyGenerator _enemyGenerator;
    [SerializeField] private CoinGenerator _coinGenerator;
    [SerializeField] private Transform _startPosition;

    public event UnityAction<int> CoinCountChanged;
    public int CoinCount { get; private set; }
    public bool IsAlive { get; private set; }

    private void Awake()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        IsAlive = true;

        transform.position = _startPosition.position;

        CoinCount = 0;
        CoinCountChanged?.Invoke(CoinCount);

        _enemyGenerator.ResetPool();
        _coinGenerator.ResetPool();
    }

    public void AddCoin()
    {
        CoinCount++;
        CoinCountChanged?.Invoke(CoinCount);
    }

    public void Die()
    {
        IsAlive = false;
        Time.timeScale = 0;
        _losePanel.SetActive(true);
    }
}
