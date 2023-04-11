namespace ClassHomework {

    public class Point {
        // variables

        private int x, y;

        // Constructors

        public Point() {
            x = 0;
            y = 0;
        }
        public Point(int x, int y) { 
            this.x = x; 
            this.y = y;
        }

        // Acsessors

        public int X { get { return x; } set { if (value > 0) x = value; } }
        public int Y { get { return y; } set { if (value > 0) y = value; } }

        // Functions

        public void showData() {
            Console.WriteLine($"x : {x}\ny : {y}");
        }

        public override string ToString() {
            return $"x : {x}\ny : {y}";
        }
    }

    public class Counter {
        // variables

        private int min, max, counter = 0;

        // Constructors

        public Counter() {
            min = 0;
            max = 0;
        }

        public Counter(int min, int max) { 
            this.min = min;
            this.max = max;
            counter = min;
        }

        // Acsessors

        public int Min { get { return min; } set {  if (value > 0) this.min = value; } }
        public int Max { get { return max; } set {  if (value > 0) this.max = value; } }

        // Functions

        public int increment() {
            if (counter + 1 != max) { counter++; }
            else counter = min; 
            return counter;
        }

        public int getCurrent() { return counter; }
    }

    internal class Program {
        static void Main(string[] args) {
            Point point = new Point(1, 2);
            point.showData();
            Console.WriteLine(point);

            point.X = 5;
            Console.WriteLine(point.X);
            Console.WriteLine(point);

            // Counter

            Counter counter = new Counter(0, 100);

            for (int i = 0; i < 200; i++) {
                Console.WriteLine(counter.getCurrent());
                counter.increment();
            }

        }
    }
}