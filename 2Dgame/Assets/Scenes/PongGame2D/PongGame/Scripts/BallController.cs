using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject Bat1;
    public GameObject Bat2;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        Bat1 = GameObject.Find("Bat_1");
        Bat2 = GameObject.Find("Bat_2");
        CountScore.canAddScore = true;
        StartCoroutine(Pause());
       
    }

   
    void Update()
    {
        if (Mathf.Abs(this.transform.position.x) >= 21f)
        {
            CountScore.canAddScore = true;
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        } 
    }

    IEnumerator Pause()
    {
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);

        if (directionX == 0)
        {
            directionX = 1;
        }

        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector2(12f * directionX, 10f * directionY);
    }

    void OnCollisionEnter2D (Collision2D hit)
    {
        if (hit.gameObject.name == "Bat_1")
        {
            if (Bat1.GetComponent<Rigidbody2D> ().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2 (10f, 10f);
            }

            else if (Bat2.GetComponent<Rigidbody2D> ().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(10f, -10f);
            }

            else
            {
                rb.velocity = new Vector2(12f, 10f);
            }
        }

        if (hit.gameObject.name == "Bat_2")
        {
            if (Bat2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-10f, 10f);
            }

            else if (Bat2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(-10f, -10f);
            }

            else
            {
                rb.velocity = new Vector2(-12f, 10f);
            }
        }
    }
}
