using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleModule
{
	public class RotationBehaviour : MonoBehaviour
	{
		public float RotationRate = 30;

		public void Update()
		{
			transform.Rotate(RotationRate * Time.deltaTime, 0, 0);
		}

	}
}
