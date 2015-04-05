namespace DistanceCalculator.Client
{
	using System;
	using System.Net;

	using DistanceCalculatorServiceReference;

	using Newtonsoft.Json;

	using RestService.Requests;

	using Service;

	public class CalculatorClient
	{
		public static void Main()
		{
			var service = new DistanceCalculatorServiceClient();

			var result = service.CalcDistance(new Point { X = 5, Y = 10 }, new Point { X = 20, Y = 30 });

			Console.WriteLine("Result from SOAP service: {0}", result);

			using (WebClient webClient = new WebClient())
			{
				var calcDistanceRequest = new CalculateDistanceRequest
				{
					StartPoint = new RestService.Models.Point { X = 15, Y = 23 },
					EndPoint = new RestService.Models.Point { X = 35, Y = 2 }
				};

				webClient.Headers.Set("Content-type", "application/json");

				var distanceRequestAsJsonString = JsonConvert.SerializeObject(calcDistanceRequest);
				var response = webClient.UploadString(
					"http://localhost:31009/api/calculate-distance", 
					distanceRequestAsJsonString);

				Console.WriteLine("Result from REST service: {0}", response);
				Console.ReadLine();
			}
		}
	}
}