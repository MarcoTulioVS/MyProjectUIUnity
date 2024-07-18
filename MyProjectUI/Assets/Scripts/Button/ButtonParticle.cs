using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonParticle : MonoBehaviour
{
    public ParticleSystem particle;
    
    public void ShowParticle()
    {
        particle.Play();
    }
}
