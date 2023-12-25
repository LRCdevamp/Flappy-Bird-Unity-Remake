using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // We need to add this to be able to use UI related functions like Text etc. ( Line 11 )
using UnityEngine.SceneManagement; // We need to add this to be able to use screen and scene related functions. ( Line )

public class LogicScript : MonoBehaviour
{
   public int playerScrore = 0;
   public int scoreToAdd = 1; // The default value is 1 and it can be changed through Unity UI. For non programmer people
   public Text scoreText; // We need to set the visibility to Public cause we will need to change this within other objects
   public GameObject gameOverScreen;

   [ContextMenu("Add Score")] /* Using this, We will be able to run this function inside Unity, Using three
   dots of this component. */
   public void addScore(){
      playerScrore = playerScrore + scoreToAdd ;
      scoreText.text = playerScrore.ToString(); // Pay attention to .ToString()
   }

   public void restartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void gameOver()
   {
      gameOverScreen.SetActive(true);
   }
   
   
   
}
