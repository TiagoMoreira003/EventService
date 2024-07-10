// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IImage.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// IImage
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.UpdateImage
{
	/// <summary>
	/// <see cref="IImage"/>
	/// </summary>
	public interface IImage
	{
		/// <summary>
		/// Deletes the image asynchronous.
		/// </summary>
		/// <param name="imageId">The image identifier.</param>
		/// <returns></returns>
		Task DeleteImageAsync(Guid imageId);

		/// <summary>
		/// Updates the image asynchronous.
		/// </summary>
		/// <param name="image">The image.</param>
		/// <param name="imageId">The image identifier.</param>
		/// <returns></returns>
		Task UpdateImageAsync(IFormFile image, Guid imageId, string contentType);
	}
}