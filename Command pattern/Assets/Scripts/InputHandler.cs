using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern
{
	public class InputHandler : MonoBehaviour
	{
		public Transform box;
		private Command btnA, btnD;
		private Vector3 boxPosStart;
        protected float _moveDistance = 1f;

		void Start ()
		{
			btnA = new DoNothing();
			btnD = new MoveRight();

			boxPosStart = box.position;
		}

        //Kiểm tra xem chúng ta có nhấn một phím nào không, nếu có thì phím được liên kết với command
		void Update ()
		{
            if(Input.GetKeyDown(KeyCode.A))
            {
                MoveA();
            }
            
            // if (Input.GetKeyDown(KeyCode.D)) 
            // {
			// 	btnD.ExeCmd(box);
			// } 
		}

        void MoveA()
        {
            box.Translate(box.right * _moveDistance);
        }
	}
}