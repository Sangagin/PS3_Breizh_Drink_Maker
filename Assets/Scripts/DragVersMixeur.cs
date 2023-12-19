using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragVersMixeur : MonoBehaviour, ITouchable
{
    // 0 = pomme
    // 1 = miel
    public CreerBoisson1 creerBoisson;
    public UiManager uiManager;
    public VariableManagerParcelles variableManager;
    public int type = 0;
    private Vector3 store;
    public int pommeActuelles;
    private int mielActuel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pommeActuelles = uiManager.getPomme();
        mielActuel = uiManager.getMiel();
    }

    public void OnTriggerEnter(Collider other)
    {
        int recette = variableManager.getRecetteActive();
        if (recette != 0)
        {
            if (recette == 1)
            {
                if (type == 0)
                {

                    //enleve une pomme du total demmandé
                    int pomme = creerBoisson.getPommeDonne();
                    int pommeBesoin = creerBoisson.getPommeBesoin();
                    if (pommeActuelles > 0)
                    {
                        if (pommeBesoin - pomme > 0)
                        {
                            pomme += 1;
                            pommeActuelles -= 1;
                            uiManager.setPomme(pommeActuelles);
                            creerBoisson.setPommeDonne(pomme);
                        }
                    }





                }
                else if (type == 1)
                {
                    //enleve un miel du total demmandé
                    int miel = creerBoisson.getMielDonne();
                    int mielBesoin = creerBoisson.getMielBesoin();
                    if (mielActuel > 0)
                    {

                        if (mielBesoin - miel > 0)
                        {
                            miel += 1;
                            mielActuel -= 1;
                            uiManager.setMiel(mielActuel);
                            creerBoisson.setMielDonne(miel);
                        }
                    }
                }

            }
            if (recette == 2) {
                if (type == 0)
                {

                    //enleve une pomme du total demmandé
                    int pomme2 = creerBoisson.getPommeDonne2();
                    int pommeBesoin2 = creerBoisson.getPommeBesoin2();
                    if (pommeActuelles > 0)
                    {
                        if (pommeBesoin2 - pomme2 > 0)
                        {
                            pomme2 += 1;
                            pommeActuelles -= 1;
                            uiManager.setPomme(pommeActuelles);
                            creerBoisson.setPommeDonne2(pomme2);
                        }
                    }





                }
                else if (type == 1)
                {
                    //enleve un miel du total demmandé
                    int miel2 = creerBoisson.getMielDonne2();
                    int mielBesoin2 = creerBoisson.getMielBesoin2();
                    if (mielActuel > 0)
                    {

                        if (mielBesoin2 - miel2 > 0)
                        {
                            miel2 += 1;
                            mielActuel -= 1;
                            uiManager.setMiel(mielActuel);
                            creerBoisson.setMielDonne2(miel2);
                        }
                    }
                }
            }

            if (recette == 3) {
                if (type == 0)
                {

                    //enleve une pomme du total demmandé
                    int pomme3 = creerBoisson.getPommeDonne3();
                    int pommeBesoin3 = creerBoisson.getPommeBesoin3();
                    if (pommeActuelles > 0)
                    {
                        if (pommeBesoin3 - pomme3 > 0)
                        {
                            pomme3 += 1;
                            pommeActuelles -= 1;
                            uiManager.setPomme(pommeActuelles);
                            creerBoisson.setPommeDonne3(pomme3);
                        }
                    }





                }
                else if (type == 1)
                {
                    //enleve un miel du total demmandé
                    int miel3 = creerBoisson.getMielDonne3();
                    int mielBesoin3 = creerBoisson.getMielBesoin3();
                    if (mielActuel > 0)
                    {

                        if (mielBesoin3 - miel3 > 0)
                        {
                            miel3 += 1;
                            mielActuel -= 1;
                            uiManager.setMiel(mielActuel);
                            creerBoisson.setMielDonne3(miel3);
                        }
                    }
                }
            }

        }
    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
        store = transform.position;

    }
    public void OnTouchedStay(Vector3 touchPosition)
    {
        transform.position = touchPosition;
    }
    public void OnTouchedUp()
    {
        transform.position = store;
    }
}
