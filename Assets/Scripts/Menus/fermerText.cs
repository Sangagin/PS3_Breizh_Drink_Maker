using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fermerText : MonoBehaviour
{
    public GameObject fenetre;
    public GameObject fenetre2;
    public void fermer()
    {
        fenetre.SetActive(false);
        if( fenetre2 != null)
        {
            fenetre2.SetActive(true);

        }
    }

}
