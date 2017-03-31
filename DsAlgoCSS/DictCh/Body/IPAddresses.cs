using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictCh.Body {
   //集成字典类接口
    public class IPAddresses : DictionaryBase {
        public IPAddresses() { }
        public void Add(string name, string ip) {
            base.InnerHashtable.Add(name, ip);
        }
        public string Item(string name) {
            return base.InnerHashtable[name].ToString();
        }
        public void Remove(string name) {
            base.InnerHashtable.Remove(name);
        }
    }//!_public class IPAddresses : DictionaryBase
}//!_namespace DictCh.Body
