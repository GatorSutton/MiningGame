using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteSpawner : MonoBehaviour {

    public GameObject musicNotePrefab;

    private Note currentNote;
    public string noteToPlay;
    

	// Use this for initialization
	void Start () {
        List<Note> notes = new List<Note>();

        notes.Add(new Note("C", 0));
        notes.Add(new Note("D", 2));
        notes.Add(new Note("E", 4));
        notes.Add(new Note("F", 5));
        notes.Add(new Note("G", 7));
        notes.Add(new Note("A", 9));
        notes.Add(new Note("B", 11));

        currentNote = notes.Find(x => x.name == noteToPlay);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnMouseDown()
    {
        spawnNote(currentNote);
    }

    public void spawnNote(Note note)
    {
        noteStruck nS = Instantiate(musicNotePrefab, transform).GetComponent<noteStruck>();
        nS.semitone_offset = note.offset;
    }
}
