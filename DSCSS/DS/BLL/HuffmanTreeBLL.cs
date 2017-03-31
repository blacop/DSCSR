using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.BLL {

    public class HuffmanTreeBLL {
        /// <summary>
        /// 构建赫夫曼树
        /// 思路：一步一步向上搭建
        /// </summary>
        /// <param name="huffmanTree">待操作的赫夫曼树</param>
        /// <param name="leafNum">叶节点数量</param>
        /// <param name="weight">节点权重值</param>
        /// <returns>构建好的赫夫曼树</returns>
        public static HuffmanTree[] Create(HuffmanTree[] huffmanTree, int leafNum, int[] weight) {
            //获取赫夫曼树结点总数
            int totalNodes = 2 * leafNum - 1;

            //初始化叶节点，赋值权重
            InitLeafNode(huffmanTree, leafNum, weight);

            //构造赫夫曼树(4个节点只需要3步就可以完成构建)
            //从叶子节点数开始，until到赫夫曼树结点总数，因为前面已经赋值权重
            for (int i = leafNum; i < totalNodes; i++) {
                //初始化最小下标
                int minIndex1 = -1;
                int minIndex2 = -1;

                //int searchNode，要查找的节点数
                //获取权重最小的两个叶子节点的下标
                SelectNode(huffmanTree, i, ref minIndex1, ref minIndex2);

                //赋值 权重最小的两个叶子节点的 Parent 为 i循环数
                huffmanTree[minIndex1].Parent = i;
                huffmanTree[minIndex2].Parent = i;

                //赋值 i循环数 节点 的 子树
                huffmanTree[i].Left = minIndex1;
                huffmanTree[i].Right = minIndex2;
                huffmanTree[i].Weight = huffmanTree[minIndex1].Weight + huffmanTree[minIndex2].Weight;
            }
            return huffmanTree;
        }

        /// <summary>
        /// 赫夫曼编码
        /// 思路：左子树为0，右子树为1，对应的编码后的规则是：从根节点到子节点
        /// </summary>
        /// <param name="huffmanTree">待操作的赫夫曼树</param>
        /// <param name="leafNum">叶子节点的数量</param>
        /// <returns>赫夫曼编码</returns>
        public static string[] Coding(HuffmanTree[] huffmanTree, int leafNum) {
            string[] huffmanCode = new string[leafNum];
            //当前节点下标
            int current = 0;
            //父节点下标
            int parent = 0;
            //正向推赫夫曼编码
            for (int i = 0; i < leafNum; i++) {
                string codeTemp = string.Empty;
                current = i;
                //第一次获取最左节点
                parent = huffmanTree[current].Parent;
                while (parent != 0) {
                    if (huffmanTree[parent].Left == current) codeTemp += "0";
                    else codeTemp += "1";
                    //继续找父节点
                    current = parent;
                    parent = huffmanTree[parent].Parent;
                }
                //逆置一次编码
                huffmanCode[i] = new string(codeTemp.Reverse().ToArray());
            }
            return huffmanCode;
        }
        //从叶子节点逆推赫夫曼编码
        public static string[] CodingReverse(HuffmanTree[] huffmanTree, int leafNum) {
            string[] huffmanCode = new string[leafNum];
            //当前节点下标 int current = 0;
            int c = 0;
            //父节点下标 int parent = 0;
            int f = 0;
            //从叶子节点逆推赫夫曼编码
            for (int i = 0; i < leafNum; i++) {
                int start = leafNum;
                //从叶子节点逆推赫夫曼编码
                for (c = 0, f = huffmanTree[i].Parent; f != 0; c = f, f = huffmanTree[f].Parent) {
                    if (huffmanTree[f].Left == c) huffmanCode[--start] = "0";
                    else huffmanCode[--start] = "1";
                }
            }
            return huffmanCode;
        }

        /// <summary>
        /// 初始化叶节点
        /// </summary>
        /// <param name="huffmanTree">哈夫曼树数组引用</param>
        /// <param name="leafNum">叶节点数量</param>
        /// <param name="weight">权值数组</param>
        private static void InitLeafNode(HuffmanTree[] huffmanTree, int leafNum, int[] weight) {
            if (huffmanTree == null || leafNum < 1 || weight.Count() < 1) return;
            //对 哈夫曼树数组.权值 进行 赋值 use by 权值数组
            for (int i = 0; i < leafNum; i++) {
                huffmanTree[i].Weight = weight[i];
            }
        }

        /// <summary>
        /// 获取叶子节点中权重最小的两个节点
        /// </summary>
        /// <param name="huffmanTree">待操作的赫夫曼</param>
        /// <param name="searchNode">要查找的节点个数</param>
        /// <param name="minIndex1">最小节点下标1</param>
        /// <param name="minIndex2">最小节点下标2</param>
        private static void SelectNode(HuffmanTree[] huffmanTree, int searchNode, ref int minIndex1, ref int minIndex2) {
            HuffmanTree minNode1 = null;
            HuffmanTree minNode2 = null;

            for (int i = 0; i < searchNode; i++) {
                //只查找独根树叶子节点
                if (huffmanTree[i].Parent == 0) {
                    #region //如果为null，则表示当前节叶子节点最小 循环到结点1
                    if (minNode1 == null) {
                        minIndex1 = i;
                        minNode1 = huffmanTree[i];
                        continue;
                    }
                    #endregion
                    #region //如果为null，则表示当前节叶子节点最小 循环到结点2
                    if (minNode2 == null) {
                        minIndex2 = i;
                        minNode2 = huffmanTree[i];
                        //交换位置，确保minIndex1为最小
                        if (minNode1.Weight >= minNode2.Weight) {
                            //节点交换
                            var temp = minNode1;
                            minNode1 = minNode2;
                            minNode2 = temp;
                            //交换下标
                            var tempIndex = minIndex1;
                            minIndex1 = minIndex2;
                            minIndex2 = tempIndex;
                            continue;
                        }
                    }
                    #endregion
                    #region //查找最小值 循环到结点3 与 结点1 比较
                    if (minNode1 != null && minNode2 != null) {
                        if (huffmanTree[i].Weight < minNode1.Weight) //注意，不能是“<=”
                        {
                            //将min1临时转存给min2
                            minNode2 = minNode1;
                            minNode1 = huffmanTree[i];

                            //记录在数组中的下标
                            minIndex2 = minIndex1;
                            minIndex1 = i;
                        } else { //查找最小值 循环到结点3 与 结点2 比较
                            if (huffmanTree[i].Weight < minNode2.Weight) {
                                minNode2 = huffmanTree[i];
                                minIndex2 = i;
                            }
                        }
                    }
                    #endregion
                }
            }//!_for (int i = 0; i < searchNode; i++)
        }//!_SelectNode


    }//!_public class HuffmanTreeBLL

    /// <summary>
    /// 赫夫曼树存储结构
    /// </summary>
    public class HuffmanTree {
        public int Weight { get; set; } //权值

        public int Parent { get; set; } //父节点

        public int Left { get; set; } //左孩子节点

        public int Right { get; set; } //右孩子节点
    }
}
