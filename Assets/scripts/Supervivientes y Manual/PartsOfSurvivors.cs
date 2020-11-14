using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsOfSurvivors: MonoBehaviour {

    public GameObject partsofSurvivors;
    public static int theScoree;


    void Update() {

        partsofSurvivors.GetComponent<Text>().text = "Saved survivors: " + theScoree;


    }
}
