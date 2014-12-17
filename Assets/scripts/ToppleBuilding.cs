using UnityEngine;
using System.Collections;

public class ToppleBuilding : MonoBehaviour {

	public GameObject terrain;
	public GameObject snowing;
	public GameObject buildingArea;
	public GameObject start1;
	public GameObject start2;
	public GameObject start3;


	// Use this for initialization
	void Start () {
		snowing.SetActive(true);
		StartCoroutine( WaitRotate(0f, -4f) );
		StartCoroutine( WaitRotate(3f, -4f) );
		StartCoroutine( WaitRotate(6f, -10f) );
		StartCoroutine( WaitToGo (8f) );
		terrain.SetActive(true);
		start1.SetActive(true);
		start2.SetActive(true);
		start3.SetActive(true);
	}
	
	IEnumerator WaitRotate(float time, float angle) {
		yield return new WaitForSeconds(time);
		transform.Rotate(new Vector3(angle, 0f, 0f));	
	}
	IEnumerator WaitToGo(float time) {
		yield return new WaitForSeconds(time);
		buildingArea.SetActive(false);
	}
}
