using Unity.VisualScripting;
using UnityEngine;

public class TransformTranslate : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0,0,10);
            Debug.Log("W Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0,0,-10);
            Debug.Log("S Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-10,0,0);
            Debug.Log("A Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(10,0,0);
            Debug.Log("D Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Translate(0,10,0);
            Debug.Log("Q Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Translate(0,-10,0);
            Debug.Log("Z Key Pressed");
        }
    }
}
