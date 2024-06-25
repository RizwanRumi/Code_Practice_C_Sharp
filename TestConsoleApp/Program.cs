internal class Program
{
    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public readonly double Distance;
             
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Distance = Math.Sqrt(X * X + Y * Y);
        }
    }

    public const double TargetDiameter = 5.0;

    private static void Main(string[] args)
    {
        if (args.Length != 0)
        {
            Console.WriteLine("Loading data from " + args[0]);

            try
            {
                List<Point> points = new List<Point>();

                using (StreamReader reader = new StreamReader(args[0]))
                {
                    string line ;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] numbers = line.Split(",");
                        Point p = new Point(int.Parse(numbers[0]), int.Parse(numbers[1]));
                        points.Add(p);
                    }
                }

                Console.WriteLine("Number of rays: " + points.Count);

                var sortedPoints = points.OrderBy(point => point.Distance); 

                IEnumerable<Point> hits = sortedPoints.Where(point => point.Distance <= TargetDiameter).Select(point => point);
                int numberHits = hits.Count();
                Console.WriteLine("Number of hits on target: " + numberHits);

                int hitsInnerCircle = points.Count(point => point.Distance <= TargetDiameter / 2);
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
        else
        {
            Console.WriteLine("Please provide file path to load data from.");
        }

    }
}