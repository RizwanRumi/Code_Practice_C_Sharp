using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public interface IDistanceCalculator
    {
        double CalculateDistance(int x, int y);
    }

    public class EuclideanDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistance(int x, int y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }

    public class ManhattanDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistance(int x, int y)
        {
            return Math.Abs(x) + Math.Abs(y);
        }
    }

    public class ChebyshevDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistance(int x, int y)
        {
            return Math.Max(Math.Abs(x), Math.Abs(y));
        }
    }

    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public readonly double Distance; 

        private readonly IDistanceCalculator _distanceCalculator;
               
        // Constructor Injection
        public Point(int x, int y, IDistanceCalculator distanceCalculator)
        {
            X = x;
            Y = y;
            _distanceCalculator = distanceCalculator;
            Distance = _distanceCalculator.CalculateDistance(X, Y);
        }
    }

    internal class EditedProgram
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
                                Point p = new Point(x, y, distanceCalculator); 
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
