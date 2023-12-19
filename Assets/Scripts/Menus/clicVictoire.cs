using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clicVictoire : MonoBehaviour
{
    // Start is called before the first frame update
    public int actuelLV;

public void back()
    {
        var info = FindAnyObjectByType<infoLevel>();
        if(actuelLV==1)
        {
            info.level2Unlock = true;

        }
        else if (actuelLV==2)
        {
            info.level3Unlock = true;
        }
        else if ( actuelLV==3)
        {
            info.level4Unlock = true;
        }
        else if (actuelLV == 4)
        {
            info.level5Unlock = true;
        }

        SceneManager.LoadScene("MenuPrincipal");

    }

}
