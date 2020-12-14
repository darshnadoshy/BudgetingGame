using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneScript : MonoBehaviour
{
   public float aisle1, aisle2, aisle3, aisle4, aisle5, total;
   public GameObject player;
   public Text message; 
   public Text totalamt;
   //public Text a1, a2, a3, a4, a5;
 
   public void Start(){
       
       aisle1 = Aisle1Script.total;
       aisle2 = Aisle2Script.total;
       aisle3 = Aisle3Script.total;
       aisle4 = Aisle4Script.total;
       aisle5 = Aisle5Script.total;
       total = aisle1 + aisle2 + aisle3 + aisle4 + aisle5;

       totalamt.text = total.ToString();

       if (total > 0 && total <= 20)
       //if (total <= 20)
       {
           message.text = "Congratulations!\n\nYou’ve mastered the art of budgeting!";
       }
       else
       {
           message.text = "Sorry you lost!\n\nRemember to try to look for the lower cost items. Try again?";
       }
   }
}
