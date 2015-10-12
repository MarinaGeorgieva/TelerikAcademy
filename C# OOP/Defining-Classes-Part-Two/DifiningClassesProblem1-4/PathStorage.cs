namespace DifiningClassesProblem1_4
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePath(string filePath, Path path)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Point3D point in path.Points)
                {
                    string currentLine = string.Format("({0}, {1}, {2})", point.X, point.Y, point.Z);
                    writer.WriteLine(currentLine);
                }                
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    double[] coordinates = currentLine
                        .Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse).ToArray();

                    path.AddPoint(coordinates[0], coordinates[1], coordinates[2]);

                    currentLine = reader.ReadLine();
                }

                return path;
            }
        }
    }
}
