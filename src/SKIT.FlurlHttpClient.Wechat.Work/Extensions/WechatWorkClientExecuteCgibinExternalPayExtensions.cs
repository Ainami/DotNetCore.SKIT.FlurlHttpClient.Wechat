﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinExternalPayExtensions
    {
        #region Merchant
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/addmerchant 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93666 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayAddMerchantResponse> ExecuteCgibinExternalPayAddMerchantAsync(this WechatWorkClient client, Models.CgibinExternalPayAddMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalpay", "addmerchant")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalPayAddMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/getmerchant 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93666 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayGetMerchantResponse> ExecuteCgibinExternalPayGetMerchantAsync(this WechatWorkClient client, Models.CgibinExternalPayGetMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalpay", "getmerchant")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalPayGetMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/delmerchant 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93666 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayDeleteMerchantResponse> ExecuteCgibinExternalPayDeleteMerchantAsync(this WechatWorkClient client, Models.CgibinExternalPayDeleteMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalpay", "delmerchant")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalPayDeleteMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/set_mch_use_scope 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93666 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPaySetMerchantUseScopeResponse> ExecuteCgibinExternalPaySetMerchantUseScopeAsync(this WechatWorkClient client, Models.CgibinExternalPaySetMerchantUseScopeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalpay", "set_mch_use_scope")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalPaySetMerchantUseScopeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Bill
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/get_bill_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93667 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93727 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayGetBillListResponse> ExecuteCgibinExternalPayGetBillListAsync(this WechatWorkClient client, Models.CgibinExternalPayGetBillListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalpay", "get_bill_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalPayGetBillListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}