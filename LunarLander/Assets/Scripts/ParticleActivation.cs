using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivation : MonoBehaviour
{
    public ParticleSystem parSystem;

    private void Start()
    {
        parSystem.Stop();
        parSystem.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        TurnOnAndOffParticles();
    }

    private void TurnOnAndOffParticles()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            parSystem.Play();

        if (Input.GetKeyUp(KeyCode.Space))
        {
            parSystem.Stop();
            parSystem.Clear();
        }
    }
}
