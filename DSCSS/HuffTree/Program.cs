using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace HuffTree {
//    class Program {
//        static void Main(string[] args) {
//            四个叶子节点
//            int leafNum = 4;

//            赫夫曼树的节点总数
//            int totalNodes = 2 * leafNum - 1;

//            各叶子节点的权值
//            int[] weight = new int[] { 5, 7, 2, 13 };

//            各叶子节点的值
//            string[] alphabet = new string[] { "A", "B", "C", "D" };

//            初始化赫夫曼树
//            HuffmanTree[] huffmanTree = new HuffmanTree[totalNodes].Select(p => new HuffmanTree() { }).ToArray();

//            构建赫夫曼树
//            HuffmanTreeBLL.Create(huffmanTree, leafNum, weight);

//            赫夫曼编码
//            string[] huffmanCode = HuffmanTreeBLL.Coding(huffmanTree, leafNum);

//            打印结果
//            PrintResult(alphabet, huffmanTree, huffmanCode, leafNum);

//            Console.ReadKey();
//        }

//        / <summary>
//        / 打印结果
//        / </summary>
//        / <param name="alphabet"></param>
//        / <param name="huffmanTree"></param>
//        / <param name="huffmanCode"></param>
//        / <param name="leafNum"></param>
//        private static void PrintResult(string[] alphabet, HuffmanTree[] huffmanTree, string[] huffmanCode, int leafNum) {
//            if (alphabet.Count() < 1 || huffmanTree.Count() < 1 || huffmanCode.Count() < 1) return;

//            for (int i = 0; i < leafNum; i++) {
//                Console.WriteLine("字符：{0},权重值:{1},赫夫曼编码：{2}", alphabet[i], huffmanTree[i].Weight, huffmanCode[i]);
//            }
//        }
//    }
//}

