using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
	// 公共的Vector3变量，存储相机相对于目标的偏移量
	public Vector3 cameraOffset = new Vector3(0f, 1.2f, -2.6f);
	// 私有的Transform变量，用于存储目标的Transform
	private Transform target;

	// 在游戏开始时运行，用于初始化
	void Start()
	{
		// 找到名为"Player"的游戏对象，并获取其Transform组件，将其存储在target变量中
		target = GameObject.Find("Player").transform;
	}

	// 在所有Update函数调用之后运行，用于处理与摄像机相关的更新
	void LateUpdate()
	{
		// 将摄像机的位置设置为目标位置加上偏移量，TransformPoint函数会考虑目标对象的旋转和缩放
		this.transform.position = target.TransformPoint(cameraOffset);
		// 让摄像机朝向目标对象
		this.transform.LookAt(target);
	}
}
