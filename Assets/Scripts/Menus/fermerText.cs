using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fermerText : MonoBehaviour
{
    public GameObject fenetre;
    public void fermer()
    {
        fenetre.SetActive(false);
    }

}
