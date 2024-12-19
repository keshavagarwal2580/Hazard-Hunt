using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{

    [SerializeField] private static int count = 0;
    
    public void loadRoadSafetyLevel()
    {
        SceneManager.LoadScene("RoadSafetyLevel");
    }
    public void loadConstructionSafetyLevel()
    {
       
        SceneManager.LoadScene("ConstructionSafetyLevel");
    }
    public void loadFireSafetyLevel()
    {
        
        SceneManager.LoadScene("FireSafetyLevel");
    }
    public void loadIndoorSafetyLevel()
    {
        
        SceneManager.LoadScene("IndoorSafetyLevel");
    }
    public void loadOutdoorSafetyLevel()
    {
        
        SceneManager.LoadScene("OutDoorSafetyLevel");
    }


    public void loadRoadSafetyLevelTutorial()
    {
        SceneManager.LoadScene("InGameRoadTutorial");
    }
    public void loadConstructionSafetyLevelTutorial()
    {

        SceneManager.LoadScene("InGameConstructionTutorial");
    }
    public void loadFireSafetyLevelTutorial()
    {

        SceneManager.LoadScene("InGameFireTutorial");
    }
    public void loadIndoorSafetyLevelTutorial()
    {

        SceneManager.LoadScene("InGameIndoorTutorial");
    }
    public void loadOutdoorSafetyLevelTutorial()
    {

        SceneManager.LoadScene("InGameOutdoorTutorial");
    }

    public void loadTopG()
    {
        SceneManager.LoadScene("TopG");
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
