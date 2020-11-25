using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private ObjectGenerator[] _objectGenerators;
    [SerializeField] private Transform _startPosition;

    public event UnityAction<int> CoinCountChanged;
    public event UnityAction Dead;

    private int _coinsCount;

    public void Revive()
    {
        transform.position = _startPosition.position;

        _coinsCount = 0;
        CoinCountChanged?.Invoke(_coinsCount);
    }

    public void AddCoin()
    {
        _coinsCount++;
        CoinCountChanged?.Invoke(_coinsCount);
    }

    public void Die()
    {
        Dead?.Invoke();
    }
}
