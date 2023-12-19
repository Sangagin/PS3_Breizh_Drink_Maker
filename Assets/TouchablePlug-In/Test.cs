using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour, ITouchable
{
    public VariableManagerParcelles variableManagerParcelles;
    public Vector3 store;
    public int typePlanteDrag;

    public void OnTouchedDown(Vector3 touchPosition)
    {
        store = transform.position;
        variableManagerParcelles.action = false;

        for (int i = 0; i < variableManagerParcelles.parcelles.Length; i++)
        {
            var parcelles = variableManagerParcelles.parcelles[i].GetComponent<PlanterUnTruc>();
            if (parcelles.etat ==5)
            {
                parcelles.etat = 0;
//                parcelles.utilisable = true;
            }
        }









    }


    public void OnTouchedStay(Vector3 touchPosition)
    {
       // Vector3 newpos = new Vector3 (touchPosition.x, touchPosition.y, touchPosition.z);
        transform.position = touchPosition;
        variableManagerParcelles.typePlante = typePlanteDrag;
    }


    public void OnTouchedUp()
    {


        variableManagerParcelles.action = true;
        transform.position = store;
        variableManagerParcelles.typePlante = 0;


      


    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
