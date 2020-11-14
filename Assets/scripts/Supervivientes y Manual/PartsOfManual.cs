using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PartsOfManual : MonoBehaviour {

    public GameObject partsofManual;
    public static int theScore;
    

    void Update() {

        partsofManual.GetComponent<Text>().text = "Parts of manual: " + theScore;
       

    }

	
}
