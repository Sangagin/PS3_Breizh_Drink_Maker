using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Codex : MonoBehaviour
{

    public JSONReader reader;
    public JSONReader reader2;

    public bool langue = false;


    public List<TextMeshProUGUI> textes = new List<TextMeshProUGUI>();
    public List<TextMeshProUGUI> textesFest = new List<TextMeshProUGUI>();



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if(!langue)
        {
            for(int i = 0; i < textes.Count; i++)
            {
                textes[i].text = reader.keysFR[i];
            }
            for(int i = 0;i < textesFest.Count; i++)
            {
                textesFest[i].text = reader2.keysFR[i];
            }

        }
        else
        {
            for (int i = 0; i < textes.Count; i++)
            {
                textes[i].text = reader.keysEN[i];
            }
            for (int i = 0; i < textesFest.Count; i++)
            {
                textesFest[i].text = reader2.keysEN[i];
            }
        }


        
    }
}
