﻿using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantId"/> 的副本。
        /// </summary>
        public string MerchantId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantV3Secret"/> 的副本。
        /// </summary>
        public string MerchantV3Secret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantCertificateSerialNumber"/> 的副本。
        /// </summary>
        public string MerchantCertificateSerialNumber { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantCertificatePrivateKey"/> 的副本。
        /// </summary>
        public string MerchantCertificatePrivateKey { get; }

        internal Credentials(WechatTenpayClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            MerchantId = options.MerchantId;
            MerchantV3Secret = options.MerchantV3Secret;
            MerchantCertificateSerialNumber = options.MerchantCertificateSerialNumber;
            MerchantCertificatePrivateKey = options.MerchantCertificatePrivateKey;
        }
    }
}
