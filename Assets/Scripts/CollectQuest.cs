using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectQuest : MonoBehaviour
{

    public int maxIteamCount = 10;
    public int currentIteamCount;
    public Text MaxIteamText;
    public Text CurrentIteamText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Collect()
    {
        currentIteamCount++;
    }

    // Update is called once per frame
    void Update()
    {
        MaxIteamText.text = maxIteamCount.ToString();
        CurrentIteamText.text = currentIteamCount.ToString();
    }
}
