using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using UnityEngine.Windows.Speech;

public class keywordRecognitionMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private string[] keywords;

    [HideInInspector] public KeywordRecognizer voiceRecognizer;
    public float playerSpeed = 1;
    public float speedIncrement = 0;
    public float offset = 1;

    void Start()
    {
        voiceRecognizer = new KeywordRecognizer(keywords);
        voiceRecognizer.OnPhraseRecognized += recogniceSpeech;
        voiceRecognizer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed += speedIncrement;
        transform.position += Vector3.forward * Time.deltaTime * playerSpeed;
    }

    private void recogniceSpeech(PhraseRecognizedEventArgs datos)
    {
        /*StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", datos.text, datos.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", datos.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", datos.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());*/

        StringBuilder keyword = new StringBuilder();
        keyword.AppendFormat("{0}", datos.text);
        Debug.Log(keyword.ToString());

        switch(keyword.ToString()) {
            case "Arriba":
                transform.position = new Vector3(transform.position.x, transform.position.y + offset, transform.position.z);
                break;

            case "Abajo":
                transform.position = new Vector3(transform.position.x, transform.position.y - offset, transform.position.z);
                break;

            case "Izquierda":
                transform.position = new Vector3(transform.position.x - offset, transform.position.y, transform.position.z);
                break;
                
            case "Derecha":
                transform.position = new Vector3(transform.position.x + offset, transform.position.y, transform.position.z);
                break;
        }
    }
}
