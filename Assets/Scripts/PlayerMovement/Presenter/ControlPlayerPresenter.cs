using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMovement.Model;

namespace PlayerMovement.Presenter
{
	public class ControlPlayerPresenter : IControlPlayerPresenter
	{
		private ControlPlayer controlPlayer;

		public ControlPlayerPresenter()
		{
			controlPlayer = new Accelerometer();
		}
		public Vector3 UpdateControlPlayer()
		{
			return controlPlayer.UpdateControlPlayer();
		}
	}
}
