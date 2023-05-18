using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EntryManager : MonoBehaviour
{

    [SerializeField] InputField player1;
    [SerializeField] InputField player2;
    [SerializeField] InputField player3;
    [SerializeField] InputField player4;

    [SerializeField] GameObject p3;
    [SerializeField] GameObject p4;

    private TouchScreenKeyboard keyboard;

    // Start is called before the first frame update
    void Start()
    {
        switch (PlayterNumManager.PlayerNum)
        {
            case 2:
                p3.SetActive(false);
                p4.SetActive(false);
                break;
            case 3:
                p4.SetActive(false);
                break;
        }
    }


    public void OnButton()
    {
        switch (PlayterNumManager.PlayerNum)
        {
            case 2:
                GameManager.diceSum1 = 0;
                GameManager.diceSum2 = 0;

                GameManager.playerName1 = player1.text;
                GameManager.playerName2 = player2.text;

                GameController.diceNum = 0;
                GameManager.turn = 0;
                SceneManager.LoadScene("GameScene");
                break;
            case 3:
                GameManager.diceSum1 = 0;
                GameManager.diceSum2 = 0;
                GameManager.diceSum3 = 0;

                GameManager.playerName1 = player1.text;
                GameManager.playerName2 = player2.text;
                GameManager.playerName3 = player3.text;

                GameController.diceNum = 0;
                GameManager.turn = 0;
                SceneManager.LoadScene("GameScene");
                break;
            case 4:
                GameManager.diceSum1 = 0;
                GameManager.diceSum2 = 0;
                GameManager.diceSum3 = 0;
                GameManager.diceSum4 = 0;

                GameManager.playerName1 = player1.text;
                GameManager.playerName2 = player2.text;
                GameManager.playerName3 = player3.text;
                GameManager.playerName4 = player4.text;

                GameController.diceNum = 0;
                GameManager.turn = 0;
                SceneManager.LoadScene("GameScene");
                break;

        }

    }
}
