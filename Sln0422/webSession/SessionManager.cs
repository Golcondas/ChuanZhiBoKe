using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webSession
{
   
    
    public class SessionManager
    {
       private static Dictionary<string, Dictionary<string, object>> dict =
            new Dictionary<string, Dictionary<string, object>>();

        //获取Session
       public Dictionary<string, object> GetSession(string sessionId)
        {
            return dict.ContainsKey(sessionId) ? dict[sessionId] : null;
        }

        public string SetSession(string key,string value)
        {
            ////生成ID
            //string userSessionId = System.Guid.NewGuid().ToString();
            ////为当前的用户创建一个键值对字典
            //Dictionary<string, object> uDictionary = new Dictionary<string, object>();
            ////将要保存的键值对保存到用户的字典中
            //uDictionary[key] = value;
            //dict[userSessionId] = uDictionary;

            string uSeesionId = System.Guid.NewGuid().ToString();
            Dictionary<string, object> uSessionDictionary = new Dictionary<string, object>();
            uSessionDictionary[key] = value;
            dict[uSeesionId] = uSessionDictionary;
            return uSeesionId;
        }
    }
}