using UnityEngine;

public class UseKeycard : MonoBehaviour
{
    //public GameObject clickobjtoanimate
    Animator animator;

    // This script is to click to trigger an animation on another object this script is attached to.

    void start()
    {
        animator = GetComponent<Animator>();

    }

    void OnMouseDown()
    {
        Debug.Log("Object Clicked");

        animator.SetBool("IsClicked", true);

    }
}
