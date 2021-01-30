using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    // allows next scene to be entered
    public string newGameScene;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // loads next scene on collision
        SceneManager.LoadScene(newGameScene);
         Debug.Log("Hello: ");
    }
}
