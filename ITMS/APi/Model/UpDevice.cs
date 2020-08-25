using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMS.APi.Model
{
    public class UpDevice_Request
    {
        public Access access { get; set; } = new Access();
        public string orgCode { get; set; }
        public string deviceName { get; set; }
        public string deviceType { get; set; }
        public string factory { get; set; }
        public string location { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }

    }

    public class Access
    {
        public string accessNo { get; set; } = "000001";
        public string secret { get; set; } = "169vgy";
    }
    public class UpDevice_Response
    {
        public DeviceInfo data { get; set; }
        public bool success { get; set; }
        public string errorMsg { get; set; }
    }
    public class DeviceInfo
    {
        public string deviceId { get; set; }
    }
    public class UpImg_Request
    {
        public Access access { get; set; } = new Access();
        public imgInfo[] list { get; set; }
        public string deviceId { get; set; }


    }
    public class imgInfo
    {
        public string pic { get; set; }

        public personInfo[] list { get; set; }
    }
    public class personInfo
    {
        public string name { get; set; }
        public string pid { get; set; }
        public string porder { get; set; }
        public string temp { get; set; }
        public bool mask { get; set; }
        public bool hot { get; set; }
        public string time { get; set; }
    }
    public class box
    {
        public bool success { get; set; }

        public Person[] predictions { get; set; }
        public MatchResults[] match_results { get; set; }
    }

    public class Person
    {
        public int det_idx { get; set; }
        public string class_id { get; set; }
        public float confident_score { get; set; }
        public int xmax { get; set; }
        public int xmin { get; set; }
        public int ymax { get; set; }
        public int ymin { get; set; }

        public float maxTemp { get; set; }
    }
    public class MatchResults
    {
        public int det_idx { get; set; }
        public string match_flag { get; set; }
        public string match_name { get; set; }
    }
    public class Response
    {
        public bool success { get; set; }
        public string errorMsg { get; set; }
    }

}
