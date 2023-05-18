using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using DG.Tweening;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject dice;
    [SerializeField] Text diceNumText;
    Rigidbody2D rb2D;
    public static int diceNum;
    float dt = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!rb2D.IsSleeping())
        {
            RandomDice();
        }
    }

    public void RandomDice()
    {
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        dt += Time.deltaTime;
        if (dt > 0.1) {
            dt = 0.0f;
            diceNum = Random.Range(1, 7);
            s.sprite = Resources.Load<Sprite>(diceNum.ToString());
            Text();
        }
    }

    void Text()
    {
        diceNumText.text = diceNum.ToString();
    }

}
