using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectRay : MonoBehaviour
{
    private GameObject rayLine;
    private RaycastHit hit;

    private int _maxDist = 100;
    private bool active = true;

    public GameObject saladePrefab;



    // Start is called before the first frame update
    void Start()
    {
         rayLine = GameObject.FindGameObjectWithTag("rayLine");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && (Physics.Raycast(transform.position, transform.forward, out hit, _maxDist) && active && hit.collider.gameObject.name != "floor"))
        {
            Debug.Log("Touché! ("+hit.collider.gameObject.name+")");
            GameObject salade = Instantiate(saladePrefab, hit.collider.gameObject.GetComponent<Transform>());
            Vector3 size = new(0, hit.collider.gameObject.GetComponent<BoxCollider>().size.y, 0);//(0, (float)0.05, 0);
            salade.transform.position = salade.transform.position + size;
        }
    }
}
