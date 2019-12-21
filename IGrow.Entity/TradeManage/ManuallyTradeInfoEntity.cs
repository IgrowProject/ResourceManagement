using System;

namespace IGrow.Entity.TradeManage
{

    /// <summary>
    /// 订单
    /// </summary>
    public class ManuallyTradeInfoEntity : IEntity<ManuallyTradeInfoEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OD01 { get; set; }
        /// <summary>
        /// key
        /// </summary>
        public string IGrowID { get; set; }
        /// <summary>
        /// 买家会员名
        /// </summary>
        public string OD02 { get; set; }
        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        public string OD03 { get; set; }
        /// <summary>
        /// 支付单号
        /// </summary>
        public string OD04 { get; set; }
        /// <summary>
        /// 支付详情
        /// </summary>
        public string OD05 { get; set; }
        /// <summary>
        /// 买家应付货款
        /// </summary>
        public string OD06 { get; set; }
        /// <summary>
        /// 买家应付邮费
        /// </summary>
        public string OD07 { get; set; }
        /// <summary>
        /// 买家支付积分
        /// </summary>
        public string OD08 { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public string OD09 { get; set; }
        /// <summary>
        /// 返点积分
        /// </summary>
        public string OD10 { get; set; }
        /// <summary>
        /// 买家实际支付金额
        /// </summary>
        public string OD11 { get; set; }
        /// <summary>
        /// 买家实际支付积分
        /// </summary>
        public string OD12 { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string OD13 { get; set; }
        /// <summary>
        /// 买家留言
        /// </summary>
        public string OD14 { get; set; }
        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string OD15 { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string OD16 { get; set; }
        /// <summary>
        /// 运送方式
        /// </summary>
        public string OD17 { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string OD18 { get; set; }
        /// <summary>
        /// 联系手机
        /// </summary>
        public string OD19 { get; set; }
        /// <summary>
        /// 订单创建时间
        /// </summary>
        public DateTime? OD20 { get; set; }
        /// <summary>
        /// 订单付款时间
        /// </summary>
        public DateTime? OD21 { get; set; }
        /// <summary>
        /// 宝贝标题
        /// </summary>
        public string OD22 { get; set; }
        /// <summary>
        /// 宝贝种类
        /// </summary>
        public string OD23 { get; set; }
        /// <summary>
        /// 物流单号
        /// </summary>
        public string OD24 { get; set; }
        /// <summary>
        /// 物流公司
        /// </summary>
        public string OD25 { get; set; }
        /// <summary>
        /// 订单备注
        /// </summary>
        public string OD26 { get; set; }
        /// <summary>
        /// 宝贝总数量
        /// </summary>
        public string OD27 { get; set; }
        /// <summary>
        /// 店铺Id
        /// </summary>
        public string OD28 { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string OD29 { get; set; }
        /// <summary>
        /// 订单关闭原因
        /// </summary>
        public string OD30 { get; set; }
        /// <summary>
        /// 卖家服务费
        /// </summary>
        public string OD31 { get; set; }
        /// <summary>
        /// 买家服务费
        /// </summary>
        public string OD32 { get; set; }
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string OD33 { get; set; }
        /// <summary>
        /// 是否手机订单
        /// </summary>
        public string OD34 { get; set; }
        /// <summary>
        /// 分阶段订单信息
        /// </summary>
        public string OD35 { get; set; }
        /// <summary>
        /// 特权订金订单id
        /// </summary>
        public string OD36 { get; set; }
        /// <summary>
        /// 是否上传合同照片
        /// </summary>
        public string OD37 { get; set; }
        /// <summary>
        /// 是否上传小票
        /// </summary>
        public string OD38 { get; set; }
        /// <summary>
        /// 是否代付
        /// </summary>
        public string OD39 { get; set; }
        /// <summary>
        /// 定金排名
        /// </summary>
        public string OD40 { get; set; }
        /// <summary>
        /// 修改后的sku
        /// </summary>
        public string OD41 { get; set; }
        /// <summary>
        /// 修改后的收货地址
        /// </summary>
        public string OD42 { get; set; }
        /// <summary>
        /// 异常信息
        /// </summary>
        public string OD43 { get; set; }
        /// <summary>
        /// 天猫卡券抵扣
        /// </summary>
        public string OD44 { get; set; }
        /// <summary>
        /// 集分宝抵扣
        /// </summary>
        public string OD45 { get; set; }
        /// <summary>
        /// 是否是O2O交易
        /// </summary>
        public string OD46 { get; set; }
        /// <summary>
        /// O2O交易类型
        /// </summary>
        public string OD47 { get; set; }
        /// <summary>
        /// O2O店铺id
        /// </summary>
        public string OD48 { get; set; }
        /// <summary>
        /// O2O店铺名称
        /// </summary>
        public string OD49 { get; set; }
        /// <summary>
        /// O2O导购员id
        /// </summary>
        public string OD50 { get; set; }
        /// <summary>
        /// O2O导购员姓名
        /// </summary>
        public string OD51 { get; set; }
        /// <summary>
        /// O2O提货类型
        /// </summary>
        public string OD52 { get; set; }
        /// <summary>
        /// O2O外部订单id
        /// </summary>
        public string OD53 { get; set; }
        /// <summary>
        /// 新零售交易类型
        /// </summary>
        public string OD54 { get; set; }
        /// <summary>
        /// 新零售导购门店名称
        /// </summary>
        public string OD55 { get; set; }
        /// <summary>
        /// 新零售导购门店id
        /// </summary>
        public string OD56 { get; set; }
        /// <summary>
        /// 新零售发货门店名称
        /// </summary>
        public string OD57 { get; set; }
        /// <summary>
        /// 新零售发货门店id
        /// </summary>
        public string OD58 { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public string OD59 { get; set; }
        /// <summary>
        /// 预约门店
        /// </summary>
        public string OD60 { get; set; }
        /// <summary>
        /// 是否村淘订单
        /// </summary>
        public string OD61 { get; set; }
        /// <summary>
        /// 确认收货时间
        /// </summary>
        public string OD62 { get; set; }
        /// <summary>
        /// 打款商家金额
        /// </summary>
        public string OD63 { get; set; }
        /// <summary>
        /// 含应开票给个人的个人红包
        /// </summary>
        public string OD64 { get; set; }
        /// <summary>
        /// 是否信用购
        /// </summary>
        public string OD65 { get; set; }
        /// <summary>
        /// 体验期结束时间
        /// </summary>
        public string OD66 { get; set; }
        /// <summary>
        /// 前N有礼
        /// </summary>
        public string OD67 { get; set; }
        /// <summary>
        /// 配送类型
        /// </summary>
        public string OD68 { get; set; }
        /// <summary>
        /// 主订单编号
        /// </summary>
        public string OD69 { get; set; }
        /// <summary>
        /// 单据状态 暂定 退款1已对帐2
        /// </summary>
        //public int DStatus { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public bool? DeleteMark { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
