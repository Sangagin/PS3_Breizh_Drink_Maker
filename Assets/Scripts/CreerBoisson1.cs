using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CreerBoisson1 : MonoBehaviour
{



    public TextMeshProUGUI quantPomme;
    public TextMeshProUGUI quantMiel;
    public TextMeshProUGUI quantPomme2;
    public TextMeshProUGUI quantMiel2;
    public TextMeshProUGUI quantPomme3;
    public TextMeshProUGUI quantMiel3;

    public VariableManagerParcelles variableManager;
    public BoutonManager boutonManager;
    private int typeRecette;

    public int pommeBesoin = 2;

    private int pommeDonne = 0;

    public int mielBesoin = 0;
    private int mielDonne = 0;


    public int pommeBesoin2 = 1;

    private int pommeDonne2 = 0;

    public int mielBesoin2 = 0;
    private int mielDonne2 = 0;


    public int pommeBesoin3 = 2;

    private int pommeDonne3 = 0;

    public int mielBesoin3 = 1;
    private int mielDonne3 = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        typeRecette = variableManager.getRecetteActive();





        if (typeRecette == 1)
        {


            quantMiel.text = "x " + (mielBesoin - mielDonne);
            quantPomme.text = "x " + (pommeBesoin - pommeDonne);

        }
        else if (typeRecette == 2)
        {
            quantMiel2.text = "x " + (mielBesoin2 - mielDonne2);
            quantPomme2.text = "x " + (pommeBesoin2 - pommeDonne2);
        }
        else if (typeRecette == 3)
        {
            quantMiel3.text = "x " + (mielBesoin3 - mielDonne3);
            quantPomme3.text = "x " + (pommeBesoin3 - pommeDonne3);
        }

        if(mielBesoin==mielDonne && pommeBesoin == pommeDonne)
        {
            boutonManager.setPlein(true);
        }

        if (mielBesoin2 == mielDonne2 && pommeBesoin2 == pommeDonne2)
        {
            boutonManager.setPlein(true);
        }


        if (mielBesoin3 == mielDonne3 && pommeBesoin3 == pommeDonne3)
        {
            boutonManager.setPlein(true);
        }



    }





    public int getPommeBesoin() { return pommeBesoin; }
    public int getPommeDonne() { return pommeDonne; }
    public int getMielBesoin() { return mielBesoin; }
    public int getMielDonne() { return mielDonne; }

    public int getPommeBesoin2() { return pommeBesoin2; }
    public int getPommeDonne2() { return pommeDonne2; }
    public int getMielBesoin2() { return mielBesoin2; }
    public int getMielDonne2() { return mielDonne2; }

    public int getPommeBesoin3() { return pommeBesoin3; }
    public int getPommeDonne3() { return pommeDonne3; }
    public int getMielBesoin3() { return mielBesoin3; }
    public int getMielDonne3() { return mielDonne3; }

    public void setPommeBesoin(int pommeBesoin) { this.pommeBesoin = pommeBesoin; }
    public void setPommeDonne(int pommeDonne) { this.pommeDonne = pommeDonne; }
    public void setMielBesoin(int mielBesoin) { this.mielBesoin = mielBesoin; }
    public void setMielDonne(int mielDonne) { this.mielDonne = mielDonne; }


    public void setPommeBesoin2(int pommeBesoin2) { this.pommeBesoin2 = pommeBesoin2; }
    public void setPommeDonne2(int pommeDonne2) { this.pommeDonne2 = pommeDonne2; }
    public void setMielBesoin2(int mielBesoin2) { this.mielBesoin2 = mielBesoin2; }
    public void setMielDonne2(int mielDonne2) { this.mielDonne2 = mielDonne2; }


    public void setPommeBesoin3(int pommeBesoin3) { this.pommeBesoin3 = pommeBesoin3; }
    public void setPommeDonne3(int pommeDonne3) { this.pommeDonne3 = pommeDonne3; }
    public void setMielBesoin3(int mielBesoin3) { this.mielBesoin3 = mielBesoin3; }
    public void setMielDonne3(int mielDonne3) { this.mielDonne3 = mielDonne3; }

}
