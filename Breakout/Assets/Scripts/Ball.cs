using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;

public class Ball : MonoBehaviour
{
    public Rigidbody2D ball,player;
    public float force;
    public int movementSpeed;
    private int random;
    public TMP_Text score;
    void Start()
    {
        random = Random.Range(-1, 1);
        if (random == 0)
            random += 1;
        ball.velocity = new Vector2( random* force,-force);
        score.text = "0";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ball.velocity.Set(ball.velocity.x + player.velocity.x,
                ball.velocity.y + ball.velocity.x);
        }
        else if(collision.gameObject.tag == "box")
        {
            collision.gameObject.SetActive(false);
            ball.AddForce(new Vector2(ball.velocity.x, ball.velocity.y));
            score.text = (int.Parse(score.text)+1).ToString();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EditorSceneManager.LoadScene("SampleScene"); 
    }
}
