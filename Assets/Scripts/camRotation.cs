using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRotation : MonoBehaviour
{

    private float rotationY = 0;
    private float _rotationSpeed = 2f;
    private Transform _tfCam;

    // Start is called before the first frame update
    void Start()
    {
        _tfCam = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse Y") * _rotationSpeed;

        _tfCam.localRotation = Quaternion.AngleAxis(rotationY, Vector3.left);
    }
}
