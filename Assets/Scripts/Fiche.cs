using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class Fiche : MonoBehaviour
{
    public string[] CompositionAFaire;
    public int score = 0;

    public int temps;
    public bool col = false;


    public GameObject Burger; 
    public TextMeshPro _textMeshPro;
    
    GameObject fils;
    int nbEle = 0;
    int nbElements;



    // Start is called before the first frame update
    void Start()
    {
        Burger = GameObject.FindGameObjectWithTag("Burger");
        generationFiche();
        _textMeshPro.color = Color.black;
        //fils = Burger;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && col)
        {
            Verif(); 
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
        nbElements = Random.Range(3, 5);
        int alimentRandom; 
        CompositionAFaire = new string[nbElements + 2];
        CompositionAFaire[0] = "PainBas";
        for(int i = 0; i < nbElements; i++)
        {
            alimentRandom = Random.Range(0, 4);
            CompositionAFaire[i + 1] = ((Aliment)alimentRandom).ToString();
        }
        CompositionAFaire[nbElements + 1] = "PainHaut";

        GetComponent<timer>()._time = temps = Random.Range(15, 25)+nbElements*3;
        afficheComp();

        //Debug.Log("liste" + CompositionAFaire);
    }

    public void Verif()
    {
        col = false;
        GameObject fil = Burger;
        int elem = nbElement();
        for (int i = 0; i < elem; i++)
        {
            Debug.Log("AA " + CompositionAFaire[i]);
            Debug.Log("A " + fil.name);
            if(fil.GetComponent<Transform>().childCount != 0)
            {
                if(i < nbElements + 2)
                {
                    if (CompositionAFaire[i] == fil.transform.GetChild(0).tag)
                    {
                        Debug.Log("AAA");
                        score++;
                    }
                    fil = GameObject.Find(fil.transform.GetChild(0).name);
                }
            }

        }
        DestructionBurger();
        generationFiche();
        Debug.Log("score " + score);
    }

    public int nbElement()
    {
        fils = Burger;
        nbEle = 0;
        while (fils.GetComponent<Transform>().childCount != 0)
        {
            nbEle++;
            fils = GameObject.Find(fils.transform.GetChild(0).name);
        }
        Debug.Log("ele " + nbEle);
        return nbEle;
    }

    public void afficheComp()
    {
        string tmp = "Commande :";
        foreach(string s in CompositionAFaire) 
        {
            tmp += ("\n- " + s);
        }
        _textMeshPro.text = tmp;
    }

    public void DestructionBurger()
    {
        Destroy(GameObject.Find(Burger.transform.GetChild(0).name));
    }

}
