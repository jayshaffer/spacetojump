using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    PlayerController playerController;
    public int damage;
    void Start()
    {
       if(playerController == null){
           playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
       } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("here");
       if(other.gameObject.tag == "Player"){
           playerController.Damage(damage);
       }  
    }
}
