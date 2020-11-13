using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuButtonsAction : MonoBehaviour
{
    [SerializeField] private GameObject _aboutAuthorsPanel;

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnAboutAuthorsButtonClick()
    {
        _aboutAuthorsPanel.GetComponent<Image>().color = new Color(255, 255, 255, 0);
        _aboutAuthorsPanel.SetActive(true);
        _aboutAuthorsPanel.GetComponent<Image>().DOFade(1, 2f);
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
