using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
   public GameObject clickObjToDestroy;

    void OnMouseDown()
    {
        Debug.Log("Object was clicked");
        //Debug.LogError("Object was clicked");//this Log Error will stop playing
        //Debug.LogWarning("Object was clicked");//this Log Warning will not stop playing

        Destroy(clickObjToDestroy);

    }
}
