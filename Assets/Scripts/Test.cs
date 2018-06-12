using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test : MonoBehaviour {

    private int[] array;

	// Use this for initialization
	void Start () {
        //Debug.Log("Hello unity again!!");
        array = new int[5];
        array = array.Select(_ => Random.Range(0, 500)).ToArray();
        Debug.Log("\n-=-=ここから小さい順-=-=");
        array.OrderBy(e => e).ToList().ForEach(e => Debug.Log(e));
        Debug.Log("\n-=-=ここから大きい順-=-=");
        array.OrderByDescending(e => e).ToList().ForEach(e => Debug.Log(e));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
