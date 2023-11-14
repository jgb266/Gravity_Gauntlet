using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZPlatformMovement : MonoBehaviour
{
    public GameObject go;
    public int minZ = -10;
    public int maxZ = 10;
    public float speed = 5f;
    public int direction = 0;

    // Update is called once per frame
    void Update()
    {
        if(direction == 0)
        {
            Vector3 currentPos = go.transform.position;
            currentPos.z += speed * Time.deltaTime;
            go.transform.position = currentPos;

            if(currentPos.z > maxZ)
               direction = 1;
        }
        else if(direction == 1)
        {
            Vector3 currentPos = go.transform.position;
            currentPos.z -= speed * Time.deltaTime;
            go.transform.position = currentPos;

            if(currentPos.z < minZ)
               direction = 0;
        }
    }
}
