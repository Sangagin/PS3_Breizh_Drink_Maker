using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class VariableManagerParcelles : MonoBehaviour
{
    // Start is called before the first frame update





    //selection de la grille des parcelles


    public int typePlante;
    public GameObject[] parcelles = new GameObject[] { };

    public int miel;
    private bool clientCree = false;

    public bool action = false;
    public int reccetteActive;
    public List<GameObject> clients = new List<GameObject>();
    public GameObject clientType;
    public GameObject posDepartClient;
    public int time;



    void Start()
    {
        for(int i = 0; i < parcelles.Length; i++)
        {
            var listeParcelles = parcelles[i].GetComponent<PlanterUnTruc>();
            listeParcelles.id = i;
        }



    }

    // Update is called once per frame
    void Update()
    {

        if(clients.Count<3 && !clientCree)
        {
            Debug.Log("crea");
            clientCree = true;

            GameObject nouvClient = Instantiate(clientType, posDepartClient.transform.position, posDepartClient.transform.rotation);
            clients.Add(nouvClient);

            StartCoroutine(waitNewClient(time));
        }




    }

    public int getRecetteActive() { return reccetteActive; }
    public void setRecetteActive(int newRecetteActive) {  reccetteActive = newRecetteActive; }

    public IEnumerator waitNewClient(int time)
    {
        yield return new WaitForSeconds(time);
        clientCree = false;



    }

}
