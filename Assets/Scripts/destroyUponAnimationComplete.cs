using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyUponAnimationComplete : MonoBehaviour
{
	public void DestroyEvent(string s)
	{
		if (s == "end")
		{
			Destroy(gameObject);
		}
	}
}
