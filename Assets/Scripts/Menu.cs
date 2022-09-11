using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class Menu : MonoBehaviour
{

    public InputActionProperty MenuAction;
    public GameObject menuObject;

     [SerializeField]
    Color colorEnabled, colorDisabled;

    public UniversalRenderPipelineAsset scriptableAssetURP;   

    [SerializeField]
    Camera menucamera;
   
    
    void Start()
    {
        MenuAction.action.Enable();
        MenuAction.action.performed += OnMenuActivated;
        MenuAction.action.canceled += OnMenuCancel;
    }
   

    private void OnMenuActivated(InputAction.CallbackContext obj)
    {
       menuObject.SetActive(true);      
       menuObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward *8;
       menuObject.transform.rotation = Camera.main.transform.rotation;
       Time.timeScale = 0;
       menucamera.enabled = true;
       AudioListener.volume = 0;
    }

     private void OnMenuCancel(InputAction.CallbackContext obj)
    {
        menuObject.SetActive(false);
        Time.timeScale = 1;
        menucamera.enabled = false;
        AudioListener.volume = 1;
    }

    

    public void SetAntialiasing(int value)
    {
        scriptableAssetURP.msaaSampleCount = value;
    }

    public void SetAnisotropic(int value)
    {

        switch (value)
        {
            
            default:
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
            break;

            case 0:
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
            break;

            case 1:
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Enable;
            break;

            case 2:
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.ForceEnable;
            break;
        }
        
    }
}
