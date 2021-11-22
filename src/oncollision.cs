using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncollision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        
        

    void OnTriggerEnter(Collider other)
    {
        GetComponent<keywordRecognitionMovement>().voiceRecognizer.Stop();
        GetComponent<keywordRecognitionMovement>().voiceRecognizer.Dispose();
        GetComponent<keywordRecognitionMovement>().enabled = false;
    }
}
