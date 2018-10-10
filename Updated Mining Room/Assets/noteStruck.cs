using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteStruck : MonoBehaviour {

    //public for the note to be played

    bool miss = true;
    AudioSource AS;


	// Use this for initialization
	void Start () {
        AS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //determine distance away from
   public void musicNoteStruck()
    {
        AS.Play();
        miss = false;
        print("play NOTE");
    }

}
