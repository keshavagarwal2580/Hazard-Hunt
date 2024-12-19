using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private bool isMuted = false;
    [SerializeField] private GameObject Mute;
    [SerializeField] private GameObject UnMute;


    public void ToggleMute()
    {
        isMuted = !isMuted;
        AudioListener.volume = isMuted ? 0f : 1f;
        Mute.SetActive(isMuted);
        UnMute.SetActive(!isMuted);
    }
}
