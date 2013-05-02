using UnityEngine;
using System.Collections;

public class Script1 : MonoBehaviour 
{
	void FixedUpdate()
	{
		transform.RotateAround( new Vector3( 0.0f, 1.0f, 0.0f ), 0.1f );
	}
}
