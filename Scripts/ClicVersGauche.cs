using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicVersGauche : MonoBehaviour
{


    public Camera cam;
    public BoutonManager boutonMan;

    // Update is called once per frame
    public void ClikVersGauche()
    {
        cam.transform.position = cam.transform.position - new Vector3(22f, 0, 0);
        boutonMan.idScene -= 1;
    }
}
