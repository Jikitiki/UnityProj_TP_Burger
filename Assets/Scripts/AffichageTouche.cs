using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AffichageTouche : MonoBehaviour
{
    public string msg;
    public TMP_Text textTouche;

    public GameObject canvas;
    public bool isTable = true;

    // Start is called before the first frame update
    void Start()
    {
        if(isTable)
            textTouche.color = Color.black;
        else 
            textTouche.color = Color.white;
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider col)
    {
        if(col.tag == "Burger")
        { 
            textTouche.text = msg;
            canvas.SetActive(true);
        }
    }
        public void OnTriggerExit(Collider col)
    {
        if(col.tag == "Burger")
        {
            canvas.SetActive(false);
        }
    }
}
