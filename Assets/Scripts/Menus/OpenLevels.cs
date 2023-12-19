using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLevels : MonoBehaviour
{
    public varMan varMan;

    public void openLv()
    {

        bool ctrl = varMan.getLevelsActive();
        if (!ctrl)
        {
            ctrl = true;
            varMan.setLevelsActive(ctrl);
            varMan.setCtrlActive(false);
            varMan.setOptionsActive(false);



        }
    }
}
