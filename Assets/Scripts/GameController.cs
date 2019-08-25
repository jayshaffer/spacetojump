using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int currentScene;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void NextScene(){
        SceneManagement.SceneManager.LoadScene(currentScene++);
    }
}
