using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace ITMS.Model
{
    /// <summary>
    /// 测温区域
    /// </summary>
    public class TemperatureArea
    {
        [NonSerialized]
        public Stroke class_id;
        public int x { get; set; }
        public int y { get; set; }
        public int maxx { get; set; }
        public int maxy { get; set; }
    }

    public class TemperatureAreaList
    {
        public List<TemperatureArea> areas { get; set; }
        public string DeviceId { get; set; }
    }
}
