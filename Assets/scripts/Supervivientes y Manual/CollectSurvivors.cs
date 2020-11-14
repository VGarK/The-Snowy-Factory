using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSurvivors: MonoBehaviour {

    public AudioSource collectSound;

    void OnTriggerEnter(Collider other) {

        collectSound.Play();
        PartsOfSurvivors.theScoree += 1;
        Destroy(gameObject);

    }
}
