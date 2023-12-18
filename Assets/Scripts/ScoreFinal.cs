using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreFinal : MonoBehaviour
{
    public GameObject[] tabTable;
    public int scoreFinal = 0;
    public TMP_Text textScore;
    public GameObject canvas;

    private float _time = 40;
    private bool sco = true;


    // Start is called before the first frame update
    void Start()
    {
        textScore.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        //Debug.Log(_time);
        if (_time <= 0.0 && sco)
        {
            CalculScore(); 
            sco = false;
        }
        
    }

    public void CalculScore()
    {
        for(int i = 0; i< tabTable.Length; i++)
        {
            scoreFinal += tabTable[i].GetComponent<Fiche>().score;
        }
        canvas.SetActive(true);
        textScore.text = "Score Final : " + scoreFinal.ToString();
    }

}
