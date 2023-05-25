using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public string labelText = "收集4个黄色胶囊就可以赢得你的自由！";
    public int maxItems = 4;
    public bool showWinScreen = false;
    private int _itemsCollected = 0;

    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;

            if (_itemsCollected >= maxItems)
            {
                labelText = "你收集到了所有的胶囊！";
                showWinScreen = true;
                ToggleFreezeTime(true);

			} else
            {
                labelText = "找到了胶囊！只需要再收集" + (maxItems - _itemsCollected) + "个！";
            }
        }
    }

	private void ToggleFreezeTime(bool isFreeze)
    {
        if (isFreeze)
        {
			Time.timeScale = 0f;
		} else
        {
			Time.timeScale = 1f;
		}
    }

	private void Restart()
	{
		SceneManager.LoadScene(0);
	}

	private void OnGUI()
    {
        GUI.Box(new Rect(20, 50, 150, 25), "胶囊："+ _itemsCollected);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        if (showWinScreen == true)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "你自由了，点我重开游戏") == true)
            {
                Restart();
                ToggleFreezeTime(false);
			}
		}
    }
}
