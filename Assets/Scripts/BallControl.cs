using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private float rand;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    private void GoBall()
    {
        rand = Random.Range(0, 2);
        if (rand == 0) rb2d.AddForce(new Vector2(-20, -15));
        else rb2d.AddForce(new Vector2(20, -15));

    }

    private void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    public void RestartTheGame()
    {
        ResetBall();
        Invoke("GoBall", 2);
    }


}
