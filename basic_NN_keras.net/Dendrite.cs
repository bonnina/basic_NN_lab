using System;

namespace basic_NN_keras.net
{
    class Dendrite
    {
        /// <summary>
        /// input signal
        /// </summary>
        public Pulse InputPulse { get; set; }

        /// <summary>
        /// connection strength between the dendrite and synapsis of two neurons
        /// </summary>
        public double SynapticWeight { get; set; }

        /// <summary>
        /// bool used during training to adjust the SynapticWeight value
        /// </summary>
        public bool Learnable { get; set; } = true;
    }
}
