using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<GameObject> listImage;

    [Header("About Assets")]
    public GameObject aboutBG;
    public GameObject aboutParent;
    public List<GameObject> contentsList;

    [Header("EMB Assets")]
    public GameObject embParent;


    public void OffAllImage()
    {
        foreach(GameObject go in listImage)
        {
            go.SetActive(false);
        }
    }

    public void ActivateContent(int index)
    {
        aboutBG.SetActive(false);
        DeActivateContents();
        contentsList[index].SetActive(true);
    }

    public void DeActivateContents()
    {
        foreach(GameObject go in contentsList)
        {
            go.SetActive(false);
        }
    }


}
