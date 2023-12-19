using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset jsonFile;

    void Start()
    {
        ClickUpCostSeparate costsInJson = JsonUtility.FromJson<ClickUpCostSeparate>(jsonFile.text);

        foreach (ClickUpCost clickUpCost in costsInJson.clickUpCostSeparate)
        {
            Debug.Log(clickUpCost.french + " " + clickUpCost.english);
        }
    }
}