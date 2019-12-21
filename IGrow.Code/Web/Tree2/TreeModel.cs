/*******************************************************************************
 * Copyright © 2019 .Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
namespace IGrow.Code
{
    public class TreeModel
    {
        public string parentId { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
        public bool state { get; set; }
        public bool complete { get; set; }
        public string img { get; set; }
        public string title { get; set; }
    }
}
