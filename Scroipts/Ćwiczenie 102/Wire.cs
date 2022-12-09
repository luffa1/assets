using UnityEngine;
using System.Collections;

public class Wire : MonoBehaviour {

	public Transform pivot;

	public Material lineMat;
	
	public float radius = 0.05f;
	
	// Connect all of the `points` to the `mainPoint`
	public GameObject mainPoint;
	public GameObject[] points;
	
	// Fill in this with the default Unity square mesh
	// We will account for the square pivot/origin being in the middle.
	public Mesh squareMesh;
	GameObject[] ringGameObjects;


	// Use this for initialization
	void Start () 
	{
		this.ringGameObjects = new GameObject[points.Length];
		// this.connectingRings = new ProceduralRing[points.Length];
		for (int i = 0; i < points.Length; i++) {
			// Make a gameobject that we will put the ring on
			// And then put it as a child on the gameobject that has this Command and Control script
			this.ringGameObjects [i] = new GameObject ();
			this.ringGameObjects [i].name = "Connecting ring #" + i;
			this.ringGameObjects [i].transform.parent = this.gameObject.transform;
			
			// We make a offset gameobject to counteract the default squaremesh pivot/origin being in the middle
			GameObject ringOffsetSquareMeshObject = new GameObject ();
			ringOffsetSquareMeshObject.transform.parent = this.ringGameObjects [i].transform;
			
			// Offset the square so that the pivot/origin is at the bottom in relation to the outer ring gameobject.
			ringOffsetSquareMeshObject.transform.localPosition = new Vector3 (0f, 1f, 0f);
			// Set the radius
			ringOffsetSquareMeshObject.transform.localScale = new Vector3 (radius, 1f, radius);
			
			// Create the the Mesh and renderer to show the connecting ring
			MeshFilter ringMesh = ringOffsetSquareMeshObject.AddComponent<MeshFilter> ();
			ringMesh.mesh = this.squareMesh;
			
			MeshRenderer ringRenderer = ringOffsetSquareMeshObject.AddComponent<MeshRenderer> ();
			ringRenderer.material = lineMat;

		}
	}
	
	// Update is called once per frame
	void Update () 
	{
			for(int i = 0; i < points.Length; i++) {
				// Move the ring to the point
				this.ringGameObjects[i].transform.position = this.points[i].transform.position;
				
				// Match the scale to the distance
				float squareDistance = 2f*Vector3.Distance(this.points[i].transform.position, this.mainPoint.transform.position);
				this.ringGameObjects[i].transform.localScale = new Vector3(this.ringGameObjects[i].transform.localScale.x, squareDistance, this.ringGameObjects[i].transform.localScale.z);
				
				// Make the square look at the main point.
				// Since the square is pointing up(y) and the forward is z, we need to offset by 90 degrees.
				this.ringGameObjects[i].transform.LookAt(this.mainPoint.transform, Vector3.up);
				this.ringGameObjects[i].transform.rotation *= Quaternion.Euler(90, 0, 0);
			}
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawLine (transform.position, pivot.position);
	}

}
