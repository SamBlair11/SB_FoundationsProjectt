using UnityEngine;

public class Interact_KeycardPanel : MonoBehaviour
{
    bool insideTrigger = false;
    private Animator anim;
    public GameObject securityDoor;

    private void Awake()
    {
        anim = securityDoor.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && insideTrigger)
        {
            Debug.Log("Button Pressed");

            anim.Play("Open_securityDoor");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            insideTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        insideTrigger = false;
    }
}
