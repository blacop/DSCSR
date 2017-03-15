﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_StackQueue.TestMain {
    public struct Dancer {
        public string sex;
        public string name;
        
        public void GetName(string n) {
            name = n;
        }
        public override string ToString() {
            return name;
        }
    }//public struct Dancer 结构体Dancer
    class Class1 {
        static void newDancers(Queue male, Queue female) { //构造人物组合
            Dancer m, w;
            m = new Dancer();
            w = new Dancer();
            if (male.Count > 0 && female.Count > 0) {
                m.GetName(male.Dequeue().ToString()); //出队 得到名字
                w.GetName(female.Dequeue().ToString()); //出队 得到名字
            } else if ((male.Count > 0) && (female.Count == 0))
                Console.WriteLine("Waiting on a female dancer.");
            else if ((female.Count > 0) && (male.Count == 0))
                Console.WriteLine("Waiting on a male dancer.");
        } //构造人物组合
        static void headOfLine(Queue male, Queue female) { //得到队头人物名字
            Dancer w, m;
            m = new Dancer();
            w = new Dancer();
            if (male.Count > 0)
                m.GetName(male.Peek().ToString());
            if (female.Count > 0)
                w.GetName(female.Peek().ToString());
            if (m.name != " " && w.name != "")
                Console.WriteLine("Next in line are: " + m.name + "\t" + w.name);
            else if (m.name != "") //!=
                Console.WriteLine("Next in line is: " + m.name);
            else
                Console.WriteLine("Next in line is: " + w.name);
        } //得到队头人物名字
        static void startDancing(Queue male, Queue female) { //开始活动
            Dancer m, w;
            m = new Dancer();
            w = new Dancer();
            Console.WriteLine("Dance partners are: ");
            Console.WriteLine();
            for (int count = 0; count <= 3; count++) {
                m.GetName(male.Dequeue().ToString());
                w.GetName(female.Dequeue().ToString());
                Console.WriteLine(w.name + "\t" + m.name);
            }
        } //开始活动
        static void formLines(Queue male, Queue female) { //从文件导入人物资料
            Dancer d = new Dancer();
            StreamReader inFile;
            inFile = File.OpenText(@"c:\dancers.dat");
            string line;
            while (inFile.Peek() != -1) {
                line = inFile.ReadLine();
                d.sex = line.Substring(0, 1);//与保存格式有关
                d.name = line.Substring(2, line.Length - 2);
                if (d.sex == "M")
                    male.Enqueue(d);
                else
                    female.Enqueue(d);
            }
        }//从文件导入人物资料

        //static void Main(string[] args) {
        //    Queue males = new Queue();
        //    Queue females = new Queue();
        //    formLines(males, females);
        //    startDancing(males, females);
        //    if (males.Count > 0 || females.Count > 0)
        //        headOfLine(males, females);
        //    newDancers(males, females);
        //    if (males.Count > 0 || females.Count > 0)
        //        headOfLine(males, females);
        //    newDancers(males, females);
        //    Console.Write("press enter"); Console.Read();
        //}

    }// class Class1 
}//namespace ch5_StackQueue.TestMain 
