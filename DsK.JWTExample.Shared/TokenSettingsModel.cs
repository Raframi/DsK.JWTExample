﻿namespace DsK.JWTExample.Shared;
public class TokenSettingsModel
{
    public string? Issuer { get; set; }
    public string? Audience { get; set; }
    public string? Key { get; set; }
}