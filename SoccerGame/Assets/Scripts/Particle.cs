using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    [SerializeField] ParticleSystem collectParticle = null;



    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Collect();
        }
    }


    public void Collect()
    {
        collectParticle.Play();
    }

}
