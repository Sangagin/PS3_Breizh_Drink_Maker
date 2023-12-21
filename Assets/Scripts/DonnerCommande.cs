using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonnerCommande : MonoBehaviour,ITouchable
{

    public UiManager uiManager;
    public VariableManagerParcelles variableManagerParcelles;
    public Vector3 store;

    public int nbBouteille1;
    public int nbBouteille2;
    public int nbBouteille3;

    public GameObject posArr1;
    public GameObject posArr2;
    public GameObject posArr3;

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
        transform.position=store;
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

        if (other.gameObject.tag == "Client")
        {
            var demmandeClient = other.gameObject.GetComponent<PasserComande>();
            if (nbBouteille1 >= demmandeClient.bouteilleType1Voulus && nbBouteille2 >= demmandeClient.bouteilleType2Voulus && nbBouteille3 >= demmandeClient.bouteilleType3Voulus)
            {
                uiManager.addArgent(nbBouteille1*50+nbBouteille2+15+nbBouteille3*70);

                nbBouteille1 = 0;
                nbBouteille2 = 0;
                nbBouteille3 = 0;
                transform.position = store;
                variableManagerParcelles.clients.Remove(other.gameObject);
                Destroy(other.gameObject);
            
            }



            
            

        }
    }

}
