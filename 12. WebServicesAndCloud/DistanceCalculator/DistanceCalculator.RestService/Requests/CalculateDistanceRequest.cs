namespace DistanceCalculator.RestService.Requests
{
	using Models;

	public class CalculateDistanceRequest
	{
		public Point StartPoint { get; set; }

		public Point EndPoint { get; set; }
	}
}