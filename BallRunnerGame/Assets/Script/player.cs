using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float maxX;
    public float minX;
   
  
public Rigidbody rigidbody;
    void Update()
    {
        Vector3 player = transform.position;
        player.x = Mathf.Clamp(player.x, minX, maxX);
        transform.position=player;
        
        // if(player.x<=minX){
        //    Debug.Log("Minimum"+player.x);
        //     player.x=minX;
        // }
        // if(player.x>=maxX){
        //    Debug.Log("Maximum");
        //     player.x=maxX;
        // }
        // transform.position=player;

            if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position - new Vector3(5f*Time.deltaTime, 0, 0); 
           
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // rigidbody.AddForce(0, 0, 2f * Time.deltaTime);
            transform.position = transform.position + new Vector3(0, 0, 5f * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(5f * Time.deltaTime, 0, 0);
           
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position - new Vector3(0, 0, 5f * Time.deltaTime);
           
        }

    }
}
