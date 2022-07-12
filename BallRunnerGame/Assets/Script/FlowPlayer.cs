using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowPlayer : MonoBehaviour
{
    public float offset;
    public Transform Playerposition;

    // Update is called once per frame
    void Update()
    {


        Vector3 cameraPos=transform.position;
        Vector3 PlayerPos=Playerposition.position;
        cameraPos.z=PlayerPos.z-offset;
        transform.position=cameraPos;
        // Vector3 cameraPos = transform.position;
        // Vector3 PlayerPos = Playerposition.position;
        // cameraPos.z = PlayerPos.z - offset;
        // transform.position = cameraPos;
    }
}
