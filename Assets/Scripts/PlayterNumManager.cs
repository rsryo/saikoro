using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayterNumManager : MonoBehaviour
{
    [SerializeField] GameObject playerNum2;
    [SerializeField] GameObject playerNum3;
    [SerializeField] GameObject playerNum4;

    public static int PlayerNum;

    // Start is called before the first frame update

    // Update is called once per frame
    public void OnButton2()
    {
        PlayerNum = 2;
        SceneManager.LoadScene("MemberScene");
    }
    public void OnButton3()
    {
        PlayerNum = 3;
        SceneManager.LoadScene("MemberScene");
    }
    public void OnButton4()
    {
        PlayerNum = 4;
        SceneManager.LoadScene("MemberScene");
    }
}
