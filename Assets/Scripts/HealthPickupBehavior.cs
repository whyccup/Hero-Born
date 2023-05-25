using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 声明一个名为HealthPickupBehavior的公共类，继承自MonoBehaviour
public class HealthPickupBehavior : MonoBehaviour
{
	// 定义公共的GameBehavior变量gameManager，用于存储游戏管理器
	public GameBehavior gameManager;

	// 在游戏开始时运行，用于初始化
	private void Start()
	{
		// 找到名为"GameManager"的游戏对象，并获取其GameBehavior组件，将其存储在gameManager变量中
		gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
	}

	// 当发生碰撞时运行
	private void OnCollisionEnter(Collision collision)
	{
		// 如果发生碰撞的对象的名字是"Player"
		if (collision.gameObject.name == "Player")
		{
			Debug.Log("收集到黄色胶囊了！");

			// 销毁这个组件的父对象（也就是包含这个组件的游戏对象）
			Destroy(this.transform.parent.gameObject);

			// 增加gameManager的Items属性的值
			gameManager.Items += 1;
		}
	}
}
