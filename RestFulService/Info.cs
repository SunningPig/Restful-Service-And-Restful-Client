using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/************************************************************************************
* Autor：xuliangxing
* Email：907562392@qq.com
* WeChart：xuliangxing
* Version：V1.0.0.0
* CreateTime：2018/4/8 13:36:40
* Description：
* Company：
* Copyright © 2018  All Rights Reserved
************************************************************************************/
namespace RestFulService
{
    [DataContract]
    public class Info
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
