using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
	// 定义公共向量变量EnemyOffset，存储敌人相对于玩家的位置偏移
	public Vector3 EnemyOffset = new Vector3(0f, 0.5f, 2.6f);

	// 定义私有方法OnTriggerEnter，当有其他游戏对象进入这个游戏对象的触发器时自动执行
	private void OnTriggerEnter(Collider other)
	{
		// 如果进入触发器的游戏对象的名字是"Player"
		if (other.name == "Player")
		{
			Debug.Log("玩家进入攻击范围 —— 攻击！");

			// 将敌人的位置设置为玩家的相对位置（由EnemyOffset指定）
			this.transform.position = other.transform.TransformPoint(EnemyOffset);
			// 使敌人面向玩家
			this.transform.LookAt(other.transform);
		}
	}

	// 定义私有方法OnTriggerExit，当有其他游戏对象离开这个游戏对象的触发器时自动执行
	private void OnTriggerExit(Collider other)
	{
		// 如果离开触发器的游戏对象的名字是"Player"
		if (other.name == "Player")
		{
			Debug.Log("玩家离开攻击范围 —— 回去巡逻");
		}
	}
}
