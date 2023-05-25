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


		/***
			1. `FixedUpdate`：这是Unity中的一个内置函数，它在每个物理更新步骤中运行。物理更新步骤与帧更新步骤（Update）有所不同，前者的时间间隔是固定的，后者则根据计算机的性能和屏幕刷新率可能有所不同。在处理物理相关的行为，如移动和旋转刚体（Rigidbody）时，我们通常在`FixedUpdate`中进行。

			2. `Vector3 rotation = Vector3.up * hInput;`：这行代码创建了一个表示旋转的向量。向量的方向是“向上”（对应Unity坐标系中的y轴），大小等于用户的水平输入（可能是用键盘的左右键或者鼠标的左右移动来控制的）。

			3. `Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);`：这行代码将旋转向量转换为四元数。四元数是一种可以用来表示和计算3D旋转的数学结构。`Euler`方法是将欧拉角（表示旋转的三个角度）转换为四元数，而`Time.fixedDeltaTime`是物理更新步骤的时间间隔。

			4. `_rb.MovePosition(this.transform.position + Time.fixedDeltaTime * vInput * this.transform.forward);`：这行代码是用来移动物体的。`MovePosition`是Rigidbody的一个方法，用于设置刚体的位置。这里的新位置是当前位置加上用户的垂直输入（可能是用键盘的上下键或者鼠标的上下移动来控制的）乘以时间间隔和物体前方的方向（`this.transform.forward`）。

			5. `_rb.MoveRotation(_rb.rotation * angleRot);`：这行代码是用来旋转物体的。`MoveRotation`是Rigidbody的一个方法，用于设置刚体的旋转。这里的新旋转是当前旋转乘以前面计算出来的旋转四元数。
		 */
	}
}
