using UnityEngine;
//This script is to Destroy a Game Object using the Spacebar
public class PushSpaceDestroy : MonoBehaviour
{

public GameObject gameObjectToDestroy;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);//This destroys the Game Object that the script is attached to

            //Destroy(this);//This destroys the script attached to the Game Object

            //Destroy(this.gameObject);//This destroys the Game Object that the script is attached to

            Destroy(gameObjectToDestroy);//This destroys the Game Object that is assigned to the variable in the Inspector

            
        }
    }
}
