using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class PlayerControll : MonoBehaviour
{

    [SerializeField]
    private int moveSpeed;

    [SerializeField]
    private Animator playerAni;

    public Rigidbody2D rb;

    List<Transform> maps = new List<Transform>();


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }




}
