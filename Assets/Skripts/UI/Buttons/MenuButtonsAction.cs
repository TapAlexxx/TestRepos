using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuButtonsAction : MonoBehaviour
{
    [SerializeField] private GameObject _aboutAuthorsPanel;
    [SerializeField] private Image _authorsPanelImage;

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnAboutAuthorsButtonClick()
    {
        _authorsPanelImage.color = new Color(255, 255, 255, 0);
        _aboutAuthorsPanel.SetActive(true);
        _authorsPanelImage.DOFade(1, 2f);
    }

    public void OnClosePanelButtonClick()
    {
        _aboutAuthorsPanel.SetActive(false);
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
