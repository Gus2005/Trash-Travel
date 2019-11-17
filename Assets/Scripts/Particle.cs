using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{

    public Transform sparkle;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        sparkle.GetComponent<ParticleSystem>().enableEmission = false;


    }
    [System.Obsolete]
    void OnTriggerEnter2D()
    {
        sparkle.GetComponent<ParticleSystem>().enableEmission = true;
        StartCoroutine(stopSparkles());
    }
    [System.Obsolete]
    IEnumerator stopSparkles()
    {
        yield return new WaitForSeconds(.4f);

        sparkle.GetComponent<ParticleSystem>().enableEmission = false;
    }

}