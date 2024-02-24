namespace Presentation.WebAPI.Tools.Cors.Common
{
	using EventService.Domain.Utils;
	using EventService.Domain.SeedWork;

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
