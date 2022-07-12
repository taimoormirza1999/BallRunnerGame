using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHit : MonoBehaviour
{
    public player playerScript;
    public score scoreScript;
    public GameOver GameOverScript;
    public int count=0;
    public AudioSource coinget;
    public AudioSource background;
    public AudioSource gameover;
     public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Coins")
        { 
            coinget.Play();
            count++;
           scoreScript.ShowScore(count);
           
        Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Wall")
        {   background.enabled=false;
        gameover.Play();
            scoreScript.GetScore();
            GameOverScript.showGameOverPannel();
            playerScript.enabled = false;
        }

    }
}
