/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

using System;
using UnityEngine;

[Serializable]
public class SerializableRect
{
	public float X { get; set; }

	public float Y { get; set; }

	public float Width { get; set; }

	public float Height { get; set; }

	public SerializableRect(Rect rect)
	{
		this.X = rect.x;
		this.Y = rect.y;
		this.Width = rect.width;
		this.Height = rect.height;
	}

	public Rect ToRect()
	{
		return new Rect(this.X, this.Y, this.Width, this.Height);
	}
}


