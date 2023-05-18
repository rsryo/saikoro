using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using DG.Tweening;

public class GameManager : MonoBehaviour
{

    [SerializeField] Transform start;
    [SerializeField] Transform map;
    [SerializeField] Transform map2;
    [SerializeField] Transform map3;
    [SerializeField] Transform map4;
    [SerializeField] Transform map5;
    [SerializeField] Transform map6;
    [SerializeField] Transform map7;
    [SerializeField] Transform map8;
    [SerializeField] Transform map9;
    [SerializeField] Transform map10;
    [SerializeField] Transform map11;
    [SerializeField] Transform map12;
    [SerializeField] Transform map13;
    [SerializeField] Transform map14;
    [SerializeField] Transform map15;
    [SerializeField] Transform map16;
    [SerializeField] Transform map17;
    [SerializeField] Transform map18;
    [SerializeField] Transform map19;
    [SerializeField] Transform map20;
    [SerializeField] Transform map21;
    [SerializeField] Transform map22;
    [SerializeField] Transform map23;
    [SerializeField] Transform map24;
    [SerializeField] Transform map25;
    [SerializeField] Transform map26;
    [SerializeField] Transform map27;
    [SerializeField] Transform map28;
    [SerializeField] Transform map29;
    [SerializeField] Transform map30;
    [SerializeField] Transform map31;
    [SerializeField] Transform map32;
    [SerializeField] Transform map33;
    [SerializeField] Transform map34;
    [SerializeField] Transform map35;
    [SerializeField] Transform map36;
    [SerializeField] Transform map37;
    [SerializeField] Transform goal;

    [SerializeField] Transform zoon;
    [SerializeField] Transform zoon2;
    [SerializeField] Transform zoon3;
    [SerializeField] Transform zoon4;
    [SerializeField] Transform zoon5;
    [SerializeField] Transform zoon6;

    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
    [SerializeField] GameObject player3;
    [SerializeField] GameObject player4;

    [SerializeField] GameObject image;
    [SerializeField] Text eventText;

    [SerializeField] GameObject playerName;
    [SerializeField] Text playerNameText;
    [SerializeField] GameObject button;

    [SerializeField] Camera allCamera;
    [SerializeField] GameObject mapButton;

    GameObject playerCamera;

    List<Transform> maps = new List<Transform>();
    List<Transform> zoons = new List<Transform>();

    public static int diceSum1 = 0;
    public static int diceSum2 = 0;
    public static int diceSum3 = 0;
    public static int diceSum4 = 0;

    public static int zoonSum1 = 0;
    public static int zoonSum2 = 0;
    public static int zoonSum3 = 0;
    public static int zoonSum4 = 0;

    public static int turn = 0;

    public static string playerName1;
    public static string playerName2;
    public static string playerName3;
    public static string playerName4;

    bool isButton = true;

    static bool activeZoon1 = false;
    static bool activeZoon2 = false;
    static bool activeZoon3 = false;
    static bool activeZoon4 = false;

    [SerializeField] GameObject goalImage;
    [SerializeField] Text untilGoal;
    int lastGoal;

    bool allMap = false;

