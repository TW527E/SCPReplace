﻿using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace SCPReplace
{
	public class SCPReplace : Plugin<Configs>
	{
		public static SCPReplace SCPReplaceRef { get; set; }

		public EventHandler eventHandlers;

		public SCPReplace()
		{
			SCPReplaceRef = this;
		}

		public override void OnEnabled()
		{
			eventHandlers = new EventHandler();
			Player.Left += eventHandlers.OnPlayerLeft;
		}

		public override void OnDisabled()
		{
			Player.Left -= eventHandlers.OnPlayerLeft;
			eventHandlers = null;
		}
	}
}
