// Decompiled with JetBrains decompiler
// Type: TumblRipper.PluginInterface.FileToDownloadStatusCodes
// Assembly: TumblRipper.PluginInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E766857F-E220-474D-9A9B-64EE1BB1D7AF
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.PluginInterface.dll

namespace TumblRipper.PluginInterface
{
  public enum FileToDownloadStatusCodes
  {
    UnknownError = -1,
    FileNotDownloaded = 10,
    FileDownloadedButEmpty = 11,
    FileUnknownError = 12,
    Continue = 100,
    SwitchingProtocols = 101,
    OK = 200,
    Created = 201,
    Accepted = 202,
    NonAuthoritativeInformation = 203,
    NoContent = 204,
    ResetContent = 205,
    PartialContent = 206,
    Ambiguous = 300,
    MultipleChoices = 300,
    Moved = 301,
    MovedPermanently = 301,
    Found = 302,
    Redirect = 302,
    RedirectMethod = 303,
    SeeOther = 303,
    NotModified = 304,
    UseProxy = 305,
    Unused = 306,
    RedirectKeepVerb = 307,
    TemporaryRedirect = 307,
    BadRequest = 400,
    Unauthorized = 401,
    PaymentRequired = 402,
    Forbidden = 403,
    NotFound = 404,
    MethodNotAllowed = 405,
    NotAcceptable = 406,
    ProxyAuthenticationRequired = 407,
    RequestTimeout = 408,
    Conflict = 409,
    Gone = 410,
    LengthRequired = 411,
    PreconditionFailed = 412,
    RequestEntityTooLarge = 413,
    RequestUriTooLong = 414,
    UnsupportedMediaType = 415,
    RequestedRangeNotSatisfiable = 416,
    ExpectationFailed = 417,
    UpgradeRequired = 426,
    InternalServerError = 500,
    NotImplemented = 501,
    BadGateway = 502,
    ServiceUnavailable = 503,
    GatewayTimeout = 504,
    HttpVersionNotSupported = 505,
  }
}
