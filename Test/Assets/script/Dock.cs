using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dock : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 8;
    public int groundCollision;
    public float jump = 6;
    private Rigidbody2D myRigidbody;
    private Animator myAni;
    private bool isWalk;
    private bool isJump;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAni = GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        Walk();
    }
    void Walk() 
    {
        var body = GetComponent<Rigidbody2D>();
        var v = body.velocity;

        v.x = Input.GetAxis("Horizontal") * speed;


        if (Input.GetKeyDown(KeyCode.Space) && groundCollision > 0)
        {
            v.y = jump;
            isJump = true;
        }
        else
            isJump = false;
        myAni.SetBool("isJump", isJump);
        body.velocity = v;

        if (v.x != 0)
        {
            var scale = transform.localScale;
            scale.x = (Mathf.Sign(v.x) * Mathf.Abs(transform.localScale.x))*-1;
           transform.localScale = scale;
            isWalk = true;
        }
        else
            isWalk = false;
        myAni.SetBool("isWalk", isWalk);
    }
}
