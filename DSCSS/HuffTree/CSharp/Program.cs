using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS.BLL;

namespace HuffTree.Main {
    class Program {
        static void Main(string[] args) {
            //四个叶子节点
            int leafNum = 4;
            //赫夫曼树的节点总数
            int totalNodes = 2 * leafNum - 1;
            //各叶子节点的权值
            int[] weight = new int[] { 5, 7, 2, 13 };
            //各叶子节点的值
            string[] alphabet = new string[] { "A", "B", "C", "D" };            

            //初始化赫夫曼树，lambda,(HuffmanTree隐藏了类型 p =new HuffmanTree(){}).ToArray()
            HuffmanTree[] huffmanTree = new HuffmanTree[totalNodes].Select(p => new HuffmanTree() { }).ToArray();
            //上面的Lambda Expression Implementation在效果上与匿名方法没有任何区别，
            //“=>”左边的name定义了参数（当参数个数为1的时候，圆括号可以省略），
            //“=>”右边定义执行体。由于C# 3.0编译器具有Type Inference的能力，
            //参数类型与返回值都将由编译器通过上下文判定，因此与匿名方法不同，
            //Lambda表达式的参数可以不给定参数类型。当所表示的匿名方法没有任何参数时，
            //Lambda表达式也同样可以使用，只需在“=>”左边用一对圆括号表示即可。即：
            //() => Console.WriteLine("Hello!");

            //构建赫夫曼树
            HuffmanTreeBLL.Create(huffmanTree, leafNum, weight);
            //赫夫曼编码
            string[] huffmanCode = HuffmanTreeBLL.Coding(huffmanTree, leafNum);
            //打印结果
            PrintResult(alphabet, huffmanTree, huffmanCode, leafNum);
            Console.ReadKey();
        }

        /// <summary>
        /// 打印结果
        /// </summary>
        /// <param name="alphabet"></param>
        /// <param name="huffmanTree"></param>
        /// <param name="huffmanCode"></param>
        /// <param name="leafNum"></param>
        private static void PrintResult(string[] alphabet, HuffmanTree[] huffmanTree, string[] huffmanCode, int leafNum) {
            if (alphabet.Count() < 1 || huffmanTree.Count() < 1 || huffmanCode.Count() < 1) return;
            for (int i = 0; i < leafNum; i++) {
                Console.WriteLine("字符：{0},权重值:{1},赫夫曼编码：{2}", alphabet[i], huffmanTree[i].Weight, huffmanCode[i]);
            }
        }
    }
}

