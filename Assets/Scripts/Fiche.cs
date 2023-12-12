using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiche : MonoBehaviour
{
    public string[] CompositionAFaire;
    public GameObject Burger;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Burger = GameObject.FindGameObjectWithTag("Burger");
        generationFiche();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum Aliment
    {
       Fromage = 0,
       Salade = 1,
       Steak = 2,
       Tomates = 3
    };

    public void generationFiche()
    {
        int nbElement = Random.Range(5, 8);
        int alimentRandom; 
        CompositionAFaire = new string[nbElement + 2];
        CompositionAFaire[0] = "PainBas";
        for(int i = 0; i < nbElement; i++)
        {
            alimentRandom = Random.Range(0, 4);
            CompositionAFaire[i + 1] = ((Aliment)alimentRandom).ToString();
        }
        CompositionAFaire[nbElement + 1] = "PainHaut";
        //Debug.Log("liste" + CompositionAFaire);
    }

    public void Verif()
    {

        GameObject fils = Burger;
        for (int i = 0; i < nbElement(); i++)
        {
            Debug.Log(fils.transform.GetChild(0).tag);
            if (CompositionAFaire[i] == fils.transform.GetChild(0).tag)
                score++;
            fils = GameObject.Find(fils.transform.GetChild(0).name);

        }
        Debug.Log("score " + score);
    }

    public int nbElement()
    {
        GameObject fils = Burger;
        int nbEle = 0;
        while (fils.GetComponent<Transform>().childCount != 0)
        {
            nbEle++;
            fils = GameObject.Find(fils.transform.GetChild(0).name);
        }
        Debug.Log("ele " + nbEle);
        return nbEle;
    }


}
