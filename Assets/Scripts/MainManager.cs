using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public bool DontDestroyEnabled = true;

    static bool audioStart = true;

    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        if (audioStart == true)
        {
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = audioClip;
            audioSource.Play();
            audioStart = false;
        }

        if (DontDestroyEnabled)
        {
            // Scene???J?????????I?u?W?F?N?g????????????????????
            DontDestroyOnLoad(this);
        }
    }

    public void OnButton()
    {
        SceneManager.LoadScene("PlayerNum");
        
    }
}
