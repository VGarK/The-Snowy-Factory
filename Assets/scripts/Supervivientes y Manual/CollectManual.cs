using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectManual : MonoBehaviour {

    public AudioSource collectSound;
  

    void OnTriggerEnter(Collider other) {

        collectSound.Play();
        PartsOfManual.theScore += 1;
        Destroy(gameObject);

        
       if (PartsOfManual.theScore == 3) {
            SceneManager.LoadScene("level2");
        }

       if (PartsOfManual.theScore == 6) {
            SceneManager.LoadScene("Victory");
        }

    }
}
