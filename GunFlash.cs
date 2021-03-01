using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFlash : MonoBehaviour
{
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();        
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            ps.Play();            
        }
    }
}
