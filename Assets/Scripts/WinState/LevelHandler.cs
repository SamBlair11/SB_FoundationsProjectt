using TMPro;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{
    public static LevelHandler Instance;

    

    public Levels[] levels;



    private void Awake()
    {
        Instance = this;
    }


}
[System.Serializable]

public class Levels
{
    public GameObject[] coins;
}