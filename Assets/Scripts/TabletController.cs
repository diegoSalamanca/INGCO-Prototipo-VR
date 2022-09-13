using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletController : MonoBehaviour
{

    [SerializeField]
    GameObject tablet;

    [SerializeField]
    Animator tabletAnimator;
    
    public void EnableTablet()
    {
        //tablet.SetActive(true);
        tabletAnimator.SetTrigger("in");
        GetComponent<AudioSource>().Play();
    }

    public void DisableTablet()
    {
        //tablet.SetActive(false);
        tabletAnimator.SetTrigger("out");
    }
}
