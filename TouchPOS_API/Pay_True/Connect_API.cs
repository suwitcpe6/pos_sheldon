using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Pay_True;
using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace TouchPOS_API.Pay_True
{
    public class Connect_API
    {
        public string GET(string Url)
        {
            try
            {

                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(Url);
                Request.ContentType = "application/json";
                Request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                String jsonresponse = reader.ReadToEnd();
                return jsonresponse;
            }
            catch (WebException wex)
            {
                throw wex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Post(string Url, string Jdata)
        {

            try
            {

                //TrueCertificate trueCertificate = new TrueCertificate();
                Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                //string sign = TrueCertificate.Sign(unixTimestamp.ToString());
                //string date = HttpUtility.UrlEncode(model.transaction_date);
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //sign = "digest-alg=RSA-SHA; key-id:RSA:rsf.org; data=" + sign;

                Encoding encoding = new UTF8Encoding();
                byte[] data = encoding.GetBytes(Jdata);

                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(Url);


                //Request.Headers.Add("X-API-Key", "d4165cd3ab2546e3b1522ccf78e4f958");
                //Request.Headers.Add("TIMESTAMP", unixTimestamp.ToString());
                //Request.Headers.Add("Content-Signature", sign);

                Request.ContentLength = data.Length;
                Request.ContentType = "application/json";
                Request.Method = "POST";

                Stream stream = Request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                String jsonresponse = reader.ReadToEnd();

                return jsonresponse;
            }
            catch (WebException wex)
            {
                throw wex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}