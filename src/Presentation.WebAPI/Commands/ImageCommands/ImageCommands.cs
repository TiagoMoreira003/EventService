// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImageCommands.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ImageCommands
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.UpdateImage
{
	using Amazon.S3.Model;
	using EventService.Domain.Clients;

	/// <summary>
	/// <see cref="ImageCommands"/>"/>
	/// </summary>
	/// <seealso cref="IImage" />
	public class ImageCommands : IImage
	{
		/// <summary>
		/// Deletes the image asynchronous.
		/// </summary>
		/// <param name="imageId">The image identifier.</param>
		public async Task DeleteImageAsync(Guid imageId)
		{
			var requestCloud = new DeleteObjectRequest
			{
				BucketName = "eventprofilephoto",
				Key = imageId.ToString(),
			};

			await S3Client.s3client().DeleteObjectAsync(requestCloud);
		}

		/// <summary>
		/// Updates the image asynchronous.
		/// </summary>
		/// <param name="image">The image.</param>
		/// <param name="imageId">The image identifier.</param>
		/// <param name="contentType"></param>
		public async Task UpdateImageAsync(IFormFile image, Guid imageId, string contentType)
		{
			var filePath = Path.GetTempFileName();

			using (var stream = new FileStream(filePath, FileMode.Create))
			{
				await image.CopyToAsync(stream);
			}

			var requestCloud = new PutObjectRequest
			{
				FilePath = filePath,
				BucketName = "eventprofilephoto",
				DisablePayloadSigning = true,
				ContentType = contentType,
				Key = imageId.ToString(),
			};

			await S3Client.s3client().PutObjectAsync(requestCloud);

			File.Delete(filePath);
		}
	}
}