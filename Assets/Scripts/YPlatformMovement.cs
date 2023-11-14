using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YPlatformMovement : MonoBehaviour
{
    public GameObject go;
    public int minY = -10;
    public int maxY = 10;
    public float speed = 5f;
    public int direction = 0;

    // Update is called once per frame
    void Update()
    {
        if(direction == 0)
        {
            Vector3 currentPos = go.transform.position;
            currentPos.y += speed * Time.deltaTime;
            go.transform.position = currentPos;

            if(currentPos.y > maxY)
               direction = 1;
        }
        else if(direction == 1)
        {
            Vector3 currentPos = go.transform.position;
            currentPos.y -= speed * Time.deltaTime;
            go.transform.position = currentPos;

            if(currentPos.y < minY)
               direction = 0;
        }
    }
}
