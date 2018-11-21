﻿using System.Collections.Generic;

namespace PlayStationDiscord
{
	public class ConsoleInformation
	{
		public string ImageKeyName { get; protected set; }

		public string Name { get; protected set; }

		public string ClientId { get; protected set; }

		public List<GameInfo> Games { get; private set; } = new List<GameInfo>();

		public ConsoleInformation(string name, string imageKey, string clientId, List<GameInfo> games)
		{
			this.Name = name;
			this.ImageKeyName = imageKey;
			this.ClientId = clientId;
			this.Games = games ?? new List<GameInfo>();
		}
	}
}