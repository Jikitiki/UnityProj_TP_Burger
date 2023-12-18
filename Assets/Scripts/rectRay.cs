using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class rectRay : MonoBehaviour
{
    private GameObject rayLine;
    private RaycastHit hit;

    private int _maxDist = 100;

    public GameObject saladePrefab;



    // Start is called before the first frame update
    void Start()
    {
         rayLine = GameObject.FindGameObjectWithTag("rayLine");
    }

    // Update is called once per frame
    void Update()
    {
        // SI Click + raycast et raycast != sol + object détecté 0 enfant
        if (Input.GetMouseButtonUp(0) && (Physics.Raycast(transform.position, transform.forward, out hit, _maxDist) && hit.collider.gameObject.name != "floor") && hit.collider.gameObject.GetComponent<Transform>().childCount < 1)
        {
            Debug.Log("Touché! ("+hit.collider.gameObject.name+")"+"   --  childCount : "+ hit.collider.gameObject.GetComponent<Transform>().childCount);
            GameObject salade = Instantiate(saladePrefab, hit.collider.gameObject.GetComponent<Transform>());
            Vector3 size = new(0, hit.collider.gameObject.GetComponent<BoxCollider>().size.y, 0);
            salade.transform.localPosition += size;
            salade.transform.rotation = hit.collider.gameObject.GetComponent<Transform>().rotation;

        }
    }
}
