# DotNetCoreAuthApi

A .NET Core Web API sample that issues JWT tokens and authorizes protected endpoints using those tokens.

## Endpoints

- `POST /api/auth/token` to generate a JWT token.
- `GET /api/secure/me` to access a protected endpoint (requires `Authorization: Bearer <token>` header).

## Sample flow

1. Get a token:

```bash
curl -X POST http://localhost:5185/api/auth/token \
  -H "Content-Type: application/json" \
  -d '{"username":"admin","password":"password"}'
```

2. Call the protected API:

```bash
curl http://localhost:5185/api/secure/me \
  -H "Authorization: Bearer <paste-token-here>"
```

## Notes

- Demo credentials are hardcoded as `admin/password` in `AuthController`.
- Update JWT settings in `appsettings.json` before production use.
