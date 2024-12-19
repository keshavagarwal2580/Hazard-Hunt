using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class findTheError : MonoBehaviour
{
    public GameObject errorPrefab; // Prefab for the error circle
    public Collider2D coll;
    public AudioSource correct;
    public AudioSource incorrect;
    private bool alreadyDone = false;
    //public Collider2D box;
    public Collider2D[] colliders;
    public bool isPresent = false;
    public LifeManager lifeManager;
    [SerializeField] private TMP_Text errorText;
    [SerializeField] private TMP_Text errorCountText;
    [SerializeField] private GameObject menuPanel;
    private bool isPanelOpen = false; // Boolean flag to track panel state

    //bool once = false;
    private void Update()
    {
        isPanelOpen = menuPanel.activeSelf;

        if (isPanelOpen)
            return; // Skip the rest of the update if the panel is open

        // Check if the tap is over a UI element
        //if (EventSystem.current.IsPointerOverGameObject())
        //    return;


        if (Input.GetMouseButtonUp(0) && !lifeManager.isGameOver)
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            keshav(worldPoint);
        }

        // Handle touch taps
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !lifeManager.isGameOver)
        {

            //if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            //    return;
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            keshav(worldPoint);  
        }     
    }

    void keshav(Vector2 worldPoint)
    {
        if (coll.OverlapPoint(worldPoint))
        {
            if (!alreadyDone)
            {
                errorPrefab.SetActive(true);
                errorText.text = coll.name;

                lifeManager.increaseCount();
                errorCountText.text = lifeManager.count.ToString() + " of 10 ";
                correct.Play();
                
                print("correct");
                alreadyDone = true;
            }
        }


        else
        {
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].OverlapPoint(worldPoint))// If collider doesn't overlap with the point
                {
                    isPresent = true;
                }
            }
            if (!incorrect.isPlaying && !isPresent && lifeManager.lives>0)
            {
                print("incorrect");
                incorrect.Play();
                lifeManager.decreaseLife();
                errorText.text = " No errors detected. ";
            }
            isPresent=false;
        }
    }
}


