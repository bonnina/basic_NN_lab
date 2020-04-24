using System;
using System.Collections.Generic;

namespace basic_NN_keras.net
{
    class NeuralLayer
    {
        public List<Neuron> Neurons { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }

        public NeuralLayer(int count, double initialWeight, string name = "")
        {
            Neurons = new List<Neuron>();
            for (int i = 0; i < count; i++)
            {
                Neurons.Add(new Neuron());
            }

            Weight = initialWeight;

            Name = name;
        }

        public void Compute(double learningRate, double delta)
        {
            foreach (var neuron in Neurons)
            {
                neuron.Compute(learningRate, delta);
            }
        }

        public void Log()
        {
            Console.WriteLine("{0}, Weight: {1}", Name, Weight);
        }
    }
}
