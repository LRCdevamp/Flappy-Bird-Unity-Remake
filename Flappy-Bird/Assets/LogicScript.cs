using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // We need to add this to be able to use UI related functions like Text etc.

public class LogicScript : MonoBehaviour
{
   public int playerScrore;
   public Text scoreText; // We need to set the visibility to Public cause we will need to change this within other objects

   [ContextMenu("Add Score")] /* Using this, We will be able to run this function inside Unity, Using three
   dots of this component. */
   public void addScore(){
      playerScrore = playerScrore + 1;
      scoreText.text = playerScrore.ToString(); // Pay attention to .ToString()
   }
}
