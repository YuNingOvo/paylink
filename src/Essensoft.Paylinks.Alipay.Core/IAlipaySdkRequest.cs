namespace Essensoft.Paylinks.Alipay.Core;

/// <summary>
/// Alipay SDK请求
/// </summary>
public interface IAlipaySdkRequest
{
    /// <summary>
    /// 获取接口名称
    /// </summary>
    string GetMethod();

    /// <summary>
    /// 设置业务参数模型
    /// </summary>
    /// <param name="bizModel">业务参数模型</param>
    void SetBizModel(object bizModel);

    /// <summary>
    /// 获取业务参数模型
    /// </summary>
    /// <returns>业务参数模型</returns>
    object GetBizModel();

    /// <summary>
    /// 设置是否需要加密
    /// </summary>
    void SetNeedEncrypt(bool value);

    /// <summary>
    /// 获取是否需要加密
    /// </summary>
    bool GetNeedEncrypt();

    /// <summary>
    /// 设置通知Url
    /// </summary>
    /// <param name="notifyUrl">通知Url</param>
    void SetNotifyUrl(string notifyUrl);

    /// <summary>
    /// 获取通知Url
    /// </summary>
    /// <returns>通知Url</returns>
    string? GetNotifyUrl();

    /// <summary>
    /// 设置跳转Url
    /// </summary>
    /// <param name="returnUrl">跳转Url</param>
    void SetReturnUrl(string returnUrl);

    /// <summary>
    /// 获取跳转Url
    /// </summary>
    /// <returns>跳转Url</returns>
    string? GetReturnUrl();
}
