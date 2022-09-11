using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetInfoWindow()
    {
        var window= Resources.Load("InfoWindow") as GameObject;

        //var window = Instantiate(windowsAll[0]);

        window.transform.position = transform.position;

    }
}
