﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FactRandom : MonoBehaviour {
    public Text myText;
    //An array of random facts
    private string[] randomFact = {
        "Around 70% of industrial waste is dumped into our oceans.",
        "80% of water pollution is caused by domestic sewage.",
        "More than 6 billion pounds of garbage end up in our oceans every year.",
        "Almost two million tons of human waste end up in our oceans daily.",
        "The nuclear crisis created by the tsunami of 2011 unleashed 11 million liters of radioactive water into the Pacific Ocean.",
        "On average 250 million people succumb each year from diseases caused by contaminated water.",
        "40 percent of plastic produced is packaging, used just once and then discarded into our oceans.",
        "Nearly half of all plastic ever manufactured has been made since 2000.",
        "Less than a fifth of all plastic is recycled globally, the rest ends up in our oceans.",
        "73% of beach litter worldwide is plastic.",
        "90% of plastic polluting our oceans is carried by just 10 rivers.",
    };
    //Selects a random fact to display
    void Start () {
        string myString = randomFact[Random.Range (0, randomFact.Length)];
        myText.text = myString;
    }
}