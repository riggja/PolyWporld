using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberScript : MonoBehaviour
{

    public Animator saberAnimator;

    public void TurnOn()
    {
        saberAnimator.SetTrigger("TurnOn");
        saberAnimator.ResetTrigger("TurnOff");
    }

    public void TurnOff()
    {
        saberAnimator.SetTrigger("TurnOff");
        saberAnimator.ResetTrigger("TurnOn");
    }

   
}
