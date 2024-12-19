using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextAndSkip : MonoBehaviour
{

    public GameObject FireSafetyPanel;
    public GameObject ConstructionSafetyPanel;
    public GameObject OutdoorSafetyPanel;
    public GameObject RoadSafetyPanel;
    public GameObject IndoorSafetyPanel;


    public void SkipButton()
    {
        SceneManager.LoadScene("Main menu");
    }

    //public void LoadConstruction()
    //{ 
    //    FireSafetyPanel.SetActive(false);
    //    ConstructionSafetyPanel.SetActive(true);
    //}

    //public void LoadOutdoor()
    //{
    //    ConstructionSafetyPanel.SetActive(false);
    //    OutdoorSafetyPanel.SetActive(true);
    //}

    //public void LoadRoad()
    //{
    //    OutdoorSafetyPanel.SetActive(false);
    //    RoadSafetyPanel.SetActive(true);
    //}

    //public void LoadIndoor()
    //{
    //    RoadSafetyPanel.SetActive(false);
    //    SceneManager.LoadScene("Main Menu");
    //}
}
