using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonnerCommande : MonoBehaviour,ITouchable
{


    public Vector3 store;

    public int nbBouteille1;
    public int nbBouteille2;

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

        Debug.Log("ici");
        if (other.gameObject.tag == "Client")
        {
            Debug.Log("colli");
            var demmandeClient = other.gameObject.GetComponent<PasserComande>();
            if (nbBouteille1 >= demmandeClient.bouteilleType1Voulus && nbBouteille2 >= demmandeClient.bouteilleType2Voulus)
            {
                Debug.Log("Vendu");
            
                nbBouteille1 = 0;
                nbBouteille2 = 0;
                transform.position = store;
                Destroy(other.gameObject);
            
            }


            
            

        }
    }

}
