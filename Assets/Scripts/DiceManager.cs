using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiceManager : MonoBehaviour
{
    [SerializeField] GameController dice;
    [SerializeField] Text playerName;

    bool diceCheck = false;

    public bool DontDestroyEnabled = true;

    public AudioClip sound1;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        switch (GameManager.turn)
        {
            case 1:
                playerName.text = GameManager.playerName1 + "のターン";
                break;
            case 2:
                playerName.text = GameManager.playerName2 + "のターン";
                break;
            case 3:
                playerName.text = GameManager.playerName3 + "のターン";
                break;
            case 4:
                playerName.text = GameManager.playerName4 + "のターン";
                break;

        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
    }

     void diceSound()
    {
        audioSource.PlayOneShot(sound1);
    }

    public void OnButton()
    {
        Rigidbody2D rb2D = dice.GetComponent<Rigidbody2D>();
        if (diceCheck == false)
        {
            rb2D.AddForce(new Vector2(0f, 1000f));
            diceCheck = true;
        }
        Invoke("diceSound" , 0.8f);
        Invoke("ChangeScene", 2.7f);
    }



}
