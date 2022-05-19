using UnityEngine;

namespace SampleModule
{
	public enum Axis
	{
		X,
		Y,
		Z
	}

	public class RotationBehaviour : MonoBehaviour
	{
		public float RotationRate = 30;
		public Axis Axis;

		public void Update()
		{
			switch (Axis)
			{
				case Axis.X:
					transform.Rotate(RotationRate * Time.deltaTime, 0, 0);
					break;
				case Axis.Y:
					transform.Rotate(0,RotationRate * Time.deltaTime, 0);
					break;
				case Axis.Z:
					transform.Rotate(0,0,RotationRate * Time.deltaTime);
					break;
			}
		}

	}
}
