using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
	// 定义公共浮点数变量moveSpeed和rotateSpeed，分别表示移动速度和旋转速度
	public float moveSpeed = 10f;
	public float rotateSpeed = 75f;

	// 定义私有浮点数变量vInput和hInput，分别表示垂直和水平输入
	private float vInput;
	private float hInput;

	// 定义私有Rigidbody变量_rb，表示物体的刚体组件
	private Rigidbody _rb;

	// 在游戏开始时运行，用于初始化
	private void Start()
	{
		// 获取物体的刚体组件，并存储在_rb变量中
		_rb = GetComponent<Rigidbody>();
	}

	// 每帧更新时运行
	private void Update()
	{
		// 获取垂直和水平输入，分别乘以移动速度和旋转速度
		vInput = Input.GetAxis("Vertical") * moveSpeed;
		hInput = Input.GetAxis("Horizontal") * rotateSpeed;
		// 物体将根据输入直接进行移动和旋转
		// this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
		// this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
	}

	// 在每个物理更新步骤时运行
	private void FixedUpdate()
	{
		// 创建一个表示旋转的向量，方向为上，大小为水平输入
		Vector3 rotation = Vector3.up * hInput;

		// 将旋转向量转换为四元数，乘以物理更新的时间步长
		Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

		// 使用刚体的MovePosition方法移动物体，新的位置为当前位置加上输入的移动量乘以时间步长
		_rb.MovePosition(this.transform.position + Time.fixedDeltaTime * vInput * this.transform.forward);

		// 使用刚体的MoveRotation方法旋转物体，新的旋转为当前旋转乘以旋转的四元数
		_rb.MoveRotation(_rb.rotation * angleRot);
	}
}
