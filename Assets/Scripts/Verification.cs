using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verification : MonoBehaviour
{
   /* private string[] ListeFaire;
    public GameObject Burger;
    public int score = 0;
    private bool isVerifier = true;

    // Start is called before the first frame update
    void Start()
    {
        ListeFaire = new string[6];
        ListeFaire[0] = "PainBas";
        ListeFaire[1] = "Salade";
        ListeFaire[2] = "Tomates";
        ListeFaire[3] = "Fromage";
        ListeFaire[4] = "Steak";
        ListeFaire[5] = "PainHaut";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (isVerifier)
            {
                Verif();
                isVerifier = false;
            }
        }
    }

    public void Verif()
    {
        
        GameObject fils = Burger;
        for (int i = 0; i< nbElement(); i++)
        {
            Debug.Log(fils.transform.GetChild(0).tag);
            if (ListeFaire[i] == fils.transform.GetChild(0).tag)
                score++;
            fils = GameObject.Find(fils.transform.GetChild(0).name);

        }
        Debug.Log("score " + score);
    }

    public int nbElement()
    {
        GameObject fils = Burger;
        int nbEle = 0;
        while(fils.GetComponent<Transform>().childCount != 0)
        {
            nbEle++;
            fils = GameObject.Find(fils.transform.GetChild(0).name);
        }
        Debug.Log("ele " + nbEle);
        return nbEle;
    }*/

}
