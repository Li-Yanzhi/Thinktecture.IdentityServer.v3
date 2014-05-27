﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Thinktecture.IdentityServer.Core.Models
{
    public class Client
    {
        public bool Enabled { get; set; }

        [Required]
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        [Required]
        public string ClientName { get; set; }
        public string ClientUri { get; set; }
        public Uri LogoUri { get; set; }
        
        public bool RequireConsent { get; set; }
        public bool AllowRememberConsent { get; set; }

        public Flows Flow { get; set; }
        public List<Uri> RedirectUris { get; set; }
        
        // in seconds
        [Range(0, Int32.MaxValue)]
        public int IdentityTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public int AccessTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public int RefreshTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public int AuthorizationCodeLifetime { get; set; }

        public List<string> ScopeRestrictions { get; set; }
        public SigningKeyTypes IdentityTokenSigningKeyType { get; set; }
        public AccessTokenType AccessTokenType { get; set; }

        // not implemented yet
        public bool RequireSignedAuthorizeRequest { get; set; }
        public SubjectTypes SubjectType { get; set; }
        public Uri SectorIdentifierUri { get; set; }
        public ApplicationTypes ApplicationType { get; set; }
    }
}