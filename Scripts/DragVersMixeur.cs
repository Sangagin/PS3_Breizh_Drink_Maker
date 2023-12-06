using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragVersMixeur : MonoBehaviour, ITouchable
{
    // 0 = pomme
    // 1 = miel
    public CreerBoisson creerBoisson;
    public UiManager uiManager;
    public int type = 0;
    private Vector3 store;
    private int pommeActuelles;
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
        if (type == 0)
        {

            //enleve une pomme du total demmandé
            int pomme = creerBoisson.getPommeDonne();
            int pommeBesoin = creerBoisson.getPommeBesoin();
            if(pommeActuelles>0) {
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
            if (mielActuel>0)
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
