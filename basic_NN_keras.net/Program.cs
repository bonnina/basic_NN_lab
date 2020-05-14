﻿using System;

namespace basic_NN_keras.net
{
    class Program
    {
        static void Main()
        {
            NetworkModel model = new NetworkModel();
            model.Layers.Add(new NeuralLayer(2, 0.1, "INPUT"));
            model.Layers.Add(new NeuralLayer(2, 0.1, "HIDDEN"));
            model.Layers.Add(new NeuralLayer(1, 0.1, "OUTPUT"));

            model.Build();
            Console.WriteLine("----Before Training------------");
            model.Print();

            Console.WriteLine();

            NeuralData X = new NeuralData(4);
            X.Add(0, 0);
            X.Add(0, 1);
            X.Add(1, 0);
            X.Add(1, 1);

            NeuralData Y = new NeuralData(4);
            Y.Add(0);
            Y.Add(0);
            Y.Add(0);
            Y.Add(1);

            model.Train(X, Y, iterations: 10, learningRate: 0.1);
            Console.WriteLine();
            Console.WriteLine("----After Training------------");
            model.Print();
        }
    }
}
