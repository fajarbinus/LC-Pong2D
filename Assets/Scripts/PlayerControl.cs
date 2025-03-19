using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed;
    public float boundY1,boundY2;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Movement()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp)) vel.y = speed;
        else if (Input.GetKey(moveDown)) vel.y = -speed;
        else vel.y = 0;
        rb2d.velocity = vel;
    }

    private void LimitPos()
    {
        var pos = transform.position;
        if (pos.y > boundY1) pos.y = boundY1;
        else if (pos.y < boundY2 ) pos.y = boundY2;
        transform.position = pos;
    }

    void Update()
    {
        Movement();
        LimitPos();
    }
}
