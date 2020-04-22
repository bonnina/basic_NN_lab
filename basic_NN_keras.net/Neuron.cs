using System;
using System.Collections.Generic;

namespace basic_NN_keras.net
{
    class Neuron
    {
        public List<Dendrite> Dendrites { get; set; }

        public Pulse OutputPulse { get; set; }

        private double Weight;

        public Neuron()
        {
            Dendrites = new List<Dendrite>();
            OutputPulse = new Pulse();
        }
    }
}
