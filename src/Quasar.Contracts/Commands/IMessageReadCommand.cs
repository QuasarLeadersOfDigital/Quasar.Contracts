﻿﻿using System;

namespace Quasar.Contracts.Commands
{
	/// <summary>
	/// Command to read a message
	/// </summary>
	public interface IMessageReadCommand : ICommand
	{
		/// <summary>
		/// Returns message identity
		/// </summary>
		Guid MessageId { get; }
		
		/// <summary>
		/// Returns chat identity
		/// </summary>
		Guid ChatId { get; }
	}
}
