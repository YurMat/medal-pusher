using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medalinit : MonoBehaviour {

    public GameObject medalObjPrefab;
    public GameObject medalsObj;

    void Awake()
    {
        Debug.Log("Awake");
    }

    // Use this for initialization
    void Start () {
        Debug.Log("Start");
        //GetComponent<Rigidbody>().position = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {
        //left ctrl ボタンを押すとインプット
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 offs = new Vector3(Mathf.Sin(Time.time), 2, 0);
            Debug.Log("Input.GetButtonDown Fire1");
            Instantiate(medalObjPrefab, transform.position + offs, transform.rotation);
        }

    }
}
