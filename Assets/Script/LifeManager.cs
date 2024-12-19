using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public int lives = 3;
    public GameObject[] livesIcon;
    public GameObject[] deadLivesIcon;

    public int count = 0;
    public bool isGameOver = false;
    [SerializeField] private GameObject gameoverPanel;
    
    public void decreaseLife()
    {

        
        lives -= 1;
        if(lives >= 0)
        livesIcon[lives].SetActive(false);
        deadLivesIcon[lives].SetActive(true);
        if (lives <= 0)
        {
            isGameOver = true;
            gameoverPanel.SetActive(true);
            StartCoroutine("LoadMainMenu");
        }
    }
    public void increaseCount()
    {  
        count++;
    }
    private void Update()
    {
        if (count >= 10)
        {
            StartCoroutine("LoadMainMenu");        
        }
    }

    IEnumerator LoadMainMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main menu");
    }
}
