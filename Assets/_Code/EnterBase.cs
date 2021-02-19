using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using FMODUnity;

public class EnterBase : MonoBehaviour
{
    int isPlayerInside = 0;

    public void transitionToInside()
    {
        var Inside = RuntimeManager.GetVCA(path: "vca:/Inside");
        var Outside = RuntimeManager.GetVCA(path: "vca:/Outside");
        Inside.setVolume(1);
        Outside.setVolume(0);
    }

    public void transitionToOutside()
    {
        var Inside = RuntimeManager.GetVCA(path: "vca:/Inside");
        var Outside = RuntimeManager.GetVCA(path: "vca:/Outside");
        Inside.setVolume(0);
        Outside.setVolume(1);
    }



    void OnTriggerEnter(Collider other)
    {
        if (isPlayerInside == 1)
            isPlayerInside = 0;
        else
            isPlayerInside = 1;

        if (isPlayerInside == 1)
            transitionToInside();
        else
            transitionToOutside();
    }
}
