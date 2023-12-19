using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{



    private int pomme = 0;
    private int miel = 0;


    public int bouteille1 = 0;
    public int bouteille2 = 0;
    public int bouteille3 = 0;

    public float time = 50f;
    public int argent = 0;
    public int argentObjectif = 10;





    public TextMeshProUGUI textUiPomme;
    public TextMeshProUGUI textUiMiel;

    public TextMeshProUGUI textUiBouteille1;
    public TextMeshProUGUI textUiBouteille2;
    public TextMeshProUGUI textUiBouteille3;
    public TextMeshProUGUI textUiTime;
    public TextMeshProUGUI textUiArgent;
    public TextMeshProUGUI textUiArgentObjectif; 
    public TextMeshProUGUI textUiTime2;
    public TextMeshProUGUI textUiArgent2;
    public TextMeshProUGUI textUiArgentObjectif2;

    public Client1Libre posArriveeClient1;
    public Client2Libre posArriveeClient2;
    public Client3Libre posArriveeClient3;

    public TextMeshProUGUI demandeBout1Client1;
    public TextMeshProUGUI demandeBout2Client1;
    public TextMeshProUGUI demandeBout3Client1;

    public TextMeshProUGUI demandeBout1Client2;
    public TextMeshProUGUI demandeBout2Client2;
    public TextMeshProUGUI demandeBout3Client2;

    public TextMeshProUGUI demandeBout1Client3;
    public TextMeshProUGUI demandeBout2Client3;
    public TextMeshProUGUI demandeBout3Client3;

    public GameObject fenetreGagne;
    public GameObject fenetrePerdu;


    public int commande1 = 1;
    public int commande2 = 2;
    public int commande3 = 0;
    public int commande4 = 3;
    public int commande5 = 0;
    public int commande6 = 3;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(countdown());

    }

    // Update is called once per frame
    void Update()
    {
        textUiPomme.text = "x " + pomme;

        textUiMiel.text = "x " + miel;



        textUiBouteille1.text = "x " + bouteille1;

        textUiBouteille2.text = "x " + bouteille2;

        textUiBouteille3.text = "x " + bouteille3;

        textUiTime.text = "Temps : " + time;

        textUiArgent.text = "Argent : " + argent;

        textUiArgentObjectif.text = "Objectif : " + argentObjectif;

        textUiTime2.text = "Temps : " + time;

        textUiArgent2.text = "Argent : " + argent;

        textUiArgentObjectif2.text = "Objectif : " + argentObjectif;

        if (argent >= argentObjectif)
        {
            time = 9999999;
            Debug.Log("gagne");
            fenetreGagne.SetActive(true);
        }
        else
        {
            fenetreGagne.SetActive(false);
        }
        if (time <= 0)
        {
            fenetrePerdu.SetActive(true);
        }
        else {
            fenetrePerdu.SetActive(false);
        }


        demandeBout1Client1.text = posArriveeClient1.bout1.ToString();
        demandeBout2Client1.text = posArriveeClient1.bout2.ToString();
        demandeBout3Client1.text = posArriveeClient1.bout3.ToString();


        demandeBout1Client2.text = posArriveeClient2.bout1.ToString();
        demandeBout2Client2.text = posArriveeClient2.bout2.ToString();
        demandeBout3Client2.text = posArriveeClient2.bout3.ToString();

        demandeBout1Client3.text = posArriveeClient3.bout1.ToString();
        demandeBout2Client3.text = posArriveeClient3.bout2.ToString();
        demandeBout3Client3.text = posArriveeClient3.bout3.ToString();




    }



    //assesseurs

    public int getPomme() { return pomme; }
    public int getMiel() { return miel; }
    public int getBouteille1() { return bouteille1; }
    public int getBouteille2() { return bouteille2; }
    public int getBouteille3() { return bouteille3; }

    public int getArgent() { return argent; }
    public int getArgentObjectif() { return argentObjectif; }
    public float getTime() { return time; }
    public void setPomme(int pommeAdd) { pomme = pommeAdd; }
    public void setMiel(int mielAdd) { miel = mielAdd; }
    public void setBouteille1(int bouteille1Add) { bouteille1 = bouteille1Add; }
    public void setBouteille2(int bouteille2Add) { bouteille2 = bouteille2Add; }
    public void setBouteille3(int bouteille3Add) { bouteille3 = bouteille3Add; }
    public void setArgent(int argentAdd) { argent = argentAdd; }
    public void setArgentObjectif(int argentObjectifAdd) { argentObjectif = argentObjectifAdd; }
    public void setTime(float timeAdd) { time = timeAdd; }
    public void addArgent(int argentAdd) { argent += argentAdd; }
    public void addTime(float timeAdd) { time += timeAdd; }




    IEnumerator countdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time -= 1;
        }
    }



}
