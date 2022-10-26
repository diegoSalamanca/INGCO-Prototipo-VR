using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RayObjectInteractor : MonoBehaviour
{
    
   
    XRInteractorLineVisual xRInteractorLineVisual;

    [SerializeField]
    Material reticleMatMarker, reticleMatInfo;

    private void Start() {
        xRInteractorLineVisual = GetComponent<XRInteractorLineVisual>();
        
    }

    public void HoverInfo(HoverEnterEventArgs args)
    {
        if(args.interactableObject.transform.GetComponent<InfoObject>())
        {
            xRInteractorLineVisual.reticle.GetComponentInChildren<MeshRenderer>().material = reticleMatInfo;
            


            var info = args.interactableObject.transform.GetComponent<InfoObject>();
            //info.ActivatedOutline();            
        }
        else
        {
            xRInteractorLineVisual.reticle.GetComponentInChildren<MeshRenderer>().material = reticleMatMarker;
        }
        
    }

    public void UnHoverInfo(HoverExitEventArgs args)
    {
        if(args.interactableObject.transform.GetComponent<InfoObject>())
        {
            xRInteractorLineVisual.reticle.GetComponentInChildren<MeshRenderer>().material = reticleMatMarker;

            var info = args.interactableObject.transform.GetComponent<InfoObject>();
            //info.UnActivatedOutline();
            
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