    public bool DontDestroyEnabled = true;

    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        button.SetActive(false);
        playerCamera = Camera.main.gameObject;
        maps.Add(start);
        maps.Add(map);
        maps.Add(map2);
        maps.Add(map3);
        maps.Add(map4);
        maps.Add(map5);
        maps.Add(map6);
        maps.Add(map7);
        maps.Add(map8);
        maps.Add(map9);
        maps.Add(map10);
        maps.Add(map11);
        maps.Add(map12);
        maps.Add(map13);
        maps.Add(map14);
        maps.Add(map15);
        maps.Add(map16);
        maps.Add(map17);
        maps.Add(map18);
        maps.Add(map19);
        maps.Add(map20);
        maps.Add(map21);
        maps.Add(map22);
        maps.Add(map23);
        maps.Add(map24);
        maps.Add(map25);
        maps.Add(map26);
        maps.Add(map27);
        maps.Add(map28);
        maps.Add(map29);
        maps.Add(map30);
        maps.Add(map31);
        maps.Add(map32);
        maps.Add(map33);
        maps.Add(map34);
        maps.Add(map35);
        maps.Add(map36);
        maps.Add(map37);
        maps.Add(goal);
        zoons.Add(zoon);
        zoons.Add(zoon2);
        zoons.Add(zoon3);
        zoons.Add(zoon4);
        zoons.Add(zoon5);
        zoons.Add(zoon6);
        switch (PlayterNumManager.PlayerNum)
        {
            case 2:
                player3.SetActive(false);
                player4.SetActive(false);
                break;
            case 3:
                player4.SetActive(false);
                break;
        }
        playerName.SetActive(false);
        goalImage.SetActive(false);
        StartGame();
            switch (turn)
            {
                case 0:
                    turn = 1;
                    player1.transform.position = maps[0].position + new Vector3(0.5f, 0.5f, 0);
                    player2.transform.position = maps[0].position + new Vector3(-0.5f, 0.5f, 0);
                    player3.transform.position = maps[0].position + new Vector3(0.5f, -0.5f, 0);
                    player4.transform.position = maps[0].position + new Vector3(-0.5f, -0.5f, 0);
                    activeZoon1 = false;
                    activeZoon2 = false;
                    activeZoon3 = false;
                    activeZoon4 = false;
                button.SetActive(true);
                    break;
                case 1:
                    playerCamera.transform.parent = player1.transform;
                    playerCamera.transform.position = new Vector3(player1.transform.position.x, player1.transform.position.y + 0.5f, -10);
                    if (activeZoon1 == false)
                    {
                        StartCoroutine(Moving(diceSum1, GameController.diceNum, 1));
                    }
                    else
                    {
                        StartCoroutine(ZoonMoving(zoonSum1, GameController.diceNum, 1));
                    }
                    break;
                case 2:
                    playerCamera.transform.parent = player2.transform;
                    playerCamera.transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y + 0.5f, -10);
                    if (activeZoon2 == false)
                    {
                        StartCoroutine(Moving(diceSum2, GameController.diceNum, 2));
                    }
                    else
                    {
                        StartCoroutine(ZoonMoving(zoonSum2, GameController.diceNum, 2));
                    }
                    break;
                case 3:
                    playerCamera.transform.parent = player3.transform;
                    playerCamera.transform.position = new Vector3(player3.transform.position.x, player3.transform.position.y + 0.5f, -10);
                    if (activeZoon3 == false)
                    {
                        StartCoroutine(Moving(diceSum3, GameController.diceNum, 3));
                    }
                    else
                    {
                        StartCoroutine(ZoonMoving(zoonSum3, GameController.diceNum, 3));
                    }
                break;
                case 4:
                    playerCamera.transform.parent = player4.transform;
                    playerCamera.transform.position = new Vector3(player4.transform.position.x, player4.transform.position.y + 0.5f, -10);
                    if (activeZoon4 == false)
                    {
                        StartCoroutine(Moving(diceSum4, GameController.diceNum, 4));
                    }
                    else
                    {
                        StartCoroutine(ZoonMoving(zoonSum4, GameController.diceNum, 4));
                    }
                break;
            
        }

    }

    void StartGame()
    {
        if (activeZoon1 == true)
        {
            player1.transform.position = zoons[zoonSum1].position + new Vector3(0.5f, 0.5f, 0);
        }
        else if (activeZoon1 == false)
        {
            player1.transform.position = maps[diceSum1].position + new Vector3(0.5f, 0.5f, 0);
        }

        if (activeZoon2 == true)
        {
            player2.transform.position = zoons[zoonSum2].position +  new Vector3(-0.5f, 0.5f, 0);
        }
        else if (activeZoon2 == false)
        {
            player2.transform.position = maps[diceSum2].position + new Vector3(-0.5f, 0.5f, 0);
        }
        if (activeZoon3 == true)
        {
            player3.transform.position = zoons[zoonSum3].position + new Vector3(0.5f, -0.5f, 0);
        }
        else if (activeZoon1 == false)
        {
            player3.transform.position = maps[diceSum3].position + new Vector3(0.5f, -0.5f, 0);
        }

        if (activeZoon4 == true)
        {
            player4.transform.position = zoons[zoonSum4].position + new Vector3(-0.5f, -0.5f, 0);
        }
        else if (activeZoon4 == false)
        {
            player4.transform.position = maps[diceSum4].position + new Vector3(-0.5f, -0.5f, 0);
        }
        image.SetActive(false);
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void GoalScene()
    {
        SceneManager.LoadScene("GoalScene");
    }

    IEnumerator Moving(int diceSum,int num , int turnCount)
    {
        mapButton.SetActive(false);
        for (int i = 1; i <= num; i++)
        {

            if (diceSum + i < 38)
            {
                yield return new WaitForSeconds(0.5f);
                audioSource.PlayOneShot(sound1);
                switch (turnCount)
                {
                    case 1:
                        player1.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                        diceSum1++; ;
                        break;
                    case 2:
                        player2.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                        diceSum2++;
                        break;
                    case 3:
                        player3.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                        diceSum3++; ;
                        break;
                    case 4:
                        player4.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                        diceSum4++;
                        break;
                }
            }
            else if (diceSum + i >= 38)
            {
                yield return new WaitForSeconds(0.5f);
                switch (turnCount)
                {
                    case 1:
                        player1.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                        break;
                    case 2:
                        player2.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                        break;
                    case 3:
                        player3.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                        break;
                    case 4:
                        player4.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                        break;
                }
                yield return new WaitForSeconds(2.0f);
                GoalScene();
            }
        }
        diceSum = diceSum + num;
        if (diceSum > 0)
        {
            yield return new WaitForSeconds(2.0f);
            MasEvent(diceSum ,turnCount);
        }
        if (turn == 1)
        {
            turn = 2;
        }
        else if (turn == 2)
        {
            if (PlayterNumManager.PlayerNum == 2)
            {
                turn = 1;
            }
            else
            {
                turn = 3;
            }
        }
        else if (turn == 3)
        {
            if (PlayterNumManager.PlayerNum == 3)
            {
                turn = 1;
            }
            else
            {
                turn = 4;
            }
        }
        else if (turn == 4)
        {
            turn = 1;
        }
        yield return new WaitForSeconds(1.5f);
        button.SetActive(true);

    }

    void MasEvent(int diceSum , int turn)
    {
        switch(diceSum)
        {
            case 1:
                eventText.text = "ゲームは始まったばかり！気合いを入れるために全員で乾杯！！";
                image.SetActive(true);
                break;
            case 2:
                eventText.text = "序盤からとばすと後が怖い！酒は控えよう";
                image.SetActive(true);
                break;
            case 3:
                eventText.text = "気づいたら酒を持っていた。飲む";
                image.SetActive(true);
                break;
            case 4:
                eventText.text = "喉が乾いた！とりあえず飲む";
                image.SetActive(true);
                break;
            case 5:
                eventText.text = "好きな人とジャンケンをする。負けた人は飲む。";
                image.SetActive(true);
                break;
            case 6:
                eventText.text = "肝臓がお酒を欲しそうにこちらを見ている。肝臓のためにお酒を飲んであげよう！";
                image.SetActive(true);
                break;
            case 7:
                eventText.text = "電車で居眠り。寝過ごした！！２マス戻る";
                image.SetActive(true);
                StartCoroutine(returnMas(turn, diceSum, 2));
                break;
            case 8:
                eventText.text = "LINEを開く。未読のメッセージが５件以上あったら飲む";
                image.SetActive(true);
                break;
            case 9:
                eventText.text = "英語禁止ゲーム開催！次の自分の順番まで英語を使った人は飲む";
                image.SetActive(true);
                break;
            case 10:
                eventText.text = "家に忘れ物をしてしまった！スタートに戻る。";
                image.SetActive(true);
                returnStart(turn);
                break;
            case 11:
                eventText.text = "みんながトイレに行ってしまった！水でも飲んで休憩しよう！";
                image.SetActive(true);
                break;
            case 12:
                eventText.text = "山手線ゲーム！！負けた人飲む";
                image.SetActive(true);
                break;
            case 13:
                eventText.text = "全員で自分以外の人を指さす。指されてなかった人は悲しみから立ち直るために乾杯！";
                image.SetActive(true);
                break;
            case 14:
                eventText.text = "「炙りカルビ」を３回言う。噛んでしまったら飲む";
                image.SetActive(true);
                break;
            case 15:
                eventText.text = "ジャンケン大会開催！全員でジャンケンをして勝った人は優勝賞品のお酒２杯がプレゼント！";
                image.SetActive(true);
                break;
            case 16:
                eventText.text = "酔っ払った！水でも飲んで休憩";
                image.SetActive(true);
                break;
            case 17:
                eventText.text = "記憶をなくして大やらかし！次の自分の番まで絶対に飲まない！";
                image.SetActive(true);
                break;
            case 18:
                eventText.text = "今日は月曜日！ジャンプの発売日！２マスジャンプ";
                StartCoroutine(jumpMas(turn, diceSum, 2));
                break;
            case 19:
                eventText.text = "サンタさんがお酒をくれた！サンタさんに感謝して飲もう！";
                image.SetActive(true);
                break;
            case 20:
                eventText.text = "記憶をなくしてしまった。。。スタートへ戻る。";
                image.SetActive(true);
                returnStart(turn);
                break;
            case 21:
                eventText.text = "次の自分の番まで、サイコロで偶数が出るたびに１杯飲む";
                image.SetActive(true);
                break;
            case 22:
                eventText.text = "マジシャンになる。目の前にあるお酒を消すマジックを披露する";
                image.SetActive(true);
                break;
            case 23:
                eventText.text = "好きな人を１人指名する。指名された人は１回だけ代打で飲ませることができる";
                image.SetActive(true);
                break;
            case 24:
                eventText.text = "この先の２マスから嫌な予感がする。回避するために２マス進む";
                image.SetActive(true);
                StartCoroutine(jumpMas(turn, diceSum, 2));
                break;
            case 25:
                eventText.text = "仕事で大失敗！嫌なことを忘れるために酒の桃源郷へワープ";
                alcholLand(turn);
                break;
            case 26:
                eventText.text = "明日は月曜日！仕事に行きたくなさすぎて酒の桃源郷へワープ";
                alcholLand(turn);
                break;
            case 27:
                eventText.text = "男の熱い友情に乾杯！！男子全員で乾杯する";
                image.SetActive(true);
                break;
            case 28:
                eventText.text = "マジシャンになる。目の前にあるお酒を消すマジックを披露する";
                image.SetActive(true);
                break;
            case 29:
                eventText.text = "お冷を人数分！全員水で乾杯しよう";
                image.SetActive(true);
                break;
            case 30:
                eventText.text = "バカだからわかんねぇ！！バカだから飲む";
                image.SetActive(true);
                break;
            case 31:
                eventText.text = "シンプルに４マス戻る";
                image.SetActive(true);
                StartCoroutine(returnMas(turn, diceSum, 4));
                break;
            case 32:
                eventText.text = "好きな人を一人指名して飲ませることができる！";
                image.SetActive(true);
                break;
            case 33:
                eventText.text = "恋人ができてカーニバル！付き合っている人がいる人全員で乾杯！";
                image.SetActive(true);
                break;
            case 34:
                eventText.text = "ここが最後の休憩。よく頑張りました！";
                image.SetActive(true);
                break;
            case 35:
                eventText.text = "酔っ払いも木から落ちる。片足立ちを３０秒できなかったら飲む";
                image.SetActive(true);
                break;
            case 36:
                eventText.text = "最後の力を振り絞る。飲む";
                image.SetActive(true);
                break;
            case 37:
                eventText.text = "まだまだ飲みたいのにゴール目前！大量の酒を求めて酒の桃源郷へワープ";
                alcholLand(turn);
                break;
        }
        image.SetActive(true);
        mapButton.SetActive(false);
    }

    void alcholLand(int turn)
    {
        switch (turn)
        {
            case 1:
                player1.transform.DOMove(zoons[0].transform.position, 0.5f);
                activeZoon1 = true;
                break;
            case 2:
                player2.transform.DOMove(zoons[0].transform.position, 0.5f);
                activeZoon2 = true;
                break;
            case 3:
                player3.transform.DOMove(zoons[0].transform.position, 0.5f);
                activeZoon3 = true;
                break;
            case 4:
                player4.transform.DOMove(zoons[0].transform.position, 0.5f);
                activeZoon4 = true;
                break;
        }
    }

    IEnumerator returnMas(int turn , int diceSum , int mas)
    {
        for (int i = 1; i <= mas; i++)
        {
            audioSource.PlayOneShot(sound1);
            yield return new WaitForSeconds(0.5f);
            switch (turn)
            {
                case 1:
                    player1.transform.DOMove(maps[diceSum - i].transform.position, 0.5f);
                    diceSum1--; ;
                    break;
                case 2:
                    player2.transform.DOMove(maps[diceSum - i].transform.position, 0.5f);
                    diceSum2--;
                    break;
                case 3:
                    player3.transform.DOMove(maps[diceSum - i].transform.position, 0.5f);
                    diceSum3--; ;
                    break;
                case 4:
                    player4.transform.DOMove(maps[diceSum - i].transform.position, 0.5f);
                    diceSum4--;
                    break;
            }
        }

    }

    IEnumerator jumpMas(int turn, int diceSum, int mas)
    {
        for (int i = 1; i <= mas; i++)
        {
            yield return new WaitForSeconds(0.5f);
            audioSource.PlayOneShot(sound1);
            switch (turn)
            {
                case 1:
                    player1.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                    diceSum1++; ;
                    break;
                case 2:
                    player2.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                    diceSum2++;
                    break;
                case 3:
                    player3.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                    diceSum3++; ;
                    break;
                case 4:
                    player4.transform.DOMove(maps[diceSum + i].transform.position, 0.5f);
                    diceSum4++;
                    break;
            }
        }

    }

    void returnStart(int turn)
    {
        switch (turn)
        {
            case 1:
                player1.transform.DOMove(maps[0].transform.position, 1.5f);
                diceSum1 = 0;
                break;
            case 2:
                player2.transform.DOMove(maps[0].transform.position, 1.5f);
                diceSum2 = 0;
                break;
            case 3:
                player3.transform.DOMove(maps[0].transform.position, 1.5f);
                diceSum3 = 0;
                break;
            case 4:
                player4.transform.DOMove(maps[0].transform.position, 1.5f);
                diceSum4 = 0;
                break;
        }
    }

    public void OnButton()
    {

        if (isButton == false)
        {
            ChangeScene();
            mapButton.SetActive(false);
        }

        if (isButton == true)
        {
            image.SetActive(false);
            playerName.SetActive(true);
            goalImage.SetActive(true);
            mapButton.SetActive(true);
            switch (turn)
            {
                case 1:
                    playerNameText.text = playerName1 + "のターン";
                    untilGoal.text = "ゴールまで" + (38 - diceSum1).ToString();
                    playerCamera.transform.position = new Vector3(player1.transform.position.x, player1.transform.position.y, -10);
                    break;
                case 2:
                    playerNameText.text = playerName2 + "のターン";
                    untilGoal.text = "ゴールまで" + (38 - diceSum2).ToString();
                    playerCamera.transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y, -10);
                    break;
                case 3:
                    playerNameText.text = playerName3 + "のターン";
                    untilGoal.text = "ゴールまで" + (38 - diceSum3).ToString();
                    playerCamera.transform.position = new Vector3(player3.transform.position.x, player3.transform.position.y, -10);
                    break;
                case 4:
                    playerNameText.text = playerName4 + "のターン";
                    untilGoal.text = "ゴールまで" + (38 - diceSum4).ToString();
                    playerCamera.transform.position = new Vector3(player4.transform.position.x, player4.transform.position.y, -10);
                    break;

            }
            isButton = false;
        }
    }

    IEnumerator ZoonMoving(int zoonSum, int num, int turnCount)
    {

        for (int i = 0; i < num; i++)
        {

            if (zoonSum < 5 )
            {
                yield return new WaitForSeconds(0.5f);
                switch (turnCount)
                {
                    case 1:
                        player1.transform.DOMove(zoons[zoonSum1 + 1].transform.position, 0.5f);
                        zoonSum1++;
                        zoonSum++;
                        break;
                    case 2:
                        player2.transform.DOMove(zoons[zoonSum2 + 1].transform.position, 0.5f);
                        zoonSum2++;
                        zoonSum++;
                        break;
                    case 3:
                        player3.transform.DOMove(zoons[zoonSum3 + 1].transform.position, 0.5f);
                        zoonSum3++;
                        zoonSum++;
                        break;
                    case 4:
                        player4.transform.DOMove(zoons[zoonSum4 + 1].transform.position, 0.5f);
                        zoonSum4++;
                        zoonSum++;
                        break;
                }
            }
            else if (zoonSum == 5)
            {
                yield return new WaitForSeconds(0.5f);
                switch (turnCount)
                {
                    case 1:
                        zoonSum1 = 0 ;
                        zoonSum = 0;
                        player1.transform.DOMove(zoons[0].transform.position, 0.5f);
                        break;
                    case 2:
                        zoonSum2 = 0;
                        zoonSum = 0;
                        player2.transform.DOMove(zoons[0].transform.position, 0.5f);
                        break;
                    case 3:
                        zoonSum3 = 0 ;
                        zoonSum = 0;
                        player3.transform.DOMove(zoons[0].transform.position, 0.5f);
                        break;
                    case 4:
                        zoonSum4 = 0;
                        zoonSum = 0;
                        player4.transform.DOMove(zoons[0].transform.position, 0.5f);
                        break;
                }
            }
        }
        yield return new WaitForSeconds(2.0f);
        StartCoroutine(ZoonEvent(zoonSum, turnCount));
        if (turn == 1)
        {
            turn = 2;
        }
        else if (turn == 2)
        {
            if (PlayterNumManager.PlayerNum == 2)
            {
                turn = 1;
            }
            else
            {
                turn = 3;
            }
        }
        else if (turn == 3)
        {
            if (PlayterNumManager.PlayerNum == 3)
            {
                turn = 1;
            }
            else
            {
                turn = 4;
            }
        }
        else if (turn == 4)
        {
            turn = 1;
        }
        yield return new WaitForSeconds(1.5f);
        button.SetActive(true);

    }

    IEnumerator ZoonEvent(int zoonSum, int turn)
    {
        switch (zoonSum)
        {
            case 0:
                eventText.text = "目が覚めてしまった。。。酒の桃源郷から抜け出す。";
                image.SetActive(true);
                yield return new WaitForSeconds(1.0f);
                switch (turn)
                {
                    case 1:
                        player1.transform.DOMove(maps[diceSum1].transform.position, 0.5f);
                        activeZoon1 = false;
                        break;
                    case 2:
                        player2.transform.DOMove(maps[diceSum2].transform.position, 0.5f);
                        activeZoon2 = false;
                        break;
                    case 3:
                        player3.transform.DOMove(maps[diceSum3].transform.position, 0.5f);
                        activeZoon3 = false;
                        break;
                    case 4:
                        player4.transform.DOMove(maps[diceSum4].transform.position, 0.5f);
                        activeZoon4 = false;
                        break;
                }
                break;
            case 1:
                eventText.text = "アルコールカーニバル！！とりあえず飲む";
                image.SetActive(true);
                break;
            case 2:
                eventText.text = "ヒヤッフーーーー！！とりあえず飲む";
                image.SetActive(true);
                yield return new WaitForSeconds(1.0f);
                break;

            case 3:
                eventText.text = "目が覚めてしまった。。。酒の桃源郷から抜け出す。";
                image.SetActive(true);
                yield return new WaitForSeconds(1.0f);
                switch (turn)
                {
                    case 1:
                        player1.transform.DOMove(maps[diceSum1].transform.position, 0.5f);
                        activeZoon1 = false;
                        break;
                    case 2:
                        player2.transform.DOMove(maps[diceSum2].transform.position, 0.5f);
                        activeZoon2 = false;
                        break;
                    case 3:
                        player3.transform.DOMove(maps[diceSum3].transform.position, 0.5f);
                        activeZoon3 = false;
                        break;
                    case 4:
                        player4.transform.DOMove(maps[diceSum4].transform.position, 0.5f);
                        activeZoon4 = false;
                        break;
                }
                break;

            case 4:
                eventText.text = "最高の気分！とりあえず飲む";
                image.SetActive(true);
                yield return new WaitForSeconds(1.0f);
                break;
            case 5:
                eventText.text = "神になった気がする。とりあえず飲む";
                image.SetActive(true);
                yield return new WaitForSeconds(1.0f);
                break;
        }
        image.SetActive(true);
    }

    public void OnMapButton()
    {
        if (allMap == false)
        {
            allCamera.orthographicSize = 25;
            allCamera.transform.position = new Vector3(-5, 9, -10);
            allMap = true;
        }
        else if (allMap == true)
        {
            allCamera.orthographicSize = 7;
            switch (turn)
            {
                case 1:
                    playerCamera.transform.parent = player1.transform;
                    playerCamera.transform.position = new Vector3(player1.transform.position.x, player1.transform.position.y + 0.5f, -10);
                    break;
                case 2:
                    playerCamera.transform.parent = player2.transform;
                    playerCamera.transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y + 0.5f, -10);
                    break;
                case 3:
                    playerCamera.transform.parent = player3.transform;
                    playerCamera.transform.position = new Vector3(player3.transform.position.x, player3.transform.position.y + 0.5f, -10);
                    break;
                case 4:
                    playerCamera.transform.parent = player4.transform;
                    playerCamera.transform.position = new Vector3(player4.transform.position.x, player4.transform.position.y + 0.5f, -10);
                    break;
            }
            allMap = false;
                  
        }
    }

}
