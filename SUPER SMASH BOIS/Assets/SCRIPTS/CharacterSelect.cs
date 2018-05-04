using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject CharacterIcon;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {

            Debug.Log("Ben");
            Instantiate(CharacterIcon, new Vector3(-5.25f,-3.25f,0), Quaternion.identity);
        }
    }
}
