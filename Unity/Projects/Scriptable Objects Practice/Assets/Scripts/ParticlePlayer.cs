using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{

    public ParticleSystem particleSystem;

    void Start()
    {
        //Verifies that the system is stopped when play is pushed.
        particleSystem.Stop();
    }

    public void PlayParticles()
    {
        particleSystem.Play();
    }
}
