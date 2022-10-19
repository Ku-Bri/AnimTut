/***
 * Author: Bridget Kurr
 * Created: 10/19/22
 * Modified:
 * Description: trigger for door/gate
 ***/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    public GameObject doorObject; //reference to the door game object
    public string animParam; // reference to actual animator parameter
    Animator animator; //reference to the animator

    // Start is called before the first frame update
    void Start()
    {
        animator = doorObject.GetComponent<Animator>();
        Debug.Log(animator.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool(animParam, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool(animParam, false);
        }
    }
}
