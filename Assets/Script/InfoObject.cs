using UnityEngine;

public class InfoObject : MonoBehaviour
{
    GameObject window;

    [SerializeField]
    GameObject outline;

    public InfoScriptable infoScriptable;

    TabletController tabletController;

    InfoWindow infoWindow;

    public void SetInfoWindow()
    {

        //var windowObject = Resources.Load("InfoWindow") as GameObject;

        //window = Instantiate(windowObject);

        tabletController = FindObjectOfType<TabletController>();

        infoWindow = FindObjectOfType<InfoWindow>();

        infoWindow.SetInfo(infoScriptable);
        

        //window.transform.position = transform.position;

        //window.transform.position = Camera.main.transform.position + Camera.main.transform.forward *1.5f;
        //window.transform.rotation = Camera.main.transform.rotation;

        tabletController.transform.position = Camera.main.transform.position + Camera.main.transform.forward *0.35f;
        tabletController.transform.rotation = Camera.main.transform.rotation;

        tabletController.EnableTablet();

    }

    public void DeleteInfoWindow()
    {
       //Destroy(window);
       tabletController.DisableTablet();

    }

    public void ActivatedOutline()
    {
        outline.SetActive(true);
    }

    public void UnActivatedOutline()
    {
        outline.SetActive(false);
    }
}
