using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Menus : MonoBehaviour
{
   // allows the levels loaded to be inputted
   public string newGameScene;
   public string optionScene;

 
   public void NewGame()
   {
       // loads inputted level, starting at one for new games
       SceneManager.LoadScene(newGameScene);
   }
 
   public void GoToMenu()
   {
       // loads menu
       SceneManager.LoadScene("Scene1");
   }

   public void OptionScene()
   {
       // loads additional scene
       SceneManager.LoadScene(optionScene);
   }
 
   public void QuitGame()
   {
       // quits game
       Application.Quit();
   }
}
