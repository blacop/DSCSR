using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayCh.Algo {
    class BitArrayCWL {
        static void Main() {
            int bits;
            string[] binNumber = new string[8];
            int binary;
            byte[] ByteSet = new byte[] { 1, 2, 3, 4, 5 };
            BitArray BitSet = new BitArray(ByteSet);
            bits = 0;
            binary = 7;
            for (int i = 0; i <= BitSet.Count - 1; i++) {
                if (BitSet.Get(i) == true)
                    binNumber[binary] = "1";
                else
                    binNumber[binary] = "0";
                bits++;
                binary--;
                if ((bits % 8) == 0) {
                    binary = 7;
                    bits = 0;
                    for (int ji = 0; ji <= 7; ji++)
                        Console.Write(binNumber[ji]);
                    Console.WriteLine();
                }
            }
        }
    }
}
