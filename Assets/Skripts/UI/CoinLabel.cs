using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinLabel : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _coinCountText;

    private void OnEnable()
    {
        _player.CoinCountChanged += OnCoinCountChanged;
    }

    private void OnDisable()
    {
        _player.CoinCountChanged -= OnCoinCountChanged;
    }

    private void OnCoinCountChanged(int count)
    {
        _coinCountText.text = ": " + count.ToString();
    }
}
