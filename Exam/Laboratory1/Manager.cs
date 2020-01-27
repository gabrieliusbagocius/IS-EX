using System;
using System.Diagnostics;

namespace Laboratory2
{
    public class Manager
    {

        private static Random r = new Random();

        public Random random
        {
            get { return r; }
            set { r = value; }
        }

        public static void Main()
        {
            // RANDOM EXAMPLE FOR THE 2 - 3 - 2 NEURAL NETWORK TO PROVE THAT IT DOES EXECUTE

            var nn = new NeuralNetwork(2, 3, 2);
            double[,] trainingData = new double[4, 4] { { 0, 0, 0, 0 }, { 0, 1, 0, 0 },{ 1, 0, 1, 1 }, { 1, 1, 0, 0 } };
            var inputs = new double[2];
            var targets = new double[2];


            for (var n = 0; n < 5000; n++)
            {
                int rand = r.Next(0, trainingData.GetLength(0));
                inputs[0] = trainingData[rand, 0];
                inputs[1] = trainingData[rand, 1];
                targets[0] = trainingData[rand, 2];
                targets[0] = trainingData[rand, 3];
                nn.Train(inputs, targets);
            }


            inputs[0] = trainingData[0, 0];
            inputs[1] = trainingData[0, 1];
            nn.FeedForward(inputs);
            Console.WriteLine("Actuals: ");
            Console.WriteLine(trainingData[0, 0]);
            Console.WriteLine(trainingData[0, 1]);


            Console.WriteLine();
            Console.ReadKey();

        }
    }
}