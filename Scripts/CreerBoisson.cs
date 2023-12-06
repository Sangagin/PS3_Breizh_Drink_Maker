using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CreerBoisson : MonoBehaviour
{



    public TextMeshProUGUI quantPomme;
    public TextMeshProUGUI quantMiel;

    public VariableManagerParcelles variableManager;
    public BoutonManager boutonManager;
    private int typeRecette;

    public int pommeBesoin = 2;

    public int pommeDonne = 0;
    private int mielBesoin = 2;
    private int mielDonne = 0;

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
            quantMiel.text = "x " + (mielBesoin - mielDonne);
            quantPomme.text = "x " + (pommeBesoin - pommeDonne);
        }
        else if (typeRecette == 3)
        {
            quantMiel.text = "x " + (mielBesoin - mielDonne);
            quantPomme.text = "x " + (pommeBesoin - pommeDonne);
        }

        if(mielBesoin==mielDonne && pommeBesoin == pommeDonne)
        {
            boutonManager.setPlein(true);
        }


    }





    public int getPommeBesoin() { return pommeBesoin; }
    public int getPommeDonne() { return pommeDonne; }
    public int getMielBesoin() { return mielBesoin; }
    public int getMielDonne() { return mielDonne; }

    public void setPommeBesoin(int pommeBesoin) { this.pommeBesoin = pommeBesoin; }
    public void setPommeDonne(int pommeDonne) { this.pommeDonne = pommeDonne; }
    public void setMielBesoin(int mielBesoin) { this.mielBesoin = mielBesoin; }
    public void setMielDonne(int mielDonne) { this.mielDonne = mielDonne; }

}
