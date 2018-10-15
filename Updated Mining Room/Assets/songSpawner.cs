using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class songSpawner : MonoBehaviour {

    private noteSpawner nS;

    List<Note> notes = new List<Note>();
    List<Note> marioSong = new List<Note>();

    // Use this for initialization
    void Start () {
        nS = transform.GetComponentInChildren<noteSpawner>();

        notes.Add(new Note("C", 0));
        notes.Add(new Note("C#", 1));
        notes.Add(new Note("D", 2));
        notes.Add(new Note("D#", 3));
        notes.Add(new Note("E", 4));
        notes.Add(new Note("F", 5));
        notes.Add(new Note("G#", 6));
        notes.Add(new Note("G", 7));
        notes.Add(new Note("G#", 8));
        notes.Add(new Note("A", 9));
        notes.Add(new Note("A#", 10));
        notes.Add(new Note("B", 11));

        notes.Add(new Note("^C", 12));
        notes.Add(new Note("^C#", 13));
        notes.Add(new Note("^D", 14));
        notes.Add(new Note("^D#", 15));
        notes.Add(new Note("^E", 16));
        notes.Add(new Note("^F", 17));
        notes.Add(new Note("^G#", 18));
        notes.Add(new Note("^G", 19));
        notes.Add(new Note("^G#", 20));
        notes.Add(new Note("^A", 21));
        notes.Add(new Note("^A#", 22));
        notes.Add(new Note("^B", 23));

        notes.Add(new Note(".C", -1));
        notes.Add(new Note(".C#", -2));
        notes.Add(new Note(".D", -3));
        notes.Add(new Note(".D#", -4));
        notes.Add(new Note(".E", -5));
        notes.Add(new Note(".F", -6));
        notes.Add(new Note(".G#", -7));
        notes.Add(new Note(".G", -8));
        notes.Add(new Note(".G#", -9));
        notes.Add(new Note(".A", -10));
        notes.Add(new Note(".A#", -11));
        notes.Add(new Note(".B", -12));

        createMario();
        StartCoroutine("playMario");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void createMario()
    {
        marioSong.Add(notes.Find(x => x.name == "^E"));
        marioSong.Add(notes.Find(x => x.name == "^E"));
        marioSong.Add(notes.Find(x => x.name == "^E"));
        marioSong.Add(notes.Find(x => x.name == "^C"));
        marioSong.Add(notes.Find(x => x.name == "^E"));
        marioSong.Add(notes.Find(x => x.name == "^G"));
        marioSong.Add(notes.Find(x => x.name == "G"));
    }

    private IEnumerator playMario()
    {
        while (marioSong.Count > 0)
        {
            nS.spawnNote(marioSong[0]);
            marioSong.RemoveAt(0);
            yield return new WaitForSeconds(.5f);
        }
    }
}
