// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorMessage.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ErrorMessage
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Utils
{
	/// <summary>
	///   <see cref="ErrorMessage" />
	/// </summary>
	public class ErrorMessage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ErrorMessage" /> class.
		/// </summary>
		public ErrorMessage()
		{
			this.Message = string.Empty;
		}

		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		/// <value>
		/// The code.
		/// </value>
		public int? Code { get; set; }

		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		/// <value>
		/// The message.
		/// </value>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>
		/// The status.
		/// </value>
		public int? Status { get; set; }
	}
}