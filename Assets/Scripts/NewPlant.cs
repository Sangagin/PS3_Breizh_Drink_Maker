using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlant : MonoBehaviour, ITouchable
{

    public int id;
    public VariableManagerParcelles variableMan;
    public BoutonManager boutonManager;
    public UiManager uiManager;
    public bool encours = false;
    public int etat = 0;
    public bool utilisable = true;
    public bool totalUtilisable = true;

    public List<GameObject> parcellesAsso = new List<GameObject>();
    public List<GameObject> parcellesVoulues = new List<GameObject>();


    public bool cote = false;
    public bool bas = false;
    public bool centre = false;

    public int typePlante;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        /*
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
                    StartCoroutine(ExecuteAfterTime(5));

                }



            }
        }
        */

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


        if (encours)
        {
            encours = false;
            StartCoroutine(ExecuteAfterTime(2));
        }



        if (etat == 3 && !variableMan.action)
        {



            if (parcellesAsso.Count > 0)
            {
                for (int i = 0; i <= parcellesAsso.Count; i++)
                {
                    var recupAutresParcelles = parcellesVoulues[i].GetComponent<NewPlant>();
                    if (recupAutresParcelles.etat == 3)
                    {
                        recupAutresParcelles.setEtat(0);
                    }

                }
            }


        }

        if (etat == 3 && variableMan.action)
        {

            //etat = 5;





        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (etat == 0)
        {

            if (parcellesVoulues.Count == 0)
            {

                if (variableMan.typePlante == 1)
                {
                    if (!cote && !bas)
                    {
                        parcellesVoulues.Add(variableMan.parcelles[id]);
                        parcellesVoulues.Add(variableMan.parcelles[id + 1]);
                        parcellesVoulues.Add(variableMan.parcelles[id + 4]);
                        parcellesVoulues.Add(variableMan.parcelles[id + 5]);
                    }
                    else if (cote && !bas)
                    {
                        parcellesVoulues.Add(variableMan.parcelles[id]);
                        parcellesVoulues.Add(variableMan.parcelles[id - 1]);
                        parcellesVoulues.Add(variableMan.parcelles[id + 3]);
                        parcellesVoulues.Add(variableMan.parcelles[id + 4]);
                    }
                    else if (cote && bas)
                    {
                        parcellesVoulues.Add(variableMan.parcelles[id]);
                        parcellesVoulues.Add(variableMan.parcelles[id - 1]);
                        parcellesVoulues.Add(variableMan.parcelles[id - 4]);
                        parcellesVoulues.Add(variableMan.parcelles[id - 5]);
                    }
                    else if (!cote && bas)
                    {
                        parcellesVoulues.Add(variableMan.parcelles[id]);
                        parcellesVoulues.Add(variableMan.parcelles[id + 1]);
                        parcellesVoulues.Add(variableMan.parcelles[id - 3]);
                        parcellesVoulues.Add(variableMan.parcelles[id - 4]);
                    }
                }
                else if (variableMan.typePlante == 2)
                {

                    if (!cote)
                    {
                        parcellesVoulues.Add(variableMan.parcelles[id]);
                        parcellesVoulues.Add(variableMan.parcelles[id + 1]);
                    }
                    else
                    {
                        parcellesVoulues.Add(variableMan.parcelles[id]);
                        parcellesVoulues.Add(variableMan.parcelles[id - 1]);
                    }

                }
                else if (variableMan.typePlante == 3)
                {

                    parcellesVoulues.Add(variableMan.parcelles[id]);

                }
            }

            for (int i = 0; i < parcellesVoulues.Count; i++)
            {
                for (int j = 0; i < parcellesAsso.Count; i++)
                {
                    if (parcellesAsso[j] == parcellesVoulues[j])
                    {
                        utilisable = false;
                    }
                }
            }

            if (utilisable)
            {
                if (parcellesAsso.Count == 0)
                {

                    if (variableMan.typePlante == 1)
                    {
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

                        parcellesAsso.Add(variableMan.parcelles[id]);

                    }
                }



                for (int i = 0; i < parcellesAsso.Count; i++)
                {
                    var recupAutresParcelles = parcellesAsso[i].GetComponent<NewPlant>();
                    recupAutresParcelles.parcellesAsso = parcellesAsso;
                    recupAutresParcelles.setEtat(3);
                }
            }

        }
    }











    private void OnTriggerExit(Collider other)
    {
        parcellesVoulues.Clear();




    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        etat = 2;


    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
        if (etat == 2)
        {
            etat = 0;
        }
        return;
    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
        return;
    }

    public void OnTouchedUp()
    {
        return;
    }



    public void setEtat(int etat)
    {
        this.etat = etat;
    }
}
