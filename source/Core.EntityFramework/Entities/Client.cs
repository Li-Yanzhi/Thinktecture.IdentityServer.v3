﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Models;

namespace Thinktecture.IdentityServer.Core.EntityFramework.Entities
{
    public class Client
    {
        [Key]
        public virtual int ID { get; set; }
        public virtual bool Enabled { get; set; }

        [Required]
        public virtual string ClientId { get; set; }
        public virtual string ClientSecret { get; set; }
        [Required]
        public virtual string ClientName { get; set; }
        public virtual string ClientUri { get; set; }
        public virtual string LogoUri { get; set; }

        public virtual bool RequireConsent { get; set; }
        public virtual bool AllowRememberConsent { get; set; }

        public virtual Flows Flow { get; set; }

        // in seconds
        [Range(0, Int32.MaxValue)]
        public virtual int IdentityTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public virtual int AccessTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public virtual int RefreshTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public virtual int AuthorizationCodeLifetime { get; set; }

        public virtual SigningKeyTypes IdentityTokenSigningKeyType { get; set; }
        public virtual AccessTokenType AccessTokenType { get; set; }

        // not implemented yet
        public virtual bool RequireSignedAuthorizeRequest { get; set; }
        public virtual SubjectTypes SubjectType { get; set; }
        public virtual string SectorIdentifierUri { get; set; }
        public virtual ApplicationTypes ApplicationType { get; set; }

        public virtual ICollection<ClientRedirectUri> RedirectUris { get; set; }
        public virtual ICollection<ClientScopeRestriction> ScopeRestrictions { get; set; }
    }
}
