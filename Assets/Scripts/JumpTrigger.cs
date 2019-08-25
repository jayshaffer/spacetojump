using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    
    private bool onGround;
    // Start is called before the first frame update
    void Start()
    {
       onGround = true; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool OnGround(){
        return onGround;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag != "Player"){
            onGround = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag != "Player"){
            onGround = false;
        }
    }
}
