using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int health;
    public float jumpForce;
    public JumpTrigger jumpTrigger;
    public float jumpDelay;
    Rigidbody2D rb;
    float lastJump;
    bool jumpReleased;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
        lastJump -= jumpDelay;
    }

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.GetAxis("Horizontal");
       transform.Translate(new Vector3(horizontal, 0, 0) * speed * Time.deltaTime); 
       bool onGround = jumpTrigger.OnGround();
       bool jumpButtonPressed = Input.GetButton("Jump"); 
       if(jumpButtonPressed && jumpReleased && jumpTrigger.OnGround() && CanJump()){
           Jump();
       }
       if(health <= 0){
           Kill();
       }
       jumpReleased = onGround && !jumpButtonPressed; 
    }

    public bool CanJump(){
        Debug.Log(Time.time);
        return lastJump + jumpDelay < Time.time;
    }

    public void Jump(){
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }

    public void Damage(int amount){
        health -= amount;
    }

    public void Kill(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
