using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
// public Text score;
public TextMeshProUGUI scoreText;
public TextMeshProUGUI EndScore;
 int myScore=0;
    // Start is called before the first frame update
    void Start()
    {
        EndScore.enabled=false;
        scoreText=GetComponent<TextMeshProUGUI>();
      
    }
     void Update()
    { 
     scoreText.text=myScore.ToString();    
     EndScore.text="Score: "+myScore.ToString();    
    }
  public void AddScore(int temp)
    { 
        myScore=myScore+1;
        
        }
  public void ShowScore(int temp)
    {   myScore=temp;
        scoreText.text=myScore.ToString();
        
        }
  public void GetScore()
    { 
        EndScore.enabled=true; 
        }
       
       
}
