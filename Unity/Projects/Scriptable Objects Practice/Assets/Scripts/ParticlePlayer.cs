using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{

    public ParticleSystem particleSystem;

    void Start()
    {
        //Verifies that the system is stopped when play is pushed.
        particleSystem.Stop();
    }

    //Plays the particle system when called.
    public void PlayParticles()
    {
        particleSystem.Play();
    }
}
