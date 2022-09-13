using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoWindow : MonoBehaviour
{
    public TMPro.TextMeshProUGUI title, info;
    public Image image;

    public Sprite deafulSprite;

    public void SetInfo(InfoScriptable infoScriptable)
    {
        if(infoScriptable.title != null)
        {
            title.text = infoScriptable.title;
        }
        else
        {
            title.text = "";
        }

        if(infoScriptable.info != null)
        {
            info.text = infoScriptable.info;
        }
        else
        {
            info.text = "";
        }

        if(infoScriptable.image!= null)
        {
            image.sprite = infoScriptable.image;
        }
        else
        {
            image.sprite = deafulSprite;
        }

    }
   
}
