# Game_RollBall
 Unity官方教程解析-----Roll-a-ball tutoria
## 一、前言
Unity3D是由Unity Technologies开发的一个让玩家轻松创建诸如三维视频游戏、建筑可视化、实时三维动画等类型互动内容的多平台的综合型游戏开发工具，是一个全面整合的专业游戏引擎。
Unity官网设计编写了一系列比较简单的入门教程，今天我们就来看看教程的内容吧。

## 二、简介
滚球教程
创建一个简单的滚动球游戏，教你许多与Unity工作的远离。
在您第一次尝试Unity开发，创建一个简单的滚动球游戏，教您许多原理，使用游戏对象，组件，预制，物理和脚本。

官方教程是视频版的，地址是
https://unity3d.com/learn/tutorials/s/roll-ball-tutorial

效果：
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214104636889.gif)

## 三、正文

1.设置游戏

新建场景
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214113328353.png)
在Hierarchy面板
Create->3D Object->Plane
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214113446509.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
然后在Inspector面板
Transform组件右上角，左键单击，然后点击Reset位置归零
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214113655246.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214113758222.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
设置角色移动范围
按照上面新建plane的过程新建一个Cube，然后也是位置归零
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214113908213.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
调整位置和大小
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214114013191.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
然后按照上面的流程，新建3个Cube，把plane围起来
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214114154641.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
设置主角
新建一个Sphere，位置归零，高度调整到0.5（因为中心点在球的正中间，所以归零就有一半在地面下了，就抬高0.5就行了）
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214114456632.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
创建可收集对象
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214114633591.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
均匀的摆放到地面上
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214114906982.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
Ctrl+S保存场景
游戏对象改名
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214115337217.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214115400350.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
然后把对象都分组一下
新建空对象
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214115551201.png)
分类一下
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214115642918.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
2.移动玩家对象
新建脚本PlayerController.cs
编写脚本

```csharp
using UnityEngine;

// Include the namespace required to use Unity UI
using UnityEngine.UI;

using System.Collections;

public class PlayerController : MonoBehaviour {
	//在游戏对象上创建对rigidbody组件的私有引用
	private Rigidbody rb;
	// 在比赛开始时…
	void Start ()
	{
		// 将Rigidbody组件分配给我们的私有rb变量
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		// 设置一些局部浮动变量等于水平和垂直输入的值
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// 创建一个Vector3变量，并指定X和Z作为上面的水平和垂直浮动变量的特征
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// 使用上面的“移动”矢量3给我们的玩家rigidbody添加一个物理力，并将其乘以“速度”——即出现在inspector中的公共玩家速度
		rb.AddForce (movement * speed);
	}
}

```
3.摄像机移动
新建脚本CameraController.cs
编写脚本

```csharp
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// 存储对Player game对象的公共引用，以便我们可以引用它的Transform
	public GameObject player;

	// 存储与播放器之间的Vector3偏移量(始终放置相机与播放器之间的距离)
	private Vector3 offset;

	// 在比赛开始时…
	void Start ()
	{
		// 通过从玩家的位置减去相机的位置来创建一个偏移量
		offset = transform.position - player.transform.position;
	}

	// 在标准的'Update()'循环运行之后，在每个帧被渲染之前…
	void LateUpdate ()
	{
		// 设置摄像机的位置(脚本所附的游戏对象)
		// 到玩家的位置，加上偏移量
		transform.position = player.transform.position + offset;
	}
}
```
4.显示分数和文本
在Inerarchy面板
Create->UI->Text
选中新建的text然后Ctrl+D复制两一个text
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214144154464.png)
调整text的相对位置
之后修改文字
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214144228410.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)

5.得分物体设置
将可收集的对象的tag设置成Pick Up
![在这里插入图片描述](https://img-blog.csdnimg.cn/201902141446137.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
没有Pick Up这个选项的，可以Add Tag添加

![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214144654725.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
6.获得分数
编写PlayerController.cs这个脚本

```csharp
using UnityEngine;
// 包含使用Unity UI所需的名称空间
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// 为玩家速度和文本UI游戏对象创建公共变量
	public float speed;
	public Text countText;
	public Text winText;

	// 在播放器上创建对rigidbody组件的私有引用，以及到目前为止拾取的对象的计数
	private Rigidbody rb;
	//分数
	private int count;

	// 在比赛开始时…
	void Start ()
	{
		// 将Rigidbody组件分配给我们的私有rb变量
		rb = GetComponent<Rigidbody>();

		// 将计数设置为零
		count = 0;

		// 运行SetCountText函数来更新UI(参见下面)
		SetCountText ();

		// 将Win text UI的text属性设置为一个空字符串，使“You Win”(game over message)为空
		winText.text = "";
	}
void FixedUpdate ()
	{
		// 设置一些局部浮动变量等于水平和垂直输入的值
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// 创建一个Vector3变量，并指定X和Z作为上面的水平和垂直浮动变量的特征
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// 使用上面的“移动”矢量3给我们的玩家rigidbody添加一个物理力，并将其乘以“速度”——即出现在inspector中的公共玩家速度
		rb.AddForce (movement * speed);
	}


	// 当这个游戏对象与一个碰撞器相交时，勾选'is trigger'，
	// 将对碰撞器的引用存储在一个名为“other”的变量中。
	void OnTriggerEnter(Collider other) 
	{
		// . .如果我们相交的游戏对象被赋予了标签" Pick Up "
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			// 使另一个游戏对象(拾取)不活动，使其消失
			other.gameObject.SetActive (false);

			// 在分数变量count中添加1
			count = count + 1;

			// 给它添加一个SetCountText()函数(见下面)
			SetCountText ();
		}
	}

	// 创建一个独立的函数，该函数可以更新'countText' UI，并检查是否达到了获胜所需的金额
	void SetCountText()
	{
		// 更新'countText'变量的文本字段
		countText.text = "你的分数是: " + count.ToString ();

		// 检查我们的“count”是否等于或超过12，因为有12个Cube得分物体
		if (count >= 12) 
		{
			// 设置“winText”的文本值
			winText.text = "You Win!";
		}
	}
}
```
得分物体勾选Is Trigger
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214150030106.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)

将脚本PlayerController.cs附加到Player对象上
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214145352792.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
将UI对象，拖到面板中箭头指向的位置
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214145444249.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
7.得分物体旋转
新建Rotator.cs脚本
编写脚本

```csharp
using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// 在渲染每一帧之前。
	void Update () 
	{
		// 在X轴上将这个脚本所附的游戏对象旋转15个单位，
		// Y轴是30 Z轴是45，乘以三角函数使之等于每秒
		// 而不是每帧。
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}	
```
附加到得分物体上
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214145752765.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)
8.bug修改
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214145835740.png)
这个是因为player身上没有rigidbody组件，所以报错了 
修改方法：
添加![在这里插入图片描述](https://img-blog.csdnimg.cn/20190214145942858.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3E3NjQ0MjQ1Njc=,size_16,color_FFFFFF,t_70)

OK，教程结束
