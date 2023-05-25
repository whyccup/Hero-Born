using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if(other.name == "Player")
		{
			Debug.Log("玩家进入攻击范围 —— 攻击！");
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
