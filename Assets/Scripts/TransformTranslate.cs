using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TransformTranslate : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
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
        }*/

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right*movementSpeed*Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right*movementSpeed*Time.deltaTime);
        }


        //rotate right
        {if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(transform.up*rotationSpeed*Time.deltaTime);

        }
        }

        //rotate left
        {if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate((-1)*transform.up*rotationSpeed*Time.deltaTime);

        }
        }
        
    }
}
