using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPlatformMovement : MonoBehaviour
{
    public GameObject go;
    public int minX = -10;
    public int maxX = 10;
    public float speed = 5f;
    public int direction = 0;

    // Update is called once per frame
    void Update()
    {
        if(direction == 0)
        {
            Vector3 currentPos = go.transform.position;
            currentPos.x += speed * Time.deltaTime;
            go.transform.position = currentPos;

            if(currentPos.x > maxX)
               direction = 1;
        }
        else if(direction == 1)
        {
            Vector3 currentPos = go.transform.position;
            currentPos.x -= speed * Time.deltaTime;
            go.transform.position = currentPos;

            if(currentPos.x < minX)
               direction = 0;
        }
    }
}
