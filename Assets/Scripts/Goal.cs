using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player_Tag"))
       {
           Debug.Log("You have reached the goal!");
           SceneManager.LoadScene("Winner_Screen");
        }
    }
}
