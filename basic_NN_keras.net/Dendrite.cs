using System;

namespace basic_NN_keras.net
{
    class Dendrite
    {
        // input signal
        public Pulse InputPulse { get; set; }

        // connection strength between the dendrite and synapsis of two neurons
        public double SynapticWeight { get; set; }

        // bool used during training to adjust the SynapticWeight value
        public bool Learnable { get; set; } = true;
    }
}
