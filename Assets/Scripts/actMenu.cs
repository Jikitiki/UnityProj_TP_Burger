using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class actMenu : MonoBehaviour
{

    public TextMeshPro _textMeshPro;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (_textMeshPro != null) { Debug.Log("oui"); }
        _textMeshPro.text = "Commande : \n test";
    }
}
