﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationAttribute.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ValidationAttribute
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Validation
{
	using System.Linq;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Mvc.Filters;
	using EventService.Presentation.WebAPI.Utils;

	/// <summary>
	/// <see cref="ValidationAttribute"/>
	/// </summary>
	/// <seealso cref="ActionFilterAttribute"/>
	public class ValidationAttribute : ActionFilterAttribute
	{
		/// <summary>
		/// Called when [action executing].
		/// </summary>
		/// <param name="context">The filter context.</param>
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			if (!context.ModelState.IsValid)
			{
				var errors = context.ModelState.Values.Where(v => v.Errors.Count > 0)
					 .SelectMany(v => v.Errors)
					 .Select(v => v.ErrorMessage)
					 .ToArray();

				var responseObj = new ErrorMessage
				{
					Status = 400,
					Message = string.Join(", ", errors)
				};

				context.Result = new JsonResult(responseObj)
				{
					StatusCode = 400
				};
			}
		}
	}
}