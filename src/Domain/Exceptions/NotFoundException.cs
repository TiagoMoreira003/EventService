﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotFoundException.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// NotFoundException
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.Exceptions
{
	using System;
	using System.Runtime.Serialization;

	/// <summary>
	/// <see cref="NotFoundException"/>
	/// </summary>
	/// <seealso cref="EventServiceException"/>
	[Serializable]
	public sealed class NotFoundException : EventServiceException
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NotFoundException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public NotFoundException(string message)
			: base(message, (int)Enum.ErrorCode.NotFound)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="NotFoundException"/> class.
		/// </summary>
		/// <param name="info">
		/// The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the
		/// serialized object data about the exception being thrown.
		/// </param>
		/// <param name="context">
		/// The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains
		/// contextual information about the source or destination.
		/// </param>
		private NotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}