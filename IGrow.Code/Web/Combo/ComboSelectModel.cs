/*******************************************************************************
 * Copyright © 2019 .Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/

namespace IGrow.Code
{
    public class ComboSelectModel
    {
        public string id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
        public string parentid { get; set; }
        public object children { get; set; }
    }
}
