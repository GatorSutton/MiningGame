using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteStruck : MonoBehaviour {

    //public for the note to be played
    public float semitone_offset = 0;
    public float octave;
    bool miss = true;
    AudioSource AS;


	// Use this for initialization
	void Start () {
        AS = GetComponent<AudioSource>();
        Destroy(gameObject, 15f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //determine distance away from
   public void musicNoteStruck()
    {
        if (miss)
        {
            AS.pitch = Mathf.Pow(2f, semitone_offset / 12.0f) * octave;
            AS.Play();
            miss = false;
            print("play NOTE");
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

}
