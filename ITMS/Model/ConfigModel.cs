using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMS.Model
{
    public class ConfigModel: ViewModelBase
    {
        
        public string DeviceId { get; set; }
        public string orgCode { get; set; }
        public string deviceName { get; set; }
        public string deviceType { get; set; }
        public string location { get; set; }
        public string CameraIp { get; set; }
        public string CameraUser { get; set; }
        public string CameraName { get; set; }
        public string rtspAdtress { get; set; }
        public string CameraPassword { get; set; }
        public string RayIp { get; set; }
        public string RayName { get; set; }
        public string RayUser { get; set; }
        public string RayPassword { get; set; }
    }
}
