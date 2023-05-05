# Hero-Born

Unity3D Learning Demo

## IDEA and debugging

 [more information](https://blog.walterlv.com/post/unity-starter-install-and-integrated-with-visual-studio.html)

1. 在 `Unity > Settings > External Tools > External Script Editor` 选择 Visual Studio
2. 勾选所有 `Generate .csproj files for` 下的 checkbox
3. 右键你要打开的 cs 文件，选择 `Open C# project`

## 游戏设计规划点

1. 概念:对游戏的全局理念和设计，包括游戏类型和玩法风格。
2. 核心机制:角色可以在游戏中使用的可玩功能或互动方式。常见的游戏机制包括跳跃、射击、解谜、驾驶等。
3. 控制方案:玩家用来控制游戏角色、环境交互和其他可执行动作的键位映射。
4. 故事:推动游戏发展的背景叙事，用于在玩家与游戏世界之间建立共情与关联。
5. 艺术风格:游戏的总体观感，并体现在从角色、界面美术到关卡和环境设计的各方面。
6. 胜负条件:决定游戏输赢的规则，通常由一些可能会遭遇失败的目标构成。

## Hero-Born One Pager

### 概念

    游戏原型的重点是潜行躲避敌人并收集治疗道具，还包一部分FPS(First-person shooter，第一人称射击)的内容度

### 核心机制

    主要机制围绕利用可见度(Line of sight，LoS)来领先巡逻中的敌人并收集所需道具。
    战斗包含向敌人射击，这会自动触发反击响应。

### 控制方案

    使用 W A S D 键或方向键控制移动，鼠标控制摄像机。使用空格键射击，通过对象碰撞收集道具。
    简单的HUD(Head Up Display，抬头显示系统)将显示玩家收集到的道具和剩余子弹数量，以及一个常规血条栏来显示玩家生命值。

### 故事

    玩家将在一个开放的城市环境中进行潜行和射击，收集医疗包并保持自己的生命力。在这个世界中，随处可见游荡的感染者，它们会攻击任何接近它们的人。玩家必须谨慎行事，利用环境中的遮蔽物，尽可能地避免被敌人发现。如果玩家被感染者攻击并失去所有生命力，那么他将再次回到起点。然而，如果他成功收集到所有的医疗包将成为一个真正的Hero

### 艺术风格

    为了快速高效地开发原型，关卡和角色的艺术风格将全部采用原始GameObject。如有需要，之后可以替换为3D模型或地形环境。

### 胜负条件

    胜利：收集到所有的医疗包
    失败：人物血量被消耗完

## 编辑器工具

1. 手形(Hand):平移以更改在场景中的位置
2. 移动(Move): 拖动相应轴箭头，分别沿x、y和z轴移动对象
3. 旋转(Rotate): 拖转标记的相应部位来调整对象的旋转
4. 缩放(Scale): 拖动指定轴来修改对象的比例。
5. 矩形变换(Rect Transform):移动、旋转和缩放工具功能三合一。移动、旋转和缩放(Move,Rotate,and Scale): 可同时控制对象的位置旋转和缩放，但与矩形变换使用的视觉辅助工具不同。
6. 自定义编辑器工具(Custom Editor Tools): 访问为编辑器创建的所有自定义工具(更多信息请参阅文档: <https://docs.unity3dcom/2020.1/Documentation/ScriptReference/EditorTools.EditorTool.html>)。

## 摄像机操作

1. 需要改变摄像机的角度，可以按住鼠标右键/或者alt+左键来操作
2. 需要平移摄像机，可以按住鼠标中键来挪动
3. 需要四处移动但保持摄像机方向不变，可以按住鼠标右键并 A、D 键分别向左和向右移动。
4. 按F键可以放大并聚焦在选定的 GameObject 上
