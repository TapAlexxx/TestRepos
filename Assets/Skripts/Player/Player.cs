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
    
    public int CoinCount { get; private set; }

    public void Revive()
    {
        transform.position = _startPosition.position;

        CoinCount = 0;
        CoinCountChanged?.Invoke(CoinCount);
    }

    public void AddCoin()
    {
        CoinCount++;
        CoinCountChanged?.Invoke(CoinCount);
    }

    public void Die()
    {
        Dead?.Invoke();
    }
}
