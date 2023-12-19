using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseLevels : MonoBehaviour
{
    public varMan varMan;

    public void closeLv()
    {
        varMan.setLevelsActive(false);

    }
}
