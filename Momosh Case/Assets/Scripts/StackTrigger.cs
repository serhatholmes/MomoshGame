using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Handcuff"){
            StackManager.instance.PickUp(other.gameObject,true, "Untagged");
            //StackManager.instance.Stairs(other.gameObject, true, "Untagged",true);
        }

        else if (other.tag == "Thief")
        {
            StackManagerThief.instance.PickUp(other.gameObject,true,"Untagged");
        }
        
        else if (other.tag == "Prison")
        {
            
        }
        
    }
}
