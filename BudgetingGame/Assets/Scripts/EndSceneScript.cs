using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneScript : MonoBehaviour
{
   public float aisle1, aisle2, aisle3, aisle4, aisle5, total;
   public GameObject player;
   public Text message, totalamt;

   public void results()
   {
       aisle1 = player.GetComponent<Aisle1Script>().GetAisle1Total();
       aisle2 = player.GetComponent<Aisle2Script>().GetAisle2Total();
       aisle3 = player.GetComponent<Aisle3Script>().GetAisle3Total();
       aisle4 = player.GetComponent<Aisle4Script>().GetAisle4Total();
       aisle5 = player.GetComponent<Aisle5Script>().GetAisle5Total();
       total = aisle1 + aisle2 + aisle3 + aisle4 + aisle5;

       totalamt.text = total.ToString();

       if (total <= 20)
       {
           message.text = "Congratulations!\n\nYou’ve mastered the art of budgeting!";
       }
       else
       {
           message.text = "Sorry you lost!\n\nRemember to try to look for the lower cost items. Try again?";
       }
   } 
}
