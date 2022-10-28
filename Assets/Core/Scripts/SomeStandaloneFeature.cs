using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeStandaloneFeature : MonoBehaviour
{
    public CoreManager coreManager;

    public string textToShow;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TextToShow: " + textToShow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
