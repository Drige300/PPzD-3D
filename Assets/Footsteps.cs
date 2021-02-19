using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string InputSound;
    bool PlayerIsMoving;
    public float FootstepSpeed;

    void Start()
    {
        InvokeRepeating("CallFootsteps", 0, FootstepSpeed);
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") >= 0.01f || Input.GetAxis("Horizontal") >= 0.01f || Input.GetAxis("Vertical") <= 0.01f || Input.GetAxis("Horizontal") <= 0.01f)
        {
            PlayerIsMoving = true;
        }
        else if (Input.GetAxis("Vertical") == 0 || Input.GetAxis("Horizontal") == 0)
        {
            PlayerIsMoving = false;
        }
    }

    void CallFootsteps()
    {
        if (PlayerIsMoving == true)
        {
            FMODUnity.RuntimeManager.PlayOneShot(InputSound);
        }
    }

    void OnDisable()
    {
        PlayerIsMoving = false;
    }
}
