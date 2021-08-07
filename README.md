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
    "ConfigurationDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "PersistedGrantDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "IdentityDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "AdminLogDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "AdminAuditLogDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "DataProtectionDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097"
  },
  "AdminConfiguration": {
    "IdentityAdminRedirectUri": "https://localhost:6003/signin-oidc",
    "IdentityServerBaseUrl": "https://localhost:5001"
  }
}

# Identity.STS.Identity
{
  "ConnectionStrings": {
    "ConfigurationDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "PersistedGrantDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "IdentityDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "AdminLogDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "AdminAuditLogDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097",
    "DataProtectionDbConnection": "Server=localhost, 1433;Database=Identity;User Id=sa;Password=Hau171097"
  },
  "AdminConfiguration": {
    "IdentityServerBaseUrl": "https://localhost:5001"
  }
}
