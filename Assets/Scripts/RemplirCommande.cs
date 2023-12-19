using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemplirCommande : MonoBehaviour, ITouchable
{

    public Vector3 store;
    public int capacite = 0;
    public int typeBouteille;
    public UiManager uiManager;
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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Commande")
        {
            var commandeARemplir = other.gameObject.GetComponent<DonnerCommande>();
            if (typeBouteille == 1)
            {
                capacite = uiManager.getBouteille1();
                if (capacite > 0)
                {
                    commandeARemplir.nbBouteille1 += 1;
                    capacite -= 1;
                    uiManager.setBouteille1(capacite);
                }
            }

            else if (typeBouteille == 2)
            {
                capacite = uiManager.getBouteille2();
                if (capacite > 0)
                {
                    commandeARemplir.nbBouteille2 += 1;
                    capacite -= 1;
                    uiManager.setBouteille2(capacite);
                }
            }
        }
    }
}
