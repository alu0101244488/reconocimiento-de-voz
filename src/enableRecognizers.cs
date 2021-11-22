using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableRecognizers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableMovement() {
        GetComponent<keywordRecognitionMovement>().enabled = true;
    }

    public void disableMovement() {
        GetComponent<keywordRecognitionMovement>().voiceRecognizer.Stop();
        GetComponent<keywordRecognitionMovement>().voiceRecognizer.Dispose();
        GetComponent<keywordRecognitionMovement>().enabled = false;
        Debug.Log("stop keywordRecognition");
    }
    
    public void enableDictation() {
        GetComponent<DictationRecognition>().enabled = true;
    }

    public void disableDictation() {
        GetComponent<DictationRecognition>().m_DictationRecognizer.Stop();
        GetComponent<DictationRecognition>().m_DictationRecognizer.Dispose();
        GetComponent<DictationRecognition>().enabled = false;
        Debug.Log("stop DictationRecognition");
    }
}
