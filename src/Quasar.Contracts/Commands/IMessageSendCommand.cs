﻿﻿using System;

namespace Quasar.Contracts.Commands
{
	/// <summary>
	/// Command to send a message
	/// </summary>
	public interface IMessageSendCommand : ICommand
	{
		/// <summary>
		/// Returns message identifier
		/// </summary>
		Guid MessageId { get; }
		
		/// <summary>
		/// Returns chat identity
		/// </summary>
		Guid ChatId { get; }
		
		/// <summary>
		/// Returns message content
		/// </summary>
		string Content { get; }
	}
}
