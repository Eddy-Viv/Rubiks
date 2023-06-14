using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rubiks
{
    internal class PolicyNetwork
    {

        Random rnd = new Random();

        private double[] input;
        public double[] Input {
            set {
                if (value.Length == input.Length) { 
                    input = value;
                } else { 
                    Application.Exit();
                }
            } 
        }

        private double[] output;
        public double[] Output { 
            get { 
                return output;
            }
        }

        private bool[] label;
        public bool[] Label
        {
            set { 
                if (value.Length == output.Length) { 
                    label = value;
                } else { 
                    Application.Exit();
                }
            }
        }

        private double[][,] layers;

        private double[][,] parameterDerivatives;

        private double[,] hiddenLayerVals;

        private double learningRate, loss;

        private double log2E;

       

        PolicyNetwork(int noInputs, int noOutputs, int noLayers = 1, int width = 2) { 
            input = new double[noInputs];
            output = new double[noOutputs];
            label = new bool[noOutputs];
            layers = new double[0][,];
            parameterDerivatives = new double[0][,];
            hiddenLayerVals = new double[0,0];

            if (noLayers == 1) { 
                layers = new double[1][,];
                layers[0] = new double[noInputs, noOutputs];
                parameterDerivatives = new double[1][,];
                parameterDerivatives[0] = new double[noInputs, noOutputs];
            } else if (noLayers > 1) { 
                layers = new double[noLayers][,];
                parameterDerivatives = new double[noLayers][,];
                hiddenLayerVals = new double[noLayers - 1, width + 1];
                layers[0] = new double[noInputs, width];
                layers[noLayers - 1] = new double[width + 1, noOutputs];
                parameterDerivatives[0] = new double[noInputs, width];
                parameterDerivatives[noLayers - 1] = new double[width + 1, noOutputs];
                for (int i = 1; i < noLayers - 1; i++)
                {
                    layers[i] = new double[width + 1, width];
                    parameterDerivatives[i] = new double[width + 1, width];
                }
            } else { 
                Application.Exit();
            }

            Init();

            log2E = Math.Log2(Math.E);

        }

        public void Init(bool blank = false) {
            for (int i = 0; i < layers.Length; i++)
            {
                for (int j = 0; j < layers[i].GetLength(0); j++)
                {
                    for (int k = 0; k < layers[i].GetLength(1); k++)
                    {
                        if (blank) {
                            layers[i][j, k] = 0;
                        } else { 
                            layers[i][j, k] = (rnd.NextDouble() * 2) - 1;
                        }
                        parameterDerivatives[i][j, k] = 0;
                    }
                }
            }
            input[input.Length - 1] = 1;
            for (int i = 0; i < hiddenLayerVals.GetLength(0); i++)
            {
                hiddenLayerVals[i, hiddenLayerVals.GetLength(1) - 1] = 1;
            }
        }

        public void Eval() { 

            for (int i = 0; i < hiddenLayerVals.GetLength(0); i++) { 
                for (int j = 0; j < hiddenLayerVals.GetLength(1) - 1; j++)
                {
                    hiddenLayerVals[i, j] = 0;
                }
            }
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = 0;
            }

            for (int j = 0; j < layers[0].GetLength(0); j++) { 
                for (int k = 0; k < layers[0].GetLength(1); k++) {
                    hiddenLayerVals[0, k] += input[j] * layers[0][j, k];
                }
            }
            // activate here

            for (int i = 1; i < layers.Length - 1; i++) { 
                for (int j = 0; j < layers[i].GetLength(0); j++) { 
                    for (int k = 0; k < layers[i].GetLength(1); k++)
                    {
                        hiddenLayerVals[i,k] += hiddenLayerVals[i - 1, j] * layers[i][j, k];
                    }
                }
                //activate here
            }

            for (int j = 0; j < layers[layers.Length - 1].GetLength(0); j++) { 
                for (int k = 0; k < layers[layers.Length - 1].GetLength(1); k++)
                {
                    output[k] += hiddenLayerVals[hiddenLayerVals.GetLength(0) - 1, j] * layers[layers.Length - 1][j, k];
                }
            }
        }

        private double Activate (double inp) { 
            
            return (inp * Math.Log2(Math.Abs(inp) + 2)) / (Math.Abs(inp) + 2);
        }

        private double DerActivation (double inp) { 
            return ((log2E * Math.Abs(inp)) + (2 * Math.Log2(Math.Abs(inp) + 2))) * Math.Pow((Math.Abs(inp) + 2), -2);
        }

        public double Loss() { 
            loss = 0;

            for (int i = 0; i < output.Length; i++) { 
                if ((output[i] > 0) && !label[i]) { 
                    loss += output[i];
                } else if ((output[i] < 0) && label[i]) { 
                    loss -= output[i];
                }
            }

            return loss;
        }



        public void backPropagate() { 
            
        }


    }
}
