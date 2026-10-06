using UnityEngine;
//This script is to Destroy a Game Object using the Spacebar
public class PushSpaceDestroy : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
