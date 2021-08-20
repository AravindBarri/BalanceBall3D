using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatform : MonoBehaviour
{
	public float fallTime = 4f;
	public float regenerateTime = 5f;
	Renderer platformcolor;

	private void Start()
	{
		platformcolor = GetComponent<Renderer>();
	}
	void OnCollisionEnter(Collision collision)
	{
		//Debug.DrawRay(contact.point, contact.normal, Color.white);
		if (collision.gameObject.tag == "Player")
		{
			Invoke("changeColor", 2f);
			StartCoroutine(Fall(fallTime));
		}
	}

	IEnumerator Fall(float time)
	{
		print(time);
		time -= 1;
		yield return new WaitForSeconds(time);
		this.gameObject.SetActive(false);
		Invoke("Regenerateplat", regenerateTime);
	}
	void Regenerateplat()
	{
		platformcolor.material.SetColor("_Color", Color.white);
		this.gameObject.SetActive(true);
	}
	void changeColor()
	{
		platformcolor.material.SetColor("_Color", Color.red);
	}
}
