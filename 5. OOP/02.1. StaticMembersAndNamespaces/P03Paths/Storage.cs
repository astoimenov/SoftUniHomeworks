namespace P03Paths
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using P01Point3D;

    public static class Storage
    {
        public static void SaveToFile(string fileName, Path3D path)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(path);
            }
        }

        public static Path3D LoadFromFile(string fileName)
        {
            Path3D path = new Path3D();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string input = reader.ReadToEnd();
                const string Pattern = "{([\\d,.]+), ([\\d,.]+), ([\\d,.]+)}";

                var regx = new Regex(Pattern);
                var matches = regx.Matches(input);
                if (matches.Count <= 0)
                {
                    throw new ApplicationException("Invalid data!");
                }

                foreach (Match match in matches)
                {
                    double x = double.Parse(match.Groups[1].Value);
                    double y = double.Parse(match.Groups[2].Value);
                    double z = double.Parse(match.Groups[3].Value);

                    Point3D point = new Point3D(x, y, z);
                    path.AddPoint(point);
                }
            }

            return path;
        }
    }
}
