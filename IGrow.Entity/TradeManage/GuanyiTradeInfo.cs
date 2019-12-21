using System; 

namespace IGrow.Entity.TradeManage
{ 
    public class GuanyiTradeInfoEntity : IEntity<GuanyiTradeInfoEntity>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string IGrowID { get; set; }
        /// <summary>
        ///  取消状态 已取消与已删除的订单返回true，反之，返回false
        /// </summary> 
        public bool Cancel { get; set; }
        /// <summary>
        ///  拦截信息
        /// </summary> 
        public string Hold_info { get; set; }
        /// <summary>
        ///  单据编号
        /// </summary> 
        public string Code { get; set; }
        /// <summary>
        ///  税额
        /// </summary> 
        public double Tax_amount { get; set; }
        /// <summary>
        ///  商品数量
        /// </summary> 
        public double Qty { get; set; }
        /// <summary>
        ///  订单金额  商品明细amount总和+运费+优惠金额
        /// </summary> 
        public double Amount { get; set; }
        /// <summary>
        ///  支付金额
        /// </summary> 
        public double Payment { get; set; }
        /// <summary>
        ///  是否审核
        /// </summary> 
        public bool Approve { get; set; }
        /// <summary>
        ///  是否货到付款
        /// </summary> 
        public bool Cod { get; set; }
        /// <summary>
        ///  是否取消
        /// </summary> 
        //public bool Cancle { get; set; }
        /// <summary>
        ///  身份证号
        /// </summary> 
        public string VipIdCard { get; set; }
        /// <summary>
        ///  电子邮箱
        /// </summary> 
        public string VipEmail { get; set; }
        /// <summary>
        ///  真实姓名
        /// </summary> 
        public string VipRealName { get; set; }
        /// <summary>
        ///  到账状态
        /// </summary> 
        public string AccountStatus { get; set; }
        /// <summary>
        ///  到账金额
        /// </summary> 
        public double AccountAmount { get; set; }
        /// <summary>
        ///  配货状态 0:未配货1:部分配货2:全部配货
        /// </summary> 
        public int AssignState { get; set; }
        /// <summary>
        ///  平台单号
        /// </summary> 
        public string Platform_code { get; set; }
        /// <summary>
        ///  
        /// </summary> 
        public DateTime? Createtime { get; set; }
        /// <summary>
        ///  
        /// </summary> 
        public DateTime? Modifytime { get; set; }
        /// <summary>
        ///  拍单时间
        /// </summary> 
        public DateTime? Dealtime { get; set; }
        /// <summary>
        ///  支付时间
        /// </summary> 
        public DateTime? Paytime { get; set; }
        /// <summary>
        ///  店铺名称
        /// </summary> 
        public string Shop_name { get; set; }
        /// <summary>
        ///  店铺代码
        /// </summary> 
        public string Shop_code { get; set; }
        /// <summary>
        ///  仓库名称
        /// </summary> 
        public string Warehouse_name { get; set; }
        /// <summary>
        ///  仓库代码
        /// </summary> 
        public string Warehouse_code { get; set; }
        /// <summary>
        ///  快递公司名称
        /// </summary> 
        public string Express_name { get; set; }
        /// <summary>
        ///  快递公司代码
        /// </summary> 
        public string Express_code { get; set; }
        /// <summary>
        ///  会员名称
        /// </summary> 
        public string Vip_name { get; set; }
        /// <summary>
        ///  会员代码
        /// </summary> 
        public string Vip_code { get; set; }
        /// <summary>
        ///  收货人姓名
        /// </summary> 
        public string Receiver_name { get; set; }
        /// <summary>
        ///  收货人电话
        /// </summary> 
        public string Receiver_phone { get; set; }
        /// <summary>
        ///  收货人手机
        /// </summary> 
        public string Receiver_mobile { get; set; }
        /// <summary>
        ///  收货邮编
        /// </summary> 
        public string Receiver_zip { get; set; }
        /// <summary>
        ///  收货地址
        /// </summary> 
        public string Receiver_address { get; set; }
        /// <summary>
        ///  地区信息
        /// </summary> 
        public string Receiver_area { get; set; }
        /// <summary>
        ///  买家留言
        /// </summary> 
        public string Buyer_memo { get; set; }
        /// <summary>
        ///  卖家备注
        /// </summary> 
        public string Seller_memo { get; set; }
        /// <summary>
        ///  二次备注
        /// </summary> 
        public string Seller_memo_late { get; set; }
        /// <summary>
        ///  物流费用
        /// </summary> 
        public double Post_fee { get; set; }
        /// <summary>
        ///  货到付款服务费
        /// </summary> 
        public double Cod_fee { get; set; }
        /// <summary>
        ///  让利金额
        /// </summary> 
        public double Discount_fee { get; set; }
        /// <summary>
        ///  物流成本
        /// </summary> 
        public double Post_cost { get; set; }
        /// <summary>
        ///  标准重量
        /// </summary> 
        public double Weight_origin { get; set; }
        /// <summary>
        ///  商品总金额
        /// </summary> 
        public double Payment_amount { get; set; }
        /// <summary>
        ///  发货状态 0-未发货1-部分发货2-全部发货
        /// </summary> 
        public int Delivery_state { get; set; }
        /// <summary>
        ///  订单类型 Sales-销售订单Return-换货订单Charge-费用订单Delivery-补发货订单Invoice-补发票订单
        /// </summary> 
        public string Order_type_name { get; set; }
        /// <summary>
        ///  业务员
        /// </summary> 
        public string Business_man { get; set; }
        /// <summary>
        ///  平台旗帜0-未标记1-红2-黄3-绿4-蓝5-紫
        /// </summary> 
        public int Platform_flag { get; set; }
        /// <summary>
        ///  附加信息
        /// </summary> 
        public string Extend_memo { get; set; }
        /// <summary>
        ///  审核时间
        /// </summary> 
        public DateTime? ApproveDate { get; set; }
        /// <summary>
        ///  到账时间
        /// </summary> 
        public DateTime? AccountDate { get; set; }
        /// <summary>
        ///  订单标记代码
        /// </summary> 
        public string Trade_tag_code { get; set; }
        /// <summary>
        ///  订单标记名称
        /// </summary> 
        public string Trade_tag_name { get; set; }
        /// <summary>
        ///  预计发货时间
        /// </summary> 
        public string Plan_delivery_date { get; set; }
    }
}
