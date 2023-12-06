using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasserComande : MonoBehaviour
{


    public float bouteilleType1Voulus;
    public float bouteilleType2Voulus;
    public float bouteilleType3Voulus;
    private GameObject commandeClientBulle;
    public GameObject bulle;


    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        bouteilleType1Voulus = Random.Range(0, 4);
        bouteilleType2Voulus = Random.Range(0, 4);
        bouteilleType3Voulus = Random.Range(0, 4);

    }

    // Update is called once per frame
    void Update()
    {
        



    }



    private void OnMouseDown()
    {
        //fait apparaitre la bulle d'info sur la commande
        commandeClientBulle = Instantiate(bulle, this.transform.position+new Vector3(0,2f,0), this.transform.rotation);


    }
    private void OnMouseUp()
    {
        Destroy(commandeClientBulle);
    }
}
