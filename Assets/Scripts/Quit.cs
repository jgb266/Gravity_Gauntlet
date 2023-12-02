using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
       Debug.Log("Collided");
       if(other.gameObject.CompareTag("Player_Tag"))
       {
           Debug.Log("You have Quit!");
           SceneManager.LoadScene("Loser_Screen");
        }
    }
}
