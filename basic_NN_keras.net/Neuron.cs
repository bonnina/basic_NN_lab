using System;
using System.Collections.Generic;

namespace basic_NN_keras.net
{
    class Neuron
    {
        // receives the input values, does the weighted sum of all the input signals
        // from all dendrites and passes them to the activation function

        public List<Dendrite> Dendrites { get; set; }

        public Pulse OutputPulse { get; set; }

        private double Weight;

        public Neuron()
        {
            Dendrites = new List<Dendrite>();
            OutputPulse = new Pulse();
        }

        // forward the input pulse to the next layer
        public void Fire()
        {
            OutputPulse.Value = Sum();

            OutputPulse.Value = Activation(OutputPulse.Value);
        }

        public void Compute(double learningRate, double delta)
        {
            Weight += learningRate * delta;
            foreach (var terminal in Dendrites)
            {
                terminal.SynapticWeight = Weight;
            }
        }

        private double Sum()
        {
            double computeValue = 0.0f;
            foreach (var d in Dendrites)
            {
                computeValue += d.InputPulse.Value * d.SynapticWeight;
            }

            return computeValue;
        }

        private double Activation(double input)
        {
            double threshold = 1;
            return input >= threshold ? 0 : threshold;
        }
    }
}
