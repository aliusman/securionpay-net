﻿using Newtonsoft.Json;
using SecurionPay.Common;
using SecurionPay.Converters;
using SecurionPay.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurionPay.Response
{
    public class Dispute : BaseResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("updated")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime Updated { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("Status")]
        [JsonConverter(typeof(SafeEnumConverter))]
        public DisputeStatus Status { get; set; }

        [JsonProperty("reason")]
        [JsonConverter(typeof(SafeEnumConverter))]
        public DisputeReason Reason { get; set; }

        [JsonProperty("acceptedAsLost")]
        public bool AcceptedAsLost { get; set; }

        [JsonProperty("charge")]
        public Charge Charge { get; set; }

        [JsonProperty("evidence")]
        public DisputeEvidence Evidence{ get; set; }

        [JsonProperty("evidenceDetails")]
        public DisputeEvidenceDetails EvidenceDetails { get; set; }
    }
}
