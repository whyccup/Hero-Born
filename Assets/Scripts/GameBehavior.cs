using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 声明一个名为GameBehavior的公共类，继承自MonoBehaviour
public class GameBehavior : MonoBehaviour
{
	// 定义公共字符串变量labelText，存储屏幕上显示的文本
	public string labelText = "收集4个黄色胶囊就可以赢得你的自由！";
	// 定义公共整数变量maxItems，存储游戏胜利需要收集的物品数量
	public int maxItems = 4;
	// 定义公共布尔值变量showWinScreen，表示是否显示胜利界面
	public bool showWinScreen = false;
	// 定义私有整数变量_itemsCollected，存储已经收集的物品数量
	private int _itemsCollected = 0;
	// 定义Items属性，获取或设置已收集的物品数量
	public int Items
	{
		get { return _itemsCollected; }
		set
		{
			_itemsCollected = value;
			// 如果收集的物品数量大于或等于需要收集的物品数量
			if (_itemsCollected >= maxItems)
			{
				labelText = "你收集到了所有的胶囊！";
				showWinScreen = true;
				ToggleFreezeTime(true);
			}
			else
			{
				labelText = "找到了胶囊！只需要再收集" + (maxItems - _itemsCollected) + "个！";
			}
		}
	}

	// 定义私有方法ToggleFreezeTime，接收一个布尔值参数，表示是否暂停游戏
	private void ToggleFreezeTime(bool isFreeze)
	{
		// 如果需要暂停游戏
		if (isFreeze)
		{
			Time.timeScale = 0f;  // 设置游戏时间的缩放比例为0，即暂停游戏
		}
		else
		{
			Time.timeScale = 1f;  // 设置游戏时间的缩放比例为1，即恢复游戏
		}
	}

	// 定义私有方法Restart，用于重新开始游戏
	private void Restart()
	{
		SceneManager.LoadScene(0);  // 重新加载场景，参数0表示加载的是场景列表中的第一个场景
	}

	// 定义私有方法OnGUI，用于处理游戏的图形用户界面
	private void OnGUI()
	{
		// 在屏幕上显示一个包含已收集的物品数量的盒子
		GUI.Box(new Rect(20, 50, 150, 25), "胶囊：" + _itemsCollected);
		// 在屏幕上显示labelText变量中的文本
		GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

		// 如果需要显示胜利界面
		if (showWinScreen == true)
		{
			// 如果玩家点击了"你自由了，点我重开游戏"按钮
			if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "你自由了，点我重开游戏") == true)
			{
				Restart();  // 重新开始游戏
				ToggleFreezeTime(false);  // 解除游戏暂停
			}
		}
	}
}
