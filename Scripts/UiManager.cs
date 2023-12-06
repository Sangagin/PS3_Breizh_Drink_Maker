using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{



    private int pomme=0;
    private int miel=0;
    private int ressource3= 0;

    private int bouteille1 = 0;
    private int bouteille2 = 0;
    private int bouteille3 = 0;

    public TextMeshProUGUI textUiPomme;
    public TextMeshProUGUI textUiMiel;
    public TextMeshProUGUI textUiRessource3;
    public TextMeshProUGUI textUiBouteille1;
    public TextMeshProUGUI textUiBouteille2;
    public TextMeshProUGUI textUiBouteille3;







    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textUiPomme.text = "x " + pomme;

        textUiMiel.text = "x " + miel;

        textUiRessource3.text = "x " + ressource3;

        textUiBouteille1.text = "x " + bouteille1;

        textUiBouteille2.text = "x " + bouteille2;
        
        textUiBouteille3.text = "x " + bouteille3;





    }



    //assesseurs

    public int getPomme() { return pomme; }
    public int getMiel() { return miel; }
    public int getRessource3() { return ressource3; }
    public int getBouteille1() { return bouteille1; }
    public int getBouteille2() { return bouteille2; }
    public int getBouteille3() { return bouteille3; }
    public void setPomme(int pommeAdd) { pomme = pommeAdd; }
    public void setMiel(int mielAdd) { miel = mielAdd; }
    public void setRessource3(int ressource3) { this.ressource3 = ressource3; }
    public void setBouteille1(int bouteille1Add) { bouteille1 = bouteille1Add; }
    public void setBouteille2(int bouteille2Add) { bouteille2 = bouteille2Add; }
    public void setBouteille3(int bouteille3Add) { bouteille3 = bouteille3Add; }



}
