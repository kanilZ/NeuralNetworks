using NeuralNetworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem
{
    class SystemController
   {
        public NeuralNetwork DataNetwork { get; }
        public NeuralNetwork ImageNetwork { get; }
        public SystemController()
        {
            var datatopology = new Topology(14, 1, 0.1, 7);
            DataNetwork = new NeuralNetwork(datatopology);

            var imageTopology = new Topology(400, 1, 0.1, 200);
            ImageNetwork = new NeuralNetwork(imageTopology);

        }
    }
}
