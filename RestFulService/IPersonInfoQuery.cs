using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
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
    /// <summary>
    /// 定义两种方法，1、GetScore方法：通过GET请求传入name，返回对应的成绩；2、GetInfo方法：通过POST请求，传入Info对象，查找对应的User并返回给客户端
    /// </summary>
    [ServiceContract(Name = "PersonInfoQueryServices")]
    public interface IPersonInfoQuery
    {
        /// <summary>
        /// 说明：
        /// WebGet默认请求是GET方式
        /// UriTemplate(URL Routing)的参数名name必须要方法的参数名必须一致（不区分大小写）
        /// RequestFormat规定客户端必须是什么数据格式请求的（JSon或者XML），不设置默认为XML
        /// ResponseFormat规定服务端返回给客户端是以是什么数据格返回的（JSon或者XML）
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "PersonInfoQuery/{name}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User GetScore(string name);

        /// <summary>
        /// 说明：
        /// WebInvoke请求方式有POST、PUT、DELETE等，所以需要明确指定Method是哪种请求的。
        /// 注意：POST情况下，UriTemplate(URL Routing)一般是没有参数（和上面GET的UriTemplate不一样，因为POST参数都通过消息体传送）
        /// RequestFormat规定客户端必须是什么数据格式请求的（JSon或者XML），不设置默认为XML
        /// ResponseFormat规定服务端返回给客户端是以是什么数据格返回的（JSon或者XML）
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "PersonInfoQuery/Info", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User GetInfo(Info info);
    }
}
