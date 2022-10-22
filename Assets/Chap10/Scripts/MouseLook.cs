using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 캐릭터 회전(바라보기)
/// </summary>


public class MouseLook : MonoBehaviour {
    
    public enum RotationAxes        //카메라와 몸체 두가지로나눔
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float _rotationX = 0;

    private void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
        {
            body.freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update () {
		if (axes == RotationAxes.MouseX)
        {
            // Rotate Horizontally
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);  // x 이동은 y축 회전 임으로
        }

        else if (axes == RotationAxes.MouseY)
        {
            // Rotate Vertically
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0); // y 이동은 x축 회전 임으로
        }
	}
}
