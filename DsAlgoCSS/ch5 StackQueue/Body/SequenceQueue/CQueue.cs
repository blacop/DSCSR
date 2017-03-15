using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_StackQueue.Body.SequenceQueue {
    public class CQueue {
        //实际是 ArrayList Queue
        private ArrayList pqueue;
        public CQueue() { 
            pqueue = new ArrayList(); //构造器
        } //构造器
        public void EnQueue(object item) {
            pqueue.Add(item); //Append(item);
        } //入队
        public void DeQueue() {
            pqueue.RemoveAt(0); //删除头部
        } //出队
        public object Peek() {
            return pqueue[0];//GetTop();
        } //GetTop()
        public void ClearQueue() {
            pqueue.Clear(); //清空
        } //清空
        public int Count() {
            return pqueue.Count; //数量
        } //数量

    }//public class CQueue {
}//namespace ch5_StackQueue.Body.SequenceQueue {
