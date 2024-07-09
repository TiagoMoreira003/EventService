// --------------------------------------------------------------------------------------------------------------------
// <copyright file="S3Client.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
//	S3Client
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.Clients
{
	using Amazon.Runtime;
	using Amazon.S3;

	/// <summary>
	/// <see cref="S3Client"/>
	/// </summary>
	public class S3Client
	{
		/// <summary>
		/// S3clients this instance.
		/// </summary>
		/// <returns></returns>
		public static AmazonS3Client s3client()
		{
			var accessKey = Clients.Common.ClientsConstantCollection.AccessKey;
			var secretKey = Clients.Common.ClientsConstantCollection.SecretKey;
			var credentials = new BasicAWSCredentials(accessKey, secretKey);
			var s3Client = new AmazonS3Client(credentials, new AmazonS3Config
			{
				ServiceURL = Clients.Common.ClientsConstantCollection.ServiceURL,
			});

			return s3Client;
		}
	}
}