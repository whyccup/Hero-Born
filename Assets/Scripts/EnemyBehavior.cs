using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
	public Vector3 EnemyOffset = new Vector3(0f, 0.5f, 2.6f);

	private void OnTriggerEnter(Collider other)
	{
		if(other.name == "Player")
		{
			Debug.Log("玩家进入攻击范围 —— 攻击！");

			this.transform.position = other.transform.TransformPoint(EnemyOffset);
			this.transform.LookAt(other.transform);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if(other.name == "Player")
		{
			Debug.Log("玩家离开攻击范围 —— 回去巡逻");
		}
	}
}
