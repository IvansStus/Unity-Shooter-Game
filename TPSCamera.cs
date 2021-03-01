using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    public float RotationSpeed = 20f;
    public float VerticalRotationSpeed = 10f;
    private Vector2 Rotation = new Vector2(0, 0);
    public Transform player, target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate(){
        ThirdPersonCamera();
    }

    void ThirdPersonCamera() {
        Rotation.x += -Input.GetAxis("Mouse Y") * RotationSpeed;
        Rotation.y += Input.GetAxis("Mouse X") * RotationSpeed;
        player.rotation = Quaternion.Euler(0, Rotation.y, 0);
        target.rotation = Quaternion.Euler(Rotation.x, Rotation.y, 0);
        
    }

}
