using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportManager : MonoBehaviour
{
    public XRRayInteractor rayInteractor;
    public InputActionProperty teleportActivate;
    public InputActionProperty teleportCancel;
    public InputActionProperty useStick;
    public InputActionProperty useGrip;

    public TeleportationProvider teleportationProvider;

    public InteractionLayerMask TeleportationnLayers;

    bool isTeleportActivate;

    InteractionLayerMask initialInteractionnLayers;

    private List<IXRInteractable> interactables = new List<IXRInteractable>();


    // Start is called before the first frame update
    void Start()
    {
        teleportActivate.action.Enable();
        teleportCancel.action.Enable();
        useStick.action.Enable();
        useGrip.action.Enable();

        teleportActivate.action.performed += OnteleportActivate;
        teleportActivate.action.canceled += OnTeleportCancel;
        teleportCancel.action.performed += OnTeleportCancel;

        initialInteractionnLayers = rayInteractor.interactionLayers;
    }
  
    void Update()
    {
        /*if(useStick.action.phase == InputActionPhase.Performed)
        print("Activated");

        if(useStick.action.phase== InputActionPhase.Canceled)
        print("canceled");

        if(!isTeleportActivate)
        return;

        if(!useGrip.action.triggered)
        return;

        rayInteractor.GetValidTargets(interactables);
        if(interactables.Count == 0)
        {
            TurnoffTeleport();
            return;
        }

        rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit);
        TeleportRequest request = new TeleportRequest();

        if(interactables[0].interactionLayers == 2)
        {
            request.destinationPosition = hit.point;

        }

        else if(interactables[0].interactionLayers == 4)
         {
            request.destinationPosition = hit.transform.GetChild(0).transform.position;

        }

        teleportationProvider.QueueTeleportRequest(request);
        TurnoffTeleport();*/
        


    }

    private void OnTeleportCancel(InputAction.CallbackContext obj)
    {      

        if(!isTeleportActivate)
        return;

        if(useGrip.action.triggered)
        return;

        rayInteractor.GetValidTargets(interactables);
        if(interactables.Count == 0)
        {
            TurnoffTeleport();
            return;
        }

        rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit);
        TeleportRequest request = new TeleportRequest();

        if(interactables[0].interactionLayers == 2)
        {
            request.destinationPosition = hit.point;

        }

        else if(interactables[0].interactionLayers == 4)
         {
            request.destinationPosition = hit.transform.GetChild(0).transform.position;

        }

        teleportationProvider.QueueTeleportRequest(request);
        TurnoffTeleport();

            //TurnoffTeleport();  
            print("Cancel");
        
    }

    private void OnteleportActivate(InputAction.CallbackContext obj)
    {
        print("Activated");
        if(useStick.action.phase != InputActionPhase.Performed)
        {
            isTeleportActivate = true;
            rayInteractor.lineType = XRRayInteractor.LineType.ProjectileCurve;
            rayInteractor.interactionLayers = TeleportationnLayers;
        }
    }

    void TurnoffTeleport()
    {
            isTeleportActivate = false;
            rayInteractor.lineType = XRRayInteractor.LineType.StraightLine;
            rayInteractor.interactionLayers = initialInteractionnLayers;
    }

   
}
