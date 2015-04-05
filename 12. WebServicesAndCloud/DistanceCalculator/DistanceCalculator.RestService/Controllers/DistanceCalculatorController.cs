namespace DistanceCalculator.RestService.Controllers
{
	using System;
	using System.Web.Http;

	using Requests;

	[RoutePrefix("api")]
	public class DistanceCalculatorController : ApiController
    {
		[Route("calculate-distance")]
		[HttpPost]
		public IHttpActionResult CalculateDistance(CalculateDistanceRequest request)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest();
			}

			int deltaX = request.StartPoint.X - request.EndPoint.X;
			int deltaY = request.StartPoint.Y - request.EndPoint.Y;
			double result = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

			return this.Ok(result);
		}
    }
}
