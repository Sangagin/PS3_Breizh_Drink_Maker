using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicVersDroite : MonoBehaviour
{

    public Camera cam;
    public BoutonManager boutonMan;

    public void clickVersDroite()
    {
        cam.transform.position = cam.transform.position + new Vector3(22f,0,0);
        boutonMan.idScene += 1;

    }


}
