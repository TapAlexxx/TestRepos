using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameButtonsAction : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameState _gameState;

    public void OnRestartButtonClick()
    {
        Time.timeScale = 1;
        _gameState.ResetGame();
        _losePanel.SetActive(false);
    }

    public void OnMenuButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
