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
    public List<GameObject> sectionList;
    public int sectionIndex = 0;

    [Header("EMB Assets")]
    public GameObject embParent;
    public List<GameObject> embServicesList;
    public int embServicesIndex = 0;

    [Header("Sponsors")]
    public List<GameObject> sponsorsList;
    private int sponsorsIndex = 0;

    [Header("Awardees")]
    public List<GameObject> awardeesList;
    private int awardeesIndex = 0;

    #region MAIN CONTENTS
    public void NextSection()
    {
        sectionList[sectionIndex].SetActive(false);
        if (sectionIndex >= sectionList.Count - 1)
        {

            sectionIndex = 0;
        }
        else
        {
            sectionIndex++;
        }
        sectionList[sectionIndex].SetActive(true);
    }

    public void PrevSection()
    {
        sectionList[sectionIndex].SetActive(false);
        if (sectionIndex <= 0)
        {
            sectionIndex = sectionList.Count - 1;
        }
        else
        {
            sectionIndex--;
        }
        sectionList[sectionIndex].SetActive(true);
    }
    #endregion

    #region SPONSORS

    public void NextButton()
    {
        sponsorsList[sponsorsIndex].SetActive(false);
        if (sponsorsIndex >= sponsorsList.Count - 1)
        {
            
            sponsorsIndex = 0;
        }
        else
        {
            sponsorsIndex++;
        }
        sponsorsList[sponsorsIndex].SetActive(true);
    }

    public void PrevButton()
    {
        sponsorsList[sponsorsIndex].SetActive(false);
        if (sponsorsIndex <= 0)
        {
            sponsorsIndex = sponsorsList.Count - 1;
        }
        else
        {
            sponsorsIndex--;
        }
        sponsorsList[sponsorsIndex].SetActive(true);
    }

    #endregion


    #region EMB_SERVICES

    public void NextServices()
    {
        embServicesList[embServicesIndex].SetActive(false);
        if (embServicesIndex >= embServicesList.Count - 1)
        {

            embServicesIndex = 0;
        }
        else
        {
            embServicesIndex++;
        }
        embServicesList[embServicesIndex].SetActive(true);
    }

    public void PrevServices()
    {
        embServicesList[embServicesIndex].SetActive(false);
        if (embServicesIndex <= 0)
        {
            embServicesIndex = embServicesList.Count - 1;
        }
        else
        {
            embServicesIndex--;
        }
        embServicesList[embServicesIndex].SetActive(true);
    }

    #endregion


    #region Awardees


    public void NextAwardee()
    {
        awardeesList[awardeesIndex].SetActive(false);
        if (awardeesIndex >= awardeesList.Count - 1)
        {

            awardeesIndex = 0;
        }
        else
        {
            awardeesIndex++;
        }
        awardeesList[awardeesIndex].SetActive(true);
    }

    public void PrevAwardee()
    {
        awardeesList[awardeesIndex].SetActive(false);
        if (awardeesIndex <= 0)
        {
            awardeesIndex = awardeesList.Count - 1;
        }
        else
        {
            awardeesIndex--;
        }
        awardeesList[awardeesIndex].SetActive(true);
    }

    #endregion
}
