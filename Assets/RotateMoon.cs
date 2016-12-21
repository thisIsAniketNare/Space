using UnityEngine;
using System.Collections;

public class RotateMoon : MonoBehaviour {
	public int speed;
	public int x;
	public int y;
	public int z;
	public GameObject earth;
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 45, 30)*Time.deltaTime,Space.Self);
		//transform.localRotation = Quaternion.identity;
		transform.RotateAround (earth.transform.position, new Vector3(x,y,z), speed * Time.deltaTime);
	}
}
