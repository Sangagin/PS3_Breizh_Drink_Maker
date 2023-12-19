using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoLevel : MonoBehaviour
{
    public static infoLevel Instance;
    public bool level2Unlock = false;
    public bool level3Unlock = false;
    public bool level4Unlock = false;
    public bool level5Unlock = false;

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
