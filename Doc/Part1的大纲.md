# Part1的大纲

## Unity的初步使用

  1. 去哪下载 => unity hub => unity 2022LTS
  2. 开启新项目 => unity hub => unity create
  3. 六大窗口 => sense => 左侧结构 => 右侧属性栏 => 下项目finder => 切换动画窗口 => game窗口
  4. 基础操作 => 摄像机操作 => 左上角工具条 (see: README.md)

## 打通VS

  1. 为什么要打通 => 提供更好的开发 => 提供debug能力
  2. 如何打通 => 打开ExternalTools => 选择 Visual Studio => .csproj files 全部勾选 (see: README.md)

## 场景搭建

  1. 搭建地面 - 选取合适的 unity 原型 - 使用工具条拉长拉宽 - 解释没有单位，全部都是相对位置
  2. 搭建墙 - 快速复制 - 使用属性栏position.size来拉宽 - 使用属性栏position.x,y,z来换位置
  3. 搭建掩体 - 介绍prefab - 用cube搭建完成 - 制作成prefab - 场景复用
  4. material - 定义颜色 - 拖上去

## 开启物理能力

  1. 制作玩家 gameObject - 解释右侧刚体（Rigidbody）- 要受物理系统控制必须是刚体 - 玩（操控重力、摩擦力）
  2. 创造可拾取 gameObject - 解释右侧碰撞体(Collider) - 触发碰撞事件必须是碰撞体

## 操控绑定
  
  1. 解释前后移动为什么是向量 x time x 输入值（w、s操作的值分别为1和-1，表示向前走，向后走）
  2. 解释左右移动为什么是角速度 x time x 输入值（a、d操作的值分别为1和-1，表示向左转，向右转）
  3. 拖拽给玩家绑定操作脚本
  4. 开启x、z轴物理位置向量锁定，保证玩家不会摔倒

## 绑定过肩视角

  1. 摄像头获取玩家 - 给摄像头传玩家位置 - 调用lookAt方法触发位置更新 - 拖拽绑定脚本

## 触发物理碰撞事件

  1. 可拾取物实现钩子触发消灭自己 - 绑定脚本
