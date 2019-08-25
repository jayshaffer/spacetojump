using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winbox : MonoBehaviour
{
    GameObject gameController;
    void Start()
    {
        if (gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        }
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           gameController.NextScene(); 
        }
    }
}
