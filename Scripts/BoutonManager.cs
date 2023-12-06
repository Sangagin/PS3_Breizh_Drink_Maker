using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoutonManager : MonoBehaviour
{

    public int idScene = 0;
    public TextMeshProUGUI textScene;

    public GameObject oui;
    public GameObject non;
    public GameObject droite;
    public GameObject gauche;
    public GameObject boutonHit;
    public VariableManagerParcelles varManParcelles;


    public GameObject besoinMiel;
    public GameObject besoinPomme;


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
    }

    // Update is called once per frame
    void Update()
    {

        if (idScene == 0)
        {
            textScene.text = "Scene Parcelle";
            gauche.SetActive(false);
            boutonHit.SetActive(false);
            besoinMiel.SetActive(false);
            besoinPomme.SetActive(false);
        }
        else if (idScene == 1)
        {
            gauche.SetActive(true);
            droite.SetActive(true);
            besoinMiel.SetActive(true);
            besoinPomme.SetActive(true);
            textScene.text = "Scene Chaudron";
            boutonHit.SetActive(plein);

        }
        else if (idScene == 2)
        {
            textScene.text = "Scene Commandes";
            droite.SetActive(false);
            boutonHit.SetActive(false);
            besoinMiel.SetActive(false);
            besoinPomme.SetActive(false);
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
}
