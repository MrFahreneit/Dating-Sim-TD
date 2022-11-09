using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daycycle : MonoBehaviour
{
	public enum CycleState
	{
		Day,
		Night
	}

	private CycleState CycleStateEnum = CycleState.Day;

	[SerializeField]
	private float rotSpeed = 40f;




	public void ChangeTimePeriod(int timeValue)
    {
		if (timeValue == 0)
        {

			CycleStateEnum = CycleState.Day;

		}

		else if(timeValue == 1)
        {
			CycleStateEnum = CycleState.Night;

		}
    }

    private void Update()
    {
		float rotationX = 0f;

		//int absRot = 1;

        switch (CycleStateEnum)
        {
            case CycleState.Day:
				rotationX = 0f;
				//absRot = -1;
				break;
            case CycleState.Night:
				rotationX = 180f;
				//absRot = 1;
				break;
        }

		Quaternion targetRotation = Quaternion.Euler(rotationX,0,0);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * rotSpeed);
		//transform.rotation = Quaternion.Euler(transform.rotation.x * absRot, transform.rotation.y, transform.rotation.z);
	}

}
