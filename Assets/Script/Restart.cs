using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private AudioManager audioManager;
    public void restart()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Load the current scene
        SceneManager.LoadScene(currentSceneName);
    }

    public void menu()
    {
        menuPanel.SetActive(true);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void cutMenu()
    {
        StartCoroutine("CloseMenuPanel");
        
    }

    public void sound()
    {
        audioManager.ToggleMute();
    }
    
    public void exit()
    {
        Application.Quit();
    }
    IEnumerator CloseMenuPanel()
    {
        yield return new WaitForSeconds(0.2f);
        menuPanel.SetActive(false);
    }
}
