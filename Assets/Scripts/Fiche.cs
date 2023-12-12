using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiche : MonoBehaviour
{
    public string[] CompositionAFaire;
    public GameObject Burger;
    public int score = 0;

    public bool col = false, touche = false;

    // Start is called before the first frame update
    void Start()
    {
        Burger = GameObject.FindGameObjectWithTag("Burger");
        generationFiche();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            touche = true;
        }
        if (Input.GetKeyUp("e"))
        {
            touche = false;
        }
        if (touche && col)
        {
            Verif();
            touche = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Burger")
        {
            Debug.Log("CA RENTRE FORT LAAAAAAAAAAAAAAA");
            col = true;

        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Burger")
        {
            col = false;
        }
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
        touche = false;

        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        GameObject fils = Burger;
        for (int i = 0; i < nbElement()-2; i++)
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
        Debug.Log("ON PASSE ICIiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");

        GameObject fils = Burger;
        int nbEle = 0;
        while (fils.GetComponent<Transform>().childCount != 0)
        {
            nbEle++;
            Debug.Log("ALLOOOOOOOOOOOOOO : " + fils.transform.GetChild(0).name);
            fils = GameObject.Find(fils.transform.GetChild(0).name);
        }
        Debug.Log("ele " + nbEle);
        return nbEle;
    }


}
