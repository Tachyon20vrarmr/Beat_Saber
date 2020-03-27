using UnityEngine;
using System.Collections;

public class Saber : MonoBehaviour {
	public Material capMaterial;
	public int count = 0;
	// Use this for initialization
	void Start () {

	}
	
	void Update(){

		/*if(count < 1){
			RaycastHit hit;

			if(Physics.Raycast(transform.position, transform.forward, out hit)){
				count = 1;
				GameObject victim = hit.collider.gameObject;

				GameObject[] pieces = vrarmrjuet.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

				if (!pieces[1].GetComponent<Rigidbody>())
				{
					Move.stop = true;
					pieces[1].AddComponent<Rigidbody>();
				}
				Destroy(pieces[1], 1);
			}

		}*/
	}
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Entered");
		GameObject victim = other.gameObject;
		
		//victim.AddComponent<Rigidbody>();
		GameObject[] pieces = vrarmrjuet.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

		if (!pieces[1].GetComponent<Rigidbody>())
		{
			//cube.stop = true;
			pieces[1].AddComponent<Rigidbody>();
		}
		Destroy(pieces[1], 1);
	}

	/*void OnDrawGizmosSelected() {

		Gizmos.color = Color.green;

		Gizmos.DrawLine(transform.position, transform.position + transform.forward * 5.0f);
		Gizmos.DrawLine(transform.position + transform.up * 0.5f, transform.position + transform.up * 0.5f + transform.forward * 5.0f);
		Gizmos.DrawLine(transform.position + -transform.up * 0.5f, transform.position + -transform.up * 0.5f + transform.forward * 5.0f);

		Gizmos.DrawLine(transform.position, transform.position + transform.up * 0.5f);
		Gizmos.DrawLine(transform.position,  transform.position + -transform.up * 0.5f);

	}*/

}
