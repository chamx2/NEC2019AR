using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float delay;
    public GameObject instructionGameObject;

    public List<GameObject> listImage;

    [Header("About Assets")]
    public GameObject aboutBG;
    public GameObject aboutParent;
    public List<GameObject> sectionList;
    public int sectionIndex = 0;
    public List<GameObject> aboutList;
    private int aboutIndex = 0;

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

    [Header("Program")]
    public List<GameObject> programList;
    private int programIndex = 0;


    

    void Start()
    {
        StartCoroutine(DestroyInstructions(delay));
    }

    IEnumerator DestroyInstructions(float delay)
    {
      
        yield return new WaitForSeconds(delay);
        Destroy(instructionGameObject);
       
    }

    #region About


    public void NextAbout()
    {
        aboutList[aboutIndex].SetActive(false);
        if (aboutIndex >= aboutList.Count - 1)
        {

            aboutIndex = 0;
        }
        else
        {
            aboutIndex++;
        }
        aboutList[aboutIndex].SetActive(true);
    }

    public void PrevAbout()
    {
        aboutList[aboutIndex].SetActive(false);
        if (aboutIndex <= 0)
        {
            aboutIndex = aboutList.Count - 1;
        }
        else
        {
            aboutIndex--;
        }
        awardeesList[aboutIndex].SetActive(true);
    }

    #endregion

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

    #region Program


    public void NextProgram()
    {
        programList[programIndex].SetActive(false);
        if (programIndex >= programList.Count - 1)
        {

            programIndex = 0;
        }
        else
        {
            programIndex++;
        }
        programList[programIndex].SetActive(true);
    }

    public void PrevProgram()
    {
        programList[programIndex].SetActive(false);
        if (programIndex <= 0)
        {
            programIndex = programList.Count - 1;
        }
        else
        {
            programIndex--;
        }
        programList[programIndex].SetActive(true);
    }

    #endregion
}
