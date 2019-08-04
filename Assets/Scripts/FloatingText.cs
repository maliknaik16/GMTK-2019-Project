using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
	public float destoryTime = 1f;

	private void Start() {
		Destroy(gameObject, destoryTime);
	}
}
