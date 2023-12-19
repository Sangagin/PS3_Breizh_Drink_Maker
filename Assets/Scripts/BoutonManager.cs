using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using TMPro;
using UnityEngine;

public class BoutonManager : MonoBehaviour
{

    public int idScene = 0;

    public TextMeshProUGUI textBoutonScene2;

    public GameObject oui;
    public GameObject non;
    public GameObject droite;
    public GameObject gauche;
    public GameObject boutonHit;
    public VariableManagerParcelles varManParcelles;
    public GameObject magasin;


    public GameObject besoinRecette1;
    public GameObject boutonDr1;
    public GameObject boutonDr2;
    public GameObject boutonGa1;
    public GameObject boutonGa2;
    public GameObject barre;
    public GameObject marqueur;
    public GameObject uiCommande;
    public GameObject uiParcelle;
//    public GameObject maxDr;
   // public GameObject maxGa;



    private bool plein = false;


    // Start is called before the first frame update
    void Start()
    {
        var cubeRendererOui = oui.GetComponent<Renderer>();
        var cubeRendererNon = non.GetComponent<Renderer>();

        cubeRendererOui.material.SetColor("_Color", Color.green);
        cubeRendererNon.material.SetColor("_Color", Color.red);
        oui.SetActive(false);
        non.SetActive(false);
//        StartCoroutine(BougeMarqueurMax());
    }

    // Update is called once per frame
    void Update()
    {

        if (idScene == 0)
        {
            gauche.SetActive(false);
            boutonHit.SetActive(false);
            besoinRecette1.SetActive(false);
            boutonGa1.SetActive(false);
            boutonGa2.SetActive(false);
            boutonDr1.SetActive(true); 
            boutonDr2.SetActive(false);
            barre.SetActive(false);
            marqueur.SetActive(false);
            magasin.SetActive(true);
            uiParcelle.SetActive(true); 

        }
        else if (idScene == 1)
        {
            magasin.SetActive(false);

            gauche.SetActive(true);
            droite.SetActive(true);
            besoinRecette1.SetActive(true);
            boutonGa1.SetActive(true);
            boutonGa2.SetActive(false);
            boutonDr1.SetActive(false);
            boutonDr2.SetActive(true);
            boutonHit.SetActive(plein);
            marqueur.SetActive(plein);
            barre.SetActive(plein);
            uiCommande.SetActive(false);
            uiParcelle.SetActive(false);
            int recette = varManParcelles.getRecetteActive();
            switch (recette)
            {
                case 1:
                    textBoutonScene2.text ="Hit";
                    break;

                case 2:
                    textBoutonScene2.text = "Hold";
                    break;

                case 3:
                    textBoutonScene2.text = "Hit";
                    break;

            }




        }
        else if (idScene == 2)
        {
            uiCommande.SetActive(true);
           
            droite.SetActive(false);
            boutonHit.SetActive(false);
            barre.SetActive (false);
            marqueur.SetActive(false);
            besoinRecette1.SetActive(false);
            boutonGa1.SetActive(false);
            boutonGa2.SetActive(true);
            boutonDr1.SetActive(false);
            boutonDr2.SetActive(false);



        }


        for (int i = 0; i < varManParcelles.parcelles.Length; i++)
        {
            var parcelles = varManParcelles.parcelles[i].GetComponent<PlanterUnTruc>();
            if (parcelles.etat == 5)
            {
                oui.SetActive(true);
                non.SetActive(true);
                break;
            }
            else
            {
                oui.SetActive(false);
                non.SetActive(false);
            }
        }







    }



    public bool getPlein() { return plein; }
    public void setPlein(bool plein) { this.plein = plein; }

    /*
    public IEnumerator BougeMarqueurMax()
    {
        yield return new WaitForSeconds(1);
        maxDr.transform.position = new Vector3(maxDr.transform.position.x, Random.Range(ui.commande1, ui.commande2);, maxDr.transform.position.z);

    }
    */
}
