// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CorsConfigConstant.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// CorsConfigConstant
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Tools.Cors.Common
{
	using EventService.Domain.Utils;

	/// <summary>
	/// <see cref="CorsConfigConstant"/>
	/// </summary>
	/// <seealso cref="ConstantObject"/>
	internal class CorsConfigConstant : ConstantObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CorsConfigConstant"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public CorsConfigConstant(string value)
			: base(value)
		{
		}
	}
}