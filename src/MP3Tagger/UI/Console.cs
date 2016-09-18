﻿using System;
using UI.Interfaces;

namespace UI
{
	public class ConsolePlus : IUserInterface
	{
		public void Update(string message)
		{
			Console.WriteLine(message.Trim());
		}

		public string ReceiveMessage()
		{
			return Console.ReadLine().Trim();
		}
	}
}

