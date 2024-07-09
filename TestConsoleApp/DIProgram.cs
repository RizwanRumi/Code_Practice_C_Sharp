using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public interface IDistanceCalculator
    {
        double CalculateDistance(Point point);
    }

    public class EuclideanDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistance(Point point)
        {
            return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }
    }

    public class ManhattanDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistance(Point point)
        {
            return Math.Abs(point.X) + Math.Abs(point.Y);
        }
    }

    public class ChebyshevDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistance(Point point)
        {
            return Math.Max(Math.Abs(point.X), Math.Abs(point.Y));
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Distance { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Distance = 0;
        }       
    }

    public class DistanceService
    {
        private readonly IDistanceCalculator _distanceCalculator;

        // Constructor injection
        public DistanceService(IDistanceCalculator distanceCalculator)
        {
            _distanceCalculator = distanceCalculator;
        }

        public double GetDistanceFromOrigin(Point point)
        {
            return _distanceCalculator.CalculateDistance(point);
        }
    }

    internal class DIProgram
    {
        public const double TargetDiameter = 5.0;

        private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("In command: program.exe <inputFilename> [distanceType]");
                return;
            }
            else
            {
                string inputFilePath = args[0];
                string distanceType = args.Length > 1 ? args[1].ToLower() : "euclidean";

                IDistanceCalculator distanceCalculator = distanceType switch
                {
                    "chebyshev" => new ChebyshevDistanceCalculator(),
                    "manhattan" => new ManhattanDistanceCalculator(),
                    "euclidean" or _ => new EuclideanDistanceCalculator()
                };


                Console.WriteLine("Loading data from " + inputFilePath);

                try
                {
                    List<Point> points = new List<Point>();

                    using (StreamReader reader = new StreamReader(inputFilePath))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] numbers = line.Split(",");

                            if (numbers.Length == 2 && int.TryParse(numbers[0], out int x) && int.TryParse(numbers[1], out int y))
                            {
                                Point p = new Point(x, y);

                                DistanceService distanceService = new DistanceService(distanceCalculator);

                                p.Distance = distanceService.GetDistanceFromOrigin(p);

                                points.Add(p);
                            }
                        }
                    }

                    Console.WriteLine("Number of rays: " + points.Count);

                    var sortedPoints = points.AsParallel().OrderBy(point => point.Distance);

                    IEnumerable<Point> hits = sortedPoints.Where(point => point.Distance <= TargetDiameter).Select(point => point);
                    int numberHits = hits.Count();
                    Console.WriteLine("Number of hits on target: " + numberHits);

                    int hitsInnerCircle = points.AsParallel().Count(point => point.Distance <= TargetDiameter / 2);
                    Console.WriteLine("Number of hits on inner target: " + hitsInnerCircle);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Error: File not found. {ex.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"The file could not be read: {e.Message}");
                }
            }
        }
    }
}
