# EXAM
# Examination.API
{
  "DatabaseSettings": {
    "Server": "localhost:27017",
    "DatabaseName": "Exam",
    "User": "mongoadmin",
    "Password": "secret"
  },
  "IdentityUrl": "https://localhost:5001"
}

# Identity.Admin
{
  "ConnectionStrings": {
    "ConfigurationDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "PersistedGrantDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "IdentityDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "AdminLogDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "AdminAuditLogDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "DataProtectionDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********"
  },
  "AdminConfiguration": {
    "IdentityAdminRedirectUri": "https://localhost:6003/signin-oidc",
    "IdentityServerBaseUrl": "https://localhost:5001"
  }
}

# Identity.STS.Identity
{
  "ConnectionStrings": {
    "ConfigurationDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "PersistedGrantDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "IdentityDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "AdminLogDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "AdminAuditLogDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********",
    "DataProtectionDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=********"
  },
  "AdminConfiguration": {
    "IdentityServerBaseUrl": "https://localhost:5001"
  }
}
