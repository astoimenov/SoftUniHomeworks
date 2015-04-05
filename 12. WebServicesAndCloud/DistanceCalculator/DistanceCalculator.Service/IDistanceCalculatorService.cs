namespace DistanceCalculator.Service
{
	using System.Runtime.Serialization;
	using System.ServiceModel;

	[ServiceContract]
	public interface IDistanceCalculatorService
	{
		[OperationContract]
		double CalcDistance(Point startPoint, Point endPoint);
	}

	[DataContract]
	public class Point
	{
		[DataMember]
		public int X { get; set; }

		[DataMember]
		public int Y { get; set; }
	}
}
