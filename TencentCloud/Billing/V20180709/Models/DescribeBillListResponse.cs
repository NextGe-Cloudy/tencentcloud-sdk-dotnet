/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillListResponse : AbstractModel
    {
        
        /// <summary>
        /// 收支明细列表
        /// </summary>
        [JsonProperty("TransactionList")]
        public BillTransactionInfo[] TransactionList{ get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 退费总额，单位（分）
        /// </summary>
        [JsonProperty("ReturnAmount")]
        public float? ReturnAmount{ get; set; }

        /// <summary>
        /// 充值总额，单位（分）
        /// </summary>
        [JsonProperty("RechargeAmount")]
        public float? RechargeAmount{ get; set; }

        /// <summary>
        /// 冻结总额，单位（分）
        /// </summary>
        [JsonProperty("BlockAmount")]
        public float? BlockAmount{ get; set; }

        /// <summary>
        /// 解冻总额，单位（分）
        /// </summary>
        [JsonProperty("UnblockAmount")]
        public float? UnblockAmount{ get; set; }

        /// <summary>
        /// 扣费总额，单位（分）
        /// </summary>
        [JsonProperty("DeductAmount")]
        public float? DeductAmount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TransactionList.", this.TransactionList);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "ReturnAmount", this.ReturnAmount);
            this.SetParamSimple(map, prefix + "RechargeAmount", this.RechargeAmount);
            this.SetParamSimple(map, prefix + "BlockAmount", this.BlockAmount);
            this.SetParamSimple(map, prefix + "UnblockAmount", this.UnblockAmount);
            this.SetParamSimple(map, prefix + "DeductAmount", this.DeductAmount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

