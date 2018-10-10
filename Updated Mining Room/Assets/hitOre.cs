using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitOre : MonoBehaviour {

    public KeyCode keyToHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(keyToHit))
          {
            //check to see if note is hit
          }
	}


    private void OnTriggerStay(Collider other)
    {

        if(Input.GetKeyDown(keyToHit))
        {
            if(other.gameObject.tag == "note")
            {
                other.gameObject.GetComponent<noteStruck>().musicNoteStruck();
            }
        }
    }
}
