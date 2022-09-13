using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RayObjectInteractor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoverInfo(HoverEnterEventArgs args)
    {
        if(args.interactableObject.transform.GetComponent<InfoObject>())
        {
            var info = args.interactableObject.transform.GetComponent<InfoObject>();
            info.ActivatedOutline();
        }
        
    }

    public void UnHoverInfo(HoverExitEventArgs args)
    {
        if(args.interactableObject.transform.GetComponent<InfoObject>())
        {
            var info = args.interactableObject.transform.GetComponent<InfoObject>();
            info.UnActivatedOutline();
        }
        
    }

    public void Select(SelectEnterEventArgs args)
    {
        print("Select");
         if(args.interactableObject.transform.GetComponent<InfoObject>())
        {
            var info = args.interactableObject.transform.GetComponent<InfoObject>();
            info.SetInfoWindow();
        }
    }

    public void UnSelect(SelectExitEventArgs args)
    {
        print("UnSelect");
         if(args.interactableObject.transform.GetComponent<InfoObject>())
        {
            var info = args.interactableObject.transform.GetComponent<InfoObject>();
            info.DeleteInfoWindow();
        }
    }
}
