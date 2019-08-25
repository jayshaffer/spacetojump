using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.GetAxis("Horizontal");
       transform.Translate(new Vector3(horizontal, 0, 0) * speed * Time.deltaTime); 
       if(health <= 0){
           Kill();
       }
    }

    public void Damage(int amount){
        health -= amount;
    }

    public void Kill(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
