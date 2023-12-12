using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class timer : MonoBehaviour
{

    public TextMeshPro _textMeshPro;
    public float _time;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;

        if (_time > 0)
        {
            //If time is greater than 0, display time left
            _textMeshPro.text = Mathf.RoundToInt(_time).ToString();
        }
        else
        {
            //Otherwise display this
            _textMeshPro.text = "TROP TARD";
            GetComponent<Fiche>().generationFiche();
        }
    }
}
