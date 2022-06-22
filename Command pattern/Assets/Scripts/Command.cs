
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern
{
	//Lớp cha
	public abstract class Command
	{
		//Box sẽ di chuyển với khoảng cách bao xa
		protected float _moveDistance = 1f;

		//Di chuyển box
		public abstract void ExeCmd(Transform box);
	}

    //Kế thừa class Command và ghi đè phương thức Execute theo mong muốn
	public class MoveRight : Command
	{
		public override void ExeCmd(Transform boxTrans)
		{
			boxTrans.Translate(boxTrans.right * _moveDistance);
		}
	}

    //Kế thừa class Command và ghi đè phương thức Execute để không có hành động nào được thực hiện
	public class DoNothing : Command
	{
		public override void ExeCmd(Transform boxTrans)
		{
		}
	}
}
