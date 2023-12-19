using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PasserComande : MonoBehaviour,ITouchable
{


    public float bouteilleType1Voulus;
    public float bouteilleType2Voulus;
    public float bouteilleType3Voulus;

    public float speed = 1f;

    private GameObject commandeClientBulle;
    public GameObject bulle;

    public Client1Libre place1;
    public Client2Libre place2;
    public Client3Libre place3;
    public UiManager ui;
   // public GameObject place1Obj, place2Obj, place3Obj;

    private Transform target;


    // Start is called before the first frame update
    void Start()
    {

        ui = FindObjectOfType<UiManager>();

        place1 = FindObjectOfType<Client1Libre>();
        place2 = FindObjectOfType<Client2Libre>();
        place3 = FindObjectOfType<Client3Libre>();





        //gameObject.SetActive(false);
        bouteilleType1Voulus = Random.Range(ui.commande1, ui.commande2);
        bouteilleType2Voulus = Random.Range(ui.commande3, ui.commande4);
        bouteilleType3Voulus = Random.Range(ui.commande5, ui.commande6);
        if (place1.libre == 0)
        {
            target = place1.transform;
        }
        else if (place2.libre == 0)
        {
            target = place2.transform;

        }
        else if (place3.libre == 0)
        {
            target = place3.transform;

        }

    }

    // Update is called once per frame
    void Update()
    {

        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);


    }

    public void OnTouchedDown(Vector3 touchPosition)
    {

        bulle.SetActive(true);

        return;    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
        return;    }

    public void OnTouchedUp()
    {
        bulle.SetActive(false);

        return;    }


    /*
    private void OnMouseDown()
    {
        //fait apparaitre la bulle d'info sur la commande
        commandeClientBulle = Instantiate(bulle, this.transform.position+new Vector3(0,2f,0), this.transform.rotation);


    }
    private void OnMouseUp()
    {
        Destroy(commandeClientBulle);
    }

    */
}
