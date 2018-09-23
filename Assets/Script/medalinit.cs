using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medalinit : MonoBehaviour {

    public GameObject medalObjPrefab;
    public GameObject medalsObj;

    void Awake()
    {
        Debug.Log("Awake");
    }

    // Use this for initialization
    void Start () {

        Debug.Log("Start");
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 offs = new Vector3(Mathf.Sin(Time.time), 2, 0);
            Debug.Log("Input.GetButtonDown Fire1");
            Instantiate(medalObjPrefab, transform.position + offs, transform.rotation);
        }

    }
}
