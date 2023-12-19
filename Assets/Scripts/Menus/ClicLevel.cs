using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicLevel : MonoBehaviour
{

    public int id;
    public varMan varManMenu;

    public void selecALevel()
    {
        Debug.Log(id);
        varManMenu.setLevelSelected(id);
    }
}
