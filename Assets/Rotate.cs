using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public int speed;
	public int x;
	public int y;
	public int z;
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 45, 30)*Time.deltaTime,Space.Self);
		transform.RotateAround (Vector3.zero, new Vector3(x,y,z), speed * Time.deltaTime);
	}
}
