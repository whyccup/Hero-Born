using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupBehavior : MonoBehaviour
{
	public GameBehavior gameManager;
	private void Start()
	{
		gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Player")
        {
			Debug.Log("收集到黄色胶囊了！");

			Destroy(this.transform.parent.gameObject);

			gameManager.Items += 1;
		}
	}
}
