using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlanterUnTruc : MonoBehaviour, ITouchable
{


    public int id;
    public VariableManagerParcelles variableMan;
    public BoutonManager boutonManager;
    public UiManager uiManager;

    /*
     etat  
        0 -> parcelle libre
        1 -> parcelle occupée
        2 -> parcelle plante terminée
        3 -> parcelle survolée
        4 -> parcelle indisponible
        5 -> parcelle proposée
     */

    public int etat = 0;
    public bool utilisable = true;
    public bool totalUtilisable = true;

    public List<GameObject> parcellesAsso = new List<GameObject>();



    //gestion position 
    public bool cote = false;
    public bool bas = false;
    public bool centre = false;

    public int typePlante;
    public Transform center;
    public Transform center4;
    public Transform center2;
    public Transform center1;
    public GameObject arbre;
    public GameObject ruche;
    public GameObject fleurs;
    public GameObject plantTemp;


    // Update is called once per frame
    void Update()
    {




        /*
        if (etat == 2)
        {
            plantTemp.transform.localScale = new Vector3(1f, 1f, 1f);

        }

        if (etat == 1)
        {
            plantTemp.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

        }
        */






        if (variableMan.action)
        {
            for (int i = 0; i < parcellesAsso.Count; i++)
            {

                //detection plante selectionnée
                var recupAutresParcelles = parcellesAsso[i].GetComponent<PlanterUnTruc>();
                if (recupAutresParcelles.etat == 3)
                {

                    recupAutresParcelles.etat = 5;
                }
                if (i == parcellesAsso.Count)
                {
                    variableMan.action = false;
                }

                //detection plante plantée
                if (recupAutresParcelles.etat == 1)
                {
                    StartCoroutine(ExecuteAfterTime(10));

                }



            }
        }





        //modif couleur pour proto

        var render = this.GetComponent<Renderer>();

        switch (etat)
        {

            case 0:

                render.material.SetColor("_Color", Color.white);
                break;

            case 1:

                render.material.SetColor("_Color", Color.green);


                break;
            case 2:

                render.material.SetColor("_Color", Color.cyan);


                break;
            case 3:

                render.material.SetColor("_Color", Color.red);


                break;
            case 4:

                render.material.SetColor("_Color", Color.black);


                break;
            case 5:

                render.material.SetColor("_Color", Color.blue);


                break;
        }


    }





    private void OnTriggerEnter(Collider other)
    {

        if (etat == 0)
        {
            var recupType = other.GetComponent<Test>();


            if (variableMan.typePlante == 1)
            {
                parcellesAsso.Clear();
                center = center4.transform;
                if (!cote && !bas)
                {
                    parcellesAsso.Add(variableMan.parcelles[id]);
                    parcellesAsso.Add(variableMan.parcelles[id + 1]);
                    parcellesAsso.Add(variableMan.parcelles[id + 4]);
                    parcellesAsso.Add(variableMan.parcelles[id + 5]);
                }
                else if (cote && !bas)
                {
                    parcellesAsso.Add(variableMan.parcelles[id]);
                    parcellesAsso.Add(variableMan.parcelles[id - 1]);
                    parcellesAsso.Add(variableMan.parcelles[id + 3]);
                    parcellesAsso.Add(variableMan.parcelles[id + 4]);
                }
                else if (cote && bas)
                {
                    parcellesAsso.Add(variableMan.parcelles[id]);
                    parcellesAsso.Add(variableMan.parcelles[id - 1]);
                    parcellesAsso.Add(variableMan.parcelles[id - 4]);
                    parcellesAsso.Add(variableMan.parcelles[id - 5]);
                }
                else if (!cote && bas)
                {
                    parcellesAsso.Add(variableMan.parcelles[id]);
                    parcellesAsso.Add(variableMan.parcelles[id + 1]);
                    parcellesAsso.Add(variableMan.parcelles[id - 3]);
                    parcellesAsso.Add(variableMan.parcelles[id - 4]);
                }
            }
            else if (variableMan.typePlante == 2)
            {
                parcellesAsso.Clear();
                center = center2.transform;

                if (!cote)
                {
                    parcellesAsso.Add(variableMan.parcelles[id]);
                    parcellesAsso.Add(variableMan.parcelles[id + 1]);
                }
                else
                {
                    parcellesAsso.Add(variableMan.parcelles[id]);
                    parcellesAsso.Add(variableMan.parcelles[id - 1]);
                }

            }
            else if (variableMan.typePlante == 3)
            {
                parcellesAsso.Clear();
                center = center1;

                parcellesAsso.Add(variableMan.parcelles[id]);

            }


            for (int i = 0; i < parcellesAsso.Count; i++)
            {

                var recupAutresParcelles = parcellesAsso[i].GetComponent<PlanterUnTruc>();
                recupAutresParcelles.parcellesAsso = parcellesAsso;



            }


            //a modifier !



            for (int i = 0; i < parcellesAsso.Count; i++)
            {
                var recupAutresParcelles = parcellesAsso[i].GetComponent<PlanterUnTruc>();

                if (!recupAutresParcelles.utilisable)
                {
                    utilisable = false;


                }


            }




            if (utilisable)
            {
                for (int i = 0; i < parcellesAsso.Count; i++)
                {


                    var recupAutresParcelles = parcellesAsso[i].GetComponent<PlanterUnTruc>();
                    if (!recupAutresParcelles.utilisable)
                    {

                        totalUtilisable = false;
                    }

                    if (i == parcellesAsso.Count - 1 && totalUtilisable)
                    {
                        totalUtilisable = true;
                    }
                }





                if (totalUtilisable)
                {
                    if (center == center4)
                        
                    {
                        plantTemp = Instantiate(arbre, center.position, center.rotation);
                    }
                    else if (center == center2)
                    {
                        plantTemp = Instantiate(ruche, center.position, center.rotation);

                    }
                    else if(center == center1)
                    {
                        plantTemp = Instantiate(fleurs, center.position, center.rotation);

                    }
                    for (int i = 0; i < parcellesAsso.Count; i++)
                    {
                        var recupAutresParcelles = parcellesAsso[i].GetComponent<PlanterUnTruc>();

                        if (recupAutresParcelles.etat == 0)
                        {
                            recupAutresParcelles.etat = 3;
                            recupAutresParcelles.typePlante = recupType.typePlanteDrag;
                        }
                    }

                }




            }


        }


       

    }


    public void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < parcellesAsso.Count; i++)
        {
            var recupAutresParcelles = parcellesAsso[i].GetComponent<PlanterUnTruc>();
            if (recupAutresParcelles.etat == 3)
            {
                recupAutresParcelles.etat = 0;
                recupAutresParcelles.utilisable = true;
                plantTemp.SetActive(false);
            }


        }
        totalUtilisable = true;




    }




    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        for (int j = 0; j < parcellesAsso.Count; j++)
        {
            var recupAutresParcelles = parcellesAsso[j].GetComponent<PlanterUnTruc>();
            if (recupAutresParcelles.etat == 1)
            {
                recupAutresParcelles.etat = 2;
                recupAutresParcelles.utilisable = false;
            }
        }

    }

    public void OnTouchedDown(UnityEngine.Vector3 touchPosition)
    {


        if (etat == 2)
        {
            plantTemp.SetActive(false );
            for (int j = 0; j < parcellesAsso.Count; j++)
            {
                var recupAutresParcelles = parcellesAsso[j].GetComponent<PlanterUnTruc>();
                if (recupAutresParcelles.etat == 2)
                {
                    recupAutresParcelles.etat = 0;
                    
                }
                recupAutresParcelles.utilisable = true;
            }
            for (int j = 0; j < parcellesAsso.Count; j++)
            {
                var recupAutresParcelles = parcellesAsso[j].GetComponent<PlanterUnTruc>();
                recupAutresParcelles.parcellesAsso.Clear();
            }


            if (typePlante == 1)
            {
                int pomme = uiManager.getPomme();
                pomme += 1;
                uiManager.setPomme(pomme);
            }
            else if (typePlante == 2)
            {
                int miel = uiManager.getMiel();
                miel += 1;
                uiManager.setMiel(miel);
            }






        }


    }

    public void OnTouchedStay(UnityEngine.Vector3 touchPosition)
    {
        return;
    }

    public void OnTouchedUp()
    {
        return;
    }





    /*
    private void OnMouseDown()
    {

        if (variableMan.parcellesARecolter[id])
        {
            variableMan.parcellesARecolter[id] = false;

            if (variableMan.typePlante == 1)
            {
                variableMan.pomme += 1;

            }
            else if (variableMan.typePlante == 2)
            {
                variableMan.miel += 1;

            }
            else if (variableMan.typePlante == 3)
            {
                variableMan.pomme += 1;

            }
            Debug.Log("pomme " + variableMan.pomme);
            Debug.Log("miel " + variableMan.miel);


        }

        else if (!variableMan.parcellesARecolter[id])
        {
            if (variableMan.planteType1Selection)
            {
                boutonManager.oui.SetActive(true);
                boutonManager.non.SetActive(true);
                for (int i = 0; i < variableMan.parcellesSurbrillance.Length; i++)
                {
                    variableMan.parcellesSurbrillance[i] = false;
                }

                if (id < 11 && id != 3 && id != 7)
                {
                    variableMan.parcellesSurbrillance[id] = true;
                    variableMan.parcellesSurbrillance[id + 1] = true;
                    variableMan.parcellesSurbrillance[id + 4] = true;
                    variableMan.parcellesSurbrillance[id + 5] = true;



                }
                if (id > 11 && id < 15)
                {
                    variableMan.parcellesSurbrillance[id] = true;
                    variableMan.parcellesSurbrillance[id + 1] = true;
                    variableMan.parcellesSurbrillance[id - 4] = true;
                    variableMan.parcellesSurbrillance[id - 3] = true;
                }

                if (id == 3 || id == 7 || id == 11)
                {
                    variableMan.parcellesSurbrillance[id] = true;
                    variableMan.parcellesSurbrillance[id - 1] = true;
                    variableMan.parcellesSurbrillance[id + 3] = true;
                    variableMan.parcellesSurbrillance[id + 4] = true;
                }

                if (id == 15)
                {
                    variableMan.parcellesSurbrillance[id] = true;
                    variableMan.parcellesSurbrillance[id - 1] = true;
                    variableMan.parcellesSurbrillance[id - 4] = true;
                    variableMan.parcellesSurbrillance[id - 5] = true;

                }

            }

            else if (variableMan.planteType2Selection)
            {
                boutonManager.oui.SetActive(true);
                boutonManager.non.SetActive(true);
                for (int i = 0; i < variableMan.parcellesSurbrillance.Length; i++)
                {
                    variableMan.parcellesSurbrillance[i] = false;
                }

                variableMan.parcellesSurbrillance[id] = true;


            }


            else if (variableMan.planteType3Selection)
            {
                boutonManager.oui.SetActive(true);
                boutonManager.non.SetActive(true);
                for (int i = 0; i < variableMan.parcellesSurbrillance.Length; i++)
                {
                    variableMan.parcellesSurbrillance[i] = false;
                }


                if (id < 12)
                {
                    variableMan.parcellesSurbrillance[id] = true;
                    variableMan.parcellesSurbrillance[id + 4] = true;
                }
                else
                {
                    variableMan.parcellesSurbrillance[id] = true;
                    variableMan.parcellesSurbrillance[id - 4] = true;
                }
            }

        }

    }
    */




}
