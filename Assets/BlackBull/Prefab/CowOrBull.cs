using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowOrBull : MonoBehaviour
{
    GameObject theCow;
    GameObject theBull;
    // Start is called before the first frame update
    void Start()
    {
        theCow = GameObject.Find("Cow");
        Debug.Log(theCow);
        theBull = GameObject.Find("Bull");
        Debug.Log(theCow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchAnimals(){
        Debug.Log("Entered");
        
        if (theCow.activeSelf && !(theBull.activeSelf))
        {
            theCow.SetActive(false);
            theBull.SetActive(true);
        } else if(theBull.activeSelf && !(theCow.activeSelf))
        {
            theCow.SetActive(true);
            theBull.SetActive(false);
        } else
        {
            Debug.Log("Error in switching animals!");
            theCow.SetActive(true);
            theBull.SetActive(false);            
        }

    }
}
