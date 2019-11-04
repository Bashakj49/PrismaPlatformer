using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    SceneManager.LoadScene("Level1");
    //}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "DeathCollider")
            SceneManager.LoadScene("Level1");
    }
}

