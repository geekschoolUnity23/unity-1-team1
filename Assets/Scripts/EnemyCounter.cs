using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public int maxEnemyCountMutant;
    public int currentEnemyCountMutant;
    public Text MaxEnemyCountTextMutant;
    public Text CurrentEnemyCountTextMutant;

    public int maxEnemyCountMarader;
    public int currentEnemyCountMarader;
    public Text MaxEnemyCountTextMarader;
    public Text CurrentEnemyCountTextMarader;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void MutantPoint()
    {
        currentEnemyCountMutant++;
    }

    public void MaraderPoint()
    {
        currentEnemyCountMarader++;
    }

    // Update is called once per frame
    void Update()
    {
        MaxEnemyCountTextMutant.text = maxEnemyCountMutant.ToString();
        CurrentEnemyCountTextMutant.text = currentEnemyCountMutant.ToString();

        MaxEnemyCountTextMarader.text = maxEnemyCountMarader.ToString();
        CurrentEnemyCountTextMarader.text = currentEnemyCountMarader.ToString();
    }
}
