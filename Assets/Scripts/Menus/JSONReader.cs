using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset jsonFile;
    public int count = 0;

    public List<string> keysFR = new List<string>();
    public List<string> keysEN = new List<string>();


    void Start()
    {
        ClickUpCostSeparate costsInJson = JsonUtility.FromJson<ClickUpCostSeparate>(jsonFile.text);

        foreach (ClickUpCost clickUpCost in costsInJson.clickUpCostSeparate)
        {
            keysFR.Add(clickUpCost.french);
            keysEN.Add(clickUpCost.english);
//            Debug.Log(clickUpCost.french + " " + clickUpCost.english);
            count++;
        }
    }//26
}