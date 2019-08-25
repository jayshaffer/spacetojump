using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winbox : MonoBehaviour
{
    GameController gameController;
    public int something;
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
