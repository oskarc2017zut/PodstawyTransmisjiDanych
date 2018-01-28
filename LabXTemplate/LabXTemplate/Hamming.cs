using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXTemplate
{
    partial class Zadania
    {
        int[] getCodded(int[] input)
        {
            input = input.Reverse().ToArray();

            int[] additionalBitsPossition = new int[input.Length - 1];
            for (int i = 0; i < input.Length - 1; i++)
            {
                var resoult = (int)(Math.Pow(2, i));
                if (resoult >= input.Length +
                    additionalBitsPossition.Skip(1).Select(x => x).Where(x => x != 0).ToArray().Length)
                    break;
                additionalBitsPossition[i] = resoult;
            }
            additionalBitsPossition = additionalBitsPossition.Select(x => x).Where(x => x != 0).ToArray();




            int[] output = new int[input.Length + additionalBitsPossition.Length];
            int[] inputBitsPossiotion = new int[input.Length];
            for (int i = 0, inputPointer = 0, inputBitsPossitionPointer = 0; i < input.Length + additionalBitsPossition.Length; i++)
            {
                if (additionalBitsPossition.ToList().Contains((i + 1))) continue;
                if (input[inputPointer] != 0)
                    inputBitsPossiotion[inputBitsPossitionPointer++] = i;

                output[i] = input[inputPointer++];
            }
            inputBitsPossiotion = inputBitsPossiotion.Select(x => x).Where(x => x != 0).ToArray();

            int additionalBitsValue = inputBitsPossiotion.Aggregate(0, (current, t) => current ^ t + 1);

            foreach (int additionalBitPossiotion in additionalBitsPossition)
            {

                output[additionalBitPossiotion - 1] = (additionalBitsValue & 1);
                additionalBitsValue = additionalBitsValue >> 1;
            }

            return output.Reverse().ToArray();
        }

        int[] getDecoded(int[] input)
        {
            input = input.Reverse().ToArray();

            List<int> onePositions = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 1)
                {
                    onePositions.Add(i);
                }
            }
            int xor = 0;
            foreach (int position in onePositions)
            {
                xor ^= position+1;
            }
            
            xor--;
            if (xor >0)
            {
                if (input[xor] == 0)
                {
                    input[xor] = 1;
                }
                else
                {
                    input[xor] = 0;
                }
            }

            int[] additionalBitsPossition = new int[input.Length - 1];
            for (int i = 0; i < input.Length - 1; i++)
            {
                var resoult = (int)(Math.Pow(2, i));
                if (resoult > input.Length +
                    additionalBitsPossition.Skip(1).Select(x => x).Where(x => x != 0).ToArray().Length)
                    break;
                additionalBitsPossition[i] = resoult;
            }
            additionalBitsPossition = additionalBitsPossition.Select(x => x).Where(x => x != 0).ToArray();

            List<int> output = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!additionalBitsPossition.Contains(i-1))
                {
                    output.Add(input[i]);
                }
            }
            return output.ToArray();
        }
    }

    
}
