using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private float _speedX=0, _speedY=0, _speedZ=0;
    float rotationX=0;
    float rotationY=0;

    public float _acc = 8f;
    private float _rotationSpeed = 2f;
    private Transform _tfPlayer;
    private float _incrX,_incrZ,_incrY;

    // Start is called before the first frame update
    void Start()
    {
        _tfPlayer = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        _incrX = Time.deltaTime * _acc;
        _incrY = Time.deltaTime * _acc;
        _incrZ = Time.deltaTime * _acc;

        _tfPlayer.Translate(_incrZ * Input.GetAxis("Horizontal"), 0, _incrX*Input.GetAxis("Vertical"));

         rotationX += Input.GetAxis("Mouse X") * _rotationSpeed;

        _tfPlayer.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);

        //transform.Rotation(this.transform.position, Vector3.left, Input.GetAxis ("Mouse Y"));

		
    }
}
