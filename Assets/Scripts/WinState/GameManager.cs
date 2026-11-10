using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int current_Level;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
