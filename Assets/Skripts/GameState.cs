using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameState : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private ObjectGenerator[] _objectGenerators;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private CameraTracker _cameraTracker;


    public event UnityAction PlayerDead;


    private void Awake()
    {
        ResetGame();
    }

    private void OnEnable()
    {
        _player.Dead += OnPlayerDead;
    }

    private void OnDisable()
    {
        _player.Dead -= OnPlayerDead;
    }

    public void ResetGame()
    {
        _cameraTracker.SetNewTarget(_player.transform);
        _player.Revive();
        foreach (var generator in _objectGenerators)
        {
            generator.ResetPool();
        }
        Time.timeScale = 1;
    }

    private void OnPlayerDead()
    {
        _cameraTracker.UnTrack();
        Time.timeScale = 0;
        _losePanel.SetActive(true);
    }
}
